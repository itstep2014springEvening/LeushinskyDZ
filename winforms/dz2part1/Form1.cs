using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gasoline = {"АИ-69", "АИ-92", "АИ-95"};
            textBox6.Text = "6900";
            comboBox1.DataSource = gasoline;
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (comboBox1.SelectedItem == comboBox1.Items[0])
            {
                textBox6.Text = "6900";
            }
            if (comboBox1.SelectedItem == comboBox1.Items[1])
            {
                textBox6.Text = "9200";
            }
            if (comboBox1.SelectedItem == comboBox1.Items[2])
            {
                textBox6.Text = "9500";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            groupBox4.Text = "К выдаче";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            groupBox4.Text = "К оплате";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] tbCollection =
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, 
                textBox8, textBox9, textBox10,textBox11,textBox12,textBox13,textBox14
            };
            foreach (var tb in tbCollection)
            {
                if (tb.Text == "")
                {
                    tb.Text = "0";
                }
            }
            float resultForGasoline = 0;
            if (radioButton1.Checked)
            {
                
                resultForGasoline = float.Parse(textBox6.Text) * float.Parse(textBox1.Text);
                textBox3.Text = resultForGasoline.ToString("N", CultureInfo.CreateSpecificCulture("ru-RU"));
            }
            if (radioButton2.Checked)
            {
                
                resultForGasoline = float.Parse(textBox2.Text) / float.Parse(textBox6.Text);
                textBox3.Text = resultForGasoline.ToString("N", CultureInfo.CreateSpecificCulture("ru-RU"));
            }

            int resultForHamburgers = int.Parse(textBox11.Text)*int.Parse(textBox7.Text) +
                                      int.Parse(textBox12.Text)*int.Parse(textBox8.Text)
                                      + int.Parse(textBox13.Text)*int.Parse(textBox9.Text) +
                                      int.Parse(textBox14.Text)*int.Parse(textBox10.Text);

            textBox4.Text = resultForHamburgers.ToString("N", CultureInfo.CreateSpecificCulture("ru-RU"));
            float result = resultForGasoline + resultForHamburgers;
            textBox5.Text = result.ToString("N", CultureInfo.CreateSpecificCulture("ru-RU"));
            float finalResult = 0;
            finalResult += result;
            textBox15.Text = finalResult.ToString("N", CultureInfo.CreateSpecificCulture("ru-RU"));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox11.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                textBox11.Text = "";
                textBox11.Enabled = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox12.Enabled = true;
            }
            if (!checkBox2.Checked)
            {
                textBox12.Text = "";
                textBox12.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox13.Enabled = true;
            }
            if (!checkBox3.Checked)
            {
                textBox13.Text = "";
                textBox13.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox14.Enabled = true;
            }
            if (!checkBox4.Checked)
            {
                textBox14.Text = "";
                textBox14.Enabled = false;
            }
        }

    }
}
