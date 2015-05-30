using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Test1()
        {
            try
            {
                Console.WriteLine(" * * * Генерация исключения  IndexOutOfRangeException");
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(" * * * Обработка исключения  IndexOutOfRangeException");
                // повторная генерация исключения (исключения типа IndexOutOfRangeException)
                // для обработки catch более высокого уровня!
                throw;
            }
          
        }
        static void Test2()
        {
            try
            {
                Console.WriteLine(" * * * Генерация исключения  IndexOutOfRangeException");
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(" * * * Обработка исключения  IndexOutOfRangeException");
                // повторная генерация исключения типа DivideByZeroException
                throw new DivideByZeroException("Деление на ноль");  
            }

        }


static void Main(string[] args)
{
    Console.WriteLine("Повторная генерация исключений");
    try
    {
        Test1();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {

        Test2();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }



    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
}
    }
}
