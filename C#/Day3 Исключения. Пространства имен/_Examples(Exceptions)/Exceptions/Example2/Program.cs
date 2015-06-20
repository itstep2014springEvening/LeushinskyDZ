
using System;

namespace Example2
{
	class Program
	{
		public static void Main(string[] args)
		{
            Console.Write("Преобразование типов с сокращенной записью try-catch ");
			int a=0;
            if (!Int32.TryParse(Console.ReadLine(), out a))  // сокращенная запись 
            {
                Console.Write("тип введенных данных!");
                return;
            }

            int b;
			Int32.TryParse(Console.ReadLine(),out b);
		    
			Console.WriteLine(a+b);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}