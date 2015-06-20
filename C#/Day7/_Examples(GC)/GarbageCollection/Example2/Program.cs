using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example2Finalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример использования Finalaze()");
            Car car = new Car { Name = "BMW" };
            Console.WriteLine(car.Name);
            Test();
            GC.Collect();      // ЯВНАЯ СБОРКА МУСОРА
            Console.ReadKey();
        }

        static void Test()
        {
            Car car = new Car { Name = "Ford" };
            Console.WriteLine(car.Name);
        }
    }

    class Car
    {
        public string Name {get; set;}
        ~ Car()  // Деструктор (метод Finalize())
        {
            Console.WriteLine("Вызов деструктора Car.Name={0}", Name);
        }
    }
}
