namespace TunMod_VPN_Client.UI
{
    partial class HomePage
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
            this.LabelHome = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHome
            // 
            this.LabelHome.AutoSize = true;
            this.LabelHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelHome.ForeColor = System.Drawing.Color.White;
            this.LabelHome.Location = new System.Drawing.Point(31, 32);
            this.LabelHome.Name = "LabelHome";
            this.LabelHome.Size = new System.Drawing.Size(90, 19);
            this.LabelHome.TabIndex = 8;
            this.LabelHome.Text = "Active Config";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProfile.ForeColor = System.Drawing.Color.Gold;
            this.lblProfile.Location = new System.Drawing.Point(31, 57);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(95, 20);
            this.lblProfile.TabIndex = 8;
            this.lblProfile.Text = "Not Selected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gold;
            this.lblStatus.Location = new System.Drawing.Point(31, 133);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Disconnected";
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConnect.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(206, 215);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(111, 39);
            this.BtnConnect.TabIndex = 10;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TunMod_VPN_Client.Properties.Resources.rec2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(278, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 151);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Connect With";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(46, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 23);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "HTTP Proxy (Payload)";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(46, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 23);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Directly Connect";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.panel1);
            this.PanelHome.Controls.Add(this.BtnConnect);
            this.PanelHome.Controls.Add(this.lblStatus);
            this.PanelHome.Controls.Add(this.lblProfile);
            this.PanelHome.Controls.Add(this.label4);
            this.PanelHome.Controls.Add(this.LabelHome);
            this.PanelHome.Location = new System.Drawing.Point(13, 34);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(519, 265);
            this.PanelHome.TabIndex = 13;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(549, 311);
            this.Controls.Add(this.PanelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomePage";
            this.Activated += new System.EventHandler(this.HomePage_Activated);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelHome;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelHome;
    }
}