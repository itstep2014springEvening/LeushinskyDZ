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

namespace WPFEXAMDLL
{
    /// <summary>
    /// Interaction logic for MyLittleNumericUD.xaml
    /// </summary>
    public partial class MyLittleNumericUD : UserControl
    {
        public MyLittleNumericUD()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty ValueProperty;
        public static readonly DependencyProperty MaximumProperty;
        public static readonly DependencyProperty MinimumProperty;
        public static readonly DependencyProperty DecimalPlacesProperty;

        static MyLittleNumericUD()
        {
            ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(MyLittleNumericUD),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnValueSet)));
            MaximumProperty = DependencyProperty.Register("Maximum", typeof(double), typeof(MyLittleNumericUD),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMaximumSet)));
            MinimumProperty = DependencyProperty.Register("Minimum", typeof(double), typeof(MyLittleNumericUD),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMinimumSet)));
            DecimalPlacesProperty = DependencyProperty.Register("DecimalPlaces", typeof(double), typeof(MyLittleNumericUD),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnDecimalPlacesSet)));

            ValueChangedEvent = EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble,
                typeof (RoutedEventHandler), typeof (MyLittleNumericUD));
        }

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value);}
        }
        private static void OnValueSet(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ((MyLittleNumericUD)sender).SetValueTextBox();
        }
        void SetValueTextBox()
        {
            tbPathFile.Text = this.Value.ToString();
        }



        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        private static void OnMaximumSet(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ((MyLittleNumericUD)sender).SetMaximum();
        }

        void SetMaximum()
        {
            Maximum = this.Maximum;
        }

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        private static void OnMinimumSet(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ((MyLittleNumericUD)sender).SetMinimum();
        }

        void SetMinimum()
        {
            Minimum = this.Minimum;
        }
        
         public double DecimalPlaces
        {
            get { return (double)GetValue(DecimalPlacesProperty); }
            set { SetValue(DecimalPlacesProperty, value); }
        }

        private static void OnDecimalPlacesSet(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ((MyLittleNumericUD)sender).SetDecimalPlaces();
        }

        void SetDecimalPlaces()
        {
            DecimalPlaces = this.DecimalPlaces;
        }


        public event RoutedEventHandler ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }
        public static RoutedEvent ValueChangedEvent;
       
       

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            double plus = 1;
            for (int i = 0; i < DecimalPlaces; i++)
            {
                plus /= 10;
            }
            //if (Math.Round(DecimalPlaces) != 0)
            //{
            //    double.Parse(tbPathFile.Text)

            //}
            try
            {
                tbPathFile.Text = (double.Parse(tbPathFile.Text) + plus).ToString();
            }
            catch (Exception ex)
            {
                
                
            }
            

        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            double minus = 1;
            for (int i = 0; i < DecimalPlaces; i++)
            {
                minus /= 10;
            }
            try
            {
                tbPathFile.Text = (double.Parse(tbPathFile.Text) - minus).ToString();

            }
            catch (Exception ex)
            {
                
                
            }
           
        }

        private void tbPathFile_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            try
            {
                if (double.Parse(tbPathFile.Text) > Maximum)
                {
                    tbPathFile.Text = (Math.Round(Maximum)).ToString();
                }
                if (double.Parse(tbPathFile.Text) < Minimum)
                {
                    tbPathFile.Text = (Math.Round(Minimum)).ToString();
                }

            }
            catch (Exception)
            {
                
                
            }
            
            RoutedEventArgs args = new RoutedEventArgs(MyLittleNumericUD.ValueChangedEvent, this);
            RaiseEvent(args);

        }
    }
}
