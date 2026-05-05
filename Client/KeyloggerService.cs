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
        //public static string Logs = "";
        
        public static bool Running = false;

        private string fullMessage;

        public InputManagerKeylogger Input;
       // public com          

      

        public KeyloggerService()
        {
            Input = new InputManagerKeylogger();
        }

        public void ChangeRunningState()
        {
            Running = true;
        }

        public void setValues(string mess)
        {
            fullMessage = mess;
        }

        public string UpdateLogs()
        {


            if(Running)
            {
                return fullMessage;

            }







          //  if (Input.Up) return "Up Key has pressed at (" + DateTime.Now.ToString("HH:mm:ss") + "";
          //  if (Input.Down) return "Down Key has pressed at (" + DateTime.Now.ToString("HH:mm:ss");
           // if (Input.Left) return "Left Key has pressed at (" + DateTime.Now.ToString("HH:mm:ss");
           // if (Input.Right) return "Right Key has pressed at (" + DateTime.Now.ToString("HH:mm:ss");


            return "";
        }




        public static void Start()
        {
          //  Application.AddMessageFilter(new KeyFilter());

            
        }

     
        

       /* private class KeyFilter : IMessageFilter
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
        }*/
    }
}
