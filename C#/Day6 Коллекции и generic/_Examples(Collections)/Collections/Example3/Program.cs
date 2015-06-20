using System;
using System.Collections;

namespace Example3
{
    class ExampleSimpleArrFromList
    {
        static void Main(string[] args)
        {
            // Преобразовать коллекцию типа ArrayList в обычный массив. 
            ArrayList al = new ArrayList(); 
            // Добавить элементы в динамический массив. 
            al.Add(1); 
            al.Add(2); 
            al.Add(3) ; 
            al.Add(4) ; 
            Console.Write("Содержимое: "); 
            foreach(int i in al) 
               Console.Write(i + " "); 
            Console.WriteLine (); 
            
            // Создание массива из коллекции
            int[] ia = (int[])al.ToArray(typeof(int));
            
            // Просуммировать элементы массива, 
            int sum = 0;
            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Сумма равна: " + sum);


            int[] ia2 = new int[al.Count];
            // Копирование элемментов коллекции в массив
            al.CopyTo(ia2);
            
            // Просуммировать элементы массива, 
            sum = 0;
            for (int i = 0; i < ia2.Length; i++)
                sum += ia2[i];
            Console.WriteLine("Сумма равна: " + sum);
         
           
           
            // Просуммировать элементы массива, 
            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Сумма равна: " + sum);

            Console.ReadKey();
        }
    }
}
