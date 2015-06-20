using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] myTasks = {  "Выучить C#", "Выучить ADO.NET",
                                  "Выучить WPF", "Выучить ASP.NET"};
            // Записать все данные в файл на диске С: .
            File.WriteAllLines(@"tasks.txt", myTasks);

            // Прочитать все данные и вывести на консоль.
            foreach (string task in File.ReadAllLines(@"tasks.txt"))
            {
                Console.WriteLine("Выполнено: {0}", task);
            }
            Console.ReadLine();



        }
    }
}
