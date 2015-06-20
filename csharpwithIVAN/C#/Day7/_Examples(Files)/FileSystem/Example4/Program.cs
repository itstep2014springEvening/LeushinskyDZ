using System;
using System.IO;

namespace BinaryWriterReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем путь к файлу
            string filePath = "test.txt";
            using (FileStream fs =  new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                // Создаем объект BinaryWriter для  записи простых типов данных в поток.
                BinaryWriter bw = new BinaryWriter(fs);
                
                // Получаем данные для записи в файл
                Console.WriteLine("Введите строку для записи в файл:");
                string writeText = Console.ReadLine();
                
                int writeNum = -1;
                Console.WriteLine("Введите целое число для записи в файл:");
                Int32.TryParse(Console.ReadLine(), out writeNum);

                double writeNumD = -1;
                Console.WriteLine("Введите дробное число для записи в файл:");
                Double.TryParse(Console.ReadLine(), out writeNumD);

                // Запишем данные в поток
                bw.Write(writeText);
                bw.Write(writeNum);
                bw.Write(writeNumD);
               
                // Сохраним данные из буфера на диск
                bw.Flush();
                
                // Установим курсор на начало файла
                bw.Seek(0, SeekOrigin.Begin);

                
                // Теперь прочитаем данные из файла для этого используем BinaryReader.
                BinaryReader br = new BinaryReader(fs);
                
                // Данные читать нужно в том же порядке, в котором они и записывались в поток
                Console.WriteLine("Строка, прочитанная из файла:");
                Console.WriteLine(br.ReadString());
                Console.WriteLine("Целое число, прочитанное из файла:");
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine("Дробное число, прочитанное из файла:");
                Console.WriteLine(br.ReadDouble());

            }
            Console.Read();
        }
    }
}

