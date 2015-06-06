using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsFromCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in args)
            {
                Console.WriteLine("Параметр {0}", str);
            }
            Console.ReadKey();
        }
        /*
         * Параметры, передаваемые из командной строки (для отладки приложения), 
         * задаются в свойствах проекта на вкладке Debug в поле Command line arguments
         * 
         * Для запуска приложения из командной строки нужно указать полный  путь к программе (к .exe)
         * и перечислить параметры 
         */
    }
}
