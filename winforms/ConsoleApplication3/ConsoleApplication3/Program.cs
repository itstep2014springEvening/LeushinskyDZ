using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            try
            {

                //"Data Source=A1-PREPOD; Initial Catalog=People;integrated security=true";
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MainCS"].ConnectionString;
                connection.Open();
                Console.WriteLine(connection.State);
                SqlCommand sqlcommand = new SqlCommand("SELECT * FROM Persons", connection);
                //SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                //Int32 sqldatareader = (Int32)sqlcommand.ExecuteScalar();
                Int32 sqldatareader = (Int32)sqlcommand.ExecuteNonQuery();
                //while(sqldatareader.Read()!=false)
                //{
                //    Console.WriteLine("{0,-10} {1,-10}", sqldatareader["ID"], sqldatareader["NAME"]);
                //}
                Console.WriteLine(sqldatareader);
                Console.WriteLine(ConfigurationManager.ConnectionStrings["MainCS"].ProviderName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
                Console.Read();
        }
    }
}
