using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7EventHandler
{
    // public delegate void delWork(string message);  В примере пользовательский делегат не нужет 
    //                                                т.к. используется стандартный  - EventHandler,
    // который имееет след вид:   public delegate void EventHandler(object sender, EventArgs e);
    // следовательно, мы должны из события передать следующую информацию
    // object sender - объект, который вызвал событие
    // EventArgs e - дополнительные параметры!
   
    class TestEventHandler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EventHandler");

            Worker worker = new Worker("Alex", "programmer");
            Manager manager = new Manager();
            worker.WorkEnded += new EventHandler(manager.GoHome);

            worker.Work();

            Console.ReadKey();
        }


    }
    class Manager
    {
        public void GoHome(Object sender, EventArgs e)  // 
        {
            Worker worker = (Worker)sender;        // приведение типов !
            Console.WriteLine("Рабочий день закончился! Иди домой, {0}!", worker.Name);
        }
    }

    public class Worker
    {
        public event EventHandler WorkEnded;

        public String Name;
        public String Post;

        public Worker(String Name, String Post)
        {
            this.Name = Name;
            this.Post = Post;

        }

        public void OnEndWork()
        {
            if (WorkEnded != null)
            {         WorkEnded(this, EventArgs.Empty);  // передача ссылки на объект, который вызвал событие 
            }
       }

        public void Work()
        {
            for (int i = 1; i <= 8; i++)
            {
                if (i == 8) OnEndWork();
                else Console.WriteLine("Работаю {0} час!", i);
            }
        }
    }

    
}
