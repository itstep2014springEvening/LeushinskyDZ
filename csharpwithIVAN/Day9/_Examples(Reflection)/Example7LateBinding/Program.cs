using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example7LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                // загрузка сборки
                assembly = Assembly.Load("TestClassLib");
                // получение указанного типа из сборки!
                Type type = assembly.GetType("TestClassLib.SportsCar");
                // создание объекта класса 
                dynamic carInstance = Activator.CreateInstance(type);
                // вызов метода!
                carInstance.Acceleration();
                carInstance.Driver("Иванов И.И.!", 50);
             
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
