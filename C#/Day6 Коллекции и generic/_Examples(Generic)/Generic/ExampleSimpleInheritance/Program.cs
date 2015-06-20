using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Наследование обобщенных классов");
            ColorPoint1<int> cPoint1 = new ColorPoint1<int>("Red", 10, 20);
            Console.WriteLine(cPoint1.GetInfo());
            Console.ReadKey(true);
        }
    }

    public class ColorPoint1<T> : Point<T>
    {
        string  Color { get; set; }

        public ColorPoint1(string color, T x, T y)
            : base(x, y)
        {
            Color = color;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "Цвет: " + Color;
        }
    }

    public class Point<T>
    {
        T x;   // обобщенное поле
        public T X
        {
            get { return x; }
            set { x = value; }
        }
        T y;
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point() // конструктор
        {
            this.x = default(T);
            this.y = default(T);
        }
        public Point(T x, T y) // конструктор
        {
            this.x = x;
            this.y = y;
        }
        public virtual string GetInfo()
        {
            return String.Format("X={0}, Y={1}", x.ToString(), y.ToString());
        }

    }
}
