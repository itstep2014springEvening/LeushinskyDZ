using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Итераторы");
            Console.WriteLine("Простейший итератор");
            
            TestIterator mc = new TestIterator(5);
            foreach (int i in mc.NumColl(0))
                Console.Write("{0} ", i);

            Console.WriteLine("\nПример  CarPark");

            CarPark parkCars = new CarPark();
            parkCars.AddCar(new Car { Num = 1, Name = "BMV"});
            parkCars.AddCar(new Car { Num = 2, Name = "Ford" });
            parkCars.AddCar(new Car { Num = 3, Name = "Audi" });
            parkCars.AddCar(new Car { Num = 4, Name = "Opel" });
            parkCars.AddCar(new Car { Num = 5, Name = "Fiat" });
            parkCars.AddCar(new Car { Num = 6, Name = "Volvo" });

            foreach (Car car in parkCars.NumColl(3,5))
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
    // Создание класса, реализующего итератор!
    class TestIterator
    {
        int last = 0;
        public TestIterator(int last) 
        { this.last = last; 
        }

        public IEnumerable NumColl(int beg)
        {
            for (int i = beg; i <= last; i++)
                yield return 2 * i + 1;
        }
    }


    class Car
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return String.Format("{0}.{1}", Num, Name);
        }
    }

    class CarPark
    {
        ArrayList park = new ArrayList();

        public void AddCar(Car newCar)
        {
            park.Add(newCar);
        }
        public IEnumerable NumColl(int NumSt, int NumEnd)
        {
           for (int i = 0; i < park.Count; i++)
            {
                if (NumSt <= ((Car)park[i]).Num 
                         && NumEnd >= ((Car)park[i]).Num)
                yield return park[i];
            }
        }

    
    }
}
