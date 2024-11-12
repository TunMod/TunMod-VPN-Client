using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TunMod_VPN_Client.BL
{
    public class IPAddress
    {
        public static string GetExternalIpAddress()
        {
            string pubIp = "";

            //try
            //{
            //    pubIp = new System.Net.WebClient().DownloadString("https://api.ipify.org");
            //}
            //catch
            //{ }

            return pubIp;
        }

    }
}
