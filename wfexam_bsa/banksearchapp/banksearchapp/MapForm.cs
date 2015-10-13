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
    public partial class MapForm : Form
    {
        GMapControl gMapControl1;
        public MapForm()
        {
            //InitializeComponent();
            //Load+=MapForm_Load;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
           // SetParamsMap();
        }

        private void SetParamsMap()
        {
            gMapControl1 = new GMapControl();
            gMapControl1.Dock = DockStyle.Fill;
            this.Controls.Add(gMapControl1);

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
    }
}
