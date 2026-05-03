using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using SharedLibrary;
namespace RemoteCommand
{
    class ClientHandler
    {
        public TcpClient Clinet { get; private set; }
        public NetworkStream Stream { get; private set; }


        public string Id { get; set; }

        public event Action<ClientHandler, Packet> OnPacketReceived;
        public event Action<ClientHandler> OnDisconnected;


        public ClientHandler(TcpClient client)
        {
            Clinet = client;
            Stream = client.GetStream();
        }

        public void Start()
        {
            ReceiveAsync();
        }


        public async void Send(Packet packet)
        {
            byte [] data = PacketSerializer.Serialize(packet);
            await Stream.WriteAsync(data, 0, data.Length);
        }


        private async void ReceiveAsync()
        {

            try
            {
                byte[] buffer = new byte[4096];

                while(true)
                {
                    int bytesRead = await Stream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead == 0) break;


                    Packet packet = PacketSerializer.Deserialize(buffer);

                    OnPacketReceived.Invoke(this, packet);
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            OnDisconnected.Invoke(this);
        }
    }
}
