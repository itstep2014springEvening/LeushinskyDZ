using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryOperator
{
    class CPoint
    {
        private int x;
        private int y;

        public CPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }

        //перегрузка бинарного оператора + (сложение точек)
        public static CPoint operator +(CPoint A, CPoint B)
        {
            CPoint C = new CPoint(0, 0);
            C.x = A.x + B.x;
            C.y= A.y + B.y;
            return C;
        }

        //перегрузка бинарного оператора * (произведение точек)
        public static CPoint operator *(CPoint A, CPoint B)
        {
            CPoint C = new CPoint(0, 0);
            C.x = A.x * B.x;
            C.y = A.y * B.y;
            return C;
        }

        
        
        //перегрузка бинарного оператора + (сложение точки и числа)
        public static CPoint operator +(CPoint A, int X)
        {
            CPoint C = new CPoint(0, 0);
            C.x = A.x + X;
            C.y = A.y + X;
            return C;
        }

        //перегрузка бинарного оператора + (сложение числа и точки)
        public static CPoint operator +(int X, CPoint A)
        {
            CPoint C = new CPoint(0, 0);
            C.x = A.x + X;
            C.y = A.y + X;
            return C;
        }
        public  string GetString()
        {
            return string.Format("Point: X = {0} Y = {1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CPoint p1 = new CPoint(10, 10);
            CPoint p2 = new CPoint(11, 12);
            Console.WriteLine("Точка p1: {0}", p1.GetString());
            Console.WriteLine("Точка p2: {0}", p2.GetString());
            CPoint p3 = p1 + p2;  // сложение объектов класса CPoint 
            Console.WriteLine("Точка p3=p1+p2: {0}", p3.GetString());
            CPoint p4 = p1 * p2;  // произведение объектов класса CPoint 
            Console.WriteLine("Точка p4=p1*p2: {0}", p4.GetString());
            Console.Write("Введите число: ");
            int X;
            Int32.TryParse(Console.ReadLine(), out  X);

            CPoint p5 = p1 + X;  // сложение объекта класса CPoint с числом 
            Console.WriteLine("Точка p5=p1+{0}: {1}", X, p5.GetString());

            CPoint p6 = X + p2; 
            Console.WriteLine("Точка p6={0}+p2: {1}", X, p6.GetString());

            
            Console.ReadKey();
        }
    }
}
