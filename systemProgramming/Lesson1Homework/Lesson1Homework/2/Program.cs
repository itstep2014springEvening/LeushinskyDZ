using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Bank a = new Bank(10000,15,"PriorBank");
            Bank b = new Bank(20000,20, "BelarusBank");
            Console.ReadLine();
        }

        public class Bank : INotifyPropertyChanged
        {
            public int Money;
            public int Percent;
            public string name;

            protected void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, e);
            }

            protected void OnPropertyChanged(string propertyName)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(name));
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value != name)
                    {
                        name = value;
                        OnPropertyChanged("Name");
                    }
                    ParameterizedThreadStart pts = new ParameterizedThreadStart(WrightItToDisc);
                    Thread t = new Thread(pts);
                    t.Start(new List<string>() {Money.ToString(), Percent.ToString(), Name});
                    
                    Console.WriteLine("Данные записаны");
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        
            
        public Bank(int money,  int percent,string name)
            {
                this.Money = money;
                this.Percent = percent;
                this.Name = name;
                
            }
            
        }

        public static void WrightItToDisc(object a)
        {
            StreamWriter sw = new StreamWriter(new FileStream("Class.txt", FileMode.Append,FileAccess.Write));
            foreach (var s in (List<string>)a)
            {
                sw.Write(s+Environment.NewLine);
            }
            
            sw.Close();
        }
    }

}
