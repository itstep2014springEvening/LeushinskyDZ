using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Использование checked/unchecked");
            // переменная типа byte хранит числа от 0 до 255 (всего 256)
             Byte b1 = 100;
             //b1 =300-256= 44 – разряды, которые  не попадают отбрасываются
             b1 = (Byte)(b1 + 200);   
             Console.WriteLine("Результат: "+b1);
             
             Byte b2 = 100;
             try
             { // контроль за переполнением и генерация исключения при переполнении
                 b2 = checked((Byte)(b2 + 200));   
                 Console.WriteLine("Результат checked: " + b2);
             } catch(OverflowException ex)
             {
               Console.WriteLine(ex.Message);
             }

             Byte b3 = 100;
             try
             {  // игнорирование переполнения и негенерирование исключения
                 b3 = unchecked((Byte)(b3 + 200));  
                 Console.WriteLine("Результат unchecked: " + b3);
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }

            // Для установки контроля за переполнением для всего проекта необходимо установить:
             // Properties->Build->Advanced->Check for Arithmetic underflow / overflow.




            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }



}
