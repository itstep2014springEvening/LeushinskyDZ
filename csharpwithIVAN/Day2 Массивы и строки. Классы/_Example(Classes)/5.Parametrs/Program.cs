using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parametrs
{
    class Program
    {
        static void Main(string[] args)
        {
  Console.WriteLine("Передача значимого и ссылочного типа по значению" +
                              "без пересоздания ссылочной переменной");
            int i = 0;
            int[] myArr = { 0, 1, 2, 4 };
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("MyArr[0] = {0}", myArr[0]);
            Console.WriteLine("Вызов MyFunction");

            // передаем по значению: i содержит 0, myArr содержит адрес!
            MyFunctionByVal1(i, myArr);
            
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("MyArr[0] = {0}", myArr[0]);


  Console.WriteLine("\n\nПередача значимого и ссылочного типа по значению" +
                                  "с пересозданием ссылочной переменной");
            i = 10;
            myArr = new int[]{ 1, 2, 3 };
            Console.WriteLine("Внутри метода Main до передачи в метод " +"MyFunction i = {0}", i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            // передаем по значению: i содержит 10, myArr содержит адрес!
            MyFunctionByVal2(i, myArr);
           
            Console.WriteLine("Внутри метода Main после передачи в метод " +"MyFunction i = {0}", i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");


  Console.WriteLine("\n\nПередача значимого и ссылочного типа по ссылке");
            i = 10;
            myArr = new int[]{ 1, 2, 3 };
            Console.WriteLine("Внутри метода Main до передачи в метод " + "MyFunction i = {0}", i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            // передаем по ссылке
            MyFunctionByRef(ref i, ref myArr);
            
            Console.WriteLine("Внутри метода Main после передачи в метод " + "MyFunction i = {0}", i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            Console.ReadKey();
        }

        static void MyFunctionByVal1(int i, int[] MyArr)
        {
             // т.к. передали по значению число, то здесь создается копия этого числа 
            i = 100;
            //  т.к. передали по значению адрес, то здесь создается копия этого адреса 
            // следовательно меняется значение элемента массива по адресу массива в памяти
            MyArr[0] = 100;
           
        }

        static void MyFunctionByVal2(int i, int[] myArr)
        {
            Console.WriteLine("Внутри функции MyFunction до изменения i = {0}", i); 
            Console.Write("MyArr { ");
            foreach (int val in myArr)
      	        Console.Write(val + " ");
            Console.WriteLine("}");
            
            // т.к. передали по значению число, то здесь создается копия этого числа 
            i = 100;
            //  т.к. передали по значению адрес, то здесь создается копия этого адреса 
            //  следовательно меняется значение адреса массива, а не элементы по адресу 
            myArr = new int[] { 3, 2, 1 };
                     
            Console.WriteLine("Внутри функции MyFunction после изменения i ={0}", i); 
            Console.Write("MyArr { ");
            foreach (int val in myArr)
      	        Console.Write(val + " ");
            Console.WriteLine("}");
        }
        
        static void MyFunctionByRef(ref int i, ref int[] myArr)
        {
            Console.WriteLine("Внутри функции MyFunction до изменения i = "+"{0}", i); 
            Console.Write("MyArr { ");
            foreach (int val in myArr)
      	        Console.Write(val + " ");
            Console.WriteLine("}");
            //  т.к. передали по по ссылке, то здесь не создаются копии 
            //  а используются адреса перменных 
            i = 100;
            myArr = new int[] { 3, 2, 1 };
            
            Console.WriteLine("Внутри функции MyFunction после изменения i ="+"{0}", i); 
            Console.Write("MyArr { ");
            foreach (int val in myArr)
      	        Console.Write(val + " ");
            Console.WriteLine("}");
        }

    }
}
