using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using SharedLibrary;

namespace Client
{
    class SystemInfoService
    {

        public static Packet GetInfo()
        {
            return new Packet
            {
                Command = "INFO",
                Data = "Hostname: " + Dns.GetHostName() + "\n" + "IP: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0]
            };
        }
    }
}
