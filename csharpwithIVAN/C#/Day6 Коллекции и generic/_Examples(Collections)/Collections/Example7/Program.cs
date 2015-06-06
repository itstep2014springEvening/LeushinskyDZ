using System;
using System.Collections;

namespace Example7
{
    class ExampleQueue
    {
        static void Main(string[] args)
        {
            // Создание коллекции - типа "Очередь"
            Queue q = new Queue();
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
           // Добавляем элементы в очередь!
            InsertToEnd(q, 22);
            InsertToEnd(q, 65);
            InsertToEnd(q, 91);
           // Излекаем  
            GetFirst(q);
            GetFirst(q);
            GetFirst(q);
            try
            {   // пробуем извлечь 
                GetFirst(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Очередь пуста.");
            }
            Console.ReadKey();

        }
        static void InsertToEnd(Queue q, int a) 
        {
            // метод в классе Queue для добавления эл-та
            q.Enqueue(a) ; 
            Console.WriteLine("Поместить в очередь: Добавлен(" + a + ")"); 
           
            Console.Write("Содержимое очереди: "); 
            foreach(int i in q) 
               Console.Write(i + " "); 
            Console.WriteLine (); 
        }
       
        static void GetFirst( Queue q) 
        { 
            Console.Write("Извлечь из очереди: Извлечен -> ");
            // метод в классе Queue для извлечения эл-та
            int a = (int) q.Dequeue(); 
            Console.WriteLine (a); 
           
            Console.Write("Содержимое очереди: "); 
            foreach(int i in q) 
                Console.Write(i + " ") ; 
            
            Console.WriteLine(); 
        }

    }
}
