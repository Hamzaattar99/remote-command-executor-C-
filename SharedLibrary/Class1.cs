using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SharedLibrary
{
    public class Class1
    {
    }



    [Serializable]
    public class Packet
    {
        public string Command { get; set; }
        public string Data { get; set; }
        public byte[] BinaryData { get; set; }
    }


    //------------------------------------------------------------------------------------------------

    public class PacketSerializer
    {
        public static byte[] Serialize(Packet packet)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, packet);
                return ms.ToArray();
            }
        }


        public static Packet Deserialize(byte[] data)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Packet)bf.Deserialize(ms);
            }
        }
    }


    //------------------------------------------------------------------------------------------------------

    [Serializable]
    public class ClientInfo
    {
        public string Id { get; set; }
        public string Hostname { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string MacAddress { get; set; }
        public DateTime ConnectedTime { get; set; }
    }

}
