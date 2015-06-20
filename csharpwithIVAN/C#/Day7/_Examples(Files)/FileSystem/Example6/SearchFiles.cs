using System;
using System.IO;


namespace Example6
{
    class SearchFiles
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите название файла");
            // Создаем переменную fileName, в которую
            //запишем название файла, введеное пользователем.
            string fileName = Console.ReadLine();
            //Проверяем наличие файла в директории по умолчанию (bin/Debug)
            if (File.Exists(fileName))
            {
                //Если файл существует, выводим его содержимое.
                StreamReader stRead = new StreamReader(fileName);
                string A;
                A = stRead.ReadToEnd();
                stRead.Close();
                Console.WriteLine(A);
            }
            else
            {
                //Если файл не найден, выводим окно сообщения
                Console.WriteLine("Файл с указанным именем не существует. Сoздать его Y/N");
                //Считываем результат пользователя
                string strNoYes = Console.ReadLine();
                if ((strNoYes == "Y") || (strNoYes == "y"))
                {
                    //Создаем новый файл.
                    StreamWriter stWrite = new StreamWriter(fileName);
                    Console.WriteLine("Введите текст");
                    string text = Console.ReadLine();
                    stWrite.WriteLine(text);
                    stWrite.Close();
                    Console.WriteLine("Файл создан");
                }
                else
                {
                    // Если пользователь отказался от создания файла, выводим сообщение.
                    Console.WriteLine("Ничего не будет созданно");
                }
            }

            Console.ReadKey();
        }
    }
}
