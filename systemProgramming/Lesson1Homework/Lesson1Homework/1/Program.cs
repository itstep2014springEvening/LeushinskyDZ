using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int [] a = new int[33];

            for(int i =0;i<a.Length ;i++)
            {
                a[i] = r.Next(0, Int32.MaxValue);
            }

            ParameterizedThreadStart pts = new ParameterizedThreadStart(Transformation);
            Thread t = new Thread(pts);
            t.Start((object)a);

            Console.ReadLine();
        }

        public static void Transformation(object a)
        {
            foreach (var i in (int[])a)
            {
                i.ToString();
                Console.WriteLine(i);
            }
        }
    }
}
