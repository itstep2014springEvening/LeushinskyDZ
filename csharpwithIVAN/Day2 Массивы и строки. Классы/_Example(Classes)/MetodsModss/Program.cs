using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodsModss
{
    class Program
    {  
        // МОДИФИКАТОР REF

    static void Main(string[] args)
    {
        string str1 = "Первый ";
        string str2 = "Второй ";
        Console.WriteLine("До вызова метода: {0}, {1} ", str1, str2);
        Metod(ref str1, ref str2);
        Console.WriteLine("После вызова метода: {0}, {1} ", str1, str2);
        Console.ReadKey();
    }
    // передача значений s1 и s2  по ссылке 
    static void Metod(ref string s1, ref string s2)
    {
        string tempStr = s1;
        s1 = s2;
        s2 = tempStr;
    }

       


    }
}
