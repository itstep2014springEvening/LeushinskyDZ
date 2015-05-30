using System;
// Создание псевдонима пространства имен
using My = Common.IT.NameSpaceseExample;
using my = Common.IT.NameSpaceseExample;
namespace Main
    {
        class Program
        {
            static void Main()
            {

                // Доступ к классу через псевдоним
                my.MyClass obj1 = new my.MyClass();
                obj1.Print();
                
                // Доступ к классу через псевдоним, когда существует 
                // класс с таким же именем (класс My)
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
 


