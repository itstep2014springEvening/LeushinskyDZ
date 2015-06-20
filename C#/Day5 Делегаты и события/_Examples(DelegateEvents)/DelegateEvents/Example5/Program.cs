using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    
    delegate void MyDel4Event();  // объявление делегата! 

    // Объявляем класс, содержащий событие SomeEvent
    class Class4Event
    {
        public event MyDel4Event SomeEvent;      // объявление события SomeEvent на основе 
                                                 // событийного детегата MyDel4Event

        public void OnSomeEvent()               // Этот метод вызывается для генерирования события
        { 
            if (SomeEvent != null)              // проверка на "подписку на событие"
                SomeEvent();                    // вызов события!
        }
    }
    

    
    class Events
    {   
        // Метод, который выполняется при наступлении события
        // либо называется обработчиком события!
        static void handler()  //   сигнатура соотвествует сигнатуре событийного делегата  события SomeEvent
        {                      //   имя метода может быть произвольным !
            Console.WriteLine("Произошло событие!"); 
        }

        public static void Main()
        {
            Console.WriteLine("Простейшее событие!");

            Class4Event someClass = new Class4Event();        // Создаем объект класса Class4Event


            someClass.SomeEvent += new MyDel4Event(handler);  // Добавляем метод handler() в список события через событийный делегат 
            
            
            someClass.OnSomeEvent();                          // Генерируем событие (вызов события)
            
            Console.ReadKey();

        }
    }
   

}
