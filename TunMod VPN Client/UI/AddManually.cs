using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TunMod_VPN_Client.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TunMod_VPN_Client.UI
{
    public partial class AddManually : Form
    {
        public AddManually(long _ConfigID1)
        {
            InitializeComponent();

            this._ConfigID = _ConfigID1;

            if(_ConfigID1 !=0)
            {
                Load_Edit();
            }
        }

        long _ConfigID;


        public void Load_Edit()
        {
            SSHConfig _SSHConfig = BL.usr.LoadConfig(_ConfigID);

            txtProfileName.Text = _SSHConfig.C_Name;

            txtHost.Text = _SSHConfig.C_Host;
            txtPort.Text = _SSHConfig.C_Port.ToString();


            txtUser.Text = _SSHConfig.C_User;
            txtPass.Text = _SSHConfig.C_Pass;


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Create_Obj()
        {
            try
            {
                SSHConfig _Config = new SSHConfig();

                if (_ConfigID == 0)
                    _Config.id = GetID();
                else
                    _Config.id = _ConfigID;
                _Config.C_Name = txtProfileName.Text;
                _Config.C_Host = txtHost.Text;
                _Config.C_Port = Convert.ToInt32(txtPort.Text);
                _Config.C_UDPGW = 0;

                _Config.C_User = txtUser.Text;
                _Config.C_Pass = txtPass.Text;

                _Config.C_Default = true;

                if (_ConfigID == 0)
                    BL.usr.WriteConfig(_Config, 0);
                else
                    BL.usr.WriteConfig(_Config, 1);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter correct values");

                txtProfileName.Focus();
            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Validations_Fields();

            Create_Obj();

        
        }


        public void Validations_Fields()
        {
            bool _Valid = true;

            if (txtProfileName.Text.Length == 0)
            {
                _Valid = false;
                lblProfile.ForeColor = Color.Red;
            }

            if (txtHost.Text.Length == 0)
            {
                _Valid = false;
                lblHost.ForeColor = Color.Red;
            }

            if (txtPort.Text.Length == 0)
            {
                _Valid = false;
                lblPort.ForeColor = Color.Red;
            }


            if (txtUser.Text.Length == 0)
            {
                _Valid = false;
                lblUser.ForeColor = Color.Red;
            }


            if (txtPass.Text.Length == 0)
            {
                _Valid = false;
                lblPass.ForeColor = Color.Red;
            }

        }


        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }


        private void txtProfileName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
                lblProfile.ForeColor = Color.Black;
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
                lblHost.ForeColor = Color.Black;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
                lblPort.ForeColor = Color.Black;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
                lblUser.ForeColor = Color.Black;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
                lblPass.ForeColor = Color.Black;
        }

        public long GetID()
        {
            Random _rand = new Random();
            string _temp = _rand.Next(1, 9) + "" + _rand.Next(10, 99) + "" + _rand.Next(1, 9) + "" + _rand.Next(10, 99) + "" + _rand.Next(121, 888);

            return Convert.ToInt64(_temp);
        }

        private void AddManually_Load(object sender, EventArgs e)
        {

        }
    }
}
