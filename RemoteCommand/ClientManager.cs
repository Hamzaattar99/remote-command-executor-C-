using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SharedLibrary;

namespace RemoteCommand
{
    class ClientManager
    {

        private List<ClientHandler> _clients = new List<ClientHandler>();

        public IReadOnlyList<ClientHandler> Clients
        {
            get { return _clients; }
        }

        public event Action<ClientHandler> OnClientAdded;
        public event Action<ClientHandler> OnClientRemoved;


        public void Add(ClientHandler client)
        {
            _clients.Add(client);

            if(OnClientAdded != null)
            {
                OnClientAdded.Invoke(client);
            }
            
        }

        public void Remove(ClientHandler client)
        {
            _clients.Remove(client);

            if (OnClientRemoved != null)
            {
                OnClientRemoved.Invoke(client);
            }
        }

        public ClientHandler GetId(string id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

    }
}
