//http://habrahabr.ru/post/213809/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz5
{
    
    public partial class Form1 : Form
    {
        List<Car> Cars = new List<Car>();
        Timer RaceTimer = new Timer();
        Car car1 = new Car();
        Car car2 = new Car();
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
            RaceTimer.Tick += RaceTimer_Tick;
            RaceTimer.Interval = 1;
            
            label1.Text = "F\nI\nN\nI\nS\nH";
            
            
            car1.CarFinished += car1_CarFinished;
            car2.CarFinished += car2_CarFinished;
            car1.Location = new Point(124,152);
            car1.Size = new Size(75,23);
            car1.Text = "BMW";
            car1.BringToFront();
            this.Controls.Add(car1);
            car2.Location = new Point(124, 206);
            car2.Size = new Size(75, 23);
            car2.Text = "LADA";
            car2.BringToFront();
            this.Controls.Add(car2);

        }

        void car2_CarFinished()
        {
            
        }

        void car1_CarFinished()
        {
            MessageBox.Show("AHAHA OLOLO");
       
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            RaceTimer.Start();
        
            //button1.Left += 7;
        }

        void RaceTimer_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            car1.Left+=r.Next(1,5)+trackBar1.Value;
            car2.Left += r.Next(1, 6) + trackBar1.Value;
            foreach(var car in Cars)
            {
                if ((car.Left + car.Width) >= groupBox1.Left)
                {
                    RaceTimer.Stop();
                    car.CarFinish();
                }
            }
            
                
               
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            RaceTimer.Stop();
            car1.Left = 124;
            car2.Left = 124;
            
        }
    }
}
