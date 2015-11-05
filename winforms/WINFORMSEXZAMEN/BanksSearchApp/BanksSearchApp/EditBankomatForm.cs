using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            List<Bankomat> bankomats = db.Bankomats.ToList();
            List<Bank> banks = db.Banks.ToList();
            comboBox2.SelectedValue = "BankomatId";
            comboBox2.DisplayMember = "BankomatName";
            comboBox2.DataSource = bankomats;


            comboBox1.ValueMember = "BankId";
            comboBox1.DisplayMember = "BankName";
            comboBox1.DataSource = banks;

            comboBox2.SelectedItem = 1;

            List<Service> ServicesForCLB1 =
                db.BankomatToServices.Where(s => s.BankomatId == 1).Select(d => d.Service).ToList();
            checkedListBox1.ValueMember = "ServiceId";
            checkedListBox1.DisplayMember = "ServiceName";
            checkedListBox1.DataSource = ServicesForCLB1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            var selectedItemToCompareBankomat = (Bankomat)comboBox2.SelectedItem;
            Bankomat selectedBankomatToEdit = db.Bankomats.Single(b => b.BankomatId == selectedItemToCompareBankomat.BankomatId);

            //var selectedItemToCompareBank = (Bankomat)comboBox1.SelectedItem;
            List<Bank> banks = db.Banks.ToList();
            Bank selectedBankToEdit = banks.Single(bank=>bank.Bankomats.Contains(selectedBankomatToEdit));
            List<BankomatToService> servicesConnectionInSelectedBankomat =
                db.BankomatToServices.Where(s => s.BankomatId == selectedBankomatToEdit.BankomatId).ToList();

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


            checkedListBox1.ValueMember = "ServiceId";
            checkedListBox1.DisplayMember = "ServiceName";
            checkedListBox1.DataSource = servicesInSelectedBankomat.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItemToCompareBankomat = (Bankomat)comboBox2.SelectedItem;
            Bankomat selectedBankomatToEdit = db.Bankomats.Single(b => b.BankomatId == selectedItemToCompareBankomat.BankomatId);

            selectedItemToCompareBankomat.BankomatName = textBox1.Text;
            selectedItemToCompareBankomat.Telephone = textBox3.Text;


            Bank bankOwnerOfSelectedItem =
                db.Bankomats.Include(x => x.Bank)
                    .Single(x => x.BankomatId == selectedItemToCompareBankomat.BankomatId)
                    .Bank;

            
                selectedItemToCompareBankomat.BankId = comboBox1.SelectedIndex;
            

            selectedItemToCompareBankomat.CityName = textBox2.Text;
            selectedItemToCompareBankomat.StreetName = textBox4.Text;
            selectedItemToCompareBankomat.HomeNumber = textBox5.Text;
            selectedItemToCompareBankomat.CoordinateX = Double.Parse(textBox6.Text);
            selectedItemToCompareBankomat.CoordinateY = Double.Parse(textBox7.Text);
            selectedItemToCompareBankomat.OpenDate = DateTime.Parse(textBox11.Text);

            var serviceIds = new List<long>();

            foreach (var itemChecked in checkedListBox1.CheckedItems)
            {
                serviceIds.Add(((Service)itemChecked).ServiceId);
            }
            foreach (var serviceId in serviceIds)
            {
                db.BankomatToServices.Add(new BankomatToService()
                {
                    BankomatId = selectedItemToCompareBankomat.BankomatId,
                    ServiceId = serviceId
                });
            }
            selectedItemToCompareBankomat.PersonalInformation = textBox10.Text;
            selectedItemToCompareBankomat.WorkingTime = textBox9.Text;

            //services

            selectedItemToCompareBankomat.Review = textBox13.Text;
            selectedItemToCompareBankomat.AdditionalInformation = textBox12.Text;



            db.Bankomats.AddOrUpdate(selectedItemToCompareBankomat);
            db.SaveChanges();




        }
    }
}
