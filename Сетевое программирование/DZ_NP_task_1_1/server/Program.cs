using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace server
{
    class Program
    {
        public static StreetDB db = new StreetDB();
        
       

        static void Main(string[] args)
        {
#region dbstaff
            
            SqlConnection conn = new SqlConnection(@"Data Source=(local);
                            Initial Catalog=StreetsDB.mdf;
                            Integrated Security=True");
            try
            {

                conn.Open();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            if ((conn.State & ConnectionState.Open) != 0)
            {

            }
            else
            {
                StreetDB db = new StreetDB();




                //string[] DBSearch = Directory.GetFiles(Environment.CurrentDirectory, "*.mdf");


                Index ind1 = new Index() { IndexId = 1, Streets = new List<Street>() };
                Street st1 = new Street() { StreetName = "Baker Street" };
                Street st2 = new Street() { StreetName = "Spenser" };
                Street st3 = new Street() { StreetName = "Aprobos" };

                Index ind2 = new Index() { IndexId = 2, Streets = new List<Street>() };
                Street st4 = new Street() { StreetName = "Saridat" };
                Street st5 = new Street() { StreetName = "Uno" };
                Street st6 = new Street() { StreetName = "Marylebone Road" };

                ind1.Streets.AddRange(new List<Street>() { st1, st2, st3 });
                ind2.Streets.AddRange(new List<Street>() { st4, st5, st6 });

                db.Indexes.AddRange(new List<Index>() { ind1, ind2 });

                db.SaveChanges();
            }
            

#endregion

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
           
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip,1024);

            serverSocket.Bind(ep);
            serverSocket.Listen(3);
            char[] buf = new char[1024];
            List<string> s = db.Streets.Where(i=>i.Index.IndexId==2).Select(street => street.StreetName).ToList();

            try
            {
                while (true)
                {
                    Socket newServerSocket = serverSocket.Accept();
                    
                        newServerSocket.Send(System.Text.Encoding.ASCII.GetBytes("Hello user"+Environment.NewLine+"Enter index: "));
                        
                    
                    Console.WriteLine(newServerSocket.RemoteEndPoint.ToString());
                    //foreach (var street in s)
                    //{
                    //    newServerSocket.Send(System.Text.Encoding.ASCII.GetBytes(street));
                    //}
                    

                    newServerSocket.Shutdown(SocketShutdown.Both);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
