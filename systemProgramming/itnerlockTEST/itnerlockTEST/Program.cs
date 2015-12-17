using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace itnerlockTEST
{
    class Program
    {
        class InterlockedCounter
        {
            public int field1
            {
                set { }
                get { return field1; }
            }
            public int field2
            {
                set { }
                get { return field2; }
            }

            public void UpdateFields()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Interlocked.Increment(ref field1);
                    if (field1%2 = 0)
                    {
                        Interlocked.Increment(ref field2);
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            
            Thread [] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(delegate()
                {
                    for (int j = 0; j < 1000000; j++)
                    {
                        Interlocked.Increment(ref Counter.count);
                    }
                
                });
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine(Counter.count);
            Console.ReadLine();
        }
    }
}
