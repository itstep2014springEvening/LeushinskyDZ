using System;
using System.IO;
using System.Text;

namespace Example5
{
    class ProgramDirectory
    {

        // ссылки на MSDN 
        // класс Directory       http://msdn.microsoft.com/ru-ru/library/system.io.directory(v=vs.110).aspx
        // класс DirectoryInfo   http://msdn.microsoft.com/ru-ru/library/system.io.directoryinfo(v=vs.110).aspx
        // класс File            http://msdn.microsoft.com/ru-ru/library/System.IO.File(v=vs.110).aspx
        // класс FileInfo        http://msdn.microsoft.com/ru-ru/library/system.io.fileinfo(v=vs.110).aspx
        // класс Path            http://msdn.microsoft.com/ru-ru/library/system.io.path(v=vs.110).aspx

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы с классами:Directory,DirectoryInfo, File, FileInfo, Path");
            
           // 
            string pathDir = @"D:\test";
            Console.WriteLine(" - - Создание каталога");
            //создание каталога (папки) по указанному пути
            Directory.CreateDirectory(pathDir);  
            
            if(Directory.Exists(pathDir))  // проверка на наличие каталога!
                Console.WriteLine("Каталог успешно создан!");
           
            Console.WriteLine(" - - Информация о каталоге");
            // получение детальной информации о данном каталоге (папке) 
            DirectoryInfo dir = new DirectoryInfo(pathDir);
            Console.WriteLine("Полный путь: {0}\nНазвание папки: {1}\nРодительский каталог: {2}\n" +
                              "Время создания: {3}\nАтрибуты: {4}\nКорневой каталог: {5}",
                               dir.FullName, 
                               dir.Name, 
                               dir.Parent, 
                               dir.CreationTime, 
                               dir.Attributes, 
                               dir.Root);

            Console.WriteLine(" - - Создание подкаталогов");
            // создание подкаталога "папка 1" в каталоге dir
             DirectoryInfo subDir1 = dir.CreateSubdirectory("папка 1");
             Console.WriteLine("Полный путь к папке 1: {0}", subDir1.FullName);
             // создание подкаталога "папка 2" в каталоге dir
             DirectoryInfo subDir2 = dir.CreateSubdirectory("папка 2");
             Console.WriteLine("Полный путь к папке 2: {0}", subDir2.FullName);
            
             // создание подкаталога "папка 21" в каталоге subDir2
             DirectoryInfo subDir21=subDir2.CreateSubdirectory("папка 21");
             Console.WriteLine("Полный путь к папке 21: {0}", subDir21.FullName);
             Console.WriteLine();

             // создание пути к файлу pathFile с использованием класса Path
             string pathFile = Path.Combine(subDir1.FullName,"файл.txt");
                         
            // создание файла в каталоге и запись в него строки текста
            Console.WriteLine(" - - Создание нового файла"); 
            FileStream fs=File.Create(pathFile);
              fs.Write(Encoding.Default.GetBytes("Создание нового файла"), 0, Encoding.Default.GetBytes("Создание нового файла").Length);
              fs.Close();
             
            // получение детальной ифнормации о созданном файле 
             Console.WriteLine(" - - Детальная информация о новом файле"); 
             FileInfo file = new FileInfo(pathFile);
             Console.WriteLine("Полный путь к файлу: {0}\nНазвание файла: {1}\nКаталог: {2}\n" +
                              "Расширение: {3}\nВремя создания: {4}\nВремя доступа: {5}\nВремя записи: {6}\nРазмер: {7}",
                               file.FullName,
                               file.Name,
                               file.Directory,
                               file.Extension,
                               file.CreationTime,
                               file.LastAccessTime,
                               file.LastWriteTime, 
                               file.Length
                               );
             

            // копирование фалов в каталог D:\test\папка 2\папка 21 
             // файлы "Koala.jpg", "Lighthouse.jpg", "Text document.txt" находятся внутри проекта 
             // true - для перезапси файлов, если они существуют!
             File.Copy("Koala.jpg", subDir21.FullName + "\\Koala.jpg",true);
             File.Copy("Lighthouse.jpg", subDir21.FullName + "\\Lighthouse.jpg", true);
             File.Copy("Text document.txt", subDir21.FullName + "\\Text document.txt", true);
             Console.WriteLine();

             // получение списка файлов в каталоге D:\test\папка 2\папка 21 
            Console.WriteLine(" - - Список файлов в каталоге");
            string[] files = Directory.GetFiles(subDir21.FullName);
            foreach (string s in files)
              {  // вывод инвормации о файлах в в каталоге D:\test\папка 2\папка 21
                  FileInfo f = new FileInfo(s);
                  Console.WriteLine("Название файла: {0}", f.Name);
              }

             // получение списка файлов в каталоге D:\test\папка 2\папка 21 c указание расширения
             Console.WriteLine(" - - Список файлов с расширением .txt в каталоге");
            string[] filesExt = Directory.GetFiles(subDir21.FullName, "*.txt");
             foreach (string s in filesExt)
             {  // вывод инвормации о файлах в в каталоге D:\test\папка 2\папка 21
                 FileInfo f = new FileInfo(s);
                 Console.WriteLine("Название файла (расширение): {0}", f.Name);
             }

             Console.WriteLine();

            // копирование файла 
             Console.WriteLine(" - - Копирование файла");
            string newFilePath=Path.Combine(subDir21.FullName, "новый файл.txt");
            FileInfo fileCopy = new FileInfo(pathFile); 
            // копирование файла в каталог с новым именем 
            // true- перезапись существующего!
            fileCopy.CopyTo(newFilePath, true);  

            if (File.Exists(newFilePath))  // проверка на наличие файла!
               Console.WriteLine("Файл успешно скопирован!");
            else Console.WriteLine("Файл не скопирован!");

            Console.WriteLine();
            // удаление файла 
            File.Delete(newFilePath);
            if (File.Exists(newFilePath))  // проверка на наличие файла!
                Console.WriteLine("Файл не удален!");
            else Console.WriteLine("Файл удален!");

            Console.WriteLine();
           
            // удаление каталога (папки),  true- вложенные каталоги и файлы удалить!
            // для удаления каталога раскомментируйте строку!
            /* 
             Directory.Delete(pathDir, true);
            */

            if (Directory.Exists(pathDir))  // проверка на наличие каталога!
                Console.WriteLine("Каталог не удален!");
            else Console.WriteLine("Каталог удален!");

            Console.ReadKey();
        }
    }
}
