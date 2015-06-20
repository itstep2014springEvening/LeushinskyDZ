using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
//-----------------------------------------------------
            // Создать новый файл на диске С: .
            FileInfo file1 = new FileInfo(@"C:\Test.dat");
            FileStream fs1 = file1.Create();
            // Использовать объект FileStream...
            // Закрыть файловый поток.
            fs1.Close();
//-----------------------------------------------------            
            // Определение контекста using для файлового ввода-вывода.
            FileInfo file2 = new FileInfo(@"C:\Test.dat");
            using (FileStream fs2 = file2.Create())
            {
            // Использовать объект FileStream...
            }
//-----------------------------------------------------
            // Создать новый файл через FileInfo.Open().
            FileInfo file3 = new FileInfo(@"C:\Test2.dat");
            using(FileStream fs3 = file3.Open(FileMode.OpenOrCreate,
                                         FileAccess.ReadWrite, FileShare.None))
            {
            // Использовать объект FileStream...
            }
//-----------------------------------------------------
            // Получить объект FileStream с правами только для чтения.
            FileInfo file4 = new FileInfo(@"C:\Test3.dat");
            using(FileStream readOnlyStream = file4.OpenRead())
            {
            // Использовать объект FileStream...
            }
//-----------------------------------------------------
            // Теперь получить объект FileStream с правами только для записи.
            FileInfo file5 = new FileInfo(@"C:\Test4.dat");
            using(FileStream writeOnlyStream = file5.OpenWrite())
            {
            // Использовать объект FileStream...
            }
//-----------------------------------------------------
            // Получить объект StreamReader.
            FileInfo file6 = new FileInfo(@"C:\boot.ini");
            using(StreamReader sreader = file6.OpenText())
            {
            // Использовать объект StreamReader...
            }

            FileInfo file7 = new FileInfo(@"C:\Test6.txt");
            using(StreamWriter swriter = file7.CreateText())
            {
            // Использовать объект StreamWriter...
            }

            FileInfo file8 = new FileInfo(@"C:\FinalTest.txt");
            using(StreamWriter swriterAppend = file8.AppendText())
            {
            // Использовать объект StreamWriter...
            }


        }
    }
}
