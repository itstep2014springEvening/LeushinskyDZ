using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCreateObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Car);

            // получение информации о всех конструкторах
            Console.WriteLine("{0,-30}{1,-20}", "Принадлежность", "Имя");
            foreach (ConstructorInfo mi in t1.GetConstructors())
            {
                 Console.WriteLine("{0,-30}{1,-20}", mi.DeclaringType, mi.Name);
                foreach (ParameterInfo pi in mi.GetParameters())
                {
                    Console.WriteLine("{0,10}. {1,-20}{2,-20}", pi.Position, pi.Name, pi.ParameterType);
                }
            }
            Console.WriteLine("----------------------------------------------------------------------");
            
            Type CarType = Type.GetType("ExampleCreateObjects.Car");
            //получение информации о конструкторe - c двумя параметрами:  int и  string
            ConstructorInfo ci = CarType.GetConstructor(new Type[] { typeof(int), typeof(string)});
            
            //вызов конструтора с передачей значений - создание  объекта!
            object Obj = ci.Invoke(new object[] { 1, "BMW" });
            Console.WriteLine(Obj.ToString());

            Console.WriteLine("----------------------------------------------------------------------");
           

            Console.ReadKey();
        }
    }
class Car
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
}
}
