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
    public partial class ExstentedFindForm : Form
    {
        public ExstentedFindForm()
        {
            InitializeComponent();
            List<string> CurrencyChangeVariants = new List<string>() { "Больше", "Равно", "Меньше" };
            comboBox1.DataSource = CurrencyChangeVariants;
            comboBox2.DataSource = CurrencyChangeVariants;
            comboBox3.DataSource = CurrencyChangeVariants;
        }

        private void ExstentedFindForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbData.BanksDB sdf = new BanksDB();
            List<Bankomat> bankomats = sdf.Bankomats.ToList().Where(x=>x.CityName==textBox1.Text&&x.StreetName==textBox2.Text&&x.HomeNumber==textBox3.Text).ToList();
            listBox1.DataSource = bankomats.Select(x=>x.BankomatName).ToList();
            textBox1.Text = "";
            //List<string> FinderUsingAdress = new List<string>();
            //if (textBox1.Text != null) { FinderUsingAdress.Add(textBox1.Text);}
            //if (textBox2.Text != null) { FinderUsingAdress.Add(textBox2.Text); }
            //if (textBox3.Text != null) { FinderUsingAdress.Add(textBox3.Text); }
        }
    }
}
