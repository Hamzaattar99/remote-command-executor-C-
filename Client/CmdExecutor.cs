using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Client
{
    class CmdExecutor
    {
        public static string Execute(string command)
        {
            Process p = new Process();

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + command;

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();


            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();


            return output + error;
        }
    }
}
