using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Война и мир", 350);
            Console.WriteLine(book1.GetString());
            book1.Name = "";
            Console.WriteLine(book1.GetString());

            // создание объекта через инициализаторы
           // Book book2 = new Book { Id=2, Name="Отцы и дети", Pages=250};
           // Console.WriteLine(book2.GetString());

            Console.ReadKey();
        }
    }

    class Book
    {
        int id;
        // свойство для доступа к закрытому
        // полю класса - id
        public int Id
        {
                get { return id; }
                set { if (value > 0)id = value; }
        }

        string name;
        // свойство для доступа к закрытому
        // полю класса -  name
        public string Name
        {
            get { return name; }
            set
            {
                    if (value.Length!=0) name = value;
                    else name = "noName";
            }
        }
        // Автоматическое свойство

        public int Pages { get; set; }
        
        //  Конструктор
        public Book()
        {
            
        }

        //  Конструктор
        public Book(int id, string name, int pages)
        {
            this.id = id; this.name = name; Pages = pages;
        }
        // Методо для возврата значений полей класса в виде строки
        public string GetString()
        {
            return String.Format("№{0}. \"{1}\" стр.{2}",id, name, Pages);
        }

        


    }
}
