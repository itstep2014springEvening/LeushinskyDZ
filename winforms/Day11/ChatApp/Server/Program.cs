using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        // коллекция подключенных клиентов!
        public static Hashtable clientsList = new Hashtable();
        
        static void Main(string[] args)
        {
            //  TcpListener Ожидает подключения клиентов TCP сети 
            IPAddress addr;
            IPAddress.TryParse("192.168.1.122", out addr);
            TcpListener serverListener = new TcpListener(addr, 8080);
            // TcpClient Предоставляет клиентские подключения для сетевых служб протокола TCP.
            TcpClient clientSocket;
            
            int counter = 0;

            // запуск сервера, ожидающего подключения клиентов
            serverListener.Start();
            Console.WriteLine("Чат сервер запушен на {0}:{1} ...", addr.ToString(), 8080);
         
            while (true)
            {
                counter += 1;
               
                // Принимает ожидающий запрос на подключение нового клиента.
                clientSocket = serverListener.AcceptTcpClient();

                byte[] bytesFrom = new byte[70000];
                string dataFromClient = null;

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.Default.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                // добавление клиента - имени клиента!
                clientsList.Add(dataFromClient, clientSocket);

                // формирование ответа клиенту
                Notice(dataFromClient + " зарегистрирован ", dataFromClient, false);
                Console.WriteLine(dataFromClient + " Зарегистрирован в чате ");
                
                // создание потока для пользователя
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, dataFromClient);
            }

            clientSocket.Close();
            serverListener.Stop();
         
        }

        public static void Notice(string msg, string userName, bool flag)
        {
            // ответ все клиентам чата 
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient noticeSocket= (TcpClient)Item.Value;
                // создание потока !
                NetworkStream noticeStream = noticeSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    // рассылка сообщения от пользователя!
                    broadcastBytes = Encoding.Default.GetBytes(userName + " написал : " + msg);
                }
                else
                {   // уведомление пользователей о подключении нового пользователя
                    broadcastBytes = Encoding.Default.GetBytes(msg);
                }
                // запись в поток информации 
                noticeStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                noticeStream.Flush();
            }
        }

       
    }


    public class handleClinet
    {
        TcpClient clientSocket;  // подключение
        string clineName;        // имя пользователя
   
        public void startClient(TcpClient inClientSocket, string clineName)
        {
            this.clientSocket = inClientSocket;
            this.clineName = clineName;
      
            // создание потока для подключившегося пользователя!
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        // получение сообщений от клиентов и рассылка их каждому клиенту!
        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[70000];
            string dataFromClient = null;    

            while (true)
            {
                try
                {
                    requestCount = requestCount + 1;
                    // получение сообщение из потока по подключению clientSocket
                    NetworkStream networkStream = clientSocket.GetStream();
                    // чтение из потока массива байтов
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    // преобразование массива байт в строку
                    dataFromClient = System.Text.Encoding.Default.GetString(bytesFrom);
                    // полоучаем из строки только сообщение 
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    // отображение сообщенияна сервере
                    Console.WriteLine("от клиента - " + clineName + " : " + dataFromClient);
                   // рассылка сообщений 
                    Program.Notice(dataFromClient, clineName, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
 
}
