using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using ClassLibrary1WcfServiceLibrary1;


namespace Person_AssemblySample__example4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName("ClassLibrary1WcfServiceLibrary1.dll"));
            Module module = assembly.GetModule("ClassLibrary1WcfServiceLibrary1.dll");
            Console.WriteLine("Data types:");
            foreach (Type t in module.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }
            Console.WriteLine(Environment.NewLine);
            Type Person = module.GetType("ClassLibrary1WcfServiceLibrary1.Person") as Type;
            object person = Activator.CreateInstance(Person, new object[] {"Ivan", "Ivanon", 33});
            Person.GetMethod("Print").Invoke(person, null);
            Console.Read();
        }
    }
}
