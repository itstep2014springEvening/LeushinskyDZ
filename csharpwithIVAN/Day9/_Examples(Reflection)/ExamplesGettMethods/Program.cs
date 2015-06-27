using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesGettMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Car);
           
            // получение информации о всех методах
            Console.WriteLine("{0,-30}{1,-20}{2,-20}", "Принадлежность","Тип возвр зн", "Имя");
            foreach (MethodInfo mi in t1.GetMethods())
            {
                // ReturnType - тип возвращаемого значения
                Console.WriteLine("{0,-30}{1,-20}{2,-20}",mi.DeclaringType, mi.ReturnType, mi.Name);
                foreach (ParameterInfo pi in mi.GetParameters())
                {
                    Console.WriteLine("{0,10}. {1,-20}{2,-20}", pi.Position, pi.Name, pi.ParameterType);
                }
            }

            Console.WriteLine("----------------------------------------------------------------------");
            
            // получение информации о всех методах (выборочно по флагам)
            MethodInfo[] InfoMethods = t1.GetMethods(BindingFlags.DeclaredOnly |
                                                                BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo mi in InfoMethods)
            {
                // ReturnType - тип возвращаемого значения
                Console.WriteLine("{0,-30}{1,-20}{2,-20}", mi.DeclaringType, mi.ReturnType, mi.Name);
                foreach (ParameterInfo pi in mi.GetParameters())
                {
                    Console.WriteLine("{0,10}. {1,-20}{2,-20}", pi.Position, pi.Name, pi.ParameterType);
                }
            }
          
            Console.WriteLine("----------------------------------------------------------------------");
            // получение информации о конкретном методе по имени
            MethodInfo info = t1.GetMethod("ToString");
            Console.WriteLine("{0,-30}{1,-20}{2,-20}", info.DeclaringType, info.ReturnType, info.Name);
                     
            if (info.IsStatic) Console.WriteLine("Метод {0} - статический", info.Name);
            if (info.IsPublic) Console.WriteLine("Метод {0} - открытый", info.Name);
            if (info.IsPrivate) Console.WriteLine("Метод {0} - закрытый", info.Name);
            if (info.IsAbstract) Console.WriteLine("Метод {0} - абстрактный", info.Name);
            if (info.IsVirtual) Console.WriteLine("Метод {0} - виртуальный", info.Name);

           Console.ReadKey();
        }
    }

abstract class Car
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

    public void AddFuel(double Fuel)
    {
        this.Fuel = Fuel;
    }
    public double UseFuel(double dFuel)
    {
        Fuel = Fuel - dFuel;
        return Fuel;
    }
    public abstract void Go(int V, int x, int Y);

}
}
