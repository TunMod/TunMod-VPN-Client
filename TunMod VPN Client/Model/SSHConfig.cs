using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunMod_VPN_Client.Model
{
    public class SSHConfig
    {
        public long id { get; set; }

        public string C_Name { get; set; }

        public string C_Host { get; set; }

        public int C_Port { get; set; }

        public int C_UDPGW { get; set; }

        public string C_User { get; set; }

        public string C_Pass { get; set; }

        public Boolean C_Default { get; set; }


    }
}
