using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Привязаться к текущему рабочему каталогу.
            DirectoryInfo dirl = new DirectoryInfo(".");
            // Привязаться к C:\Windows, используя дословную строку.
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Windows");
            // Привязаться к несуществующему каталогу, затем создать его.
            DirectoryInfo dir3 = new DirectoryInfo(@"C:\MyCode\Testing");
            dir3.Create ();
            // Вывести информацию о каталоге.
            DirectoryInfo dir = new DirectoryInfo(@"C:\MyCode\Testing");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);// полное имя
            Console.WriteLine("Name: {0}", dir.Name);// имя каталога
            Console.WriteLine("Parent: {0}", dir.Parent);// родительский каталог
            Console.WriteLine("Creation: {0}", dir.CreationTime);// время создания
            Console.WriteLine("Attributes: {0}", dir.Attributes);// атрибуты
            Console.WriteLine("Root: {0}", dir.Root);// корневой каталог
            Console.WriteLine("***************************\n");
            DisplayImageFiles();
            ModifyAppDirectory();
            Console.ReadKey();
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            // Получить все файлы с расширением *.jpg.
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            // Сколько файлов найдено?
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
            // Вывести информацию о каждом файле.
            foreach (FileInfo f in imageFiles)
            {
               
                Console.WriteLine("***************************\n") ;
                Console.WriteLine("File name: {0}", f.Name);	  //	имя файла
                Console.WriteLine("File size: {0}", f.Length);	  //	размер
                Console.WriteLine("Creation: {0}", f.CreationTime); // время создания
                Console.WriteLine("Attributes: {0}", f.Attributes); // атрибуты
                Console.WriteLine("***************************\n") ;
                break;
            }
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            // Создать \MyFolder в каталоге приложения.
            dir.CreateSubdirectory("MyFolder");
            // Получить возвращенный объект DirectoryInfo.
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");
            // Выводит путь к ..\MyFolder2\Data.
            Console.WriteLine("New Folder is: {0}", myDataFolder);

        }

    }
}
