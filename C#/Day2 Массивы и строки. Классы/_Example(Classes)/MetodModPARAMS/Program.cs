using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodModPARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Metod(1,2,3,4,5));
            Console.WriteLine(Metod(1, 2, 3, 4, 5,6,7,8,9,10));
            Console.WriteLine(Metod(new int []{5,6,7,8}));
            Console.ReadKey();
        }
        // метод с переменным количеством аргументов
        // params - должен быть последним и только одним
        public static int  Metod(params int [] mas)
        {    
          return mas.Length;
        }
    }
}
