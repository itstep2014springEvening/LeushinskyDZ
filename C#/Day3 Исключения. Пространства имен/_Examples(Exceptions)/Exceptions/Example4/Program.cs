
using System;

namespace Example4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Перехват исключений конктерного типа");
			do
             {
                try
                  {
                    Console.Write("Введите число :  ");
                   
                    string s = Console.ReadLine();
                   
                    int n = Convert.ToInt32(s);

                    if (n <= 0)
                    {   //генерируется исключение ArgumentOutOfRangeException
                        // "n <= 0" - сообщение, которое выведется при исключении
                        throw new ArgumentOutOfRangeException("n <= 0");
                    }
                    double f = Math.Log(n);
                    int d = 100 / (int)f;
                    Console.WriteLine("d = {0} f = {1}", d, f);

                    Console.Write("Продолжить (1-да/0-нет):  ");
                    string exit = Console.ReadLine();
                    if (exit == "1") break;
                }
                  catch (FormatException)
                  {  //происходит, если введенное пользователем значение
                     //невозможно  преобразовать  в целое число
                     Console.WriteLine("FormatException");
                  }
                  catch (DivideByZeroException)
                  {
                      //происходит, если  Log(1) = 0  - 100/0 Деление на ноль
                      Console.WriteLine("DivideByZeroException");
                  }
                  catch (Exception e)
                  {
                     // прехват всех  остальных  исключений
                     // например,  исключения  ArgumentOutOfRangeException,
                     // которое  генерируется, если Log(n) не   определен  (т.е. n <= 0)
                     Console.WriteLine("Exception: {0}", e.Message);            
                  }
              }
              while (true);
                			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}