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
    public partial class AddBankForm : Form
    {
        BanksDB db = new BanksDB();
        public AddBankForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Banks.Add(new Bank() {BankName = textBox1.Text});
            db.SaveChanges();
        }
    }
}
