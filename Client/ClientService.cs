using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class ClientService
    {
        private ServerConnection _connection;
        private CommandHandler _handler;

        public void Start()
        {
            _connection = new ServerConnection();
            _handler = new CommandHandler(_connection);


            _connection.OnPacketReceived += _handler.Handle;

            _connection.Connect();
        }
    }
}
