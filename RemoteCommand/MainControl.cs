using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace RemoteCommand
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void MakeActiveServerColorCircle()
        {
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(0, 0, activeServerColor.Width, activeServerColor.Height);

            activeServerColor.Region = new Region(path);
        }

        private void UpdateServerStatusColor(bool isOnline)
        {
            if(isOnline)
            {
                activeServerColor.BackColor = Color.Green;
            }
            else
            {
                activeServerColor.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            MakeActiveServerColorCircle();
        }

        private void radioButtonStopServer_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonStopServer.Checked)
            {
                UpdateServerStatusColor(false);
            }
        }

        private void radioButtonStartServer_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonStartServer.Checked)
            {
                UpdateServerStatusColor(true);
            }
        }
    }
}
