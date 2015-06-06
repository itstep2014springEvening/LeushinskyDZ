using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSimpleEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простые перечисления!");
            Book b1 = new Book(1, "Отцы и дети", 250, Style.art);   // использование перечисления
            Console.WriteLine(b1);

            Book b2;                                                // использование перечисления
            b2.Id = 2; b2.Name = "Руслан и Людмила"; b2.CountPages = 500; b2.style = Style.fairy_tales;
            Console.WriteLine(b2);

            Book b3 = new Book();
            b3.Id = 3; b3.Name = "Му-му"; b3.CountPages = 300;
            Console.WriteLine(b3);


            Console.WriteLine("Работа с перечислениями!");

            // вывод имени именнованной констранты перечисления
            Console.WriteLine(Publish.Williams);

            // вывод занячения именнованной констранты перечисления
            Console.WriteLine((byte)Publish.Williams);


            Style style = Style.fairy_tales;
            
            // сравнение перечислений
            if (style == Style.fairy_tales)
            {
                Console.WriteLine(style);
            }

            switch (style)
            {
                case Style.art: Console.WriteLine(b2.style); break;
                case Style.documentary: Console.WriteLine(b2.style); break;
                case Style.fairy_tales: Console.WriteLine(b2.style); break;
                case Style.lyrics: Console.WriteLine(b2.style); break;
                default: Console.WriteLine("не найдено!"); break;
            }

            // использование перечислений в циклах
            for (Style i = Style.art; i < Style.lyrics; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Методы класса Enum");
           // https://msdn.microsoft.com/en-us/library/System.Enum_methods(v=vs.110).aspx
            
            Console.ReadKey();
        }
    }

    struct Book
    {
        public int Id;

        public string Name;

        public int CountPages;

        public Style style;
        public Book(int I, string N, int CP, Style style)    
        {   Id = I; Name = N; CountPages = CP;
            this.style = style;
        }

        public override string ToString()
        {
            return String.Format("№{0}. {1}, стр. {2}/ {3}", Id, Name, CountPages, style);
        }
    }

    enum Style     // объявление перечисления
    {
        // именованные константы
        art,                      // 0   
        documentary,              // 1         
        lyrics,                   // 2          
        fairy_tales               // 3          
    }
    enum Publish :byte  // объявление перечисления и указание базового типа (byte)
    {
        // именованные константы
        Williams = 25,  // присваивание значений константам                   
        Jonson = 10,
        Zorka = 141,
        BHV_Piter = 2
    }

}
