using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TunMod_VPN_Client.UI
{
    public partial class PingForm : Form
    {
        public PingForm()
        {
            InitializeComponent();

            _syncContext = SynchronizationContext.Current;

            CheckForIllegalCrossThreadCalls = false;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            txtPing.Text = "";
            StartProcess();

        }


        SynchronizationContext _syncContext;

        void StartProcess()
        {
            txtAddress.Text = txtAddress.Text.Replace("www.","");

            using (var process = new Process
            {

                StartInfo = new ProcessStartInfo(@"cmd.exe", "/c ping -n 4 " + txtAddress.Text )
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                }
            })
            {
                process.OutputDataReceived += (sender, args) => Display(args.Data);
                process.ErrorDataReceived += (sender, args) => Display(args.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
        }

        void Display(string output)
        {
            _syncContext.Post(_ => txtPing.AppendText(output + Environment.NewLine), null);
        }

        private void PingForm_Activated(object sender, EventArgs e)
        {
            txtPing.Text = "";
            txtAddress.Text = "";
        }
    }
}
