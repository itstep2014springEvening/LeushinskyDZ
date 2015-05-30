using System;

namespace UnaryOperator
{
    //класс точки на плоскости – пример для перегрузки операторорв
   class CPoint
    {
        int x, y;
        public CPoint(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        //перегрузка инкремента 
        public static CPoint operator ++(CPoint s)
        {
            CPoint p = new CPoint(s.x, s.y);
            p.x++; 
            p.y++; 
            return p;
        }
        //перегрузка декремента 
        public static CPoint operator --(CPoint s)
        {
            CPoint p = new CPoint(s.x, s.y);
            p.x--; 
            p.y--; 
            return p;
        }
        //перегрузка оператора - (изменение занка)
        public static CPoint operator -(CPoint s)
        {
            CPoint p = new CPoint(s.x, s.y);
            p.x = -p.x; 
            p.y = -p.y; 
            return p;
        }

        public  string GetString()
        {
            return string.Format("X = {0} Y = {1}", x, y);
        }
    }

    class Test
    {
        static void Main()
        {
            CPoint p1 = new CPoint(10, 10);
            //префиксная и постфиксная формы выполняются одинаково
            ++p1;
            Console.WriteLine(p1.GetString());      //x=11,  y=11
            
            CPoint p2 = new CPoint(10, 10);
            p2++;
            Console.WriteLine(p2.GetString());      //x=11, y=11
            --p1;
            Console.WriteLine(p1.GetString());      //x=10, y=10
            
            Console.WriteLine((-p1).GetString());   //x=-10, y=-10
            
            //после выполнения оператора - состояние исходного объекта не изменилось
            
            Console.WriteLine(p1.GetString());      //x=10, y=10
            
            Console.ReadKey();
        }
    }
}

