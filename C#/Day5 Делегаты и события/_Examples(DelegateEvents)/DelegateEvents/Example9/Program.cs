using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7EventHandler
{
   
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
        public void GoHome(Object sender, EventArgs e)  // использование WorkerEventArgs для передачи дополнительных 
        {                                                     // параметров через свойство Message
            Worker worker = (Worker)sender;
            WorkerEventArgs ww = (WorkerEventArgs)e;

            Console.WriteLine("Рабочий день закончился! Иди домой, {0}! {1}", worker.Name, ww.Message);
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
            {
                WorkerEventArgs workerArg = new WorkerEventArgs();
                workerArg.Message = "Можно еще поработать?!";
                WorkEnded(this, workerArg);  // передача ссылки на объект, который вызвал событие,
                // и дополнительных параметров через WorkerEventArgs
                // в обрабочик события!
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

    public class WorkerEventArgs:EventArgs  // создание производного 
    {
        public string Message { get; set; }

    }
}
