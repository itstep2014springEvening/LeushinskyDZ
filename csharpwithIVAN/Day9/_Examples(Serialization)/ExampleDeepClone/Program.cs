using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDeepClone
{
    class Program
    {
        static void Main(string[] args)
        {
            CBook Book = new CBook(1,"Троелсен C# 4.5",2500);
            CBook newBook = (CBook)DeepC1one(Book);
            Console.WriteLine(Book);
            Console.WriteLine(newBook);
            
            Console.WriteLine(new string('-',25));
            newBook.Price = 3000;
            Console.WriteLine(Book);
            Console.WriteLine(newBook);

            Console.ReadKey();
        }

        private static Object DeepC1one(Object original)
        {
            // Создание  временного  потока  в  памяти 
            using (MemoryStream stream = new MemoryStream())
            {
                // Создания  объекта  для  сериализации 
                BinaryFormatter  formatter  =  new  BinaryFormatter ();

                //  Сериализация  объекта  в  поток  в  памяти 
                formatter.Serialize(stream,original);
                //  Возвращение  к  началу  потока  в  памяти  перед  десериализацей 
                stream.Position  =  0;
                // Десериализация  графа  в  новый    объект  и  возвращение 
                // вызывающему  методу 
                return  formatter.Deserialize(stream); 
            }

        }
    }

    [Serializable]
    class CBook
    {   int id;
        string name;
        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public CBook(int ID, string Name, double Price)
        { id = ID; name = Name; price = Price; }
        public override string ToString()
        { return string.Format("{0}. {1},{2}", id, name, price); }
    }
}
