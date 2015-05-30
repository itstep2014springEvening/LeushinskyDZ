using System;


// подключение пространств имен! 
using A;   
using B;  


// для использования класс в другом пространстве имен 
// его необходимо подключить с ипользованием using
// !!! даже если оно находится  в текущем файле!


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
        {   // Для использования классов ClassA1 и ClassA2 в пространстве имен В
            // необходимо подключить пространство имен А 
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
        {   // Для использования класса ClassB в пространстве имен А
            // необходимо подключить пространство имен B (см. вверху)
            ClassB B = new ClassB();
            B.Print();
        }
    }
}
