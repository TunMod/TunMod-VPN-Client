namespace TunMod_VPN_Client.UI
{
    partial class ConfigsPage
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
            this.BtnAdd = new System.Windows.Forms.PictureBox();
            this.PanelConfigAll = new System.Windows.Forms.Panel();
            this.lblActive = new System.Windows.Forms.Label();
            this.PanelTotal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            this.PanelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHome
            // 
            this.LabelHome.AutoSize = true;
            this.LabelHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelHome.ForeColor = System.Drawing.Color.White;
            this.LabelHome.Location = new System.Drawing.Point(29, 11);
            this.LabelHome.Name = "LabelHome";
            this.LabelHome.Size = new System.Drawing.Size(83, 19);
            this.LabelHome.TabIndex = 7;
            this.LabelHome.Text = "SSH Configs";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_add_30;
            this.BtnAdd.Location = new System.Drawing.Point(341, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(30, 30);
            this.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.BtnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // PanelConfigAll
            // 
            this.PanelConfigAll.AutoScroll = true;
            this.PanelConfigAll.Location = new System.Drawing.Point(9, 39);
            this.PanelConfigAll.Name = "PanelConfigAll";
            this.PanelConfigAll.Size = new System.Drawing.Size(524, 245);
            this.PanelConfigAll.TabIndex = 9;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActive.ForeColor = System.Drawing.Color.Red;
            this.lblActive.Location = new System.Drawing.Point(154, 9);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(247, 15);
            this.lblActive.TabIndex = 7;
            this.lblActive.Text = "Disconnect Connection to active Config Page";
            this.lblActive.Visible = false;
            // 
            // PanelTotal
            // 
            this.PanelTotal.Controls.Add(this.PanelConfigAll);
            this.PanelTotal.Controls.Add(this.BtnAdd);
            this.PanelTotal.Controls.Add(this.LabelHome);
            this.PanelTotal.Location = new System.Drawing.Point(6, 29);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(542, 286);
            this.PanelTotal.TabIndex = 10;
            // 
            // ConfigsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.PanelTotal);
            this.Controls.Add(this.lblActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ئوئ";
            this.Activated += new System.EventHandler(this.ConfigsPage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHome;
        private System.Windows.Forms.PictureBox BtnAdd;
        private System.Windows.Forms.Panel PanelSSH;
        private System.Windows.Forms.Panel PanelC4;
        private System.Windows.Forms.Label CSSH_Name;
        private System.Windows.Forms.Panel PanelC1;
        private System.Windows.Forms.PictureBox BtnConfigsEdit;
        private System.Windows.Forms.Panel PanelActive;
        private System.Windows.Forms.Panel PanelC2;
        private System.Windows.Forms.Panel PanelC3;
        private System.Windows.Forms.PictureBox BtnConfigDelete;
        private System.Windows.Forms.Panel PanelConfigAll;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Panel PanelTotal;
    }
}