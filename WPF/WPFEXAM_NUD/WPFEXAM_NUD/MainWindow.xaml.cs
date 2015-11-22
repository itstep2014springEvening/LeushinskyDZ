using System;
using System.Collections.Generic;
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
using WPFEXAMDLL;

namespace WPFEXAM_NUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void MyLittleNumericUD_OnValueChanged(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("123");
        }

        private void MaximumSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void MaxTB_TextChanged(object sender, TextChangedEventArgs e)
        {
          //  (Math.Round(Double.Parse(MaxTB.Text))).ToString();
        }
    }
}
