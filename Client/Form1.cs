using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class mainPage : Form
    {
        private InputManagerKeylogger input = new InputManagerKeylogger();
        private KeyloggerService ss = new KeyloggerService();

        public mainPage()
        {
            InitializeComponent();

            this.KeyPreview = true;
            //this.KeyDown += MainForm_KeyDown;
            
        }

      //  public Keys LastKeyPressed;

        private void mainPage_Load(object sender, EventArgs e)
        {
           // this.Hide();
            //this.ShowInTaskbar = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //LastKeyPressed = e.KeyCode;


            //Label la = new Label();

           // la.Text = "Last Key: " + LastKeyPressed;
        }

        private void mainPage_KeyDown(object sender, KeyEventArgs e)
        {
            input.KeyDown(e.KeyCode, e.Control, e.Shift, e.Alt);
            //label1.Text = e.KeyCode.ToString() +" " + e.Control.ToString() + " " + e.Shift.ToString() + " " + e.Alt.ToString();
            //input.KeyDown(e.KeyCode);
        }

        private void mainPage_KeyUp(object sender, KeyEventArgs e)
        {
            //input.KeyUp(e.KeyCode);
        }
    }
}
