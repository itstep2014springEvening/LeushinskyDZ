using System;
using System.Collections;


namespace Example21
{
    class Program
    {
      //  В  программе создадим массив типа ArrayList, а затем упорядочивается. 
      //  Упорядочение делаем по фамилиям в алфавитном порядке, в случае одинаковых фамилий — по возрастанию средних оценок.
      //  Сортировка осуществялется с использованием интерфейса IComparer и метода Compare

        public static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса Student");
            Console.WriteLine("\nСписок студентов до сортировки:");
            
            ArrayList x = new ArrayList();
            x.Add(new Student("Иванов", 3.5));
            x.Add(new Student("Петров", 4.2));
            x.Add(new Student("Бобриков", 4.5));
            x.Add(new Student("Сидоров", 4.8));
            x.Add(new Student("Бобриков", 3.0));
            Student st = new Student();
            for (int i = 0; i < x.Count; i++)
            {
                st = (Student)x[i];
                st.print();
            }
            
                   
            x.Sort();
            
            Console.WriteLine("\nСписок студентов после сортировки:");
            for (int i = 0; i < x.Count; i++)
            {
                st = (Student)x[i];
                st.print();
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }

    public class Student : IComparable
    {
        private string fio;
        private double ochenka;
        public Student()
        {
            fio = "NoName";
            ochenka = 0;
        }
        public Student(string f, double o)
        {
            fio = f;
            ochenka = o;
        }
        public void print()
        {
            Console.WriteLine("FIO = {0}  средняя оценка = {1}", fio, ochenka);
        }

        
        public int CompareTo(Object St)
        {
            Student x = (Student)St;
         
            if (String.Compare(x.fio, this.fio) < 0)
            {
                return 1;
            }
            else if (String.Compare(x.fio, this.fio) == 0)
            {
                if (x.ochenka < this.ochenka)
                    return 1;
                else if (x.ochenka == this.ochenka)
                    return 0;
                else
                    return -1;
            }
            else
                return -1;
        }
      
    }
  
}
