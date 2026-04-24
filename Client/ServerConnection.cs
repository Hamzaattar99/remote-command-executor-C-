using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SharedLibrary;
using System.Threading;
namespace Client
{
    class ServerConnection
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public event Action<Packet> OnPacketReceived;

        public void Connect()
        {
            _client = new TcpClient();
            _client.Connect("127.0.0.1", 5000);
            _stream = _client.GetStream();

            ReceiveAsync();
        }


        public void Send(Packet packet)
        {
            byte[] data = PacketSerializer.Serialize(packet);
            _stream.Write(data, 0, data.Length);
        }


        private async void ReceiveAsync()
        {
            byte[] buffer = new byte[4096];


            while(true)
            {
                int bytes = await _stream.ReadAsync(buffer, 0, buffer.Length);

                if (bytes == 0) break;

                byte[] actualData = new byte[bytes];
                Array.Copy(buffer, actualData, bytes);

              

                Packet packet = PacketSerializer.Deserialize(actualData); // we had (buffer) instead of (actualData) .
                
                if(OnPacketReceived != null)
                {
                    OnPacketReceived.Invoke(packet);
                }
                
            }
        }
    }
}
