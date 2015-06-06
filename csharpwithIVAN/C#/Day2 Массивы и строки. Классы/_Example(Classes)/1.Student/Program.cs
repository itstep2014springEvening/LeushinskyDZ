using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();  // создание объекта класса Student
            st1.ShowInfo();               // вызов метода (на уровне объекта!)
            Student.ShowAcademy();        // вызов статического метода (на уровне класса!)
            Console.WriteLine("Оценка: {0}", st1.GetMark()); // вызов метода 
            Console.ReadKey();
        }
    }
}
