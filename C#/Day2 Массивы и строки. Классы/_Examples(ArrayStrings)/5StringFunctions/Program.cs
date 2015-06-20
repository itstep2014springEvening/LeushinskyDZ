using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions1();
            Functions2();
            Functions3();
            Functions4();
            Console.ReadKey();
        }

        static void Functions1()
        {
            string str = "Простая строка";
            char[] chrArr = new char[6];

            Console.WriteLine("Реверсирование строки");
            char[] chrArrFull = str.ToCharArray();
            Array.Reverse(chrArrFull);
            Console.Write(chrArrFull);                     

            Console.WriteLine("\nКопирование строки в массив символов");
            //Копируем шесть символов начиная с восьмой позиции и помещаем в массив символов
            str.CopyTo(8, chrArr, 0, 6);
            Console.WriteLine(chrArr);
        }

        static void Functions2()
        {
            string str1 = "Простая строка";
            string str2 = "Строка";
            string str3 = "строка";
            string[] strArr = { "ШАГ", "шагаем", "бежим", "ем", "Играем" };
            // Сравнение строк
            Console.WriteLine("\"" + str1 + "\" равна \"" + str2 + "\" : " + str1.Equals(str2));
            //
            Console.WriteLine("\"" + str2 + "\" == \"Строка\" : " + (str2 == "Строка"));
            // Сравнение без учета регистра
            Console.WriteLine("Сравнение без учета регистра:");
            Console.WriteLine("\"" + str2 + "\" равна \"" + str3 + "\" : " + str2.Equals(str3, StringComparison.CurrentCultureIgnoreCase));

            Console.Write("Слова начинающиеся на \"шаг\": ");
            foreach (string s in strArr)
                if (s.StartsWith("шаг", StringComparison.CurrentCultureIgnoreCase))
                    Console.Write(s + " ");
            
            Console.Write("\nСлова заканчивающиеся на \"ем\": ");
            foreach (string s in strArr)
                if (s.EndsWith("ем", StringComparison.CurrentCultureIgnoreCase))
                    Console.Write(s + " ");
           
            Console.WriteLine();
        }

        static void Functions3()
        {
            string str1 = "ПолиморфизмНаследованиеИнкапсуляция";
            string str2 = "АБВГДЕЖЗИКЛМН";
            // получение индексов 
            Console.WriteLine("Первое вхождение символа \'Н\': " +  str1.IndexOf('Н'));
            Console.WriteLine("Последнее вхождение символа \'И\': " + str1.LastIndexOf('И'));
            Console.WriteLine("Последнее вхождение любого из символов строки "+ "АБВГДЕЖЗИКЛМН\" : " + str1.LastIndexOfAny(str2.ToCharArray()));
            // Вывод подстроки с 11 символа по 23-й
            Console.WriteLine("Подстрока начиная с 11 символа по 23-й : " + str1.Substring(11, 12));
        }


        static void Functions4()
        {
            string str1 = "Я ";
            string str2 = "учу ";
            string str3 = "C#";
            string str4 = str1 + str2 + str3;

            Console.WriteLine("{0} + {1} + {2} = {3}", str1, str2, str3, str4);

            str4 = str4.Replace("учу", "изучаю");
            Console.WriteLine(str4);

            str4 = str4.Insert(2, "настройчиво ").ToUpper();  // приведение к верхнему регистру
            Console.WriteLine(str4);

            if (str4.Contains("настройчиво"))                // имеется ли слово "настройчиво" в строке? !!! Cравнение с учетом регистра!
                Console.WriteLine("Учу таки настройчиво :)");
            else
                Console.WriteLine("Учу как могу");

            str4 = str4.PadLeft(30, '*');                   // добавление '*' слева от строки (всего 30 символов в строке)
            str4 = str4.PadRight(35, '$');                  // добавление '$' справа от строки (всего 35 символов в строке)
            Console.WriteLine(str4);

            str4 = str4.TrimStart(new char[] { '*' });      // удаление '*' в начале строки 
            str4 = str4.TrimEnd("$".ToCharArray());         // удаление '$' с конца строки 
            Console.WriteLine(str4);

            string[] strArr = str4.Split(new char[]{' '});  // формирование массива стро из строки (разделитель "пробел")
            foreach (string str in strArr)
                Console.WriteLine(str);
           
            str4 = str4.Remove(14);
            str4 += "учусь";
            
            Console.WriteLine(str4);
        }	

    }
}
