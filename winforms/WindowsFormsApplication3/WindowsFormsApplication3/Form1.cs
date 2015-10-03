using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> nodenames = new List<string>();
            var doc = new XmlDocument();
            doc.Load("cd_catalog _1.xml");
            foreach(XmlNode xnode in doc.ChildNodes)
            {
                nodenames.Add(xnode.Name);
                nodeinnodes(xnode, nodenames);
                
            }
            listBox1.DataSource = nodenames;
            
        }
        public List<string> nodeinnodes(XmlNode xnode, List<string> nodenames)
        {
            if(xnode.HasChildNodes)
            {
                foreach(XmlNode xn in xnode.ChildNodes)
                {
                    nodenames.Add(xn.Name);
                    nodeinnodes(xnode.FirstChild, nodenames);
                }
            }
            return nodenames;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"cd_catalog _1.xml");
            listBox1.DataSource = text.ToList();
        }
    }
    
}
