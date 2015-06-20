using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       // объявление массива myArr1
            PrintArr("Массив myArr1", myArr1);                      // вызов метода для вывода элементов массива на экран

            Console.WriteLine("Размер массива: "+myArr1.Length);                                
            Console.WriteLine("Максимальный элемент в массиве myArr1: " + myArr1.Max());        
            Console.WriteLine("Минимальный элемент в массиве myArr1: " + myArr1.Min());         
            Console.WriteLine("Среднее арифметическое элементов myArr1: " + myArr1.Average());
            Console.WriteLine("Сумма элементов" + myArr1.Sum());

            Array.Reverse(myArr1);                                     // Реверсирование всего массива
            PrintArr("Массив myArr1 после реверсирования", myArr1);
            
            Array.Sort(myArr1);                                        // Сортировка всего массива
            PrintArr("Массив myArr1 после сортировки", myArr1);

            Console.WriteLine("Число 5 находится в массиве на " + Array.BinarySearch(myArr1, 5) + " позиции");

            Array.Reverse(myArr1, 3, 4);                               // Реверсирование 4-ех элементов массива начиная с (3+1)-го элемента
            PrintArr("Массив myArr1 после реверсирования", myArr1);


            int[] myArr2 = new int[20];                                // объявление нового массива myArr2 (заполнение нулями)
            PrintArr("Массив myArr2 до копирования", myArr2);

            myArr1.CopyTo(myArr2,0);                                  // копирование из myArr1  в  myArr2
            PrintArr("Массив myArr2 после копирования", myArr2);
            
            Array.Clear(myArr2, 0, myArr2.Length);
            PrintArr("Массив myArr2 после очистки: ", myArr2);         // копирование из myArr1  в  myArr2


            int[] tempArr = (int[])myArr1.Clone();                     // Клонирование массива из существующего
            PrintArr("Склонированный массив tempArr", tempArr);

            Console.WriteLine("Индекс элемента 9 в массиве - "+Array.BinarySearch(myArr1, 9));

            Console.WriteLine("Индекс 9 в массиве (первый) - " + Array.IndexOf(myArr1, 9));
            Console.WriteLine("Индекс 9 в массиве (последний)- " + Array.LastIndexOf(myArr1, 9));

            int[] myArr3 = new int[20];    
            Array.Copy(myArr1, myArr3,10);
            PrintArr("Массив myArr3 после копирования: ", myArr3);

            Array.Clear(myArr1, 0, 10); //очистка массива

            int[,] myArr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr4.Rank);

        
            Console.Read();
        }

        // 
       /// <summary>
       /// статический метод для вывода значений на экран
       /// </summary>
       /// <param name="text">Поясняющий тектс</param>
       /// <param name="arr">Массив элементы, которого необходимо вывести</param>
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)     // цикл для перебора элементов массива 
                Console.Write(arr[i] + " ");         // свойство Length - размер массива
            Console.WriteLine();
        }
    }
}
