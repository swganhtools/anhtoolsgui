using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Configuration;

namespace ANHGui
{
    public partial class frmRemoteConfig : Form
    {
        public frmRemoteConfig()
        {
            InitializeComponent();
        }

        private void frmRemoteConfig_Load(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Main DB Config
            txtHost.Text = config.AppSettings.Settings["remotehost"].Value;
            txtPort.Text = config.AppSettings.Settings["remoteport"].Value;
            txtPassKey.Text = config.AppSettings.Settings["remoteauth"].Value;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Main Config
            config.AppSettings.Settings["remotehost"].Value = txtHost.Text;
            config.AppSettings.Settings["remoteport"].Value = txtPort.Text;
            config.AppSettings.Settings["remoteauth"].Value = txtPassKey.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Update Successfull.", "Update Cconfiguration");
            Close();
        }
    }
}
