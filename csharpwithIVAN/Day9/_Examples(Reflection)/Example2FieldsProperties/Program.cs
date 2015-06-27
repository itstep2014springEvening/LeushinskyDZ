using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            Type t1 = typeof(Car);

            // получение информации о всех полях
            Console.WriteLine("{0,-30}{1,-20}{2,-20}", "Принадлежность", "Имя","Тип", "Статический");
            foreach (FieldInfo fi in t1.GetFields())
            {
                
                Console.WriteLine("{0,-30}{1,-20}{2,-20}{3,-20}", fi.DeclaringType, fi.Name, fi.FieldType, fi.IsStatic);
            }

            Console.WriteLine("----------------------------------------------------------------------");
           
            // получение информации о всех свойствах
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "Принадлежность", "Имя", "Чтение (Get)", "Запись (Set)");
            foreach (PropertyInfo pi in t1.GetProperties())
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", pi.DeclaringType, pi.Name, pi.CanRead, pi.CanWrite);
                
                foreach (MethodInfo mi in pi.GetAccessors())
                {
                    // ReturnType - тип возвращаемого значения
                    Console.WriteLine("{0,-20}{1,-20}",mi.ReturnType, mi.Name);
                }
            
            }

            Console.ReadKey();
        }
    }

      class Car
      {
        // открытое поле
        public string Name;
        // открытое статическое поле 
        public static double Fuel;
        // закрытое поле 
        private int num;
        // свойство
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        // автоматическое свойство
        public double Price { get; set; }
      }
}
