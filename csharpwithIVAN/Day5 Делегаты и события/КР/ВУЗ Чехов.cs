using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    abstract class Employee
    {
        public int Experience
        {
            get { return experience; }
        }
        public double Salary
        {
            get { return salary;}
        }
        public string Name
        {
            get { return name; }
        }
        protected string name;
        protected int experience;
        protected double rato;
        protected double salary;
    }
    class Professor:Employee
    {
       public Professor(string name)
        {
            this.name = name;
            rato = 5;
            salary = rato * 200;
            experience = 20;
        }
    }
    class Aspirant : Employee
    {
       public Aspirant(string name)
        {
            this.name = name;
            rato = 2;
            salary = rato * 200;
            experience = 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employes=new Employee[10];
            for (int i = 0; i < employes.Length; ++i)
            {
                if (i < 5) employes[i] = new Professor("Professor");
                else employes[i] = new Aspirant("Asprirant");
            }
        }
    }
}
