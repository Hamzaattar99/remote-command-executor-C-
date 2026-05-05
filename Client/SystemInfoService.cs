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
           
                
                //Data = "Hostname: " + Dns.GetHostName() + "\n" + "IP: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0]
                ClientInfo info = new ClientInfo
                {
                    Hostname = Environment.MachineName,
                    IP = GetLocalIP(),
                    MacAddress = GetMacAddress(),
                    ConnectedTime = DateTime.Now
                };

                byte[] data = PacketSerializer.SerializeObject(info);

                return new Packet
                {
                    Command = "INFO",
                    BinaryData = data
                };


            
        }

        private static string GetLocalIP()
        {
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
        }

        private static string GetMacAddress()
        {
            return "UNKNOWN"; //
        }
    }
}
