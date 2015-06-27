using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Способы получения экземрляра класса Type.

            Type t1 = typeof(Car);
            Console.WriteLine("typeof: " + t1);
            Car car = new Car(1, "BMW");

            // Полное имя типа в строковом представлении.
            Type t2 = Type.GetType("ExampleType.Car");
            Console.WriteLine("Type.GetType: " + t2);

            Type t3 = car.GetType();
            Console.WriteLine("car.GetType(): " + t3);

            Console.WriteLine("Информация о  классе Car");

            Console.WriteLine("Полное Имя:             {0}", t1.FullName);
            Console.WriteLine("Базовый класс:          {0}", t1.BaseType);
            Console.WriteLine("Абстрактный:            {0}", t1.IsAbstract);
            Console.WriteLine("Это COM объект:         {0}", t1.IsCOMObject);
            Console.WriteLine("Запрещено наследование: {0}", t1.IsSealed);
            Console.WriteLine("Это class:              {0}", t1.IsClass);

            Console.WriteLine("Информация о членах класса Car");

            // получение всех открытых членов класса
            foreach (MemberInfo mi in t1.GetMembers())
            {
                //Вывод информации о члене класса  - 
                // DeclaringType -  член данного класса или базового 
                // MemberType - тип члена (метод, конструктор и т.д.)
                // Name - имя члена
                Console.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);
            }

            Console.ReadKey();

        }
    }

    class Car
    {
        public int Num;  // поле 
        public string  Name {get; set;}  // свойтсво
       
        public Car(int Num, string Name)  // коснтруктор 
        {
            this.Num = Num; this.Name = Name;
        }
        public override string ToString() // меотд
        {
            return String.Format("{0}. {1}",Num, Name);
        }
        public event EventHandler Stop; // событие

        public static Car  operator +(Car car, int N) // операторный метод
        {
            return new Car(N++, "BMW");
        }
    }
}
