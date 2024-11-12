namespace TunMod_VPN_Client.UI
{
    partial class PingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPing = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PanelPing = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelPing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 84);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "HTTP Ping";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 84);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_ping_641;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtPing
            // 
            this.txtPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.txtPing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPing.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPing.ForeColor = System.Drawing.Color.White;
            this.txtPing.Location = new System.Drawing.Point(0, 155);
            this.txtPing.Name = "txtPing";
            this.txtPing.ReadOnly = true;
            this.txtPing.Size = new System.Drawing.Size(465, 202);
            this.txtPing.TabIndex = 1;
            this.txtPing.TabStop = false;
            this.txtPing.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(39, 108);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 25);
            this.txtAddress.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(357, 106);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 28);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Ping";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PanelPing
            // 
            this.PanelPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.PanelPing.Controls.Add(this.BtnSave);
            this.PanelPing.Controls.Add(this.txtAddress);
            this.PanelPing.Controls.Add(this.txtPing);
            this.PanelPing.Controls.Add(this.panel1);
            this.PanelPing.Location = new System.Drawing.Point(12, 6);
            this.PanelPing.Name = "PanelPing";
            this.PanelPing.Size = new System.Drawing.Size(465, 357);
            this.PanelPing.TabIndex = 2;
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(577, 404);
            this.Controls.Add(this.PanelPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PingForm";
            this.Activated += new System.EventHandler(this.PingForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelPing.ResumeLayout(false);
            this.PanelPing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtPing;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel PanelPing;
    }
}