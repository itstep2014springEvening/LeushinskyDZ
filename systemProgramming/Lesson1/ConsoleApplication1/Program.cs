using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process mProcess = new Process {StartInfo = new ProcessStartInfo("notepad.exe")};
            mProcess.Start();
            Console.WriteLine("Process " + mProcess.ProcessName + " started");
            mProcess.WaitForExit();
            Console.WriteLine("Process ends with code " + mProcess.ExitCode);
            Console.WriteLine("Current process name is: " + Process.GetCurrentProcess().ProcessName);
            Console.Read();
        }
    }
}
