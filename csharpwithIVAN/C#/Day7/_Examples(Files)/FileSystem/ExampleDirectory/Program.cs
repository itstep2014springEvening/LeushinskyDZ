using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести список всех дисковых устройств текущего компьютера.
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Список дисков:");
            foreach (string s in drives)
                Console.WriteLine("—> {0} ", s);
            // Удалить то, что было ранее создано.
            Console.WriteLine("Нажмите Enter для удаления каталогов");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"С:\MyFolder");
                // Второй параметр указывает, нужно ли удалять подкаталоги.
                Directory.Delete(@"С:\MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string dirPath = @"C:\Users\Student\Documents";
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("Каталог {0} не существует", dirPath);
                return;
            }
            // получить все подкаталоги в выбранном каталоге.
            string[] subDirs = Directory.GetDirectories(dirPath);
            foreach (string dir in subDirs)
            {
                // Вывести имя каталога
                Console.WriteLine("{0} содержит файлы:", dir);
                // получить все файлы в каталоге.
                string[] files = Directory.GetFiles(dir);
                foreach (string file in files)
                {
                    // вывести имя файла.
                    Console.WriteLine(file);
                }
            }


        }
    }
}
