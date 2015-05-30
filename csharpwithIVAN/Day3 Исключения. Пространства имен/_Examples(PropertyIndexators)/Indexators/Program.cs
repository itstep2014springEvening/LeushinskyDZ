
using System;

namespace Indexators
{
	class Program
	{
            public static void Main(string[] args)
            {
                Console.WriteLine("Индексаторы");
                // Создание объекта класс MyArray
                MyArray arr=new MyArray(5); // размер массива 5
                Random rnd=new Random();
                Console.WriteLine(" в этом цикле выхода за границы массива нет");
                for(int i=0; i<5;i++)
                {// работа с объектам класса через индексатор
	                arr[i]=rnd.Next(0,50);
	                Console.WriteLine("Значение arr[{0,2}]={1,2}",i, arr[i]);
                }
			
                Console.WriteLine(" в этом цикле имеется выход за границы массива");
                for(int i=-2; i<8;i++)
                {// работа с объектам класса через индексатор
	                arr[i]=rnd.Next(0,50);
	                Console.WriteLine("Значение arr[{0,2}]={1,2}",i, arr[i]);
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
		
		
	}

}