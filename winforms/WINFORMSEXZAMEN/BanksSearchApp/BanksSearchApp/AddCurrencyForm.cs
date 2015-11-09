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
    public partial class AddCurrencyForm : Form
    {
        BanksDB db = new BanksDB();
        public AddCurrencyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Currencies.Add(new Currency()
                {
                    CurrencyName = textBox3.Text,
                    CurrencyBuyV = Double.Parse(textBox1.Text),
                    CurrencySellV = Double.Parse(textBox2.Text),
                    Bankomat = (Bankomat)comboBox1.SelectedItem

                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
        }

        private void AddCurrencyForm_Load(object sender, EventArgs e)
        {
            List<Bankomat> bankomatsToCB1 = db.Bankomats.ToList();
            comboBox1.ValueMember = "BankomatId";
            comboBox1.DisplayMember = "BankomatName";
            comboBox1.DataSource = bankomatsToCB1;
            comboBox1.SelectedIndex = 1;
        }
    }
}
