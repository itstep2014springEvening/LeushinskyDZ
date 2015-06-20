
using System;

namespace Example2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Простейший обобщенный класс c двумя типами!");
            
			Car<int, string> point1 = new Car<int, string>(1,"BMV");
            Console.WriteLine(point1);
            Console.WriteLine(typeof(Car<int, string>).ToString());
          
            Car<string, string> point2 = new Car<string, string>("1R852","BMV");
            Console.WriteLine(point2);
            Console.WriteLine(typeof(Car<string, string>).ToString());
          
            Console.ReadKey();
		}
	} 
	   // создание обобщенного класса (generic класса)
       // класс принимает различные типы для полей класса
public class Car<T, E>
{
    T x;   // обобщенное поле
    public T X
    {  get { return x; }
        set { x = value; }
    }
           
    E name;
    public E Name
    {   get { return name; }
        set { name = value; }
    }
        
public Car() // конструктор
{   this.x=default(T);
    this.name=default(E);
}
        
public Car(T x, E y) // конструктор
{
    this.x = x;
    this.name = y;
}
public override string ToString()
{
    return String.Format("Номер={0}, Наименование={1}",x.ToString(), name.ToString());
}

}
}