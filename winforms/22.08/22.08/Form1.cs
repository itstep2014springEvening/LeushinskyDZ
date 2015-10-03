using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._08
{
    public partial class Form1 : Form
    {
        int x = 10;
        Timer t = new Timer();
        Random r = new Random();
            
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drez = MessageBox.Show("TEXT", "ASDS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if(DialogResult.Yes==drez)
            {
                label1.Text = "AAKKAKAKAKAK";
            }
            //t.Start();
            //t.Interval = 99;
            //t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            
            label1.Location = new Point(x, 100);
            x++;
        }
    }
}
