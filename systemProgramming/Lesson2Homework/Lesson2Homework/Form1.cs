using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2Homework
{
    
    public partial class Form1 : Form
    {
        public static SemaphoreSlim s = new SemaphoreSlim(3);
        public List<ThreadsAndIncrements> MyThreadsAndIncrements= new List<ThreadsAndIncrements>();
        public static int ThreadCounter = 0;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 3;
            //Semaphore semaphore = new Semaphore((int)numericUpDown1.Value, (int)numericUpDown1.Value, "S");
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            MyThreadsAndIncrements.Add(new ThreadsAndIncrements(ThreadCounter,new Thread(new ThreadStart(Work))));
            
            createdThreads.Items.Add("Поток "+ (++ThreadCounter)+" -> created");


        }

       

        public class ThreadsAndIncrements
        {
            public Thread Thread;
            public int Increment;

            public ThreadsAndIncrements(int increment,Thread thread )
            {
                this.Thread = thread;
                this.Increment = increment;
            }

            public void DoIncrement()
            {
                Increment++;
            }
        }

        public void ThreadCreated()
        {

            while (true)
            {
                Thread.Sleep(10);
            }
        }

        private void createdThreads_DoubleClick(object sender, EventArgs e)
        {
            string[] index = {"1", "1"};
            try
            {
                index = createdThreads.SelectedItem.ToString().Split();
            }
            catch (Exception)
            {
                
                
            }
            
            createdThreads.Items.Remove(createdThreads.SelectedItem);
          //  if(createdThreads.SelectedItem!=null)

            waitingThreads.Items.Add("Поток" + index[1]+" -> waiting");
           // index = 0;


        }

        private void createdThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            //donothing
        }

        private void waitingThreads_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = Int32.Parse(waitingThreads.SelectedIndex.ToString().Split()[1]);
                MyThreadsAndIncrements[index].Thread.Start();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong");
            }
            
            
            //while (true)
            //{
            //    if (semaphore.Release(3))
            //    {

            //        catch (Exception)
            //        {

            //        }

            //    }

            //}
        }

        public void Work()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
