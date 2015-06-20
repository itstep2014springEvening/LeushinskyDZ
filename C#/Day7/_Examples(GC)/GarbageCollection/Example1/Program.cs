using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация System.GC");
            Console.WriteLine("Максимальное поколение: {0}", GC.MaxGeneration);

            GarbageHelper hlp = new GarbageHelper();  // создаем объект класс для создания "мусора"
            
            // Узнаем поколение, в котором находится объект
            Console.WriteLine("Поколение объекта: {0}", GC.GetGeneration(hlp));
            
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0}",  GC.GetTotalMemory(false));
            
            // Создаем мусор
            Console.WriteLine("Создаем мусор");
            hlp.MakeGarbage();
           
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0}",  GC.GetTotalMemory(false));
           
            // Вызываем явный сбор мусора в первом поколении
            Console.WriteLine("Вызываем явный сбор мусора в первом поколении Collect(0)");
            GC.Collect(0);
            
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0}", GC.GetTotalMemory(false));
           
            // Узнаем поколение, в котором находится объект
            Console.WriteLine("Поколение объекта: {0}",   GC.GetGeneration(hlp));
            
            // Вызываем явный сбор мусора во всех поколениях
            Console.WriteLine("Вызываем явный сбор мусора во всех поколениях Collect()");
            GC.Collect();
            
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0}", GC.GetTotalMemory(false));
            
            // Узнаем поколение, в котором находится объект
            Console.WriteLine("Поколение объекта: {0}", GC.GetGeneration(hlp));
           
            Console.Read();
        }
    }


   
    // Вспомогательный класс для создания мусора
     class GarbageHelper
    {
        
        // Метод, создающий мусор
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person();
            }
        }
     }
        class Person
        {
            private string _name;
            private string _surname;
            private byte _age;

            public Person(string name, string surname, byte age)
            {
                this._age = age;
                this._name = name;
                this._surname = surname;
            }

            public Person() : this("", "", 0)
            {
            }
        }

  
    
}
