
using System;

namespace Example3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Наследование обобщенных классов");
			ColorPoint1<string, int> cPoint1 = new ColorPoint1<string, int>("Red", 10,20);
			Console.WriteLine(cPoint1.GetInfo());
			
			
			ColorPoint2<string> cPoint2 = new ColorPoint2<string>("Green", 12,17);
		    Console.WriteLine(cPoint2.GetInfo());
			
		    Console.ReadKey(true);
		}
	}
	// наследование от обобщенного класса
  	public class ColorPoint1<W, T>:Point<T>
	{
		W Color {get; set;}
		
		public ColorPoint1 (W color,T x , T y):base (x,y)
		{
		Color =color;
		}
		
		public override string GetInfo()
		{
			return base.GetInfo()+"Цвет: "+Color;
		}
	}
	
	// наследование от обобщенного класса
	// установка типа полей класса Point
	public class ColorPoint2<W>:Point<short>
	{
		W Color {get; set;}
		
		public ColorPoint2 (W color,short x , short y):base (x,y)
		{
		Color =color;
		}
		
		public override string GetInfo()
		{
			return base.GetInfo()+"Цвет: "+Color;
		}
	}
	
    public class Point<T>
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
    public virtual string GetInfo()
    {
        return String.Format("X={0}, Y={1}",x.ToString(), y.ToString());
    }

    }
}