using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _2
{
    public partial class Form1 : Form
    {
        public List<String> Vocabular = new List<string>() {"Раз", "Два" , "Три" }; 
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("!");
        }

       
                //
          

        public void WordSeeker(object enteredString)
        {
            foreach (var word in Vocabular)
            {
                
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                string enteredString = textBox1.Text;
                Thread t = new Thread(new ParameterizedThreadStart(WordSeeker));
                t.Start(enteredString);
            }
        }
    }
}
