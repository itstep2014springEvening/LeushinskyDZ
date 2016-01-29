using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_NP_task_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int ind1 = 1;
            int ind2 = 2;
            comboBox1.Items.Add(ind1);
            comboBox1.Items.Add(ind2);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ToServer));
            t.Start();
            
        }

        public void ToServer()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip, 1024);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                clientSocket.Connect(ep);
                if (clientSocket.Connected)
                {
                    listBox2.Items.Add("Server Connected");
                    byte[] buffer = new byte[1024];
                    int l;
                    do
                    {
                        clientSocket.Send(System.Text.Encoding.ASCII.GetBytes(comboBox1.SelectedItem.ToString()));
                        l = clientSocket.Receive(buffer);
                        string streets = System.Text.Encoding.ASCII.GetString(buffer, 0, l);
                        //foreach (var symbol in streets)
                        //{
                        //   // if (char.IsUpper(symbol))
                        // //   {
                        //        streets. += Environment.NewLine;
                        //  //  }
                        //}

                        listBox1.Items.Add(streets);
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
            //finally
            //{
            //    //clientSocket.Shutdown(SocketShutdown.Both);
            // //   clientSocket.Close();
            //    listBox2.Items.Add("Connection Shutdown");
            //}
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }
    }
}
