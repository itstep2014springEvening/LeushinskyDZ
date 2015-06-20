using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSpecDirs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы со специальными каталогами");
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.History));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            Console.ReadKey();
        }
    }
}
