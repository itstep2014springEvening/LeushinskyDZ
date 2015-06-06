using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLimitNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ограничения на конструктор");
            Test<A> objA = new Test<A>();
            // Ошибка параметр типа не содержит конструтор по умолчанию
            //Test<B> ObjB = new Test<B>();

            Console.ReadKey();

         



        }
    }

    // класс, имеющий конструктор по умолчанию
    class A
    {
        public int ID { get; set; }
    }
    // класс, не имеющий конструктор по умолчанию
    class B
    {
        public string  Name { get; set; }
        public B(string name)
        {
            Name = name;
        }
    }

    // обобщенный класс, демонстрирующий ограницения на конструтор
    class Test<T> where T: new ()
    {
      public Test()
      {
        
      }
    }

}
