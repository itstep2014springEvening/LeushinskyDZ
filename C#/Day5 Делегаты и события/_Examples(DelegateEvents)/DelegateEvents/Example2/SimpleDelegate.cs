using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    // 
    //  СТАТИЧЕСКИЕ МЕТОДЫ!
    //


    class SimpleDelegate
    {
        private delegate void PrintInfo(double R);    // объявление  делегата
        // Делегат - представляет собой объект, который может ссылаться на метод!
        // Требование: делегат может ссылаться только на метод, который соотвествует его сигнатуре
        // т.е. для делегата strMod - метод должен возвращать string  и принимать один параметр string

        static void Main(string[] args)
        {
            string rezult;
            Console.WriteLine("Простейший делегат! Статические методы!");

          

            PrintInfo printInfo1 = new PrintInfo(Circle.PrintRadius);     // 1-ый способ создание объекта на основе 
            // делегата PrintInfo
            Console.WriteLine("\nДелегат инициализирован методом" + " PrintRadius()");

            printInfo1(4);                                                // вызов метода по ссылке с передачей в качестве
            // агрумента числа 4

            PrintInfo printInfo2 = Circle.PrintDiameter;                    // 2-ой способ создание объекта на основе 
            // делегата PrintInfo
            Console.WriteLine("\nДелегат инициализирован методом" + " PrintDiameter()");
            printInfo2(4);


            Console.ReadKey();
        }
    }
    class Circle
    {
        public static void PrintRadius(Double Radius)  // метод для вывода радиуса окружности
        {
            Console.WriteLine("Радиус равен :           {0,7:N3}", Radius);
        }

        public static void PrintDiameter(Double Radius) // метод для вывода диаметра окружности
        {
            Double diameter = 2 * Radius;
            Console.WriteLine("Диаметр равен :          {0,7:N3}", diameter);
        }

        public static void PrintLenght(Double Radius)  // метод для вывода длины окружности
        {
            Double lenght = 2 * Math.PI * Radius;
            Console.WriteLine("Длина окружности равна : {0,7:N3}", lenght);
        }

        public static void PrintSquare(Double Radius)  // метод для вывода площади окружности
        {
            Double square = Math.PI * Radius * Radius;
            Console.WriteLine("Площадь круга равна :    {0,7:N3}", square);
        }
    }


}
