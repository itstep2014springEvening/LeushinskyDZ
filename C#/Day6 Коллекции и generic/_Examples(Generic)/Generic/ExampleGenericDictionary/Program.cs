
using System;
using System.Collections.Generic;

namespace ExampleGenericDictionary
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Словарь для хранения пар:
            //название группы - количество студентов
            Dictionary<string, int> gr = new Dictionary<string, int>();
			
            //добавление значений в список
            gr["GR1"] = 12;
            gr.Add("GR2", 10);
            gr.Add("GR3", 10);
            gr.Add("GR4", 6);
            //изменение значения
            gr["GR1"] = 14;
            //вывод всех элементов словаря
            Console.WriteLine("Dictionary Content: ");
            foreach (KeyValuePair<string, int> p in gr)
            Console.WriteLine("{0} {1}", p.Key, p.Value);
			
            //удаление по значению ключа
            gr.Remove("GR4");
			
            //попытка добавления существующего ключа
            try
            {
	            gr.Add("GR1", 15);
            }
            catch (ArgumentException e)
            {	Console.WriteLine(e.Message);  }
			
            //попытка обращения к несуществующему ключу
            try
            {
	            Console.WriteLine(gr["GR5"]);
            }
            catch (KeyNotFoundException e)
            { 	Console.WriteLine(e.Message); }
			
            //проверка существования ключа и получение зачнения
            int val;
            if (gr.TryGetValue("GR5", out val)) Console.WriteLine(val);
            else Console.WriteLine("Key not found");
			
            Console.ReadKey(true);
		}
	}
}