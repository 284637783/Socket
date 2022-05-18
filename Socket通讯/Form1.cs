using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket通讯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(text_Port.Text));
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }

            catch
            { }

            
          
        }
        Socket socketsend;
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            try
            {
                while (true)
                {
                    socketsend = socketWatch.Accept();
                    dicSocket.Add(socketsend .RemoteEndPoint .ToString (),socketsend );
                    connected_Client.Items.Add(socketsend .RemoteEndPoint .ToString ());
                    ShowMsg(socketsend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    Thread th = new Thread(Recieve);
                    th.IsBackground = true;
                    th.Start(socketsend);
                }
            }

            catch
            { }

            
        }

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket> ();

        void Recieve(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
                
            }
        }

        private void ShowMsg(string v)
        {
            txtLog.AppendText(v+"\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            string str = textMsg.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str );
            List<byte> list = new List<byte>();
            list. Add (0);
            list.AddRange(buffer );
            byte[] newbuffer =  list.ToArray();
            string ip = connected_Client.SelectedItem.ToString();
            dicSocket[ip].Send(newbuffer ); 

            //socketsend.Send(buffer );

        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\28463\Desktop";
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            text_Path.Text = ofd.FileName;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string path = text_Path.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();                
                dicSocket[connected_Client.SelectedItem.ToString()].Send(newBuffer,0,r+1,SocketFlags.None);
            }
        }

        private void Btn_shake_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[connected_Client.SelectedItem.ToString()].Send(buffer);
        }
    }
}
