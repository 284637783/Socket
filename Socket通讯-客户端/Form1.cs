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

namespace Socket通讯_客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSend;
        private void Btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(text_ip.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(text_Port.Text));
                socketSend.Connect(point);
                ShowMsg("连接成功");
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();
            }
            catch
            { }

        }

        void Recive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + s);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\28463\Desktop";
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer,1,r-1);
                        }
                    }
                    else if (buffer[0] == 2)
                    {
                        Shaking();
                    }

                }
                catch
                { }
            }
        }

        void Shaking()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200,200);
                this.Location = new Point(280, 280);
            }
        }

        private void ShowMsg(string v)
        {
            txtLog.AppendText(v + "\r\n");
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            string str = textMsg.Text.Trim();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str );
            socketSend.Send(buffer );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
