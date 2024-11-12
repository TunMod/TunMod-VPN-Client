using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TunMod_VPN_Client.BL;
using TunMod_VPN_Client.Model;

namespace TunMod_VPN_Client.UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            this.AutoScroll = false;
        
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
      

            Thread _th = new Thread(SetValues);
            _th.Start();
        }


        public void SetValues()
        {
            GetDefault();
     
      
        }

        public void GetDefault()
        {
            SSHConfig _SSHConfig = BL.usr.GetDefault();

            if (_SSHConfig != null)
            {
                lblProfile.Text = _SSHConfig.C_Name;

                lblProfile.ForeColor = Color.Green;

            }

            else
            {
                lblProfile.Text = "Not Selected";
                lblProfile.ForeColor = Color.Red;
            }
        }

        private void HomePage_Activated(object sender, EventArgs e)
        {
            Thread _th = new Thread(SetValues);
            _th.Start();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            int _ret = 0;

            BtnConnect.Enabled = false;
            if (BtnConnect.Text == "Connect")
            {

                Thread.Sleep(1000);

                _ret = BL.SSH_Call.Start_Connection();

                if (_ret == 0)
                {
                    BtnConnect.Text = "Disconnect";

                    lblStatus.Text = "Connected";

                    lblStatus.ForeColor = Color.Green;

                    BtnConnect.BackColor = Color.FromArgb(138, 154, 91);

                    Thread _th = new Thread(SetValues);
                    _th.Start();
                }
            }
            else
            {
                _ret = BL.SSH_Call.Stop_Connection();

                if (_ret == -1)
                {
                    BtnConnect.Text = "Connect";

                    lblStatus.Text = "Disconnect";
                    lblStatus.ForeColor = Color.Red;

                    BtnConnect.BackColor = Color.FromArgb(40, 40, 40);

                }


            }

            BtnConnect.Enabled = true;
        }

 
    }
}
