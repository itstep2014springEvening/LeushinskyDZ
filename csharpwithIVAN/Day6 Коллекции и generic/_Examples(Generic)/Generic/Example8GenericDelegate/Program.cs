
using System;

namespace Example8GenericDelegate
{
		
	// Этот обобщенный делегат может вызвать любой метод, 
    // возвращающий void и принимающий один параметр. 
    public delegate void MyGenericDelegate<T>(T arg); 

    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Обобщенный делегат");

           
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget); 
            strTarget("Некоторые строковые данные");

             
            MyGenericDelegate<int> intTarget = IntTarget; 
            intTarget(9); 
            
           Console.ReadKey(true);
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg в верхнем регистре: {0}", 
                arg.ToUpper()); 
        }

        static void IntTarget(int arg) 
        {
            Console.WriteLine("++arg: {0}", ++arg);
        }
    }
}