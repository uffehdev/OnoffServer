using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace OnoffServer
{
    class Server
    {
        public delegate void WriteBackMsg(char to, string msg);
        public WriteBackMsg writer;

        Socket sock;
        Thread srvThread;
        public string serverName;
        bool rdyToRecieve;
        int time;

        public Server() {
            rdyToRecieve = false;
            time = 0;
        }

        public void putServerOnline(string name) {
            srvThread = new Thread(new ThreadStart(msgsRecive));
            time = 0;
            serverName = name;
            rdyToRecieve = true;
            srvThread.Start();
        }

        public void putServerOffline() {
            if (srvThread != null) {
                rdyToRecieve = false;
                srvThread.Abort();
                sock.Dispose();
                srvThread = null;
            }
        }


        public void msgsRecive()
        {
            writer('l', "Server is online!");
            try
            {
                while (true)
                {
                    sock = new Socket(AddressFamily.InterNetwork,
                          SocketType.Dgram, ProtocolType.Udp);
                    IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
                    sock.Bind(iep);
                    EndPoint ep = (EndPoint)iep;


                    byte[] data = new byte[1024];
                    int recv = sock.ReceiveFrom(data, ref ep);
                    string msg = Encoding.ASCII.GetString(data, 0, recv);

                    writer('l', "Received: " + msg + " from: " + ep.ToString());

                    if (data == null)
                    {
                        data = new byte[1024];
                        recv = sock.ReceiveFrom(data, ref ep);
                        msg = Encoding.ASCII.GetString(data, 0, recv);
                        writer('l', "Received: " + msg + " from: " + ep.ToString());
                    }

                    if (msg.Contains("|"))
                    {
                        string[] fS = msg.Split('|');
                        string to = fS[0];
                        string masg = fS[1];
                        string minsStr = fS[2];
                        int mins = int.Parse(minsStr);

                        if (rdyToRecieve)
                        {
                            writer('l', "Fick medelande: " + to + ": " + masg + ", " + minsStr + " mins");
                            if (to == serverName)
                            {   //pc ska bytas mot datorns namn
                                //Gör den action som begärds
                                rdyToRecieve = false;
                                time = mins * 60;

                                if (masg == "turnoff")
                                {
                                    //Stäng av datorn
                                    writer('l', "Turning off the computer");
                                    writer('a', "Turn off");
                                    //callOn = shutDown;
                                    //tmr.Enabled = true;
                                }
                                else if (masg == "restart")
                                {
                                    //Starta om datorn
                                    writer('l', "Restarting the computer");
                                    writer('a', "Restart");
                                    //callOn = restart;
                                    //tmr.Enabled = true;
                                }
                                else if (masg == "sleep")
                                {
                                    //Sleepa datorn
                                    writer('l', "Sleeping the computer");
                                    writer('a', "Sleep");
                                    //callOn = sleep;
                                    //tmr.Enabled = true;
                                }
                            }
                        }
                        else
                        {
                            if (to == serverName && masg == "abort")
                            {
                                //Sleepa datorn
                                Console.WriteLine("Aborting call the computer");
                                writer('a', "None");
                                //callOn = abort;
                                //canRecive = true;
                                //tmr.Enabled = false;
                            }
                        }
                    }

                    sock.Close();
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                writer('l', e.ToString());
            }
        }
    }
}
