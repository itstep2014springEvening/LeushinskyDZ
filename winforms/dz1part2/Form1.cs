using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Label newLabel = new Label();
            //newLabel.Top = 25;
            //newLabel.Left = 25;
            //newLabel.Height = 250;
            //newLabel.Width = 250;
            //newLabel.BorderStyle = BorderStyle.Fixed3D;
            //this.Controls.Add(newLabel);
            MouseClick += OnMouseClick;
            KeyDown += Form1_KeyDown;
            
            MouseMove += Form1_MouseMove;


        }





        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left && e.Control)
            {
                Close();
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            switch (mouseEventArgs.Button)
            {
                case MouseButtons.Left:
                    if (mouseEventArgs.X == 25 && 25 < mouseEventArgs.Y && mouseEventArgs.Y < 275 ||
                        mouseEventArgs.Y == 25 && 25 < mouseEventArgs.X && mouseEventArgs.X < 275 ||
                        mouseEventArgs.X == 275 && 25 < mouseEventArgs.Y && mouseEventArgs.Y < 275 ||
                        mouseEventArgs.Y == 275 && 25 < mouseEventArgs.X && mouseEventArgs.X < 275)
                    {
                        MessageBox.Show("Вы на границе прямоугольника");
                    }
                    else if (25 < mouseEventArgs.X && mouseEventArgs.X < 275 && 25 < mouseEventArgs.Y && mouseEventArgs.Y < 275)
                    {
                        MessageBox.Show("Вы внутри прямоугольника");
                    }
                    else
                    {
                        MessageBox.Show("Вы снаружи прямоугольника");
                    }
                    break;
                case MouseButtons.Right:
                    Text = "Ширина = " + Size.Width + " Высота = " + Size.Height;//Оно работает, в отладчике проверил, просто маусмув его глушит.
                    break;
            }
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                if (25 < e.X && e.X < 275 && 25 < e.Y && e.Y < 275)
                {
                    if (e.Button == MouseButtons.Right)
                    {Text = "Ширина = " + Size.Width + " Высота = " + Size.Height;}
                    else
                    Text = "X =" + e.X + "/Y=" + e.Y;
                }
            }
           

        }

    }

