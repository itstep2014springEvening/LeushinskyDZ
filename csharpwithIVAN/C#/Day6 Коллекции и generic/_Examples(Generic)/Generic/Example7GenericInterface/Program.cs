
using System;

namespace Example7GenericInterface
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Обобщенный интерфейс");
		
			 BasicMath m = new BasicMath();
             Console.WriteLine("1 + 1 = {0}", m.Add(1, 1));
		
			Console.ReadKey(true);
		}
	}
	
	  // Реализация обобщенного интерфейса в классе BasicMath
   class BasicMath : IBinaryOperations<int>
     {
      public int Add(int arg1, int arg2) 
       { return arg1 + arg2; }

      public int Subtract(int arg1, int arg2) 
       { return arg1 - arg2; }

      public int Multiply(int arg1, int arg2) 
       { return arg1 * arg2; }

      public int Divide(int arg1, int arg2) 
       { return arg1 / arg2; } 
    }
	
   // создание обобщенного интерфейса для бинарных операций!
	public interface IBinaryOperations<T>
    {
      T Add(T arg1, T arg2);
      T Subtract(T arg1, T arg2);
      T Multiply(T arg1, T arg2);
      T Divide(T arg1, T arg2); 
    }
}