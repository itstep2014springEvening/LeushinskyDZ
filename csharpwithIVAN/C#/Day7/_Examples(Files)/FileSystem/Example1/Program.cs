using System;

using System.IO;
using System.Text;  // простраство имен 


namespace Example1FileStream
{
    class Program
    {
        // Демонстрационный пример 
        // работы с классом FileStream
        static void Main(string[] args)
        {
            // Вводим путь к файлу
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();
            
// Создаем объект FileStream - 
// FileMode (перечисление) 
    //  Create - Создает новый файл, если файл уже существует, то он, будет переписан. Курсор устанавливается на начало файла.
    //  Open   - Открывает существующий файл, если файла не существует, то будет вызвано исключение FileNotFoundException. Курсор устанавливается на начало файла.
    //  CreateNew   - Создает новый файл, если файл уже существует, то будет вызвано исключение IOException. Курсор устанавливается на начало файла.
    //  OpenOrCreate   - Открывает существующий файл, если файла не существует, то будет создан новый файл. Курсор устанавливается на начало файла.
    //  Truncate   - Открывает существующий файл и усекает его размер до нуля
    //  Append - Открывает файл, если он существует, и перемещает курсор в конец файл. Если файл не существует – создает новый файл.FileMode.Append можно использовать только вместе с FileAccess.Write.
           
//  FileAccess (перечисление)
    // запись Write 
    // чтение Read
    // запись и чтение ReadWrite
           
           
// Использование блока using позволяет правильно сакрыть поток FileStream
using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
{
    // Получаем данные для записи в файл
    Console.WriteLine("Введите строку для записи в файл:");
    string writeText = Console.ReadLine();
                
    // Преобразуем строку в массив байт,
    // т.к. FileStream умеет работать только с байтами
    byte[] writeBytes = Encoding.UTF8.GetBytes(writeText);
                                
    // Запишем данные в файл
                
    fs.Write(writeBytes, 0, writeBytes.Length);
    // 0 - Смещение байтов (начиная с нуля) в array, с которого начинается копирование байтов в поток. 
                
    // Сохраним данные из буфера на диск
    fs.Flush();
                
    // Теперь прочитаем данные из файла
    // для этого нужно сначала установить курсор 
    // на начало файла
    fs.Seek(0, SeekOrigin.Begin);
                
    // Теперь прочитаем данные в другой массив байт
    byte[] readBytes = new byte[(int)fs.Length];
    fs.Read(readBytes, 0, readBytes.Length);
                
    // Преобразуем байты в строку
    string readText = Encoding.UTF8.GetString(readBytes);
                
    // Выведем ее на консоль
    Console.WriteLine("Данные, прочитанные из файла: {0}", readText);
}
            Console.Read();
        }
    }
}
