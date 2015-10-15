using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace banksearchapp_Ivan
{
    public partial class MainForm : Form
    {
        private bool isRedactorModeActivated = false;
        GMapControl gMapControl1;
        public MainForm()
        {
            InitializeComponent();
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Controls.Add(gMapControl1);
            SetParamsMap();
        }


        private void SetParamsMap()
        {
            gMapControl1 = new GMapControl();
            gMapControl1.Dock = DockStyle.Fill;
            //this.Controls.Add(gMapControl1);

            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gMapControl1.Bearing = 0;
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.Zoom = 16;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            gMapControl1.CanDragMap = true;
            gMapControl1.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);


        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BankFinder v1.0."+Environment.NewLine+"Author - Ivan Leushynski.");
        }

        private void режимРедактированияToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (режимРедактированияToolStripMenuItem.Checked)
            {
                isRedactorModeActivated = true;
            }
            else
            {
                isRedactorModeActivated = false;
            }
        }
    }
}
