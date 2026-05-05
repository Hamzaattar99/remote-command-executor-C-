using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace RemoteCommand
{
    public partial class MainControl : UserControl
    {

        ServerListener _lisener;
        ClientManager _clientManager;
        CommandDispatcher _dispatcher;
        Logger _logger;
        DatabaseService _db;


       // ClientManager clinets = new ClientManager(); 

        public MainControl()
        {
            InitializeComponent();
        }

        private void MakeActiveServerColorCircle()
        {
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(0, 0, activeServerColor.Width, activeServerColor.Height);

            activeServerColor.Region = new Region(path);
        }

        private void UpdateServerStatusColor(bool isOnline)
        {
            if(isOnline)
            {
                activeServerColor.BackColor = Color.Green;
            }
            else
            {
                activeServerColor.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            MakeActiveServerColorCircle();



            _lisener = new ServerListener();
            _clientManager = new ClientManager();
            _logger = new Logger();
            _db = new DatabaseService(""); ///
            _dispatcher = new CommandDispatcher(_db, _logger);



            _lisener.OnClinetConnected += OnClientConnected;

            _clientManager.OnClientAdded += AddClientToGrid;
            _clientManager.OnClientRemoved += RemoveClientFromGrid;
        }

        private void  LoadClients()
        {
            //clinetsTable.Rows.Clear();


        }

        private void OnClientConnected(TcpClient tcpClient)
        {
            var handler = new ClientHandler(tcpClient);

            handler.Info = new SharedLibrary.ClientInfo
            {
                Id = Guid.NewGuid().ToString(),
                IP = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString(),
                Port = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Port,
                ConnectedTime = DateTime.Now,
                Hostname = "Unknown",
                MacAddress = "Unknown"

            };

            _clientManager.Add(handler);

            handler.OnPacketReceived += _dispatcher.Dispatch;

            handler.OnDisconnected += (c) =>
                {
                    _clientManager.Remove(c);
                };


            handler.Start();
        }


        private void AddClientToGrid(ClientHandler client)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => AddClientToGrid(client)));
                return;
            }

            var info = client.Info;

            clinetsTable.Rows.Add(

                info.Id,
                info.Hostname,
                info.IP,
                info.Port,
                info.MacAddress,
                info.ConnectedTime.ToString("HH:mm:ss")

                );
        }

        
        private void RemoveClientFromGrid(ClientHandler client)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => RemoveClientFromGrid(client)));
                return;
            }

            foreach(DataGridViewRow row in clinetsTable.Rows)
            {

                
                if(row.Cells[0].Value != null && row.Cells[0].Value.ToString() == client.Info.Id)
                {
                    clinetsTable.Rows.Remove(row);
                    break;
                }
            }
        }

        private void radioButtonStopServer_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonStopServer.Checked)
            {
                UpdateServerStatusColor(false);
                _lisener.Stop();
            }
        }

        private void radioButtonStartServer_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonStartServer.Checked)
            {
                UpdateServerStatusColor(true);
                _lisener.Start(5000);
            }
        }

        private void refershButton_Click(object sender, EventArgs e)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => refershButton_Click(sender, e)));
                return;
            }

            clinetsTable.Rows.Clear();

            foreach(var client in _clientManager.Clients)
            {
                if (client.Info == null) continue;

                clinetsTable.Rows.Add(

                    client.Id,
                    client.Info.Hostname,
                    client.Info.IP,
                    client.Info.Port,
                    client.Info.MacAddress,
                    client.Info.ConnectedTime.ToString("HH:mm:ss")

                    );
            }
        }
    }
}
