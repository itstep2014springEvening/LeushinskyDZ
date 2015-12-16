using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson1Homework
{
    internal class Program
    {
        public static char[] RandomLetters = {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o'};
        public static Random Random = new Random();
        public static char Target = RandomLetters[Random.Next(1, RandomLetters.Length)];
        public static ulong ElapsedTime = new ulong();

        private static void Main(string[] args)
        {
            TimerCallback tcForElapsedTime = new TimerCallback(TimerMethodElapsedTime);
            Timer timerForElapsedTime = new Timer(tcForElapsedTime);
            
            Console.WriteLine("Hello user, it's play time!");
            Console.WriteLine("You will see random letter, press it on a keyboard as fast as possible!");
            Console.WriteLine("Enter g when you are ready!");

            if (Console.Read() == 'g')
            {
                Console.WriteLine("GO!");
                timerForElapsedTime.Change(0, 1);
                Console.Clear();
                Console.WriteLine(Target);
                Console.Read();
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key.ToString().ToLower()==Target.ToString())
                    {
                        Console.WriteLine("\n\n\nYou did it!!!");
                        Console.WriteLine("Your reaction = " + ElapsedTime+"ms");
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine("Enter any key to exit.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Try Again!");
            }
            Console.ReadLine();
        }
        private static void TimerMethodElapsedTime(object state)
        {
            ElapsedTime++;
        }
    }
}
