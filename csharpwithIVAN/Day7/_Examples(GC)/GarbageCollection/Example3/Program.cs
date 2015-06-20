using System;
using System.Threading;

namespace Example3IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример использования Dispose()");
            Car car1 = new Car() { Name="BMW"};
            Car car2 = new Car() { Name = "Ford" };
                   
            car1.Dispose();
            Thread.Sleep(3000);  // пауза вычислительного процесса на 3000 мс (3 с.)
            car2.Dispose();


            Console.ReadKey();
        }
    }

 /*
    Когда реализуется поддержка интерфейса IDisposable, 
    то предполагается, что после завершения работы с объектом метод Dispose()
    должен вручную вызываться для этого объекта, прежде чем объектной 
    ссылке будет позволено покинуть область действия. 
  * Благодаря этому объект может  выполнять любую необходимую очистку неуправляемых 
    ресурсов без попадания в очередь финализации и без ожидания того, 
    когда сборщик мусора запустит содержащуюся в классе логику финализации.
  Особенности:
  - реализуется как в ссылочных, так и в значимых типах;
  - как правило используется блок try-finally
 */
class Car : IDisposable  // наследование от интерфейса IDisposable, содержащего метод Dispose
{
    public string Name { get; set; }
       
    public void Dispose()  // обязательная реализация метода Dispose()
    {
        Console.WriteLine("Вызов метода Dispose() для  Car.Name={0}", Name);
    }
}
}
