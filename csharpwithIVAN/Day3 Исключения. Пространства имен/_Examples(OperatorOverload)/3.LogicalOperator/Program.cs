using System;


class CPoint
{
    private int x;
    private int y;

    public CPoint(int x, int y)
    {
        this.x = x; this.y = y;
    }

    //перегрузка бинарного оператора & (оператор ) 
    public static bool  operator &(CPoint A, CPoint B)
    {
        if(A.x==B.x && A.y==B.y)
        return true;
        else return false;
    }

    //перегрузка бинарного оператора | (произведение точек)
    public static bool operator |(CPoint A, CPoint B)
    {
        if (A.x == B.x || A.y == B.y)
            return true;
        else return false;
    }

    // Перегружаем оператор false
    public static bool operator false(CPoint obj)
    {
        if ((obj.x <= 0) || (obj.y <= 0))
            return true;
        return false;
    }

    // Обязательно перегружаем оператор true
    public static bool operator true(CPoint obj)
    {
        if ((obj.x > 0) && (obj.y > 0))
            return true;
        return false;
    }
       
    public string GetString()
    {
        return string.Format("Point: X = {0} Y = {1}", x, y);
    }

 
}

class Program
{
    static void Main(string[] args)
    {
        CPoint p1 = new CPoint(10, 10);
        CPoint p2 = new CPoint(10, 10);
        Console.WriteLine("Точка p1: {0}", p1.GetString());
        Console.WriteLine("Точка p2: {0}", p2.GetString());
        if(p1&p2)  // сравнение объектов класса CPoint 
            Console.WriteLine("   У точек p1 и p2 общие координаты");
        
        CPoint p3 = new CPoint(20, 10);
        CPoint p4 = new CPoint(20, -10);
        if (p3 | p4)  // сравнение объектов класса CPoint 
            Console.WriteLine("   Точки p3 и p4 имеют общие координаты");

        CPoint p5 = new CPoint(10,10);
        if (p5)
            Console.WriteLine("Все координаты объекта p5 положительны");

        Console.ReadKey();
    }
}
