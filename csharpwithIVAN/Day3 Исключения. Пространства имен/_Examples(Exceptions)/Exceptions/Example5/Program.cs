using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 5");

            try  // Блок кода, где может произойти исключительная ситуация
            {
                Console.WriteLine("Блок try до генерации исключения");
                
                Console.Write("Генерировать исключение? (1-да/0-нет):");
                if (Console.ReadLine() == "1") 
                  throw new IndexOutOfRangeException();

                Console.WriteLine("Блок try после генерации исключения");
            }
            catch(Exception ) // Блок кода, который должен обратоботать исключительную ситуацию
            {
                Console.WriteLine("Блок catch ");
            }
            finally
            {   // Блок кода. который выполняется как приналичии исключения, так и без исключения!
                Console.WriteLine("Блок finally ");
            }
            Console.WriteLine("В конце блока try-catch ");
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
