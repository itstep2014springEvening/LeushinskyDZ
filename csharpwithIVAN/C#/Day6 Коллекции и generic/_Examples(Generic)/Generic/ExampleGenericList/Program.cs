
using System;
using System.Collections.Generic;

namespace ExampleGenericList
{
	class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Обобщенные коллекции!");
           
            // создание обобщенной коллекции List
            List<int> listInt=new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) 
                listInt.Add(rnd.Next(100));
            
            Console.WriteLine("Int collection: ");
            //при обращении к элементам коллекции возвращается резульат тип int
            foreach (int i in listInt)
                Console.Write("{0} ", i);
            Console.WriteLine();

            List<Car> listCars=new List<Car>() {new Car {Name="BMW", Type="X6", Speed=250}};
            listCars.Add(new Car{Name="Ford", Type="Focus", Speed=195});
			
            Console.WriteLine("Car collection: ");
            //при обращении к элементам коллекции возвращается резульат тип int
            foreach (Car i in listCars)
                Console.Write("{0}\n", i);
            Console.WriteLine();
            
            Console.ReadKey();
		}
	}
	
	class Car
    {
		public string Type {get; set;}    // тип 
        public string Name {get; set;}    // название 
        public double Speed {get; set;}   // скорость 

        public override string ToString()
        {
            return String.Format("{1} {0}, скорость: {2}", Type, Name, Speed);
        }
    }
}