using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbData;

namespace BanksSearchApp
{
    public partial class CursCompareTable : Form
    {
        BanksDB db = new BanksDB();
        
        public CursCompareTable()
        {
            
           
            InitializeComponent();
        }

        private void CursCompareTable_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<string>
            {
                "USD", "EUR", "RUR"
            };
            //List<Bankomat> bankomats = db.Bankomats.ToList();
            //dataGridView1.Rows.Add(bankomats);
            //dataGridView1.Columns.Add("Column1", "Bankomats");
            
        }

        private void dataGridView1_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            
            string currentCurrency = (string) comboBox1.SelectedItem;
            dt.Columns.Add("Банкомат");
           // dt.Columns.Add("Валюта");
            dt.Columns.Add("Продажа");
            dt.Columns.Add("Покупка");
            if ((string) comboBox1.SelectedItem == "USD")
            {
                foreach (var b in db.Bankomats)
                {
                    DataRow d = dt.NewRow();
                    d["Банкомат"] = b.BankomatName;
                  //  d["Валюта"] = "USD";
                    d["Продажа"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencySellV;
                    d["Покупка"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencyBuyV;
                    dt.Rows.Add(d);
                }
            }

            if ((string)comboBox1.SelectedItem == "EUR")
            {
                foreach (var b in db.Bankomats)
                {
                    DataRow d = dt.NewRow();
                    d["Банкомат"] = b.BankomatName;
                  //  d["Валюта"] = "USD";
                    d["Продажа"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencySellV;
                    d["Покупка"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencyBuyV;
                    dt.Rows.Add(d);
                }
            }

            if ((string)comboBox1.SelectedItem == "RUR")
            {
                foreach (var b in db.Bankomats)
                {
                    DataRow d = dt.NewRow();
                    d["Банкомат"] = b.BankomatName;
                  //  d["Валюта"] = "USD";
                    d["Продажа"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencySellV;
                    d["Покупка"] = b.Currencies.Single(c => c.CurrencyName == (string)comboBox1.SelectedItem).CurrencyBuyV;
                    dt.Rows.Add(d);
                }
            }
            dataGridView1.DataSource = dt;
        }
    }
}
