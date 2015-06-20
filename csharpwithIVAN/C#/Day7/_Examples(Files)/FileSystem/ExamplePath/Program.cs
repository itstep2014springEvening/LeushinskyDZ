using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы с классом Path");

            string dir = @"c:\mydir";
            string file = "myfile.txt";
            string path = @"c:\mydir\myfile.txt";
           

            Console.WriteLine(Path.GetPathRoot (path));      // главный каталог
            Console.WriteLine(Path.GetDirectoryName (path)); // каталог 
            Console.WriteLine(Path.GetFileName (path));      // имя файла
            Console.WriteLine(Path.GetFullPath (file));      // полный путь
            Console.WriteLine(Path.Combine(dir, file));      // соединить путь и имя файла

            // работа  с расширениями

            Console.WriteLine(Path.HasExtension (file));                // True
            Console.WriteLine(Path.GetExtension (file));                // .txt
            Console.WriteLine(Path.GetFileNameWithoutExtension (file)); // myfile
            Console.WriteLine(Path.ChangeExtension (file, ".log"));     // myfile.Iog

            // Разделители и символы:
            Console.WriteLine(Path.AltDirectorySeparatorChar);          // разделитель в пути
            Console.WriteLine(Path.VolumeSeparatorChar);                // разделитель при указании диска
            Console.WriteLine(Path.GetInvalidPathChars());              // запрещенные символы в пути
            Console.WriteLine(Path.GetInvalidFileNameChars());          // запрещенные символы в названии файла

                //Временные файлы
            Console.WriteLine(Path.GetTempPath());        // каталог временных файлов
            Console.WriteLine(Path.GetRandomFileName());  // случайное имя файла
            Console.WriteLine(Path.GetTempFileName());    // случайный временный файл 
            


            Console.ReadKey();
        }
    }
}
