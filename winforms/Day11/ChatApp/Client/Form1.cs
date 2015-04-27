using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        // TcpClient Предоставляет клиентские подключения для сетевых служб протокола TCP.
        TcpClient clientSocket;
        // NetworkStream Обеспечивает базовый поток данных для доступа к сети.
        NetworkStream serverStream;
        // прочитанные данные
        string readData = null;

        Thread ctThread;
        public ClientForm()
        {
            InitializeComponent();
            clientSocket = new TcpClient();
        }
 
       

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            readData = string.Format("Подключение к серверу {0}:{1}",tbIPadres.Text, tbPort.Text);
            tbChat.Text = tbChat.Text + Environment.NewLine + " >> " + readData;
            try
            {
                // подключение к серверу по IP - адресу 127.0.0.1, порт 8888
                clientSocket.Connect(tbIPadres.Text, Convert.ToInt32(tbPort.Text));
                // создание потока для доступа к сети
                serverStream = clientSocket.GetStream();
                this.Text = string.Format("Подключен к серверу {0}:{1}", tbIPadres.Text, tbPort.Text);
               
                // отправка имени  пользователя
                //  формирование массива байт из строки!
                byte[] outStream = System.Text.Encoding.Default.GetBytes(tbUserName.Text + "$");
                // запись в поток!
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                // формирование и запуск потока - для получения сообщений!
                ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            catch
            {
                MessageBox.Show("Сервер недоступен...", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                // отправка сообщения
                byte[] outStream = System.Text.Encoding.Default.GetBytes(tbMessage.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                //очищает все буферы данного потока и вызывает запись данных
                serverStream.Flush();
            }
            catch
            {
                MessageBox.Show("Подключение к серверу отсутствует...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void getMessage()
        {
            // реализация бесконечного ожидания получения сообщений!
            while (true)
            {
                // получение 
               // serverStream = clientSocket.GetStream();
                              
                // формирование массива для сохранения входных данных
                byte[] inStream = new byte[70000];
                // чтение данных из потока в буфер inStream
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                
                // формирование строки из массива байтов!
                string returndata = System.Text.Encoding.Default.GetString(inStream);
                readData = "" + returndata;
                // отображение данных на форме!
                this.Invoke(new Action(MessageToChat));
            }

        }


        // отображение информации из дополнительных потоков!
        private void MessageToChat()
        {
            tbChat.Text = tbChat.Text + Environment.NewLine + " >> " + readData;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ctThread!=null)
            ctThread.Abort();
        }

       

        
    }
}
