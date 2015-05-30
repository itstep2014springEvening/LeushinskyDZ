using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    //
    //  МНОГОАДРЕСАТНЫЙ ВЫЗОВ
    //
    class Multicasting
    {
            private delegate void PrintInfo();
            // Внимание! При создании многоадрессатного вызова 
            // целесообразно использовать методы сигнатуры  - void Metod() 
            // т.к. 
            // Если делегат возвращает значение, то им становится значение, 
            // возвращаемое последним методом в списке  вызовов. 
       

            static void Main(string[] args)
            {
            string str = "Многоадрессатный вызов";
            Circle circle = new Circle(4);

            PrintInfo printInfo = circle.PrintRadius;
            Console.WriteLine("\nДелегат инициализирован одним методом" + " PrintRadius()");
            printInfo();

            printInfo += circle.PrintDiameter;  // Добавление метода PrintDiameter в цепочку вызова делегата  printInfo
            printInfo += circle.PrintLenght;    // Добавление метода PrintLenght  в цепочку вызова делегата  printInfo
            printInfo += circle.PrintSquare;    // Добавление метода PrintSquare в цепочку вызова делегата  printInfo

            Console.WriteLine("\nДелегат вызывает цепочку методов \nPrintRadius()," + " PrintDiameter(), PrintLenght(), PrintSquare() :\n");
            printInfo();                        // Вызов делегата 

            Delegate[] dels=  printInfo.GetInvocationList();
            
                printInfo -= circle.PrintSquare;    // Удаление метода PrintSquare из цепочки вызова делегата  printInfo (1-ый вариант)
            Console.WriteLine(
                "\nТеперь делегат вызывает методы \nPrintRadius()," +" PrintDiameter(), PrintLenght() :\n");

            printInfo();                        // Вызов делегата 

            // Добавление метода PrintSquare в цепочку вызова делегата  printInfo
            // Удаление   метода PrintRadius из цепочки вызова делегата  printInfo   (2-ой вариант)
            // Удаление   метода PrintDiameter из цепочки вызова делегата  printInfo (3-ий вариант)
            printInfo = printInfo + circle.PrintSquare - circle.PrintRadius - new PrintInfo(circle.PrintDiameter);
            
            Console.WriteLine("\nТеперь делегат вызывает методы" + " \nPrintLenght(), PrintSquare() :\n");

            printInfo();                         // Вызов делегата 

            Console.WriteLine("\n");
            Console.ReadKey();
            }
    }
   
     class Circle
        {
            public Double Radius;

            public Circle(Double radius)
            {
                this.Radius = radius;
            }

            public void PrintRadius()
            {
                Console.WriteLine("Радиус равен :           {0,7:N3}", Radius);
            }

            public void PrintDiameter()
            {
                Double diameter = 2 * Radius;
                Console.WriteLine("Диаметр равен :          {0,7:N3}", diameter);
            }

            public void PrintLenght()
            {
                Double lenght = 2 * Math.PI * Radius;
                Console.WriteLine("Длина окружности равна : {0,7:N3}", lenght);
            }

            public void PrintSquare()
            {
                Double square = Math.PI * Radius * Radius;
                Console.WriteLine("Площадь круга равна :    {0,7:N3}", square);
            }
        }

     

       
}
