using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить информацию обо всех устройствах.
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            // Вывести сведения об устройствах.
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Name: {0}", d.Name);	//	имя
                Console.WriteLine("Type: {0}", d.DriveType);	//	тип
                Console.WriteLine("Root: {0}", d.RootDirectory);	//	тип
                // Проверить, смонтировано ли устройство.
                if (d.IsReady)
                {
                    Console.WriteLine("Total space: {0}", d.TotalSize);// размер в байтах.
                    Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Available space: {0}", d.AvailableFreeSpace);
                    // Свободное пространство
                    Console.WriteLine("Format: {0}", d.DriveFormat);	//	формат
                    Console.WriteLine("Label: {0}", d.VolumeLabel);	//	метка
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
