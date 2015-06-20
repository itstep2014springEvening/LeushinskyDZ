using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        // поля класса
        public string firstName = "Петя";  // открытая переменная (доступна на уровне объекта вне класса Student) 
        private string lastName="Петров";  // закрытая переменная (доступна на уровне объекта вне класса Student) 
        int group=10113;                   // закрытая перменная (по умолчанию private)
        
        // статическое поле 
        private static string academyName = "Компьютерная академия \"ШАГ\"";

        // метод (без возврашаемого значения)
        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Группа: " + group);
        }
        // статический метод (работает только со статическими полями!)
        public static void ShowAcademy()
        {
           Console.WriteLine(academyName);
        }

        // метод (с возврашаемым значением типа int)
        public int GetMark()
        {
            return new Random().Next(1, 10);
        }


    }
}
