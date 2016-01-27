using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_NP_task_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip, 1024);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                clientSocket.Connect(ep);
                if (clientSocket.Connected)
                {
                    listBox1.Items.Add("Server Connected");
                    byte[] buffer = new byte[1024];
                    int l;
                    do
                    {
                        l = clientSocket.Receive(buffer);
                        textBox1.Text += System.Text.Encoding.ASCII.GetString(buffer, 0,l);
                    } while (l > 0);
                    //clientSocket.Receive(buffer);
                    // listBox1.Text = buffer.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                listBox1.Items.Add("Connection Shutdown");
            }
        }
    }
}
