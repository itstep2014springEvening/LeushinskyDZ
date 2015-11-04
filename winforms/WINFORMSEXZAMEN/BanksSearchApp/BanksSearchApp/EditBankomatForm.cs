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
    public partial class EditBankomatForm : Form
    {
        BanksDB db = new BanksDB();
        public EditBankomatForm()
        {
            
            InitializeComponent();
            comboBox2.SelectedValue = "BankomatId";
            comboBox2.DisplayMember = "BankomatName";
            comboBox2.DataSource = db.Bankomats.ToList();

            comboBox1.ValueMember = "BankId";
            comboBox1.DisplayMember = "BankName";
            comboBox1.DataSource = db.Banks.ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            var selectedItemToCompareBankomat = (Bankomat)comboBox1.SelectedItem;
            Bankomat selectedBankomatToEdit = db.Bankomats.Single(b => b.BankomatId == selectedItemToCompareBankomat.BankomatId);

            //var selectedItemToCompareBank = (Bankomat)comboBox1.SelectedItem;
            List<Bank> banks = db.Banks.ToList();
            Bank selectedBankToEdit = banks.Single(bank=>bank.Bankomats.Contains(selectedBankomatToEdit));
            List<BankomatToService> servicesConnectionInSelectedBankomat =
                db.BankomatToServices.Where(s => s.ServiceId == selectedBankomatToEdit.BankomatId).ToList();

            List<Service> servicesInSelectedBankomat =
                servicesConnectionInSelectedBankomat.Select(bts => bts.Service).ToList();

            textBox1.Text = selectedBankomatToEdit.BankomatName;
            comboBox1.SelectedItem = selectedBankToEdit;
            textBox3.Text = selectedBankomatToEdit.Telephone;
            textBox2.Text = selectedBankomatToEdit.CityName;
            textBox4.Text = selectedBankomatToEdit.StreetName;
            textBox5.Text = selectedBankomatToEdit.HomeNumber;
            textBox6.Text = selectedBankomatToEdit.CoordinateX.ToString();
            textBox7.Text = selectedBankomatToEdit.CoordinateY.ToString();
            textBox11.Text = selectedBankomatToEdit.OpenDate.ToString();
            textBox10.Text = selectedBankomatToEdit.PersonalInformation;
            textBox9.Text = selectedBankomatToEdit.WorkingTime;
            textBox13.Text = selectedBankomatToEdit.Review;
            textBox12.Text = selectedBankomatToEdit.AdditionalInformation;

            checkedListBox1.DataSource = servicesInSelectedBankomat;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItemToCompareBankomat = (Bankomat)comboBox1.SelectedItem;
            Bankomat selectedBankomatToEdit = db.Bankomats.Single(b => b.BankomatId == selectedItemToCompareBankomat.BankomatId);

            selectedItemToCompareBankomat.BankomatName = textBox1.Text;

            db.Bankomats.AddOrUpdate(selectedItemToCompareBankomat);
        }
    }
}
