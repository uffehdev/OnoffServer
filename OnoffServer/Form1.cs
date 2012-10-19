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
using System.Net;
using System.Net.NetworkInformation;

namespace OnoffServer
{
    public partial class Form1 : Form
    {
        delegate void ChangeControlCallback(string item);

        Server srv;
        bool srvOnline, nameSet;
        string srvName;
        Timer tmrToAction;
        int minsAction, minsToAction;
        string Action;

        public Form1()
        {
            InitializeComponent();

            lblStatus.Text = "Offline(set server name)";
            lblAction.Text = "None";
            srvOnline = false;
            srv = new Server();
            srvName = "";
            nameSet = false;
            tmrToAction = new Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srv.writer += handleMsg;
            lblIp.Text = GetLocalIPAddress();
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
            string[] strA = txt.Split('|');

            Action = strA[0];
            string mins = strA[1];
            int minsAction = int.Parse(mins);
            minsToAction = minsAction;
            if (tmrToAction != null)
                tmrToAction.Dispose();

            if (minsAction == 0)
            {
                preformAction();
            }
            else
            {
                tmrToAction = new Timer();
                tmrToAction.Interval = 60000;
                tmrToAction.Tick += tmrToAction_Tick;
            }

            lblAction.Text = Action + " - " + minsToAction + "/" + minsAction + " min";
        }

        private void tmrToAction_Tick(object sender, EventArgs e)
        {
            minsToAction--;
            lblAction.Text = Action + " - " + minsToAction + "/" + minsAction + " min";
            if (minsToAction == 0)
            {
                preformAction();
            }
        }

        void preformAction()
        {
            if (Action == "Turn off")
            {
                shutDown();
            }
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


        public string GetLocalIPAddress()
        {
            string localIP;
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                IPHostEntry host;
                localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
            }
            else
            {
                localIP = "Not local network";
            }
            return localIP;
        }
    }
}
