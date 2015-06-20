using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodsMods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ans;  // инициализировать переменную не обязательно!
            Metod(10, 20, out ans);
            Console.WriteLine("Значение переменной ans: " + ans);

            string Mes;
            Metod(out Mes, 10, 20, out ans);
            Console.WriteLine(Mes);
            Console.WriteLine("Значение переменной ans: " + ans);


            int[] mas={1,2,3,4,5};
            Metod(10, 20, out ans, out mas);
            Console.WriteLine("Значение переменной ans: " + ans);
            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i]+" ");
            Console.WriteLine();

            Console.ReadKey();

        }


        // Значения выходных параметров (переменная ans) должны быть установлены вызываемым методом.
        static void Metod(int x, int у, out int ansN)
        {
            ansN = x + у;  // переменная ansN должна быть проинициализирована
        }

        static void Metod(out string Message, int x, int у, out int ansN)
        {
            ansN = x + у;
            Message = "модификатор out";
        }
        static void Metod(int x, int у, out int ansN, out int[]mas)
        {
            ansN = x + у;
            mas=new int[]{6,7,8,9,10};
        }


    }

    
}
