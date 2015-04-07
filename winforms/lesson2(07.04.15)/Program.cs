using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2_07._04._15_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


//Элементы управления
//Label => Основное свойство - текст
//TextBox => Основное свойство - текст
//Button
//RadioButton
//CheckBox
//ComboBox = выпадающий список
//TabControl = вкладки
//NumericUpDown = элемент со стрелками вверх вниз