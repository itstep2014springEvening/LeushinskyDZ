using System;
using System.Collections;


namespace Example4
{
    class ExampleHashtable
    {
        static void Main(string[] args)
        {
            // Продемонстрировать применение класса Hashtable. 
            
            // Создать хеш-таблицу. 
            Hashtable ht = new Hashtable (); 
           
            // Добавить элементы в таблицу. 
            ht.Add("здание", "жилое помещение"); 
            ht.Add("автомашина", "транспортное средство"); 
            ht.Add("книга", "набор печатных слов"); 
            ht.Add("яблоко", "съедобный плод"); 
            
            // Добавить элементы с помощью индексатора, 
            ht["трактор"] = "сельскохозяйственная машина"; 
            
            // Получить коллекцию ключей. 
            ICollection с = ht.Keys; 
            
            // Использовать ключи для получения значений, 
            foreach(string str in с) 
              Console.WriteLine(str + ": " + ht[str]);

            Console.ReadKey();
        }
    }
}
