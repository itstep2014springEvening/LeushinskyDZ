using System;
namespace IndexatorWithoutArr
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Пример индексатора без массива!");

            MyFactorial fact = new MyFactorial();
            Console.WriteLine("Fact[0]={0:N}", fact[0]); 
            Console.WriteLine("Fact[5]={0:N}",fact[5]); 
            Console.WriteLine("Fact[12]={0:N}", fact[12]);
            Console.WriteLine("Fact[30]={0:N}", fact[15]);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class MyFactorial
	{
       
		public MyFactorial()
		{
          
		}
		// создание индексатора (только для чтения)
		public double this[int Nmax]
		{
			get
			{
                double M = 1;
                for (int i = 1; i <= Nmax; i++)
                {
                    M = M * i;
                }
                return M;
			}
            
            //set
            //{   
			//     set или get  - могут отсутствовать!	
            //}
		}
		
		
	}
}