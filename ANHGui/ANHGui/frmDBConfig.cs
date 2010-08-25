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
    public partial class frmDBConfig : Form
    {
        public frmDBConfig()
        {
            InitializeComponent();
        }

        private void frmDBConfig_Load(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Main DB Config
            txtMainHost.Text = config.AppSettings.Settings["mainhost"].Value;
            txtMainUser.Text = config.AppSettings.Settings["mainuser"].Value;
            txtMainPass.Text = config.AppSettings.Settings["mainpassword"].Value;
            txtMainDB.Text = config.AppSettings.Settings["maindatabase"].Value;
            txtMainPort.Text = config.AppSettings.Settings["mainport"].Value;
            // Config DB Config
            txtConfigHost.Text = config.AppSettings.Settings["confighost"].Value;
            txtConfigUser.Text = config.AppSettings.Settings["configuser"].Value;
            txtConfigPass.Text = config.AppSettings.Settings["configpassword"].Value;
            txtConfigDB.Text = config.AppSettings.Settings["configdatabase"].Value;
            txtConfigPort.Text = config.AppSettings.Settings["configport"].Value;
            // Astro Config
            txtAstroHost.Text = config.AppSettings.Settings["astromechhost"].Value;
            txtAstroUser.Text = config.AppSettings.Settings["astromechuser"].Value;
            txtAstroPass.Text = config.AppSettings.Settings["astromechpassword"].Value;
            txtAstroDB.Text = config.AppSettings.Settings["astromechdatabase"].Value;
            txtAstromechPort.Text = config.AppSettings.Settings["astromechport"].Value;
            // Log DB Config
            txtLogHost.Text = config.AppSettings.Settings["loghost"].Value;
            txtLogUser.Text = config.AppSettings.Settings["loguser"].Value;
            txtLogPass.Text = config.AppSettings.Settings["logpassword"].Value;
            txtLogDB.Text = config.AppSettings.Settings["logdatabase"].Value;
            txtLogsPort.Text = config.AppSettings.Settings["logport"].Value;
            // Tool DB Config
            txtToolsHost.Text = config.AppSettings.Settings["toolshost"].Value;
            txtToolsUser.Text = config.AppSettings.Settings["toolsuser"].Value;
            txtToolsPass.Text = config.AppSettings.Settings["toolspassword"].Value;
            txtToolsDB.Text = config.AppSettings.Settings["toolsdatabase"].Value;
            txtToolsPort.Text = config.AppSettings.Settings["toolsport"].Value;
            // Archive DB Config
            txtArchiveHost.Text = config.AppSettings.Settings["archivehost"].Value;
            txtArchiveUser.Text = config.AppSettings.Settings["archiveuser"].Value;
            txtArchivePass.Text = config.AppSettings.Settings["archivepassword"].Value;
            txtArchiveDB.Text = config.AppSettings.Settings["archivedatabase"].Value;
            txtArchivePort.Text = config.AppSettings.Settings["archiveport"].Value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Main Config
            config.AppSettings.Settings["mainhost"].Value = txtMainHost.Text;
            config.AppSettings.Settings["mainuser"].Value = txtMainUser.Text;
            config.AppSettings.Settings["mainpassword"].Value = txtMainPass.Text;
            config.AppSettings.Settings["maindatabase"].Value = txtMainDB.Text;
            config.AppSettings.Settings["mainport"].Value = txtMainPort.Text;
            // Config Config
            config.AppSettings.Settings["confighost"].Value = txtConfigHost.Text;
            config.AppSettings.Settings["configuser"].Value = txtConfigUser.Text;
            config.AppSettings.Settings["configpassword"].Value = txtConfigPass.Text;
            config.AppSettings.Settings["configdatabase"].Value = txtConfigDB.Text;
            config.AppSettings.Settings["configport"].Value = txtConfigPort.Text;
            // Astromech Config
            config.AppSettings.Settings["astromechhost"].Value = txtAstroHost.Text;
            config.AppSettings.Settings["astromechuser"].Value = txtAstroUser.Text;
            config.AppSettings.Settings["astromechpassword"].Value = txtAstroPass.Text;
            config.AppSettings.Settings["astromechdatabase"].Value = txtAstroDB.Text;
            config.AppSettings.Settings["astromechport"].Value = txtAstromechPort.Text;
            // Main Config
            config.AppSettings.Settings["loghost"].Value = txtLogHost.Text;
            config.AppSettings.Settings["loguser"].Value = txtLogUser.Text;
            config.AppSettings.Settings["logpassword"].Value = txtLogPass.Text;
            config.AppSettings.Settings["logdatabase"].Value = txtLogDB.Text;
            config.AppSettings.Settings["logport"].Value = txtLogsPort.Text;
            // Tools Config
            config.AppSettings.Settings["toolshost"].Value = txtToolsHost.Text;
            config.AppSettings.Settings["toolsuser"].Value = txtToolsUser.Text;
            config.AppSettings.Settings["toolspassword"].Value = txtToolsPass.Text;
            config.AppSettings.Settings["toolsdatabase"].Value = txtToolsDB.Text;
            config.AppSettings.Settings["toolsport"].Value = txtToolsPort.Text;
            // Main Config
            config.AppSettings.Settings["archivehost"].Value = txtArchiveHost.Text;
            config.AppSettings.Settings["archiveuser"].Value = txtArchiveUser.Text;
            config.AppSettings.Settings["archivepassword"].Value = txtArchivePass.Text;
            config.AppSettings.Settings["archivedatabase"].Value = txtArchiveDB.Text;
            config.AppSettings.Settings["archiveport"].Value = txtArchivePort.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Update Successfull.", "Update Cconfiguration");
            Close();
        }
    }
}
