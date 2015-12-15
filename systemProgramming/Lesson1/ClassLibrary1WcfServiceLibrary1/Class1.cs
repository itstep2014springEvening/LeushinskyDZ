using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1WcfServiceLibrary1
{
    public enum PersonMaritalStatus
    {
        Merried,
        Single
    }
    [Serializable]
    public class Person
    {
        public string Name;
        public string LastName;
        public int Age;
        public PersonMaritalStatus MaritalStatus;

        public Person(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
            this.MaritalStatus = PersonMaritalStatus.Single;
        }

        public void Print()
        {
            Console.WriteLine("Person name: "+ Name+Environment.NewLine+"Person lastname: "+ LastName+Environment.NewLine+"Person age: "+ Age);
        }
    }

    public class Employee : Person
    {
        private string Position;
        private decimal Salary;

        public Employee(string name, string lastname, int age, string position, decimal salary)
            : base(name, lastname, age)
        {
            this.Position = position;
            this.Salary = salary;
        }
    }
}
