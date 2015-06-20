using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();
            Random ran = new Random();

            for (int i = 0; i < 10; i++)
                al.Add(ran.Next(1, 20));

            // Используем перечислитель
            IEnumerator etr = al.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + "\t");

            Console.WriteLine("\nПовторный вызов перечислителя: \n");
            // Сбросим значение и вновь исользуем перечислитель
            // для доступа к коллекции
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + "\t");

       

            Console.ReadLine();
        }
    }
}
