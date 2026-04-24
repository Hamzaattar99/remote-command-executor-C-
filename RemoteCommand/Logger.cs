using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    class Logger
    {
        public event Action<string> Onlog;

        public void Log(string message)
        {
            string log = "[" + DateTime.Now + "]" + message;

            //Console.WriteLine(log);

            if (Onlog != null)
                Onlog(log);
        }
    }
}
