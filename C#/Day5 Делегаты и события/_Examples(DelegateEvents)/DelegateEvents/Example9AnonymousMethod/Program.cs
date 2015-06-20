using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9AnonymousMethod
{
    class AnonymousMethod
    {
      
        delegate void DelegateCountNums();   // объявление делегата 

        delegate void DelegateCountNums2(int N1, int N2);   // объявление делегата 

        delegate String DelegateStrings(String str);  // объявление делегата 

        static void Main(string[] args)
        {
            Console.WriteLine("Пример анономных методов");

          

            // Анонимный метод для подсчета чисел (параметры не передаются)
            DelegateCountNums countNums = delegate
            {
                // тело анонимного метода
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            };
            countNums();

            // Анонимный метод для подсчета чисел (передаются параметры)
            int K = 2; // внешняя переменная 
            DelegateCountNums2 countNums2 = delegate(int N1, int N2)
            {
                int Sum = 0;
                for (int i = N1; i <= N2; i++)
                {
                    Sum += i;
                    Console.WriteLine(Sum);
                }
                Console.WriteLine(Sum * K);// использование внешнений перменной
            };

            countNums2(5, 15);


            // Анонимный метод для формирования строки (передаются параметры + возвращаемое значение)
            String strMiddle = ", сердняя часть,";
            DelegateStrings createStr = delegate(string parameter)
            {
                parameter += strMiddle;
                parameter += " а эта часть строки добавлена в конец.\n";
                return parameter;                                                // возврат значения 
            };
            string rezult = createStr("Начало строки");
            Console.Write(rezult);

        }
    }
}
