using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GetProcesses_example3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Processes List";
            Console.WindowWidth = 40;
            Console.BufferWidth = 40;
            Process[] processesList = Process.GetProcesses();
            Console.WriteLine("  {0,-28}{1,-10}","ProcessName:", "PID:");
            foreach (Process p in processesList)
            {
                Console.Write("  {0,-28}{1,-10}",p.ProcessName,p.Id);
            }
            Console.Read();
        }
    }
}
