using System;

namespace A
{
    public class DateClass  //  ������ � ����������� �������
    {   
        public void  PrintDate()
        {
            Console.WriteLine(DateTime.Now); // ����� ������� ����
        }
    }

}
namespace B
{
    public class DateClass  //  ������ � ����������� �������
    {
        public void PrintDate()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek); // ����� ��� ������
        }
    }
}

namespace Main
{
 class Tester
 {
        public static void Main()
        {
            // ��� ����, ����� �� ���� ��������� ������������ ������������ ����!
            A.DateClass obj1 = new A.DateClass();
            obj1.PrintDate();
            B.DateClass obj2 = new B.DateClass();
            obj2.PrintDate();

            Console.ReadKey();
        }
    }
}

