using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TunMod_VPN_Client.Model;


namespace TunMod_VPN_Client.UI
{
    public partial class ConfigsPage : Form
    {
        public ConfigsPage()
        {
            InitializeComponent();

            ToolTipSetup();

            Load_Configs();
        }


        public void ToolTipSetup()
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();


            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;


            toolTip1.SetToolTip(this.BtnAdd, "Import SSH Config Manually");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddManually _Add = new AddManually(0);

            _Add.ShowDialog();
            Load_Configs();
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            this.BtnAdd.Image = global::TunMod_VPN_Client.Properties.Resources.add_Color;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.BtnAdd.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_add_30;
        }


        private void BtnConfigsEdit_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = global::TunMod_VPN_Client.Properties.Resources.icons8_create_271;
        }

        private void BtnConfigsEdit_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = global::TunMod_VPN_Client.Properties.Resources.icons8_create_27;
        }

        private void BtnConfigDelete_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = global::TunMod_VPN_Client.Properties.Resources.icons8_delete_271;
        }

        private void BtnConfigDelete_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = global::TunMod_VPN_Client.Properties.Resources.icons8_delete_27;
        }



        private void BtnEdit_Click(object sender, EventArgs e)
        {
            AddManually _Add = new AddManually(Convert.ToInt64(((PictureBox)sender).Tag));

            _Add.ShowDialog();
            Load_Configs();
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string[] _SplitTag= ((PictureBox)sender).Tag.ToString().Split('#');

            DialogResult dialogResult = MessageBox.Show("Delete Config " + _SplitTag[0] + " ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SSHConfig _SSH = new SSHConfig();
                _SSH.id = Convert.ToInt64(_SplitTag[1]);

                BL.usr.WriteConfig(_SSH, 2);
            }
    

            Load_Configs();
        }


        private void BtnSelect_Click(object sender, EventArgs e)
        {

            SSHConfig _SSHConfig = BL.usr.LoadConfig(Convert.ToInt64(((Label)sender).Tag));

            if (!_SSHConfig.C_Default)
            {
                _SSHConfig.C_Default = true;

                BL.usr.WriteConfig(_SSHConfig, 1);

                Load_Configs();
            }
        }



        public void Load_Configs()
        {
            PanelConfigAll.Controls.Clear();

      

            List<SSHConfig> _ConfigsList = BL.usr.ReadAllConfig();

            if (_ConfigsList != null)
            {

                for (int i = 0; i < _ConfigsList.Count; i++)
                {
                    Create_Config_Header(_ConfigsList[i].C_Name, _ConfigsList[i].id, i, _ConfigsList[i].C_Default);
                }
            }
        }



        public void Create_Config_Header(string _ConfigName,long _ConfigID,int _ConfigIndex,Boolean _Default)
        {
            this.PanelSSH = new System.Windows.Forms.Panel();
            this.PanelActive = new System.Windows.Forms.Panel();
            this.CSSH_Name = new System.Windows.Forms.Label();
            this.PanelC1 = new System.Windows.Forms.Panel();
            this.PanelC4 = new System.Windows.Forms.Panel();
            this.PanelC3 = new System.Windows.Forms.Panel();
            this.PanelC2 = new System.Windows.Forms.Panel();
            this.BtnConfigsEdit = new System.Windows.Forms.PictureBox();
            this.BtnConfigDelete = new System.Windows.Forms.PictureBox();




            ((System.ComponentModel.ISupportInitialize)(this.BtnConfigsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConfigDelete)).BeginInit();

            // PanelSSH
            // 
            this.PanelSSH.Name = "PanelSSH" + _ConfigIndex;
            this.PanelSSH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelSSH.Controls.Add(this.PanelC2);
            this.PanelSSH.Controls.Add(this.PanelC3);
            this.PanelSSH.Controls.Add(this.PanelC4);
            this.PanelSSH.Controls.Add(this.PanelC1);
            this.PanelSSH.Controls.Add(this.PanelActive);
   
            this.PanelSSH.Name = "PanelSSH";
            this.PanelSSH.Size = new System.Drawing.Size(340, 44);
            this.PanelSSH.Location = new System.Drawing.Point(15, (((_ConfigIndex*2) * 26)) + 5);
            this.PanelSSH.Tag = _ConfigID;
            this.PanelSSH.Click += new System.EventHandler(this.BtnSelect_Click);
     
       


            // PanelActive
            // 

            if (_Default)
            {
                this.PanelActive.BackColor = System.Drawing.Color.CornflowerBlue;
            }
            else
            {
                this.PanelActive.BackColor = System.Drawing.Color.Gray;
            }

            this.PanelActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelActive.Location = new System.Drawing.Point(0, 0);
            this.PanelActive.Name = "PanelActive";
            this.PanelActive.Size = new System.Drawing.Size(8, 53);
            this.PanelActive.TabIndex = 0;
            // 

            // CSSH_Name
            // 
            this.CSSH_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CSSH_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSSH_Name.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.CSSH_Name.ForeColor = System.Drawing.Color.White;
            this.CSSH_Name.Location = new System.Drawing.Point(0, 0);
            this.CSSH_Name.Name = "CSSH_Name";
            this.CSSH_Name.Size = new System.Drawing.Size(232, 53);
            this.CSSH_Name.TabIndex = 7;
            this.CSSH_Name.Text = _ConfigName;
            this.CSSH_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.CSSH_Name.Tag = _ConfigID;
            this.CSSH_Name.Click += new System.EventHandler(this.BtnSelect_Click);
            // 


            // PanelC1
            // 
            this.PanelC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelC1.Location = new System.Drawing.Point(8, 0);
            this.PanelC1.Name = "PanelC1";
            this.PanelC1.Size = new System.Drawing.Size(16, 53);
            this.PanelC1.TabIndex = 1;
            // 

            // PanelC4
            // 
            this.PanelC4.Controls.Add(this.CSSH_Name);
            this.PanelC4.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelC4.Location = new System.Drawing.Point(24, 0);
            this.PanelC4.Name = "PanelC4";
            this.PanelC4.Size = new System.Drawing.Size(232, 53);
            this.PanelC4.TabIndex = 2;
            this.PanelC4.Tag = _ConfigID;
            this.PanelC4.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // PanelC3
            // 
            this.PanelC3.Controls.Add(this.BtnConfigDelete);
            this.PanelC3.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelC3.Location = new System.Drawing.Point(330, 0);
            this.PanelC3.Name = "PanelC3";
            this.PanelC3.Size = new System.Drawing.Size(35, 53);
            this.PanelC3.TabIndex = 3;
            // 

            // PanelC2
            // 
            this.PanelC2.Controls.Add(this.BtnConfigsEdit);
            this.PanelC2.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelC2.Location = new System.Drawing.Point(289, 0);
            this.PanelC2.Name = "PanelC2";
            this.PanelC2.Size = new System.Drawing.Size(41, 53);
            this.PanelC2.TabIndex = 4;
            // 


            // BtnConfigsEdit
            // 
            this.BtnConfigsEdit.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_create_27;
            this.BtnConfigsEdit.Location = new System.Drawing.Point(6, 11);
            this.BtnConfigsEdit.Name = "BtnConfigsEdit";
            this.BtnConfigsEdit.Size = new System.Drawing.Size(27, 27);
            this.BtnConfigsEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnConfigsEdit.TabIndex = 8;
            this.BtnConfigsEdit.TabStop = false;
            this.BtnConfigsEdit.MouseEnter += new System.EventHandler(this.BtnConfigsEdit_MouseEnter);
            this.BtnConfigsEdit.MouseLeave += new System.EventHandler(this.BtnConfigsEdit_MouseLeave);
            this.BtnConfigsEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.BtnConfigsEdit.Tag = _ConfigID;

            // 


            // BtnConfigDelete
            // 
            this.BtnConfigDelete.Image = global::TunMod_VPN_Client.Properties.Resources.icons8_delete_27;
            this.BtnConfigDelete.Location = new System.Drawing.Point(1, 11);
            this.BtnConfigDelete.Name = "BtnConfigDelete";
            this.BtnConfigDelete.Size = new System.Drawing.Size(27, 27);
            this.BtnConfigDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnConfigDelete.TabIndex = 9;
            this.BtnConfigDelete.TabStop = false;
            this.BtnConfigDelete.MouseEnter += new System.EventHandler(this.BtnConfigDelete_MouseEnter);
            this.BtnConfigDelete.MouseLeave += new System.EventHandler(this.BtnConfigDelete_MouseLeave);
            this.BtnConfigDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.BtnConfigDelete.Tag = _ConfigName + "#" + _ConfigID;
            // 

            PanelSSH.BringToFront();
            PanelConfigAll.Controls.Add(this.PanelSSH); 

            this.PanelSSH.ResumeLayout(false);
            this.PanelC4.ResumeLayout(false);
            this.PanelC3.ResumeLayout(false);
            this.PanelC2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnConfigsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConfigDelete)).EndInit();

        }


        private void ConfigsPage_Activated(object sender, EventArgs e)
        {
            if(BL.SSH_Call._StateConnect == 1)
            {
                lblActive.Location = new Point(55, 30);
                lblActive.Visible = true;
                PanelTotal.Visible = false;
            }
            else
            {
                lblActive.Visible = false;
                PanelTotal.Visible = true;
            }
        }
    }
}
