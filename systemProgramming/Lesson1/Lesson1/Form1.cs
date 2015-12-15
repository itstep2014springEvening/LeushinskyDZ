using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myProcess.StartInfo = new ProcessStartInfo("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myProcess.CloseMainWindow();
            myProcess.Close();
        }
    }
}
