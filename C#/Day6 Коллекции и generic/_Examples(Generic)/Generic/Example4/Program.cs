using System;

namespace Example4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Использование ограничений в обобщенных классах");
			
			 Console.WriteLine("Простейший обобщенный класс!");
            Point<int> point1 = new Point<int>(1,2);
            Console.WriteLine(point1);
            Console.WriteLine(typeof(Point<int>).ToString());
          
            Point<float> point2 = new Point<float>(1.0f, 2.5f);
            Console.WriteLine(point2);
            Console.WriteLine(typeof(Point<double>).ToString());
            Console.ReadKey();
			
            // ОШИБКА ПАРАМЕТР ТИПА НЕ МОЖЕТ БЫТЬ ТИПОМ ССЫЛКИ
            // Point<string> point2 = new Point<string>("1", "2");
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	// указание ограничения - параметр типа должен быть значимым типом
public class Point<T> where T: struct
{
    T x;   // обобщенное поле
    public T X
    {  get { return x; }
        set { x = value; }
    }
    T y;
    public T Y
    {   get { return y; }
        set { y = value; }
    }
public Point() // конструктор
{   this.x=default(T);
    this.y=default(T);
}
public Point(T x, T y) // конструктор
{
    this.x = x;
    this.y = y;
}
public override string ToString()
{
    return String.Format("X={0}, Y={1}",x.ToString(), y.ToString());
}

}
}