using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2part2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //int button1X = int.Parse(button1.Location.X.ToString());
            //int button1Y = int.Parse(button1.Location.Y.ToString());
            //if (e.X == button1X)
            //    MessageBox.Show("LALA");

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.ClientSize.Width - button1.Width);
            button1.Top = r.Next(0, this.ClientSize.Height - button1.Height);
        }
    }
}
