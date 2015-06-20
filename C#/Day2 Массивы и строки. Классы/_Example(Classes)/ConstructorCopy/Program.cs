using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Person
            Person person1 = new Person("Иван", 40);

            // Создание коппии объекта person1
            Person person2 = new Person(person1);

            // Изменение значений 
            person1.Age = 39;
            person2.Age = 41;

             person2.Name = "Андрей";

            // Вывод информации об объектах класса
             Console.WriteLine(person1.ShowInfo());
             Console.WriteLine(person2.ShowInfo());

             Console.ReadLine();
        }
    }

    class Person
    {
        public int Age;
        public string Name;

        // Конструтор экземпляра
        public Person(string name, int age)
        {   Name = name;
            Age = age;
        }

        // конструктор копии
        public Person(Person previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }
        //   Второй способ создания коснтуктора копии.
        //public Person(Person previousPerson)
        //    : this(previousPerson.Name, previousPerson.Age)
        //{
        //}
     
        // вывод информации о Person
        public string ShowInfo()
        {
            return Name + " возраст: " + Age.ToString();
        }
    }

}
