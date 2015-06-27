using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example6Assembly
{
    class Program
    {
       static void Main()
        {
           
// При помощи класса Assembly - можно динамически загружать сборки, 
// обращаться к членам класса в процессе выполнения, а так же получать информацию о самой сборке.
Assembly assembly = null;

try
{
    // Assembly.Load() - метод для загрузки сборки.
    assembly = Assembly.Load("TestClassLib");
    Console.WriteLine("Сборка TestClassLib - успешно загружена.");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

// Выводим информацию о всех типах в сборке.
Console.WriteLine(new string('_', 80));
Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

Type[] types = assembly.GetTypes();

foreach (Type t in types)
    Console.WriteLine("Тип: {0}", t);
          
// Выводим информацию о членах выбранного типа.
Console.WriteLine(new string('_', 80));

Type type = assembly.GetType("TestClassLib.SportsCar");
Console.WriteLine("\nЧлены класса: {0} \n", type);
MemberInfo[] members = type.GetMembers();
foreach (MemberInfo element in members)
    Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);

           Console.ReadKey();
        }
       
    }
}
