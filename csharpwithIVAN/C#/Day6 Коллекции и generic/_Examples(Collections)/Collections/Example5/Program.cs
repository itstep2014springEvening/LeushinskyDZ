using System;
using System.Collections;

namespace Example5
{
    class ExampleSortedList
    {
        static void Main(string[] args)
        {
            // Продемонстрировать применение класса SortedList. 
            
            // Создать отсортированный список. 
            SortedList sList = new SortedList();
           
            // Добавить элементы в список. 
            sList.Add("здание", "жилое помещение");
            sList.Add("автомашина", "транспортное средство");
            sList.Add("книга", "набор печатных слов");
            sList.Add("яблоко", "съедобный плод");
            
            // Добавить элементы с помощью индексатора, 
            sList["трактор"] = "сельскохозяйственная машина";
            
            // Получить коллекцию ключей. 
            ICollection с = sList.Keys;
            
            // Использовать ключи для получения значений. 
            Console.WriteLine("Содержимое списка по индексатору.");
            foreach (string str in с)
                Console.WriteLine(str + ": " + sList[str]);
            Console.WriteLine();
            
            // Отобразить список, используя целочисленные индексы. 
            Console.WriteLine("Содержимое списка по целочисленным индексам.");
            for (int i = 0; i < sList.Count; i++)
                Console.WriteLine(sList.GetByIndex(i));
            
          
            Console.ReadKey();
        }
    }
}
