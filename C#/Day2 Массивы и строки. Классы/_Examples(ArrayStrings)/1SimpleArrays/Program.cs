using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            // объявление массива (целых чисел)
            int[] mas1;  mas1=new int[5];
            int[] mas2 = new int[5];
            
            // объявление массива + инициализация
            
            int[] mas3 = new int[5]{1,2,3,4,5};
           
            int[] mas4 = new int[] { 1, 2, 3, 4, 5 };  // размер массива опеределяется кол-вом элементов в инициализаторе
          
            int[] mas5 =  { 1, 2, 3, 4, 5 };

            // объявление массива (строки)
            string[] info = { "Фамилия", "Имя", "Отчество" };

            // объявление массива (символы)
            char[] symbol = new char[4] { 'X', 'Y', 'Z', 'M' };

            // объявление двумерного массива + инициализация
            int[,] mas2D = new int [3,2]
                                   { {1,2},
                                     {3,4},
                                     {5,6} };

            
            // объявление трехмерного массива + инициализация
            int[, ,] myArr = new int[5, 5, 5];
             for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 5; k++)
                        myArr[i, j, k] = i + j + k;

        }
    }
}
