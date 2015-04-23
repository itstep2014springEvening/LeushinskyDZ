using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepathSource = textBox1.Text;
            string filepathTarget = @"D:\LeushinskyDZ\LeushinskyDZ\winforms\target.txt";

            FileStream source = new FileStream(filepathSource, FileMode.Open);
            
            FileStream target = new FileStream(filepathTarget, FileMode.Create);
            StreamReader str = new StreamReader(source);
            StreamWriter stw = new StreamWriter(target);
            str.
        }

       
    }
}
