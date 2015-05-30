using System;

namespace Example1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Простое исключение");
			
			try  // Блок кода, где может произойти исключительная ситуация
			{
			int a=Int32.Parse(Console.ReadLine());     //введите вместо целого числа символ или строку!
			int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма чисел равна "+(a + b));
            }
			catch // Блок кода, который должен обратоботать исключительную ситуацию
			{
				Console.WriteLine("Проверьте тип введенных данных!");
			}
		   		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}