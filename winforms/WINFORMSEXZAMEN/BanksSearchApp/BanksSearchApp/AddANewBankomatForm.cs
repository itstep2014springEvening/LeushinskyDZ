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
    public partial class AddANewBankomatForm : Form
    {
        public BanksDB db = new BanksDB();
        public AddANewBankomatForm()
        {
            InitializeComponent();
            List<string> currenciesForTB3 = new List<string>();
            foreach (var bnk in db.Banks)
            {
                currenciesForTB3.Add(bnk.BankName);
            }
            comboBox1.DataSource = currenciesForTB3;
            comboBox3.DataSource = currenciesForTB3;
            checkedListBox1.DataSource = db.Services.Select(x => x.ServiceName).ToList();
            radioButton1.Checked = true;


        }

        public void AddANewBankomatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.isEditorModeOn = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Service> chserv = new List<Service>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

                chserv.Add(new Service()
                {
                    ServiceId = db.Services.Select(x => x.ServiceId).ToList().Max() + i,
                    ServiceName = checkedListBox1.CheckedItems[i].ToString()
                });
            }


            //var test = (db.Bankomats.Select(x => x.BankomatId).ToList().Last() + 1);
            DataInsert dataInsert = new DataInsert();

            if (radioButton1.Checked)
            {
                dataInsert.DataInsertion(db.Banks.Single(x => x.BankName == comboBox1.Text), new List<Bankomat>()
                {
                    new Bankomat()
                    {
                        BankomatId = (db.Bankomats.Select(x => x.BankomatId).ToList().Max() + 1),
                        BankomatName = textBox1.Text,
                        BankOwnerName = comboBox1.Text,
                        Telephone = textBox3.Text,
                        CityName = textBox2.Text,
                        StreetName = textBox4.Text,
                        HomeNumber = textBox5.Text,

                        CoordinateX = Double.Parse(textBox6.Text),
                        CoordinateY = Double.Parse(textBox7.Text),
                        OpenDate = DateTime.Parse(textBox11.Text),
                        WorkingTime = textBox9.Text,
                        PersonalInformation = textBox10.Text,
                        Review = textBox13.Text,

                        AdditionalInformation = textBox12.Text,
                    }
                }, db.Currencies.Where(x => x.CurrencyName == comboBox3.Text).ToList(),
                chserv

                , db);
            }


            else
            {
                dataInsert.DataInsertion(db.Banks.Single(x => x.BankName == comboBox1.Text), new List<Bankomat>() {new Bankomat()
            {
               // BankomatId = 3,
            BankomatName = textBox1.Text,
            BankOwnerName = comboBox1.Text,
            Telephone = textBox3.Text,
            CityName = textBox2.Text,
            StreetName = textBox4.Text,
            HomeNumber = textBox5.Text,
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = Double.Parse(textBox6.Text),
            CoordinateY = Double.Parse(textBox7.Text),
            OpenDate = DateTime.Parse(textBox11.Text),
            WorkingTime = textBox9.Text,
            PersonalInformation = textBox10.Text,
            Review = textBox13.Text,
          //  Services = new List<Service>(),
            AdditionalInformation = textBox12.Text,
            }
                }, new List<Currency>()
                {
                    new Currency()
                    {
                        CurrencyId = db.Currencies.Select(x=>x.CurrencyId).ToList().Last()+1,
                        CurrencyName = "USD"+comboBox1.Text,
                        CurrencyBuyV = Double.Parse(textBox15.Text),
                        CurrencySellV = Double.Parse(textBox18.Text)
                    },
                     new Currency()
                    {
                        CurrencyId = db.Currencies.Select(x=>x.CurrencyId).ToList().Last()+1,
                        CurrencyName = "EUR"+comboBox1.Text,
                        CurrencyBuyV = Double.Parse(textBox14.Text),
                        CurrencySellV = Double.Parse(textBox17.Text)
                    },
                      new Currency()
                    {
                        CurrencyId = db.Currencies.Select(x=>x.CurrencyId).ToList().Last()+1,
                        CurrencyName = "RUR"+comboBox1.Text,
                        CurrencyBuyV = Double.Parse(textBox8.Text),
                        CurrencySellV = Double.Parse(textBox16.Text)
                    }
                }, new List<Service>()
                {
                    new Service()
                    {

                    }
                }, db);

            }
            db.SaveChanges();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label15.BackColor = Color.White;
                label16.BackColor = Color.White;
                label17.BackColor = Color.White;
                textBox15.Enabled = false;
                textBox14.Enabled = false;
                textBox8.Enabled = false;
                textBox16.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;

                comboBox3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label15.BackColor = Color.Black;
                label16.BackColor = Color.Black;
                label17.BackColor = Color.Black;
                textBox15.Enabled = true;
                textBox14.Enabled = true;
                textBox8.Enabled = true;
                textBox16.Enabled = true;
                textBox17.Enabled = true;
                textBox18.Enabled = true;

                comboBox3.Enabled = false;
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "NewRandomBankomat" +
                            (db.Bankomats.Select(x => x.BankomatId).ToList().Max() + 1).ToString();
            List<long> test = db.Bankomats.Select(x => x.BankomatId).ToList();
            textBox3.Text = "222-22-22";

            textBox2.Text = "г. Минск";
            textBox4.Text = "ул. Кабушкина";
            textBox5.Text = "94";
            textBox6.Text = "53,858333";
            textBox7.Text = "27,632581";
            textBox11.Text = DateTime.Now.ToString("d");
            textBox10.Text = "Старовойтов Игорь Петрович";
            textBox9.Text = "8.00 - 20.00";

            textBox13.Text = "Отличный банкомат!";
            textBox12.Text = "In Progress";




        }
    }
}
