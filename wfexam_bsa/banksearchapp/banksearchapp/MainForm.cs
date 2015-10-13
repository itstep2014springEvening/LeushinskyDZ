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
namespace banksearchapp
{
    public partial class MainForm : Form
    {
        GMapControl gMapControl1;
        public MainForm()
        {
            InitializeComponent();
            //splitContainer1.Panel1.
            Load += MainForm_Load;
            splitContainer1.Panel1.Controls.Add(gMapControl1);

        }

        void MainForm_Load(object sender, EventArgs e)
        {
            MapForm mf = new MapForm();
            mf.MdiParent = this;
            mf.WindowState = FormWindowState.Maximized;
            mf.Show();
           // SetParamsMap();
            //MessageBox.Show("123");
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //SetParamsMap();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            SetParamsMap();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.MdiParent = this;
            sf.WindowState = FormWindowState.Normal;
            
            sf.Show();
            
        }

        private void splitContainer1_Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

    }
}
