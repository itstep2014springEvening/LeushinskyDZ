using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3IDisposab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyResource res1 = new MyResource("res1");
            res1.Dispose();
           
            MyResource res2 = new MyResource("res2");
            if (res2 is IDisposable)
                res2.Dispose();
         
            MyResource res3 = new MyResource("res3");
            try
            {
                // Использование членов res3 
            }
            finally
            {
                // Обеспечение вызова метод Dispose() в любом случае, 
                //в том числе и при возникновении Exception. 
                res3.Dispose();
            }

            //   использование using для реализации try/finally
            using (MyResource res4 = new MyResource("res4"), res5 = new MyResource("res5"))
            {
                // Использование членов res4 и res5.
            }

            Console.Read();
        }
    }

    class MyResource : IDisposable
    {
        string name;
        public MyResource(string name)
        {
            this.name = name;
        }
        public void Dispose()
        {
            // Освобождение неуправляемых ресурсов. . . 
            // Только для целей тестирования. 
            Console.WriteLine("***** In Dispose для {0}! ***** ", name);
        }
    }
}



