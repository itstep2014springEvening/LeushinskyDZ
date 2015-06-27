using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBinarySerialization
{
    class Program
    {
        public static void Main(string[] args)
        {
            CBook book = new CBook(1, "Война и мир", 2.6);  // объект для сериализации
            CBook newBook; // объект для десериализации
            // сериализация объекта
            using (FileStream file = new FileStream("file.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, book); // сериализация
            }
            // десериализация объекта	
            using (FileStream file = new FileStream("file.txt", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                newBook = (CBook)binFormat.Deserialize(file); // десериализация ! Обязательнао должно быть приведение типа
            }

            // вывод на экран newBook - десериализованного объекта
            Console.WriteLine(newBook.ToString());
            Console.ReadKey(true);
        }
    }

    [Serializable]
    class CBook
    {
        public int id;
        public string name;
        [NonSerialized]  // определение несериализуемого поля
        public double price;
        public CBook(int ID, string Name, double Price)
        { id = ID; name = Name; price = Price; }
        public override string ToString()
        { return string.Format("{0}. {1},{2}", id, name, price); }


        [OnDeserialized]
        private void OnDeseria1ized(StreamingContext context)
        {//  Инициализация  временного  состояния  полей 
            price = 5000;
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            //  Присвоение полям  значений  по  умолчанию  в  новой  версии  типа 
        }

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            //   Модификация  состояния  перед  сериализацией 
        }
    }
}
