using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TunMod_VPN_Client.UI
{
    public partial class StatusPage : Form
    {
        public StatusPage()
        {
            InitializeComponent();
        }

        private void StatusPage_Activated(object sender, EventArgs e)
        {
            TimerStatus.Start();
        }


        public void Check_Status()
        {
            string[] _SplitValue = BL.Adapter_Status.Get_Status().Split('#');

            lblName.Text = _SplitValue[0];

            lblDown.Text = _SplitValue[1];

            lblUp.Text = _SplitValue[2];

            this.SuspendLayout();
         
        }

        private void TimerStatus_Tick(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void StatusPage_Deactivate(object sender, EventArgs e)
        {
            TimerStatus.Stop();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Check_Status();
        }

        private void PanelStatus_VisibleChanged(object sender, EventArgs e)
        {
            if(PanelStatus.Visible)
            {

            }
        }
    }
}
