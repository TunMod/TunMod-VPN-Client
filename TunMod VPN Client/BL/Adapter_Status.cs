using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TunMod_VPN_Client.BL
{
    public class Adapter_Status
    {
        public static string Get_Status()
        {
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();

            var activeAdapter = networks.First(x => x.NetworkInterfaceType != NetworkInterfaceType.Loopback
                                && x.NetworkInterfaceType != NetworkInterfaceType.Tunnel
                                && x.OperationalStatus == OperationalStatus.Up
                                && x.Name.StartsWith("vEthernet") == false);

            UnicastIPAddressInformation  uniCastIPInfo = null;


            if (activeAdapter != null && activeAdapter.GetIPProperties().UnicastAddresses != null)
            {
                UnicastIPAddressInformationCollection ipInfo = activeAdapter.GetIPProperties().UnicastAddresses;

                foreach (UnicastIPAddressInformation item in ipInfo)
                {
                    if (item.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        uniCastIPInfo = item;
                        break;
                    }
                }
            }

            if (activeAdapter == null)
                return "";
           

            string _interType = activeAdapter.NetworkInterfaceType.ToString();


            IPv4InterfaceStatistics interfaceData = activeAdapter.GetIPv4Statistics();

            double _Down = ((double)interfaceData.BytesReceived/ 1073741824);

            double _Up = ((double)interfaceData.BytesSent/ 1073741824);

            _Down = Math.Round((double)_Down, 5);

            _Up = Math.Round((double)_Up, 5);


            string _DownStr = _Down + " GB";
            string _UpStr = _Up + " GB";




            return _interType + "#" + _DownStr + "#" + _UpStr;

        }
    }
}
