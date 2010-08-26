using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ANHDBI;
using ANHDBI.MySQL;
using Utilities;
using MySql.Data.MySqlClient;
using ANHAcctMgr;
using ANHMonitor;
using ANHTCClient;

namespace ANHGui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmAcctMgr fAcctMgr = new frmAcctMgr();
            fAcctMgr.MdiParent = this;
            fAcctMgr.Show();
            Cursor = Cursors.Default;
        }

        private void configurationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmDBConfig fDBConfig = new frmDBConfig();
            fDBConfig.MdiParent = this;
            fDBConfig.Show();
            Cursor = Cursors.Default;
        }

        private void serversToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmMonitor fMonitor = new frmMonitor();
            fMonitor.MdiParent = this;
            fMonitor.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmRemoteConfig fRemoteConfig = new frmRemoteConfig();
            fRemoteConfig.MdiParent = this;
            fRemoteConfig.Show();
            Cursor = Cursors.Default;
        }
    }
}
