using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strB = new StringBuilder("Язык С#. ");
            Console.WriteLine(strB);
            // Добавление строки к существующей
            strB.Append("Платформа .NET "); 
            Console.WriteLine(strB);
            // Добавление строки к существующей + форматирование
            strB.AppendFormat("{0} {1,3:N1}", "версия",4.5); 
            Console.WriteLine(strB);
            // Вставка строки (6- индекс, место вставки)
            strB.Insert(5,"программирования "); 
            Console.WriteLine(strB);
            // Замена подстроки
            strB.Replace("4.5", "5.0");
            Console.WriteLine(strB);
            // Удаление подстроки
            strB.Remove(5, 17);
            Console.WriteLine(strB);
            // Очистка 
            strB.Clear();
            Console.WriteLine(strB);

            // Исследование поведения
            StringBuilder strS = new StringBuilder(10);
            strS.Append("строка!!!!");
            Console.WriteLine("Length: {0}, Capacity: {1}, MaxCapacity: {2:N2}", strS.Length, strS.Capacity, strS.MaxCapacity);
            strS.Append("строка!!!!");
            Console.WriteLine("Length: {0}, Capacity: {1}, MaxCapacity: {2:N2}", strS.Length, strS.Capacity, strS.MaxCapacity);
            strS.Append("строка!!!!");
            Console.WriteLine("Length: {0}, Capacity: {1}, MaxCapacity: {2:N2}", strS.Length, strS.Capacity, strS.MaxCapacity);
            strS.Append("строка!!!!");
            Console.WriteLine("Length: {0}, Capacity: {1}, MaxCapacity: {2:N2}", strS.Length, strS.Capacity, strS.MaxCapacity);
            strS.Append("строка!!!!");
            Console.WriteLine("Length: {0}, Capacity: {1}, MaxCapacity: {2:N2}", strS.Length, strS.Capacity, strS.MaxCapacity);
          
            Console.ReadKey();
        }
    }
}
