using System;
using System.Collections;


namespace Example2
{
    class ExampleSortArrayList
    {
        static void Main(string[] args)
        {
            // Отсортировать коллекцию типа ArrayList и осуществить в ней поиск. 

            // Создать коллекцию в виде динамического массива. 
            ArrayList al = new ArrayList(); 
            // Добавить элементы в динамический массив. 
            al.Add(55); 
            al.Add(43); 
            al.Add(-4); 
            al.Add(88) ; 
            al.Add(3) ; 
            al.Add(19) ; 
            Console.Write("Исходное содержимое: "); 
            foreach(int i in al) 
            Console.Write(i + " "); 
            Console.WriteLine("\n"); 
            
            // Отсортировать динамический массив. 
            al.Sort(); 
            
            // Отобразить содержимое динамического массива, используя цикл foreach. 
            Console.Write ("Содержимое после сортировки: "); 
            foreach(int i in al) 
              Console.Write(i + " "); 
            Console.WriteLine ("\n"); 
            
            Console.WriteLine("Индекс элемента 43: " +  al.BinarySearch(43));

            Console.ReadKey();
        }
    }
}
