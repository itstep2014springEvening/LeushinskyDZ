using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data;
using System.Configuration;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string providerName = ConfigurationManager.ConnectionStrings["MainCS"].ProviderName.ToLower();
            MultiConnector mc = new MultiConnector(providerName);
            mc.Connect();

            //Console.WriteLine(providerName);
            //if(providerName=="mssql")
            //{
            //    Console.WriteLine("Hello");
            //}
            Console.Read();
        }
    }
    class MultiConnector : IMUltiConnections
    {
        public string connectionString;
        public string providerName;
        public ConnectionState state;

        public string ConnectionString
        {
            get { return connectionString; }
        }
        public string ProviderName
        {
            get { return providerName; }
        }
        public ConnectionState State
        {
            get { return state; }
        }
        public MultiConnector(string providerName)
        {
            this.providerName = providerName;
        }

        
        public string GetData(string Command)
        {
            return "";
        }
        public void Connect()
        {
            if(providerName=="mssql")
            {
                Console.WriteLine("123");
            }
        }
    }
    interface IMUltiConnections
    {
        string ConnectionString { get; }
        string ProviderName { get; }
        ConnectionState State { get; }//ConnectionState - перечисление на System.Data
        void Connect();
        string GetData(string Command);
    }
}
