using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace autorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // pictureBox1.ImageLocation = @"D:\zamen.jpeg";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string ConnectionString = @"Data Source=A1-PREPOD;Initial Catalog=PhoneStore;Integrated Security=True";
            SqlConnection sc = new SqlConnection(ConnectionString);
            sc.Open();
            MessageBox.Show(sc.State.ToString());
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM Users", sc);
            SqlDataReader sqr = null;
            sqr = sqlcommand.ExecuteReader();
            List<string> lflb = new List<string>();
            while(sqr.Read())
            {
                dict.Add(sqr.GetString(sqr.GetOrdinal("Login")).Trim(), sqr.GetString(sqr.GetOrdinal("Password")).Trim()); //lflb.Add(sqr.GetString(sqr.GetOrdinal("Login")));
                
            }
            listBox1.DataSource = lflb;
            if(dict.Values)
            //OleDbConnection connection = new OleDbConnection();
            //OleDbCommand command = new OleDbCommand();
            //OleDbDataAdapter adapter = new OleDbDataAdapter();
            //DataSet dataset = new DataSet();

            //connection.ConnectionString = connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ivan\winforms\autorization\autorization\bin\Debug\Database11.accdb";

            //command.Connection = connection;
            //command.CommandText = "SELECT * FROM pass";
            //adapter.SelectCommand = command;

            //try
            //{
            //    adapter.Fill(dataset, "pass");
            //}
            //catch (OleDbException)
            //{
            //    MessageBox.Show("Error DB connection");
            //}
            //DataSet ds = new DataSet();
            //string strAccessSelect = "SELECT * FROM Pass";
            //OleDbConnection odc = null;
            //string sac = "Microsoft.ACE.OLEDB.12.0;Data Source=Database11.accdb";
            //try
            //{
            //    odc = new OleDbConnection(sac);
            //}
            //catch(Exception ex)
            //{
            //    button1.Text = "error";
            //}

            //try
            //{
            //    OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, odc);
            //    OleDbDataAdapter odda = new OleDbDataAdapter(myAccessCommand);
            //    odc.Open();
                
            //    odda.Fill(ds, "Пароль");
            //}
            ////catch (Exception ex)
            ////{
            ////    button1.Text = "error";
            ////}
            //finally
            //{
            //    odc.Close();
            //}
        }
    }
}
