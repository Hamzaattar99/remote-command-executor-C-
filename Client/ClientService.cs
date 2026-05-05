using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    class ClientService
    {
        private ServerConnection _connection;
        private CommandHandler _handler;

        public void Start()
        {
            try
            {


                _connection = new ServerConnection();
                _handler = new CommandHandler(_connection);


                _connection.OnPacketReceived += _handler.Handle;

                _connection.Connect();
            }
            catch
            {
                MessageBox.Show("Failed to operate the client!!!");
                Application.Exit();
            }
        }
    }
}
