using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TunMod_VPN_Client.Model;

namespace TunMod_VPN_Client.BL
{
    public class SSH_Call
    {

        public static int _StateConnect = 0;

        public static ProcessStartInfo psi = new ProcessStartInfo();
        public static Process proc = new Process();
        public static int Start_Connection()
        {
            try
            {
                SSHConfig _SSHConfig = BL.usr.GetDefault();

                if (_SSHConfig != null)
                {

                    psi.Arguments = _SSHConfig.C_User + "@" + _SSHConfig.C_Host + ":" + _SSHConfig.C_Port +
                        " -port=" + _SSHConfig.C_Port + " -user=" + _SSHConfig.C_User + " -pw=" + _SSHConfig.C_Pass +
                        " -proxyListPort=9015";

                    psi.CreateNoWindow = true;
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    psi.FileName = Application.StartupPath + "\\Sys\\stnlc.exe";
                    psi.RedirectStandardInput = true;
                    psi.UseShellExecute = false;

                    proc = Process.Start(psi);

                    Thread.Sleep(500);

                    proc.StandardInput.WriteLine("S");


                    _StateConnect = 1;

                 

                    return 0;
                }
                else
                {
                    MessageBox.Show("Please select ssh config");
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }


        private static void Read(StreamReader reader)
        {
            new Thread(() =>
            {
                while (true)
                {
                    int current;
                    while ((current = reader.Read()) >= 0)
                        Console.Write((char)current);
                }
            }).Start();
        }


        public static int Stop_Connection()
        {
            try
            {
                proc.StandardInput.WriteLine("exit");
            }
            catch
            {

            }

            try
            {
                proc.Kill();
            }
            catch
            { }

            _StateConnect = 0;


            return -1;
        }

    }
}
