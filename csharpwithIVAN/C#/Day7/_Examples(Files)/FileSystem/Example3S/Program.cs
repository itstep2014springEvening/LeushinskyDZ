using System;
using System.IO;


namespace Example3S
{
    class Programm
    {
        // Демонстрационный пример 
        // работы с классами StreamWriter  и StreamReader
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация StreamWriter и StreamReader");
            
            // Устанавливаем путь к файлу
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            // Создаем объект StreamWriter для записи строк в различных кодировках в файл.
            StreamWriter sw = new StreamWriter(filePath);

            // Данные для записи в файл
          

            // Запишем данные  в поток по строчно!
            sw.WriteLine("Принципы ООП:");
            sw.WriteLine("1. Инкапсуляция");
            sw.WriteLine("2. Наследование");
            sw.WriteLine("3. Полиморфизм");

            // Сохраним данные из буфера на диск и закроем поток
            sw.Dispose();


            // Теперь прочитаем данные из файла для этого используем StreamReader.
            StreamReader sr = new StreamReader(filePath);
            string str;
            // Выведем данные на консоль (по строчно)
            for (int i = 0;  (str=sr.ReadLine()) != null; i++)
            {
                Console.WriteLine(str);
            }

          

               Console.Read();
        }
    }
}
