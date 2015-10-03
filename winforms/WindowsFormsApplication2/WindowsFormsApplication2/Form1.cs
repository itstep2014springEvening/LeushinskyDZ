using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> nodeNames = new List<string>();
            //string constr = @"cd_catalog _1.xml";
            //var doc = new XmlDataDocument();
            //doc.Load(constr);
            //foreach(XmlNode xn in doc.LastChild)
            //{
            //    nodeNames.Add(xn.Name);
            //}
            //dataGridView1.DataSource = nodeNames;
           // DataSet ds = new DataSet();
           // ds.ReadXml(@"cd_catalog _1.xml");
           //// dataGridView1.DataSource = ds.Tables[0];
           // var res = ds.Tables[0].AsEnumerable().Select(no=>new {
           //     Artist = no.Field<string>("Title")
           // });
           // //var res = from a in ds.Tables[0].AsEnumerable().Select() a;
           // dataGridView1.DataSource = res;
            
            List<string> nodeNames = new List<string>();
            string constr = @"cd_catalog _1.xml";
            var doc = new XmlDataDocument();
            doc.Load(constr);
            //MessageBox.Show(doc.LastChild.LastChild.LastChild.Name);
            
            foreach(XmlNode xnode in doc.ChildNodes)
            {
                nodeNames.Add(xnode.Name);
            }
            listBox1.DataSource = nodeNames;
           
        }
        public void nodeinnodes(XmlNode xnode)
        {
            if(x)
        }

    }
}
