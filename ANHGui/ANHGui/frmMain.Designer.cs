namespace ANHGui
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sWGANHConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galaxyConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameplayConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWGANHUserMgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::ANHGui.Properties.Resources.grey;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picLogo.Image = global::ANHGui.Properties.Resources.Image8;
            this.picLogo.Location = new System.Drawing.Point(0, 436);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1025, 56);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // menMain
            // 
            this.menMain.BackColor = System.Drawing.Color.Transparent;
            this.menMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serversToolStripMenuItem,
            this.serversToolStripMenuItem1,
            this.sWGANHConfigurationToolStripMenuItem,
            this.sWGANHUserMgmtToolStripMenuItem});
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Size = new System.Drawing.Size(1025, 24);
            this.menMain.TabIndex = 3;
            this.menMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.toolStripMenuItem1});
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.serversToolStripMenuItem.Text = "Preferences";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.configurationToolStripMenuItem.Text = "Database Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem1.Text = "Remote Configuration";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // serversToolStripMenuItem1
            // 
            this.serversToolStripMenuItem1.Name = "serversToolStripMenuItem1";
            this.serversToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.serversToolStripMenuItem1.Text = "Remote Admin";
            this.serversToolStripMenuItem1.Click += new System.EventHandler(this.serversToolStripMenuItem1_Click);
            // 
            // sWGANHConfigurationToolStripMenuItem
            // 
            this.sWGANHConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galaxyConfigToolStripMenuItem,
            this.zoneConfigToolStripMenuItem,
            this.globalConfigToolStripMenuItem,
            this.gameplayConfigToolStripMenuItem});
            this.sWGANHConfigurationToolStripMenuItem.Name = "sWGANHConfigurationToolStripMenuItem";
            this.sWGANHConfigurationToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.sWGANHConfigurationToolStripMenuItem.Text = "SWG:ANH Configuration";
            // 
            // galaxyConfigToolStripMenuItem
            // 
            this.galaxyConfigToolStripMenuItem.Name = "galaxyConfigToolStripMenuItem";
            this.galaxyConfigToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.galaxyConfigToolStripMenuItem.Text = "Galaxy Config";
            // 
            // zoneConfigToolStripMenuItem
            // 
            this.zoneConfigToolStripMenuItem.Name = "zoneConfigToolStripMenuItem";
            this.zoneConfigToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.zoneConfigToolStripMenuItem.Text = "Zone Config";
            // 
            // globalConfigToolStripMenuItem
            // 
            this.globalConfigToolStripMenuItem.Name = "globalConfigToolStripMenuItem";
            this.globalConfigToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.globalConfigToolStripMenuItem.Text = "Global Config";
            // 
            // gameplayConfigToolStripMenuItem
            // 
            this.gameplayConfigToolStripMenuItem.Name = "gameplayConfigToolStripMenuItem";
            this.gameplayConfigToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gameplayConfigToolStripMenuItem.Text = "Gameplay Config";
            // 
            // sWGANHUserMgmtToolStripMenuItem
            // 
            this.sWGANHUserMgmtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagerToolStripMenuItem});
            this.sWGANHUserMgmtToolStripMenuItem.Name = "sWGANHUserMgmtToolStripMenuItem";
            this.sWGANHUserMgmtToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.sWGANHUserMgmtToolStripMenuItem.Text = "SWG:ANH User Mgmt";
            // 
            // accountManagerToolStripMenuItem
            // 
            this.accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            this.accountManagerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accountManagerToolStripMenuItem.Text = "Account Manager";
            this.accountManagerToolStripMenuItem.Click += new System.EventHandler(this.accountManagerToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::ANHGui.Properties.Resources.grey;
            this.ClientSize = new System.Drawing.Size(1025, 492);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menMain;
            this.Name = "frmMain";
            this.Text = "SWG:ANH Server Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sWGANHConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galaxyConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameplayConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWGANHUserMgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}