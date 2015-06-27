using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflex
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"ComplexLib.dll";
            Assembly assembly=null;
            try
            {
                assembly = Assembly.LoadFrom(filePath);
            }
            catch
            {
                Console.WriteLine("File not found");
            }
            Type [] types = assembly.GetTypes();
            foreach (Type tp in types)
            {
                Console.WriteLine("Полное Имя:"+tp.FullName);
                Console.WriteLine("Базовый класс:"+tp.BaseType);
                Console.WriteLine("Абстрактный:"+tp.IsAbstract);
                Console.WriteLine("Это COM объект:"+tp.IsCOMObject);
                Console.WriteLine("Запрещено наследование:"+tp.IsSealed);
                Console.WriteLine("Это class:"+tp.IsClass);
                Console.WriteLine("------------------------");
                foreach(var methods in tp.GetMethods().GroupBy(m=>m.Name))
                {
                    Console.WriteLine("Метод:" + methods.Key.ToString());
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("------------------------\n\n");

            }
            Console.Read();


        }
    }
}
