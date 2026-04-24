using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Client
{
    class FileManager
    {
        public static List<string> GetFiles(string path)
        {
            List<string> listOfFiles = new List<string>();

            foreach(var file in Directory.GetFiles(path))
            {
                listOfFiles.Add(file);
            }

            return listOfFiles;
        }
    }
}
