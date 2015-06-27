using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
Assembly assembly = null;

try
{
    assembly = Assembly.Load("TestClassLib");
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
// Создание экземпляра класса SportsCar "на лету"
// При помощи класса Activator производится позднее связывание.
// Метод CreateInstance() - предназначен для создания экземпляра типа во время выполнения.
Type type = assembly.GetType("TestClassLib.SportsCar");
           
object instance = Activator.CreateInstance(type);
        
// Получаем экземпляр класса MethodInfo для метода Acceleration(). 
MethodInfo method = type.GetMethod("Acceleration");

// Вызов метода Acceleration().
// Первый параметр - ссылка на экземпляр для которого будет вызван метод Acceleration
// Второй параметр - массив аргументов метода Acceleration (в данном случае без параметров - null)
method.Invoke(instance, null);

// Получаем экземпляр класса MethodInfo для метода Driver(). 
method = type.GetMethod("Driver");

// Массив параметров для метода Driver("Водитель", 45). 
object[] parameters = { "Иванов И.И.!", 45 };

// Вызов метода Driver().
// Первый параметр - ссылка на экземпляр для которого будет вызван метод Acceleration
// Второй параметр - массив аргументов метода Acceleration (в данном случае - name:"Shumaher", age:36 )
method.Invoke(instance, parameters);

           
            Console.ReadKey();
         }
    }
}
