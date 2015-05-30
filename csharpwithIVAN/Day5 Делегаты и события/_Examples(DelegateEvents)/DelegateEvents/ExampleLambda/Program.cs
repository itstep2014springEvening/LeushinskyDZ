using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLambda
{
    class Program
    {
      
        delegate int DelegateSumma2(int N);   // объявление делегата (простейший пример лямбда-выражения)

        delegate bool DelegateIsRange(int lower, int upper, int v); 

        delegate void DelegateCountNums();   // объявление делегата 

        delegate void DelegateCountNums2(int N1, int N2);   // объявление делегата 

        delegate String DelegateStrings(String str);  // объявление делегата 

    


        static void Main(string[] args)
        {
            Console.WriteLine("Пример лямбда-выражения");

    // Простейшее лямбда выражение
            DelegateSumma2 summa2 = cu => cu + 2;
            Console.Write(summa2(10));


    // Лямбда-выражения для подсчета чисел (передаются параметры)
            DelegateIsRange isRange = (Min, Max, N) => N >= Min && N <= Max;
            Console.WriteLine(isRange(10, 50, 25));


            // БЛОЧНЫЕ ЛЯМБДА ВЫРАЖЕНИЯ!

    // Лямбда-выражения для подсчета чисел (параметры не передаются)
            DelegateCountNums countNums = () =>
            {
                // тело лямбда-выражения
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            }; 
            countNums();

   // Лямбда-выражения для подсчета чисел (передаются параметры)
            int K = 2; // внешняя переменная 
            DelegateCountNums2 countNums2 = (N1, N2) =>
            {
                int Sum = 0;
                for (int i = N1; i <= N2; i++)
                {
                    Sum += i;
                    Console.WriteLine(Sum);
                }
                Console.WriteLine(Sum*K);// использование внешнений перменной
            }; 

            countNums2(5,15);
   

     // Лямбда-выражения для формирования строки (передаются параметры + возвращаемое значение)
            String strMiddle = ", сердняя часть,";
            DelegateStrings createStr = (parameter) =>
            {
                parameter += strMiddle;
                parameter += " а эта часть строки добавлена в конец.\n";
                return parameter;                                                // возврат значения 
            };
            string rezult = createStr("Начало строки");
            Console.Write(rezult);

            Console.Read();
        }
    }
}
