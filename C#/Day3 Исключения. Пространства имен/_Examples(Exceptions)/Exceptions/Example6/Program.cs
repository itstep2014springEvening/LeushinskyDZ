using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вложенные try-catch");

try  
{
    Console.WriteLine("Блок try  до генерации исключения");
    try
    {
        Console.WriteLine(" ---- Влож. блок try  до генерации исключения");
        Console.WriteLine("Генерировать исключение: ");
        Console.WriteLine("1 - IndexOutOfRangeException");
        Console.WriteLine("2 - DivideByZeroException");
        Console.Write("другое - нет исключения! Введите число: ");
        switch (Console.ReadLine())
        {
            case "1": throw new IndexOutOfRangeException(); break;
            case "2": throw new DivideByZeroException(); break;
            default: Console.WriteLine("Нет генерации исключений"); break;
        }
        Console.WriteLine(" ---- Влож. блок try  - конец");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(" ---- Влож. блок catch ");
    }
    finally
    {
        Console.WriteLine(" ---- Влож. блок finally ");
    }
    Console.WriteLine("Блок try  - конец");
}
catch (Exception ex) 
{
    Console.WriteLine("Блок catch ");
}
finally
{   
    Console.WriteLine("Блок finally ");
}
            Console.WriteLine("В конце блока try-catch ");
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
