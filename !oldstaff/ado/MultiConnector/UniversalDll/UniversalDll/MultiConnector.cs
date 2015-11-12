using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace UniversalDll
{
    interface IMultiConnector
    {
        string ConnectionString { get; }
        string ProviderName { get; }
        ConnectionState State { get; }
        void Connect();
        string GetData(string command);
    }

    public class MultiConnector : IMultiConnector
    {
        private ConnectionState connState;
        private SqlConnection sqlConnection;
        private OleDbConnection oleConnection;
        private OdbcConnection odbcConnection;

        public MultiConnector()
        {
            connState = ConnectionState.Closed;
            sqlConnection = null;
            oleConnection = null;
            odbcConnection = null;
        }

        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["MainCS"].ConnectionString; }
        }

        public string ProviderName
        {
            get { return ConfigurationManager.ConnectionStrings["MainCS"].ProviderName; }
        }

        public ConnectionState State
        {
            get { return connState; }
        }

        public void Connect()
        {
            try
            {
                if (ProviderName == "System.Data.SqlClient")
                {
                    try
                    {
                        sqlConnection = new SqlConnection(ConnectionString);
                        sqlConnection.Open();

                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            connState = ConnectionState.Open;
                        }
                    }

                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine(sqlEx.Message);
                    }
                }

                else if (ProviderName == "System.Data.OleDb")
                {
                    try
                    {
                        oleConnection = new OleDbConnection(ConnectionString);
                        oleConnection.Open();

                        if (oleConnection.State == ConnectionState.Open)
                        {
                            connState = ConnectionState.Open;
                        }
                    }

                    catch (OleDbException oleEx)
                    {
                        Console.WriteLine(oleEx.Message);
                    }
                }

                else if (ProviderName == "System.Data.Odbc")
                {
                    try
                    {
                        odbcConnection = new OdbcConnection(ConnectionString);
                        odbcConnection.Open();

                        if (odbcConnection.State == ConnectionState.Open)
                        {
                            connState = ConnectionState.Open;
                        }
                    }

                    catch (OleDbException odbcEx)
                    {
                        Console.WriteLine(odbcEx.Message);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetData(string command)
        {
            string forReturn = "Запрос выполнен:\n";

            try
            {
                Connect(); // Соединяю с БД

                if (ProviderName == "System.Data.SqlClient")
                {
                    try
                    {
                        SqlCommand query = new SqlCommand(command, sqlConnection);
                        SqlDataReader reader = query.ExecuteReader();

                        while (reader.Read())
                        {
                            forReturn += String.Format("{0, -10} {1, -10} {2, -10} {3, -10}\n", reader["id"], reader["name"], reader["subject"], reader["salary"]);
                        }
                    }

                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine(sqlEx.Message);
                    }

                    finally
                    {
                        sqlConnection.Close();
                    }
                }

                else if (ProviderName == "System.Data.OleDb")
                {
                    try
                    {
                        OleDbCommand query = new OleDbCommand(command, oleConnection);
                        OleDbDataReader reader = query.ExecuteReader();

                        while (reader.Read())
                        {
                            forReturn += String.Format("{0, -10} {1, -10} {2, -10} {3, -10}", reader["id"], reader["name"], reader["subject"], reader["salary"]);
                        }
                    }

                    catch (OleDbException oleEx)
                    {
                        Console.WriteLine(oleEx.Message);
                    }

                    finally
                    {
                        oleConnection.Close();
                    }
                }

                else if (ProviderName == "System.Data.Odbc")
                {
                    try
                    {
                        OdbcCommand query = new OdbcCommand(command, odbcConnection);
                        OdbcDataReader reader = query.ExecuteReader();

                        while (reader.Read())
                        {
                            forReturn += String.Format("{0, -10} {1, -10} {2, -10} {3, -10}", reader["id"], reader["name"], reader["subject"], reader["salary"]);
                        }
                    }

                    catch (OdbcException odbcEx)
                    {
                        Console.WriteLine(odbcEx.Message);
                    }

                    finally
                    {
                        odbcConnection.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return forReturn; // Возвращаю результат
        }
    }
}
