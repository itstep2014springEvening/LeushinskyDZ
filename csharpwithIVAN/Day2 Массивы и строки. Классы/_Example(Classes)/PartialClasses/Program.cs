using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    // Объявление частичного класса
    partial class Person
    {
        public String Phone;
        public String Email;
    }

    class Program
    {       static void Main(string[] args)
        {
            Person person = new Person();
            person.Num = 1;
            person.Name = "Иван";
            person.Email = "kin@tut.by";
            person.Phone = "+375298625532";
        }
    }
    // Объявление частичного класса
    partial class Person
    {
        public Int16 Num;
        public String Name;
    }
}
