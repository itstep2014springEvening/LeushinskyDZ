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
    public partial class DeleteBankomatForm : Form
    {
        DbData.BanksDB db = new BanksDB();
        public DeleteBankomatForm()
        {
            InitializeComponent();
            
            List <Bankomat> bankomatForTB1 = db.Bankomats.ToList();

            ;
            comboBox1.ValueMember = "BankomatId";
            comboBox1.DisplayMember = "BankomatName";
            comboBox1.DataSource = bankomatForTB1;
            comboBox1.Select();
            //comboBox1.SelectedIndex = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
            
            List<Bankomat> bankomatsToDelete = db.Bankomats.Where(b => b.BankomatId == comboBox1.SelectedIndex+1).ToList();
            db.Bankomats.Remove(bankomatsToDelete.First());
            db.SaveChanges();
            List<Bankomat>adsfhadhdgj =  db.Bankomats.ToList();
            // MainForm mf = new MainForm();
            this.FindForm().Close();
        }

       
    }
}
