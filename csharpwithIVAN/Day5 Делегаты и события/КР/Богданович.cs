using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        class Flower
        {
            private decimal cost;

            public decimal getCost()
            {
                return cost;
            }

        }


        class Rose : Flower
        {

            private decimal cost;

            public Rose()
            {
                cost = 0;
            }

           public Rose(decimal i)
           {
               cost = i;
           }


            public decimal override getCost()
            {
                return cost;
            }


        }


        class Tulip : Flower
        {

            private decimal cost;


            public Tulip()
            {
                cost = 0;
            }
            public Tulip(decimal i)
           {
               cost = i;
           }

            public decimal override getCost()
            {
                return cost;
            }



        }
        static void Main(string[] args)
        {

            Rose rose = new Rose(10);

            Tulip tulip = new Tulip(15);

            decimal prise;


            Flower[] bouquet = new Flower(10);

           for(int i = 0; i<5; i++)
           {
               Flower[i] = new Rose(10);
           }

            

            for(int i = 5; i<10; i++)
            {
                Flower[i] = new Tulip(15);
            }



            foreach(Flower A in bouquet)
            {
                prise += A.getCost();
            }
        }
    }
}
