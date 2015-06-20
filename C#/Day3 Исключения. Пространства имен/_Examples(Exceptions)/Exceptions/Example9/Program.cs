using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new OverflowException();
            }
            catch(DivideByZeroException)
            {
            }

            Console.ReadKey();
        }
    }
}
