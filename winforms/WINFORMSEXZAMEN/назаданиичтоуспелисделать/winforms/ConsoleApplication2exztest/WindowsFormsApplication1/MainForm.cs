using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void цветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColonsForm clfr = new ColonsForm();
            clfr.MdiParent = this;
            clfr.WindowState = FormWindowState.Maximized;
            clfr.Show();
            
        }

        private void режим1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form dorm in this.MdiChildren)
            {
                dorm.WindowState = FormWindowState.Minimized;
            }
        }

        private void режим2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
