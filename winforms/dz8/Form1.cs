using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz8
{
    public partial class Form1 : Form
    {
        //string[] nodeNames = new string[100];
        public Form1()
        {
            InitializeComponent();
            
            
        }
        List<TreeNode> ListOfChekedNodes = new List<TreeNode> ();
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
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            TreeNode tr = treeView1.TopNode;
            
            GetNameNodes(tr);
            foreach (TreeNode trnd in ListOfChekedNodes)
            {
                textBox2.Text += trnd.Text;
            }
            

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
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
