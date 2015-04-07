using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2_07._04._15_
{
    public partial class Form1 : Form
    {
        string[] mas;
        public Form1()
        {
            InitializeComponent();
            mas = new string []{ "братишка", "покушать", "здраститя", "начальник" };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = mas;
            //this.Text = (string)comboBox1.SelectedItem;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage();
            tp.Text = "Ахахахахах";
            tcMain.Controls.Add(tp);
        }

        private void comboBox1_SelectIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = mas;
            this.Text = (string)comboBox1.SelectedItem;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.Text = button.Text;
        }
    }
}
