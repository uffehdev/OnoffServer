using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OnoffServer
{
    public partial class Form1 : Form
    {
        delegate void ChangeControlCallback(string item);

        Server srv;
        bool srvOnline, nameSet;
        string srvName;

        public Form1()
        {
            InitializeComponent();

            lblStatus.Text = "Offline(set server name)";
            lblAction.Text = "None";
            srvOnline = false;
            srv = new Server();
            srvName = "";
            nameSet = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srv.writer += handleMsg;
        }

        private void btnPutOnline_Click(object sender, EventArgs e)
        {
            if (srvOnline)
            {
                srv.putServerOffline();
                lblStatus.Text = "Offline";
                btnPutOnline.Text = "Put server online";
            }
            else {
                if (nameSet)
                {
                    srv.putServerOnline(srvName);
                    lblStatus.Text = "Online";
                    btnPutOnline.Text = "Put server offline";
                }
                else { MessageBox.Show("Please set server name, then put server online!"); }
            }
            srvOnline = !srvOnline;
        }

        void handleMsg(char to, string msg)
        {
            ChangeControlCallback d;
            switch (to)
            {
                case 'l':
                    d = new ChangeControlCallback(addLstItem);
                    this.Invoke(d, new object[] { msg });
                    break;
                case 'a':
                    //Handle actions
                    d = new ChangeControlCallback(changeActionTxt);
                    this.Invoke(d, new object[] { msg });
                    break;
            }
        }

        void addLstItem(string item)
        {
            lstActions.Items.Insert(0, item);
        }

        void changeActionTxt(string txt)
        {
            lblAction.Text = txt;
        }

        private void shutDown()
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void restart()
        {
            Process.Start("shutdown", "/r");
        }

        private void sleep()
        {
            Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (srvOnline)
            {
                srv.putServerOffline();
            }
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            if (!nameSet)
            {
                srvName = txtSrvName.Text;
                txtSrvName.Enabled = false;
                btnSetName.Text = "Edit name";
                lblStatus.Text = "Offline";
            }
            else
            {
                txtSrvName.Enabled = true;
                btnSetName.Text = "Set name";
                lblStatus.Text = "Offline(set server name)";
            }
            nameSet = !nameSet;
        }

    }
}
