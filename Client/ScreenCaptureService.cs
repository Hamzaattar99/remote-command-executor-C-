using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Client
{
    class ScreenCaptureService
    {
        public static byte [] Capture()
        {
            Bitmap bmp = new Bitmap(1920, 1080);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(0, 0, 0, 0, bmp.Size);

            using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
