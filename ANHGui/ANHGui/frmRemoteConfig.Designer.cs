namespace ANHGui
{
    partial class frmRemoteConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PassKey:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(73, 10);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(169, 20);
            this.txtHost.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(73, 33);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(169, 20);
            this.txtPort.TabIndex = 4;
            // 
            // txtPassKey
            // 
            this.txtPassKey.Location = new System.Drawing.Point(73, 56);
            this.txtPassKey.Name = "txtPassKey";
            this.txtPassKey.Size = new System.Drawing.Size(169, 20);
            this.txtPassKey.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ANHGui.Properties.Resources.grey;
            this.btnSave.Location = new System.Drawing.Point(16, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Config";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRemoteConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ANHGui.Properties.Resources.grey;
            this.ClientSize = new System.Drawing.Size(258, 137);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassKey);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmRemoteConfig";
            this.Text = "Remote Configuration";
            this.Load += new System.EventHandler(this.frmRemoteConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassKey;
        private System.Windows.Forms.Button btnSave;
    }
}