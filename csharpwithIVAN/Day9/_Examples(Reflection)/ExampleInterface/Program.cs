using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleInterface
{
    class Program
    {
        static void Main(string[] args)
        {

Type t1=typeof(Car);

// получени списка интерфейсов, реализованных в классе Car
foreach (Type type in t1.GetInterfaces())
{
    Console.WriteLine("{0,-30}{1,-20}", type.DeclaringType, type.Name);
    // вывод списка методов интерфейса
    foreach (MethodInfo pi in type.GetMethods())
    {
        Console.WriteLine("{0,-10}. {1,-20}{2,-20}", pi.Name, pi.ReturnType, pi.DeclaringType);
    }
}

            Console.ReadLine();
        }
    }

    class Car:IMove
    {
        int Num;
        string Name;
        double Fuel;

        public Car(int Num, string Name)
        {
            Fuel = 0;
            this.Num = Num; this.Name = Name;
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}", Num, Name);
        }

        public void Stop()
        {
           
        }

        public void Move(int dX)
        {
           
        }
    }
    interface IMove
    {
        void Stop();
        void Move(int dX);
    }
}
