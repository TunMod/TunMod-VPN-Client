namespace TunMod_VPN_Client.UI
{
    partial class StatusPage
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.TimerStatus = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adapter Network Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_wired_network_connection_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adapter Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(69, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 21);
            this.lblName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Download";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Upload";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDown.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblDown.ForeColor = System.Drawing.Color.Gold;
            this.lblDown.Location = new System.Drawing.Point(90, 207);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(0, 21);
            this.lblDown.TabIndex = 11;
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUp.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblUp.ForeColor = System.Drawing.Color.Gold;
            this.lblUp.Location = new System.Drawing.Point(227, 207);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(0, 21);
            this.lblUp.TabIndex = 11;
            // 
            // TimerStatus
            // 
            this.TimerStatus.Interval = 500;
            this.TimerStatus.Tick += new System.EventHandler(this.TimerStatus_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 63);
            this.panel1.TabIndex = 12;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.PanelStatus.Controls.Add(this.panel5);
            this.PanelStatus.Controls.Add(this.panel1);
            this.PanelStatus.Controls.Add(this.lblUp);
            this.PanelStatus.Controls.Add(this.lblDown);
            this.PanelStatus.Controls.Add(this.label4);
            this.PanelStatus.Controls.Add(this.label3);
            this.PanelStatus.Location = new System.Drawing.Point(30, 32);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(363, 292);
            this.PanelStatus.TabIndex = 13;
            this.PanelStatus.VisibleChanged += new System.EventHandler(this.PanelStatus_VisibleChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 63);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(30, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 63);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 92);
            this.panel5.TabIndex = 13;
            // 
            // StatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(423, 348);
            this.Controls.Add(this.PanelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StatusPage";
            this.Activated += new System.EventHandler(this.StatusPage_Activated);
            this.Deactivate += new System.EventHandler(this.StatusPage_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Timer TimerStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Panel panel5;
    }
}