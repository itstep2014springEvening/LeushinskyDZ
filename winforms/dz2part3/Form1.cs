using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Цена за квадратный метр=380, за всю площадь=" + 380 * numericUpDown1.Value + Environment.NewLine;// +
                             
            //                "Цена за уборку подъездов = 200" + Environment.NewLine +
            //                "Цена за лифт=214, за каждый этаж добавляется коэффициент=0,1, итого=" + 214 * (double)numericUpDown3.Value * 0.1 + Environment.NewLine +
            //                "Цена за электричество при наличии газовой плиты и счётчика=2,36, итого=" + 2.36 * (double)numericUpDown4.Value + Environment.NewLine +
            //                "Цена за горячую воду, при наличии счётчика=34,02, итого=" + (double)numericUpDown5.Value * 34.02 + Environment.NewLine +
            //                "Цена за холодную воду, при наличии счётчика=21,03, итого=" + (double)numericUpDown6.Value * 21.03 + Environment.NewLine +
            //                "Цена за газ при наличии счётчика=52,4, итого=" + (double)numericUpDown7.Value * 52.4 + Environment.NewLine +
            //                "Цена за отопление при наличии счётчика=1408, итого=" + numericUpDown8.Value * 1408 + Environment.NewLine + "-----" +Environment.NewLine+ "Итого: "  +
            //                ((380 * (double)numericUpDown1.Value) + (50 * (double)numericUpDown1.Value) + (214 * (double)numericUpDown3.Value * 0.1) + (2.36 * (double)numericUpDown4.Value) +
            //                (double)numericUpDown5.Value * 34.02 + (double)numericUpDown6.Value * 21.03 + (double)numericUpDown7.Value * 52.4 + (double)numericUpDown8.Value * 1408);
            if(checkBox1.Checked)
            {
                textBox1.Text += "Капитальный ремонт добавляет за каждый квадратный метр=50, за всю площадь=" + 50 * numericUpDown1.Value + Environment.NewLine;
            }
            if(checkBox2.Checked)
            {
                textBox1.Text += "Цена за уборку подъездов = 200" + Environment.NewLine;
            }
            if(checkBox3.Checked)
            {
                 textBox1.Text +="Цена за лифт=214, за каждый этаж добавляется коэффициент=0,1, итого=" + 214 * (double)numericUpDown3.Value * 0.1 + Environment.NewLine;
            }
            if (checkBox4.Checked)
            {
                 textBox1.Text += "Цена за электричество при наличии газовой плиты и счётчика=2,36, итого=" + 2.36 * (double)numericUpDown4.Value + Environment.NewLine;
            }
            if (checkBox5.Checked)
            {
                 textBox1.Text +="Цена за горячую воду, при наличии счётчика=34,02, итого=" + (double)numericUpDown5.Value * 34.02 + Environment.NewLine;
            }
            if (checkBox6.Checked)
            {
                 textBox1.Text +="Цена за холодную воду, при наличии счётчика=21,03, итого=" + (double)numericUpDown6.Value * 21.03 + Environment.NewLine;
            }
            if (checkBox7.Checked)
            {
                 textBox1.Text +="Цена за газ при наличии счётчика=52,4, итого=" + (double)numericUpDown7.Value * 52.4 + Environment.NewLine;
            }
            if (checkBox8.Checked)
            {
                textBox1.Text += "Цена за отопление при наличии счётчика=1408, итого=" + numericUpDown8.Value * 1408 + Environment.NewLine;
            }
            textBox1.Text+="-----" +Environment.NewLine+ "Итого: "  +
                            ((380 * (double)numericUpDown1.Value) + (50 * (double)numericUpDown1.Value) + (214 * (double)numericUpDown3.Value * 0.1) + (2.36 * (double)numericUpDown4.Value) +
                            (double)numericUpDown5.Value * 34.02 + (double)numericUpDown6.Value * 21.03 + (double)numericUpDown7.Value * 52.4 + (double)numericUpDown8.Value * 1408);
   
        }
    }
}
