using System;
using System.Collections;

namespace Example1
{
    class ExampleArrayList
    {
        static void Main(string[] args)
        {
            // Создать коллекцию в виде динамического массива. 
            ArrayList al = new ArrayList();
            // Использование свойства Count
            Console.WriteLine("Исходное количество элементов: "+al.Count); 
            Console.WriteLine(); 
            Console.WriteLine("Добавить 6 элементов"); 
            // Добавить элементы в коллекцию. 
            al.Add('C');   al.Add('A');
            al.Add('E');   al.Add('B');
            al.Add('D');   al.Add('F');
            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое коллекции, 
            // используя индексирование. 
            Console.Write("Текущее содержимое: ");
            for (int i = 0; i < al.Count; i++)
                Console.Write(al[i] + " ");
            Console.WriteLine("\n");
           
            Console.WriteLine("Удалить 2 элемента");
            // Удалить элементы из коллекции, 
            al.Remove('F');  // удаление элемента 
            al.RemoveAt(1);  // удаление по индексу
            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое коллекцию, используя цикл foreach. 
            Console.Write("Содержимое: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");
           
            Console.WriteLine("Добавить еще 20 элементов");
            // Добавить количество элементов, достаточное для 
            // принудительного расширения коллекции. 
            for (int i = 0; i < 20; i++)
                al.Add((char)('a' + i));
            Console.WriteLine("Кол-во элементов после добавления: " +  al.Count);
            
            Console.Write("Содержимое: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");

            // Изменить содержимое коллекции, 
            // используя индексирование. 
            Console.WriteLine("Изменить три первых элемента");
            al[0] = 'X';  al[1] = 'Y';   al[2] = 'Z';
            
            Console.Write("Содержимое: ");
            foreach (char с in al)
                Console.Write(с + " ");
            Console.WriteLine();

            Console.WriteLine("\nКопирование элементов коллекции в массив mas"); 
            char[] mas = new char[al.Count];
            al.CopyTo(mas);
            foreach (char с in mas)
                Console.Write(с + " ");
            Console.WriteLine();

            Console.WriteLine("\nНаличие элемента \"X\" в коллекции");
            if (al.Contains('X'))
            {
                Console.WriteLine("Элемент \"X\" имеется в коллекции!");
            }
            Console.WriteLine("Индекс элемента  \"Z\" в коллекции: " + al.IndexOf('Z'));

            // Очистка коллекции 
            al.Clear();

            Console.ReadKey();
        }
    }
}
