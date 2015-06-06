
using System;

namespace Example3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Вывод сообщений об исключении");
			
			try  // Блок кода, где может произойти исключительная ситуация
			{
			int a=Int32.Parse(Console.ReadLine());  //введите вместо целого числа символ!
			int b=Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex) // перехват исключений любого характера
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                // Содержит   текст   сообщения   с   указанием  причины возникновения исключения
                Console.WriteLine(ex.Message);    	Console.WriteLine("-------------------------------------------");
                // Содержит имя сборки, сгенерировавшей исключение.
                Console.WriteLine(ex.Source);		Console.WriteLine("-------------------------------------------");
				// Содержит URL документа с описанием исключения
                Console.WriteLine(ex.HelpLink);		Console.WriteLine("-------------------------------------------");
				// Содержит имена и сигнатуры методов, вызов которых привел к возникновению исключения.
                Console.WriteLine(ex.StackTrace);	Console.WriteLine("-------------------------------------------");
                //Содержит метод, сгенерировавший исключение.
                Console.WriteLine(ex.TargetSite);	Console.WriteLine("-------------------------------------------");
			}
		   		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}