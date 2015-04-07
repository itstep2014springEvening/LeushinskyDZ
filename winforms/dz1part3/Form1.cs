using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int lParam = 0;
            int hParam = 50;
            int nCounter = 0;
            MessageBox.Show("Сыграем в угадай число. Загадайте число и правдиво отвечайте на вопросы!");
            while (lParam!=hParam)
            {
                if (DialogResult.Yes==MessageBox.Show("Ваше число меньше или равно " + ((lParam+hParam)/2).ToString() + " ?",
                    "Magic programm", MessageBoxButtons.YesNo, MessageBoxIcon.None))
                {
                    hParam = (lParam + hParam)/2;
                    nCounter ++;
                }
                else
                {
                    lParam = ((lParam + hParam)/2) + 1;
                    nCounter++;
                }

            }
            MessageBox.Show("Ваше число: " + lParam.ToString() + ". Вы угадали с: " + nCounter + "раз");
            
           // int a = 0;
           // int b = 2000;
           // int x = 0;

           //while (a != b)
           // {
           //     if (x <= (a + b)/2)
           //     {
           //         b = (a + b)/2;
           //     }
           //     else if ((x > (a + b)/2))
           //     {
           //         a = ((a + b) / 2) + 1;
           //     }
                    
                
           // }
           //MessageBox.Show(a.ToString());

        }
    }
}
