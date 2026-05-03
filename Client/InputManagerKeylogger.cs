
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    class InputManagerKeylogger
    {
       // public bool Up, Down, Left, Right; //

        public string LastKeyText { get; private set; }


        public event Action<string> OnKeyPressed;

        public void KeyDown(Keys key, bool ctrl, bool shift, bool alt)
        {
            string keyText = "";

            if (ctrl) keyText += "Ctrl + ";
            if (shift) keyText += "Shift + ";
            if (alt) keyText += "Alt + ";

            keyText += key.ToString();

            LastKeyText = keyText;


            if (OnKeyPressed != null) OnKeyPressed.Invoke(keyText);
           
        }

        /*public void KeyDown(Keys key)
        {
            switch (key)
            {
                case Keys.W: Up = true; break;
                case Keys.S: Down = true; break;
                case Keys.A: Left = true; break;
                case Keys.D: Right = true; break;
            }
        } 

        public void KeyUp(Keys key)
        {
            switch (key)
            {
                case Keys.W: Up = false; break;
                case Keys.S: Down = false; break;
                case Keys.A: Left = false; break;
                case Keys.D: Right = false; break;
            }
        } */
    }
}
