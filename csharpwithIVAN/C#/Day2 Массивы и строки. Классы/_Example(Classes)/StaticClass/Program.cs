using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.Balance = 500000;
            Bank bank = new Bank();  // ОШИБКА! СОЗДАНИЕ ОБЪЕКТА СТАТИЧЕСКОГО КЛАССА НЕВОЗМОЖНО!

        }
    }

    public static class Bank
    {
        public static decimal Balance;

        static Bank()
        {
            Balance = 1000000;
        }
    }

}
