using System;
// �������� ���������� ������������ ����
using My = Common.IT.NameSpaceseExample;
using my = Common.IT.NameSpaceseExample;
namespace Main
    {
        class Program
        {
            static void Main()
            {

                // ������ � ������ ����� ���������
                my.MyClass obj1 = new my.MyClass();
                obj1.Print();
                
                // ������ � ������ ����� ���������, ����� ���������� 
                // ����� � ����� �� ������ (����� My)
                My::MyClass obj2 = new My::MyClass();
                obj2.Print();

               
                My obj3 = new My();
                obj3.Print();
                
                Console.ReadKey();
                
            }
        }

        class My
        {
            public void Print()
            {
                Console.WriteLine("MyClass");
            }
        }
    }
 


