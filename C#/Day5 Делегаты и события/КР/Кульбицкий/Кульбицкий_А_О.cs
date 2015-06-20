using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Vegetable[] vegetablesFoSalad = new Vegetable[5];
            vegetablesFoSalad[0] = new Korneplody(123);
            vegetablesFoSalad[1] = new Korneplody(123);
            vegetablesFoSalad[2] = new Korneplody(14253);
            vegetablesFoSalad[3] = new Plodovye(123);
            vegetablesFoSalad[4] = new Plodovye(123);

            double count = 0.0;
            for (int i = 0; i < vegetablesFoSalad.Length; ++i)
            {
                count += vegetablesFoSalad[i].Calority;
            }
            Console.WriteLine(count);

        }
    }

    abstract class Vegetable
    {
        protected double calority;
        protected string typeOfPlant;
        public double Calority
        {
            get
            {
                return calority;
            }
        }
        public Vegetable()
        {
            calority = 0.0;
            typeOfPlant = "vegetable";
        }
        public Vegetable(double calority)
        {
            this.calority = calority;
            this.typeOfPlant = "vegetable";
        }
    }
   
    class Korneplody:Vegetable
    {
        
        public Korneplody()
            : base()
        {
            typeOfPlant += " potato";
        }
        public Korneplody(double calority)
            : base(calority)
        {
            typeOfPlant += " potato";
        }

    }

    class Plodovye:Vegetable
    {
        
        public Plodovye()
            : base()
        {
            typeOfPlant += " plodovye";
        }
        public Plodovye(double calority)
            : base(calority)
        {
            typeOfPlant += " plodovye";
        }

    }

}
