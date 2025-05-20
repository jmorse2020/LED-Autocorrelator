using LED_Autocorrelator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Autocorrelator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void keepFullLogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.KeepApplicationLog = keepFullLogCheckbox.Checked;
            Settings.Default.Save();
        }

        private void saveSettingsAndCloseButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            this.Close();
        }
    }
}
