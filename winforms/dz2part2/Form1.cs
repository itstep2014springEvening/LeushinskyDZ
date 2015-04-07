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
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
           // MouseHover += button1_MouseHover;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(rand.Next(50, 1000), rand.Next(50, 1000));
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
