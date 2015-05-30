
using System;

namespace OverloadingIndexators
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Перегрузка индексатора");
			
			// Создание объекта класс MyArray
            MyArray arr = new MyArray(5); // размер массива 5
            arr[0] = 10; arr[1] = 20; arr[2] = 30; arr[3] = 40; arr[4] = 50;
            		
		
			Console.WriteLine(" Индексация дробными числами!");
			for(double i=-2.2; i<6.7;i=i+0.3)
			{
                // работа с объектам класса через индексатор
			    Console.WriteLine("Значение arr[{0,3}]={1,3}",i, arr[i]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class MyArray
	{
		int [] Mass;  // объявление массива 
		public MyArray(int N)
		{
		 Mass=new int[N];  
		}
		// создание индексатора 
		public int this[int index]
		{
			get
			{   // если индекс в пределах индексации массива Mass
				// то возвращаем значение элемента массива 
				if(0<=index && index<Mass.Length)
				{
					return Mass[index];
				}
				else
				{ // если индекс не в пределах индексации массива Mass
				  // то возвращаем -1
					return -1;
				}
			}
			set
			{   // если индекс в пределах индексации массива Mass
                // то устанавливаем значение элемента миссива Mass				
				if(0<=index && index<Mass.Length)
				{
					Mass[index]=value;
				}
				
			}
		}
		// Перегрузка индексатора 
		public int this[double index]
		{
			get
			{   // если индекс в пределах индексации массива Mass
				// то возвращаем значение элемента массива 
				int newInd=0;
				if((index - (int)index)<0.5)
					newInd=(int)index;
				else newInd=(int)index+1;
				if(0<=newInd && newInd<Mass.Length)
				{
					return Mass[newInd];
				}
				else
				{ // если индекс не в пределах индексации массива Mass
				  // то возвращаем -1
					return -1;
				}
			}
			set
			{   // если индекс в пределах индексации массива Mass
                // то устанавливаем значение элемента миссива Mass				
				int newInd=0;
				if((index - (int)index)<0.5)
					newInd=(int)index;
				else newInd=(int)index+1;
                if(0<=newInd && newInd<Mass.Length)
				{
					Mass[newInd]=value;
				}
				
			}
		}
		
	}
}