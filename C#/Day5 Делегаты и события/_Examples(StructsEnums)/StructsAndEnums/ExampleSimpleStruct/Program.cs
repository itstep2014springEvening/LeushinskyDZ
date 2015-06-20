using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSimpleStruct
{
    class Program
    {
       static  Book b5;
        static void Main(string[] args)
        {
            Console.WriteLine("Простые структуры");


            Book b1 = new Book(1, "Отцы и дети", 250);   // создание структуры с инициализацией ч/з конструктор 
            Console.WriteLine(b1);

            Book b2;                                    // создание структуры без инициализации
            b2.Id = 2; b2.Name = "Война и мир"; b2.CountPages = 500;
            Console.WriteLine(b2);

            Book b3 = new Book();                     // создание структуры с инициализацией ч/з конструктор по умолчанию
            b3.Id = 3; b3.Name = "Му-му"; b3.CountPages = 300;
            Console.WriteLine(b3);
            
            Book b4 = b3;                             // копирование структур (создание двух копий)
            b3.Id = 4; b3.Name = "Обломов"; b3.CountPages = 190;

            Console.WriteLine(b3);
            Console.WriteLine(b4);

            b5 = b4;
            Console.WriteLine(b5);

            Console.ReadKey();
        }
    }

    struct Book  // объявление структуры
    {
        public int Id;

        public string Name;

        public int CountPages;

        // ОШИБКА! 
        // Структуры не могут явно содержать конструкторы без параметров т.к. он реализуется автоматически
        //public Book()
        //{ 
        //}

        //  конструктор с параметрами 
        public Book(int I, string N, int CP)    
        {    Id = I; Name = N; CountPages = CP;
        }

        public override string ToString()
        {
            return String.Format("№{0}. {1}, стр. {2}", Id, Name, CountPages);
        }

    }
}
