using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyDimIndexator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Многомерный индексатор");

            Book book1 = new Book(1, "Война и мир", 350);
            Book book2 = new Book(2, "Отцы и дети", 250);
            Book book3 = new Book(3, "Черное и белое", 150);

            Console.WriteLine(book1[1, "Война и мир"]);
            Console.WriteLine(book1[2, "Война и мир"]);
            
            Console.ReadKey();
        }
    }

    class Book
    {
        private int id;
        private string name;
        private int pages;

        public Book(int id, string name, int pages)
        {
            this.id = id; this.name = name; this.pages = pages;
        }
        // создание многомерного индексатора
          // первым параметром переменная целого типа
          // вторым параметром переменная строкового типа
        public int this [int Id, string Name]
        {
            get
            {
                if (id == Id && Name == name)
                {
                    return pages;
                }
                else return 0;

            }
        
        }

    }
}
