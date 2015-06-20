using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4Combine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Совместное применение: Dispose() / Destructor *****");
            // Вызвать Dispose() вручную. Это не приведет к вызову финализатора.
            MyResource rw = new MyResource();
            rw.Dispose();
            // Не вызывать метод Dispose(). Это приведет к вызову финализатора 
            // и выдаче звукового сигнала.
            MyResource rw2 = new MyResource();
            Console.ReadKey();
        }
    }
    // Сложная оболочка для ресурсов.
    public class MyResource : IDisposable
    {
        // Используется для выяснения того,
        // вызывался ли уже метод Dispose().
        private bool disposed = false;
        public void Dispose()
        {
            // Вызвать вспомогательный метод.
            // Указание true означает, что очистку
            // запустил пользователь объекта.
            CleanUp(true);
            // Подавить финализацию.
            GC.SuppressFinalize(this);
        }
        private void CleanUp(bool disposing)
        {
            // Удостовериться, не выполнялось ли уже освобождение.
            if (!this.disposed)
            {
                // Если disposing равно true, освободить
                // все управляемые ресурсы.
                if (disposing)
                {
                    // Освободить управляемые ресурсы.
                }
                // Очистить неуправляемые ресурсы.
            }
            disposed = true;
        }
        ~MyResource ()
        {
            Console.Beep();
            // Вызвать вспомогательный метод.
            // Указание false означает, что
            // очистку запустил сборщик мусора.
            CleanUp(false);
        }
    }
}
