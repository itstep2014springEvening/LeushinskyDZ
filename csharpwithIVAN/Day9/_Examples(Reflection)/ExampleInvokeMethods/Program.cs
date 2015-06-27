using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type CarType = typeof(Car);
            // Получение конструктора
            ConstructorInfo ci = CarType.GetConstructor(new Type[] { typeof(int), typeof(string) });
            //вызов конструтора с передачей значений - создание  объекта!
            object Obj = ci.Invoke(new object[] { 1, "BMW" });

            Console.WriteLine(Obj.ToString());
         
            // получение информации о методе по имени
            MethodInfo info = CarType.GetMethod("AddFuel");
            // Вызов метода AddFuel объекта Obj с передачей значения "500"
            info.Invoke(Obj, new object[] {500});
          
            Console.WriteLine(Obj.ToString());
            
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
                return String.Format("{0}. {1}, {2}", Num, Name,Fuel);
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
        }
}
