using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    public delegate void delWork(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простейшее событие!Передача параметров!");

            Worker worker = new Worker("Alex","programmer");
            
            worker.WorkEnded += new delWork(Manager.GoHome);
            
            worker.Work();

            Console.ReadKey();
        }

        
    }
    class Manager
    {
        public static void GoHome(string str)
        {
            Console.WriteLine("Молодцы, хорошо поработали! Получи премию, {0}!", str);
        }
    }

    public class Worker
    {
        // объявление события 
        public event delWork WorkEnded;

        public String Name;
        public String Post;

        public Worker(String Name, String Post)
        {
            this.Name = Name;
            this.Post = Post;
            
        }

        // метод, генерирующий событие
        public void OnEndWork()
        {
           if (WorkEnded != null)
               WorkEnded(Name);  // передача имени в обработчик события (метод GoHome класса Manager)! 
        }

        public void Work()
        {
            for (int i = 1; i <=8; i++)
            {
                if (i == 8)
                    OnEndWork(); // вызов события
                else Console.WriteLine("Работаю {0} час!", i); 
            }
        }
    }
}
