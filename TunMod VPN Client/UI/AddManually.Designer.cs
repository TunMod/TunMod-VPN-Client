namespace TunMod_VPN_Client.UI
{
    partial class AddManually
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(19)))), ((int)(((byte)(100)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(360, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 345);
            this.label1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(19)))), ((int)(((byte)(100)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 2);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(19)))), ((int)(((byte)(100)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 343);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(19)))), ((int)(((byte)(100)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(2, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 2);
            this.label4.TabIndex = 10;
            // 
            // BtnHome
            // 
            this.BtnHome.AutoSize = true;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Font = new System.Drawing.Font("Calibri", 12F);
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Location = new System.Drawing.Point(19, 18);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(171, 19);
            this.BtnHome.TabIndex = 11;
            this.BtnHome.Text = "Add SSH Config Manually";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProfile.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblProfile.ForeColor = System.Drawing.Color.Black;
            this.lblProfile.Location = new System.Drawing.Point(37, 79);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(89, 18);
            this.lblProfile.TabIndex = 11;
            this.lblProfile.Text = "Profile Name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.BackColor = System.Drawing.Color.White;
            this.txtProfileName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(129, 78);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(1);
            this.txtProfileName.Multiline = true;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(184, 24);
            this.txtProfileName.TabIndex = 0;
            this.txtProfileName.TextChanged += new System.EventHandler(this.txtProfileName_TextChanged);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHost.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblHost.ForeColor = System.Drawing.Color.Black;
            this.lblHost.Location = new System.Drawing.Point(30, 119);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(95, 18);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "Hostname / IP";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.White;
            this.txtHost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(129, 117);
            this.txtHost.Margin = new System.Windows.Forms.Padding(1);
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(184, 24);
            this.txtHost.TabIndex = 1;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPort.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(62, 159);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(60, 18);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "SSH Port";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(129, 157);
            this.txtPort.Margin = new System.Windows.Forms.Padding(1);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(184, 24);
            this.txtPort.TabIndex = 2;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(52, 196);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 18);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(129, 194);
            this.txtUser.Margin = new System.Windows.Forms.Padding(1);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 24);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(57, 233);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 18);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(129, 231);
            this.txtPass.Margin = new System.Windows.Forms.Padding(1);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(184, 24);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(134, 290);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 28);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Done";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(226, 290);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(76, 28);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Cancel";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddManually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 345);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddManually";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddManually";
            this.Load += new System.EventHandler(this.AddManually_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BtnHome;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}