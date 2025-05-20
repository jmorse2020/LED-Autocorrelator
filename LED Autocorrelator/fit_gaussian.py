import sys
import json
import numpy as np
from scipy.optimize import curve_fit

def gaussian(x, A, mu, sigma):
    return A * np.exp(-(x - mu)**2 / (2 * sigma**2))

def fit_gaussian(data):
    try:
        # Convert input lists to numpy arrays
        x_data = np.array(data["x_data"])
        y_data = np.array(data["y_data"])
        # Use the provided initial guess, or default if not provided
        initial_guess = data.get("initial_guess", [1.0, 0.0, 1.0])
        # Fit the Gaussian model
        popt, _ = curve_fit(gaussian, x_data, y_data, p0=initial_guess)
        return popt
    except Exception as e:
        # On failure, return -1 for each parameter
        return [-1, -1, -1]

if __name__ == "__main__":
    # Read the complete JSON input from stdin
    input_str = sys.stdin.read()
    try:
        input_data = json.loads(input_str)
    except json.JSONDecodeError:
        print("Error: Invalid JSON input", file=sys.stderr)
        sys.exit(1)
    params = fit_gaussian(input_data)
    # Output the parameters as a comma-separated string
    print(",".join(map(str, params)))


