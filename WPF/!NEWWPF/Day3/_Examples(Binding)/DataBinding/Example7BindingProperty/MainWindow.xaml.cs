using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example8BindingProperty
{
    // уведомление элемента управления об изменении свойства в коде
    // необходимо для окна реализовать интерфейс INotifyPropertyChanged
    public partial class MainWindow : Window, INotifyPropertyChanged 
    {
        // интерфейс INotifyPropertyChanged предоставляет событие
        // PropertyChanged, которое обеспечивает передачу информации элементу 
        // управления при изменении значения свойства в коде
        public event PropertyChangedEventHandler PropertyChanged;

        string nameApp="Привязка к свойству";
        public string NameApp
        {
            get { return nameApp; }
            set {
                   nameApp = value;
                   // вызов события PropertyChanged с передачей через PropertyChangedEventArgs
                   // имени изменяемого свойства 
                   if (PropertyChanged!=null)
                     PropertyChanged(this, new PropertyChangedEventArgs("NameApp"));
                }
        
        }

        public MainWindow()
        {
            InitializeComponent();
                     
        }

        // Изменение значения в коде 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameApp = "Изменение свойства из кода";
        }

       
    }
}
