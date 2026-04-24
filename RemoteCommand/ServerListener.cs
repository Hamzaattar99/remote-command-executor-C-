using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace RemoteCommand
{
    class ServerListener
    {

        private TcpListener _listener;
        private bool _isRunning;


        public event Action<TcpClient> OnClinetConnected;

        public void Start(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            _isRunning = true;

            ListenAsync();
        }

        public void Stop()
        {
            _isRunning = false;
            _listener.Stop();
        }

        private async void ListenAsync()
        {
            while(_isRunning)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                OnClinetConnected.Invoke(client);
            }
        }
    }
}
