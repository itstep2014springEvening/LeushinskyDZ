using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCulture.SelectedIndex = 0;
        }

        private void cbCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Kurs = 1;

            if (cbCulture.SelectedIndex == 0)
            {   // установка культуры на интерфейса
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
                // установка культуры на интерфейса
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            }
            else
            {   // установка культуры на интерфейса
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                // установка культуры на интерфейса
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Kurs = 15000;
            }
            // получение файла ресурсов для конкретного языка 
            ComponentResourceManager resources =new ComponentResourceManager(this.GetType());
            
            // применение языка для заголовка окна 
            resources.ApplyResources(this, "$this");

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;



            Double Summa = 1200000000000 / Kurs;
            tbSumma.Text = Summa.ToString( "N2");

            //  проходим по всем котролам окна для получения по свойству Name
            // значения из файла ресурсов 
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name);

            
        }
    }
}
