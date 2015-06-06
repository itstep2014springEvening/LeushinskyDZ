using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать коллекцию в виде динамического массива. 
            ArrayList al = new ArrayList();
            // Использование свойства Count
            Console.WriteLine("Исходное количество элементов: " + al.Count);
            Console.WriteLine();
            Console.WriteLine("Добавить 4 элемента");
            // Добавить элементы в коллекцию. 
            al.Add(new Car { Num = 1, Name = "Ford"});
            al.Add(new Car { Num = 2, Name = "BMW" });
            al.Add(new Car { Num = 3, Name = "Opel" });
            al.Add(new Car { Num = 4, Name = "ВАЗ" });
            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое коллекции, 
            // используя индексирование. 
            Console.Write("Текущее содержимое: \n");
            for (int i = 0; i < al.Count; i++)
                Console.WriteLine(al[i]);
            Console.WriteLine();

            Console.WriteLine("Удалить 2 элемента");
            // Удалить элементы из коллекции, 
            al.Remove(al[3]);  // удаление элемента (ВАЗ)
            al.RemoveAt(1);  // удаление по индексу (BMW)
            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое коллекцию, используя цикл foreach. 
            Console.Write("Содержимое: \n");
            foreach (Car c in al)
                Console.WriteLine(c + " ");
            Console.WriteLine();

            Console.WriteLine("Добавить еще 3 элемента");
            ArrayList al2 = new ArrayList();
            al2.Add(new Car { Num = 5, Name = "Audi" });
            al2.Add(new Car { Num = 6, Name = "Fiat" });
            al2.Add(new Car { Num = 7, Name = "Honda" });

            // Добавление в коллекцию набора объектов
            al.AddRange(al2);

            Console.Write("Содержимое: \n");
            foreach (Car c in al)
                Console.WriteLine(c);
            Console.WriteLine("\n");

            // Изменить содержимое коллекции, 
            // используя индексирование. 
            Console.WriteLine("Изменить первый элемент");
            al[0] = new Car() { Num=1, Name="New Ford "};

            Console.Write("Содержимое: \n");
            foreach (Car с in al)
                Console.WriteLine(с);
            Console.WriteLine();

            Car findCar = new Car { Num = 5, Name = "Audi" };
            Console.Write("Имеется ли в коллекции - {0}?\n", findCar);
            Console.WriteLine(al.Contains(findCar));



          
            Console.ReadKey();
        }
    }

    class Car
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return String.Format("{0}.{1}",Num, Name);
        }
    }
}
