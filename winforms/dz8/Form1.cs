using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace dz8
{
    public partial class Form1 : Form
    {
        private List<MailEvents> _events;
        Timer MailTimer = new Timer();
        SmtpClient smtp;
        List<TreeNode> ListOfChekedNodes = new List<TreeNode>();
        Dictionary<TreeNode, string> NameAndEmails = new Dictionary<TreeNode, string>();
        string[] eMails = { "dardillov999@mail.ru", "dardillov999@mail.ru", "dardillov999@mail.ru", "dardillov999@mail.ru", "dardillov999@mail.ru",
                          "dardillov999@mail.ru","dardillov999@mail.ru","dardillov999@mail.ru","dardillov999@mail.ru","dardillov999@mail.ru"};
        MailMessage message = new MailMessage();
        string[] Servers = { "MAIL.RU" };
        ListBox asd = new ListBox();
        
        //string[] nodeNames = new string[100];
        public Form1()
        {
            _events = new List<MailEvents>();
            InitializeComponent();
            textBox2.Focus();
            MailTimer.Interval = 1000;
            MailTimer.Start();
            MailTimer.Tick += MailTimer_Tick;
            smtp = new SmtpClient("smtp.mail.ru", 25);
            smtp.Credentials = new NetworkCredential("228overlord228@mail.ru", "overlordoverlordoverlordoverlord");
            smtp.EnableSsl = true;
            string[] Occasions = { "День рождения", "Свадьба", "Проводы", "Крестины", "Годовщина" };
            comboBox1.DataSource = Occasions;
            comboBox2.DataSource = Servers;
            NameAndEmails.Add(treeView1.Nodes[0], eMails[0]);
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolTip1.Show("Письмо отправлено", label6);
        }

        void MailTimer_Tick(object sender, EventArgs e)
        {
            foreach(MailEvents me in _events)
            {
                if (me.EventTime.Second == DateTime.Now.Second && me.EventTime.Minute == DateTime.Now.Minute)
                {

                    backgroundWorker1.RunWorkerAsync(me);
                  
                        
                    
                }
            }
        }
        
       
        
        string CheckedNodes = "";
        public List<TreeNode> GetNameNodes (TreeNode tr)
        {
          
            for(int i=0;i<tr.Nodes.Count;i++)
            {
                
                if(tr.Nodes[i].Checked)
                {
                   
                   ListOfChekedNodes.Add(tr.Nodes[i]);
                }
                GetNameNodes(tr.Nodes[i]);
                //NodesNames += tr.Nodes[i].Text+Environment.NewLine;
                
               
                
            }
            return ListOfChekedNodes;
        }
        public void CheckChildrensIfParentsChecked(TreeNode tr)
        {
            for(int i=0;i<tr.Nodes.Count;i++)
            {
                tr.Nodes[i].Checked = tr.Checked;
                if(tr.Nodes==null)
                {
                    NameAndEmails.Add(tr.Nodes[i], eMails[i]);
                }
                
                if (tr.Nodes[i].Checked)
                    tr.ExpandAll();
                //if(tr.Checked&&tr.Nodes.Count!=0)
                //{
                //    tr.Nodes[i].Checked=true;
                //}
                CheckChildrensIfParentsChecked(tr.Nodes[i]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime DateTimeOnPicker = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute,dateTimePicker1.Value.Second);
            
            MailEvents me = new MailEvents();
            me.Message = textBox2.Text;
            if (comboBox1.SelectedValue != null)
            me.Occasion = comboBox1.SelectedValue.ToString();
            me.Recipient = NameAndEmails[treeView1.Nodes[0]];
            me.EventDate = monthCalendar1.SelectionStart;
            me.EventTime = DateTimeOnPicker;

            
            //GetNameNodes(tr);
            
            //foreach (TreeNode trnd in ListOfChekedNodes)
            //{
            //    textBox2.Text += trnd.Text;
            //}
            

            //for(int i=0;i<nodeNames.Length;i++)
            //{
            //    textBox2.Text += nodeNames[i];
            //}
            //int i = 0;
            //foreach (TreeNode tn in treeView1.Nodes)
            //{
            //    tn.Expand();
            //    i++;
            //    //tn.
            //    if(tn.NextNode!=null )
            //    {

                    
            //    }
            //}
            //for (i = 0; i < treeView1.Nodes.Count;i++ )
            //{
            //    if(treeView1.HasChildren)
            //    {
            //        i++;
            //    }
            //}
                //MessageBox.Show(i.ToString());
            _events.Add(me);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckChildrensIfParentsChecked(e.Node);
        }

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var me = (MailEvents)e.Argument;
            message.From = new MailAddress("228overlord228@mail.ru");
            message.To.Add(new MailAddress(me.Recipient));
            message.Subject = me.Occasion;
            message.Body = me.Message;
            smtp.Send(message);
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            string file = opf.FileName;
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Pdf);

            // Добавляем информацию для файла
            ContentDisposition disposition = attach.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            //добавление вложения
            message.Attachments.Add(attach);

        }
    }
}
