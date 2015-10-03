using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApplication1wftest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForm form = new MainForm();
            Application.Run(form);
            
            //Button btn = new Button();
            //btn.Width = 100;
            //btn.Height = 30;
            //btn.Text = "123";
            //form.Controls.Add(btn);
            //Console.WriteLine("OLOLO");
            //Console.Read();
            
        }
    }
    class MainForm:Form
    {
        Label label1;
        public MainForm()
        {
            label1 = new Label();
            label1.Text = "Ololo";
            label1.Location = new Point(10,10);
            label1.Size = new Size(100,100);
            label1.BackColor = Color.Aqua;
            label1.Font = new Font("Arial", 16);
            Timer timer1 = new Timer();
            timer1.Start();
            timer1.Interval= 1000;
            timer1.Tick += timer1_Tick;
            
            this.Controls.Add(label1);

            Button btn = new Button();
            btn.Text = "lol";
            btn.Location = new Point(100, 20);
            btn.Click += new EventHandler(btn_Click);
            this.Controls.Add(btn);

        }

        void btn_Click(object sender, EventArgs e)
        {
            label1.Text = "ahaha";
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            int x = 50;
            int y = 50;
            while(true)
            {
                
                label1.Location = new Point(x, y);
                //throw new NotImplementedException();
                x++; y++;
            }
            
        }
        

    }
}
