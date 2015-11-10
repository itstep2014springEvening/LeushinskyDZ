using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbData;

namespace BanksSearchApp
{
    public partial class CurrenceChangeForm : Form
    {
        BanksDB db = new BanksDB();

        public CurrenceChangeForm()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
               
                    textBox1.Text =
                        db.Currencies.Single(cur => cur.CurrencyId == comboBox1.SelectedIndex + 1).CurrencyBuyV.ToString();
                    textBox2.Text =
                        db.Currencies.Single(cur => cur.CurrencyId == comboBox1.SelectedIndex + 1).CurrencySellV.ToString();
                   
            
        }

        private void CurrenceChangeForm_Load(object sender, EventArgs e)
        {
            List<Currency> currenciesFotCB1 = db.Currencies.ToList();
            comboBox1.ValueMember = "CurrencyId";
            comboBox1.DisplayMember = "CurrencyName";
            comboBox1.DataSource = currenciesFotCB1;
            comboBox1.SelectedIndex = 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Currency currencyAtEdit = (Currency)comboBox1.SelectedItem;
                //currencyAtEdit.CurrencyId = comboBox1.SelectedIndex + 1;
                currencyAtEdit.CurrencyBuyV = Double.Parse(textBox1.Text);
                currencyAtEdit.CurrencySellV = Double.Parse(textBox2.Text);
                db.Currencies.AddOrUpdate(currencyAtEdit);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
