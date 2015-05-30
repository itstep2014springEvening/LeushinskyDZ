using System;

namespace A
{
    public class DateClass  //  КЛАССЫ С ОДИНАКОВЫМИ ИМЕНАМИ
    {   
        public void  PrintDate()
        {
            Console.WriteLine(DateTime.Now); // вывод текущей даты
        }
    }

}
namespace B
{
    public class DateClass  //  КЛАССЫ С ОДИНАКОВЫМИ ИМЕНАМИ
    {
        public void PrintDate()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek); // вывод дня недели
        }
    }
}

namespace Main
{
 class Tester
 {
        public static void Main()
        {
            // Для того, чтобы не было конфликта используется пространство имен!
            A.DateClass obj1 = new A.DateClass();
            obj1.PrintDate();
            B.DateClass obj2 = new B.DateClass();
            obj2.PrintDate();

            Console.ReadKey();
        }
    }
}

