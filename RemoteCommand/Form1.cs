using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteCommand
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            LoadControl(mainCtlr);
        }

        MainControl mainCtlr = new MainControl();
        SessionsControl sessionsCtrl = new SessionsControl();
        LogsControl logsCtrl = new LogsControl();


        void LoadControl(UserControl control)
        {
            ContenPanel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            ContenPanel.Controls.Add(control);
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            LoadControl(mainCtlr);
        }

        private void SessionsButton_Click(object sender, EventArgs e)
        {
            LoadControl(sessionsCtrl);

        }

        private void LogsButton_Click(object sender, EventArgs e)
        {
            LoadControl(logsCtrl);
        }





    }
}
