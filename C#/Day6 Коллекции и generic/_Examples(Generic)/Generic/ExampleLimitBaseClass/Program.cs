using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLimitBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Следующий код вполне допустим, поскольку 
            // класс Friend наследует от класса PhoneNumber. 
            PhoneList<Friend> pList = new PhoneList<Friend>();
            pList.Add(new Friend("Иван", "", true));
            pList.Add(new Friend("Петр", "", true));
            pList.Add(new Friend("Илья", "", true)); 
                  
            try 
            { 
                // Найти номер телефона по заданному имени друга. 
                Friend frnd = pList.FindByName("Петр"); 
                Console.Write(frnd.Name + ": " + frnd.Number); 
                if(frnd.IsWorkNumber) 
                   Console.WriteLine(" (рабочий)") ; 
            } 
            catch
            { 
            Console.WriteLine("He найдено");
            }

           // Ошибка - т.к. класс Skype - не наследует PhoneNumber
           // PhoneList<Skype> skList = new PhoneList<Skype>(); 


        }
    }

    // Базовый класс, в котором хранятся имя абонента и номер его телефона, 
    class PhoneNumber
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public PhoneNumber(string n, string num)
        {
            Name = n;
            Number = num;
        }
    } 

    // Класс для телефонных номеров друзей
    class Friend : PhoneNumber
    {
        public bool IsWorkNumber { get; private set; } 
        public Friend(string n, string num, bool wk) :  base (n, num) 
        {   IsWorkNumber = wk;   } 
    }

    class Skype
    {
        public string Number { get; set; }
        public string Name { get; set; }
    }
   

    // класс,описывающий телефонную книгу!
    class PhoneList<T> where T:PhoneNumber
    {
        T[] phList;
        int end;
        public PhoneList()
        {
            phList = new T[10];
            end = 0;
        }

        // Добавить элемент в список
        public bool Add(T newEntry)
        {
            if (end == 10) return false;
            phList[end] = newEntry;
            end++;
            return true;
        }
        // Найти и возвратить сведения о телефоне по имени
        public T FindByName(string name) 
        {
          for(int i=0; i<end; i++) 
           { 
             // Имя может использоваться, относится к членам класса  базовым по накладываемому 
             if(phList[i].Name == name) 
               return phList[i]; 
           }
          return null; 
        }
    }


}
