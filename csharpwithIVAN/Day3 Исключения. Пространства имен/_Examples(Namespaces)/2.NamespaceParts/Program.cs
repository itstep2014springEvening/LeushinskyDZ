using System;


// ����������� ����������� ����! 
using A;   
using B;  


// ��� ������������� ����� � ������ ������������ ���� 
// ��� ���������� ���������� � ������������� using
// !!! ���� ���� ��� ���������  � ������� �����!


namespace A
{
    class ClassA1
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassA1");
        }
    }
}

namespace B
{
    public class ClassBMain
    {
        public static void Main()
        {   // ��� ������������� ������� ClassA1 � ClassA2 � ������������ ���� �
            // ���������� ���������� ������������ ���� � 
            ClassA1 b = new ClassA1();
            b.Print();
            ClassA2 c = new ClassA2();
            c.Print();
            c.TestClassB();
           
            Console.ReadLine();
        }
    }

    class ClassB
    {
        public void Print()
        {
            Console.WriteLine("Printing from B.ClassB");
        }
    }

}
namespace A
{
    class ClassA2
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassA2");
        }

        public void TestClassB()
        {   // ��� ������������� ������ ClassB � ������������ ���� �
            // ���������� ���������� ������������ ���� B (��. ������)
            ClassB B = new ClassB();
            B.Print();
        }
    }
}
