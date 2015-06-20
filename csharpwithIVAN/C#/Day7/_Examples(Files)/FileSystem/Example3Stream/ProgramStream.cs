using System;

using System.IO;
using System.Text;


namespace Example3Stream
{
    class Program
    {
        // Демонстрационный пример 
        // работы с классами StreamWriter 
        // и StreamReader
        static void Main(string[] args)
        {
            // Получаем путь к файлу
            Console.WriteLine("Демонстрация StreamWriter и StreamReader");
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();
           
            // Создаем объект StreamWriter для записи строк в различных кодировках в файл.
            StreamWriter sw = new StreamWriter(filePath);
           
            // Получаем данные для записи в файл
            Console.WriteLine("Введите строку для записи в файл:");
            string writeText = Console.ReadLine();
            
            // Запишем данные в поток
            sw.Write(writeText);
                      
            // Сохраним данные из буфера на диск и закроем поток
            sw.Dispose();

            // Теперь прочитаем данные из файла для этого используем StreamReader.
            StreamReader sr = new StreamReader(filePath);
           
            // Прочитаем данные 
            string readText = sr.ReadToEnd();
            
            // Закроем поток
            sr.Dispose();
            
            
            // Выведем их на консоль
            Console.WriteLine("Данные, прочитанные из файла: {0}", readText);
            Console.Read();
        }
    }
}
