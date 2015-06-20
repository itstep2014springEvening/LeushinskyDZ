using System;

namespace Example6GenericMetod
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Обобщенные методы!");
			
			// Обмен  двух значений
            int  a = 10, b = 90;
			Console.WriteLine("Перед: {0}, {1}", a, b); 
			MyClass.Swap<int>(ref a, ref b);
			Console.WriteLine("После: {0}, {1}", a, b); 
			Console.WriteLine();
			
			// Обмен  двух строк.
			string s1 = "Привет", s2 = "Пока"; 
			Console.WriteLine("Перед: {0} {1}!", s1, s2);
			MyClass.Swap(ref s1, ref s2);   // параметр типа можно не указывать!
			Console.WriteLine("После: {0} {1}!", s1, s2);

           


			Console.ReadKey(true);
		}
	}
	
	class MyClass
	{
		public static void Swap<T> (ref T a, ref T b)
        {
          Console.WriteLine("Передан в метод Swap() тип {0}", typeof(T)); 
          T temp;
          temp = a;
          a = b;
          b = temp;
        }
	}
	
	
	
}