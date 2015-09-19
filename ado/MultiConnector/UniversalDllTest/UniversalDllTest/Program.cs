using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using UniversalDll;

namespace UniversalDllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите запрос выборки:");
            string query = Console.ReadLine();
            MultiConnector multiconnector = new MultiConnector();
            Console.WriteLine(multiconnector.GetData(query));
        }
    }
}
