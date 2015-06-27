using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ExampleJSON
{
   
    class Program
    {
       

        static void Main(string[] args)
        {
            List<CBook> books = new List<CBook>
                        {
                            new CBook{id=1, name="Мойна и мир", price=25000},
                            new CBook{id=2, name="Отцы и дети", price=18000}
                        };

            var jSerialize = new JavaScriptSerializer();
            string json = jSerialize.Serialize(books);
            Console.WriteLine(json);
            File.WriteAllText("File.txt", json);

            Console.WriteLine(new string('-', 20));
            List<CBook> Books = jSerialize.Deserialize<List<CBook>>(json);
            foreach (CBook book in Books)
                Console.WriteLine(book);

            Console.ReadKey();

        }

public class CBook
{
    public int id;
    public string name;
    public double price;
    public CBook() { }
    public CBook(int ID, string Name, double Price)
    { id = ID; name = Name; price = Price; }
    public override string ToString()
    { return string.Format("{0}. {1},{2}", id, name, price); }
}
    }
}
