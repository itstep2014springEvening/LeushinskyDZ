using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class ProgramLazy
    {
        static void Main(string[] args)
        {
        }
    }

    class Car 
    {
       public int  Num { get; set; }
       public  string Name { get; set; }
    }

    class AvtoPark
    {
        Car[] cars = new Car[1000];
        public Car[] Cars
        {
            get { return cars; }
        }
    }
}
