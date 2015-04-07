using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string aboutMe = "Some information about me Some information about me Some information about me Some information about me Some information about me Some information about me Some information about me Some information about me Some information about me Some information about me ";
            string nOfStringElements = string.Format("{0}",aboutMe.Length);
            int nCounter = 1;
            if (DialogResult.OK == MessageBox.Show(aboutMe, "About me", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                nCounter++;
            }
            if (DialogResult.OK == MessageBox.Show(aboutMe, "About me", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                nCounter++;
            }
            DialogResult =
            MessageBox.Show(aboutMe, "Кол-во символов:" + nOfStringElements + "/ Кол-во MB:" + nCounter, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

    //public class MyMessageBox
    //{
    //    public MyMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, int counter)
    //    {
           
    //    }
    //}
}
