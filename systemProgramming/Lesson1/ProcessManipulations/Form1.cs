using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;

namespace ProcessManipulations
{
    public partial class Form1 : Form
    {
        const uint WM_SETTEXT = 0x0C;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int wParam,
            [MarshalAs(UnmanagedType.LPStr)] string lParam);

        public List<Process> Processes = new List<Process>();
        public int Counter = 0;

        public delegate void ProcessDelegate(Process process);


        void LoadAvailableAssemblies()
        {
            string except = new FileInfo(Application.ExecutablePath).Name;
            except = except.Substring(0, except.IndexOf("."));
            string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
            foreach (var file in files)
            {
                string fileName = new FileInfo(file).Name;
                if (fileName.IndexOf(except) == -1)
                {
                    listBox2.Items.Add(fileName);
                }
            }
        }

        void RunProcess(string assemblyName)
        {
            Process process = Process.Start(assemblyName);
            Processes.Add(process);
            if (Process.GetCurrentProcess().Id == GetParentProcessId(process.Id))
            {
                MessageBox.Show(process.ProcessName + " действительно дочерний процесс текущего процесса");
                process.EnableRaisingEvents = true;
            }
            
            process.Exited += Process_Exited;
            SetChildWindowText(process.MainWindowHandle, "Child process #" + (++Counter));
            if (!listBox2.Items.Contains(process.ProcessName))
            {
                listBox2.Items.Add(process.ProcessName);
            }
            listBox1.Items.Remove(listBox2.SelectedItem);
        }
        void SetChildWindowText(IntPtr handle, string text)
        {
            SendMessage(handle, WM_SETTEXT, 0, text);
        }

        int GetParentProcessId(int id)
        {
            int parentId = 0;
            using (ManagementObject obj = new ManagementObject("win32_process.handle=" + id.ToString()))
            {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }

        

        public void Process_Exited(object sender, EventArgs e)
        {
            Process process = sender as Process;
            listBox1.Items.Remove(process.ProcessName);
            listBox2.Items.Add(process.ProcessName);
            Processes.Remove(process);
            Counter--;
            int index = 0;
            foreach (var p in Processes)
            {
                SetChildWindowText(p.MainWindowHandle, "Child processes #" + ++index);
            }
        }

        public void ExecuteOnProcessByName(string processName, ProcessDelegate func)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (var process in processes)
            {
                if (Process.GetCurrentProcess().Id==GetParentProcessId(process.Id))
                {
                    func(process);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadAvailableAssemblies();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunProcess(listBox2.SelectedItem.ToString());
        }

        void Kill(Process process)
        {
            process.Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessByName(listBox1.SelectedItem.ToString(), Kill);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        void CloseMainWindow(Process process)
        {
            process.CloseMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessByName(listBox1.SelectedItem.ToString(),CloseMainWindow);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        void Refresh(Process process)
        {
            process.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessByName(listBox1.SelectedItem.ToString(), Refresh);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var p in Processes)
            {
                p.Kill();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RunProcess("calc.exe");
        }
    }
}
