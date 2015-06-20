using System;
using System.IO;
using System.Text;
namespace ExampleFileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы с FileStream");
            // Вводим путь к файлу
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();
            
            Console.WriteLine( "- Создание файла для записи -");
            // создаем поток, который создает файл (FileMode.Create) для записи (FileAccess.Write) по адресу (filePath)
            FileStream fileWr = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            // выполняется проверка на возможность чтения из файла
            if (fileWr.CanRead) Console.WriteLine("Чтение возможно!");
            else Console.WriteLine("Чтение не возможно!");
            // выполняется проверка на возможность записи в файл
            if (fileWr.CanWrite) Console.WriteLine("Запись возможна!");
            else Console.WriteLine("Запись не возможна!");
            // выполняется конвертирование строки в массив байт т.к. FileStream работает только с байтами
            byte[] bytesWr = Encoding.Unicode.GetBytes("Демонстрация работы с FileStream");
            // выполняется запись в файл массива байтов (bytesWr) размерность bytesWr.Length, начиная с 0
            fileWr.Write(bytesWr, 0, bytesWr.Length);
            // выполняется закрытие потока (файла). Данные при этом сохраняются!
            fileWr.Close();
            
            Console.WriteLine("- Создание файла для чтения -");
            // открываем поток, который открывает файл (FileMode.Open) для чтения/записи (FileAccess.ReadWrite) по адресу (filePath)
            FileStream fileR = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
           
            // выполняется проверка на возможность чтения из файла
            if (fileR.CanRead) Console.WriteLine("Чтение возможно!");
            else Console.WriteLine("Чтение не возможно!");
            // выполняется проверка на возможность записи в файл
            if (fileR.CanWrite) Console.WriteLine("Запись возможна!");
            else Console.WriteLine("Запись не возможна!");
           
            // создается массив байтов, который будет считан из файла
            byte[]bytesR=new byte[fileR.Length];
            //  выполняется чтение из файла массива байтов (bytesR) размерность bytesR.Length, начиная с 0
            fileR.Read(bytesR, 0, bytesR.Length);
            
            Console.WriteLine("Информация из файла:");
            // выполняется конвертирование массива байт в строку
            Console.WriteLine(Encoding.Unicode.GetString(bytesR));
            
            // выполняется закрытие потока (файла). 
            fileR.Close();

            Console.ReadKey();
        }
    }
}
