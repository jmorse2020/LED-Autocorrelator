using System;
using System.Collections.Generic;
using Ivi.Visa; // Make sure you reference the appropriate VISA .NET assembly

public class VisaHelper
{
    /// <summary>
    /// Searches for a USB VISA resource that matches the specified vendor ID, product ID, and optional serial number.
    /// </summary>
    /// <param name="vendorId">The vendor ID (e.g., 0x0AAD) as an unsigned short.</param>
    /// <param name="productId">The product ID (e.g., 0x01D6) as an unsigned short.</param>
    /// <param name="serialNumber">Optional serial number to further identify the device.</param>
    /// <returns>The full VISA resource string if found; otherwise, null.</returns>
    public static string FindVisaResource(ushort vendorId, ushort productId, string serialNumber = null)
    {
        // Format the vendor and product IDs as 4-digit hexadecimal strings prefixed with "0x".
        string vidString = $"0x{vendorId:X4}";
        string pidString = $"0x{productId:X4}";

        // Enumerate all USB VISA resources.
        IEnumerable<string> resources;
        try
        {
            // The query "USB?*" will list all resources starting with "USB"
            //resources = GlobalResourceManager.Find("USB?*");
            //Console.WriteLine("Enumerated USB resources:");
            //foreach (string resource in resources)
            //{
            //    Console.WriteLine(resource.ToString());
            //}
            resources = GlobalResourceManager.Find("USB?*");
        }
        catch (Exception ex)
        {
            // Log or handle error as needed
            Console.WriteLine("Error enumerating USB resources: " + ex.Message);
            return null;
        }

        // Loop through each resource string.
        foreach (string resource in resources)
        {
            // Convert resource to upper-case for case-insensitive comparison.
            string upperResource = resource.ToUpper();

            if (upperResource.Contains(vidString.ToUpper()) && upperResource.Contains(pidString.ToUpper()))
            {
                // If a serial number was provided, verify that the resource string contains it.
                if (!string.IsNullOrEmpty(serialNumber))
                {
                    if (upperResource.Contains(serialNumber.ToUpper()))
                    {
                        // Found a match with VID, PID, and serial number.
                        return resource;
                    }
                }
                else
                {
                    // Found a match with VID and PID.
                    return resource;
                }
            }
        }

        // No matching resource found.
        return null;
    }
}

