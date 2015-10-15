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
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using DbManipulating;

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
            

            


            //Console.Read();

            //var doc = new XmlDocument();
            //doc.Load(@"kurs.xml");
            //List<string> nodes = new List<string>();
            //foreach (XmlNode node in doc.SelectNodes("banks"))
            //{
            //    foreach (XmlNode child in node.ChildNodes)
            //    {
                    
            //        //for(int i=3;i<=5;i++)
            //        //nodes.Add(child.ChildNodes[i].Name+ child.ChildNodes[i].Attributes[1].InnerText+Environment.NewLine);

            //        nodes.Add(child.ChildNodes[0].InnerText);
            //    }
            //}

            //listBox1.DataSource = nodes;
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
            this.Controls.Add(gMapControl1);

            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gMapControl1.Bearing = 0;
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.Zoom = 16;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            
            gMapControl1.CanDragMap = true;
            gMapControl1.Position = new GMap.NET.PointLatLng(lat: 53.901813, lng: 27.560522);

            gMapControl1.MarkersEnabled = true;

            //Создаем новый список маркеров, с указанием компонента 
            //в котором они будут использоваться и названием списка.
            GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");
            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG =
                new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
                //Указываем координаты 
                new GMap.NET.PointLatLng(53.902542, 27.561781));
            markerG.ToolTip =
                new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
            //Текст отображаемый при наведении на маркер.
            markerG.ToolTipText = "Объект №1";

            //Инициализация нового КРАСНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markerR =
                new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(
                //Указываем координаты 
                new GMap.NET.PointLatLng(53.902752, 27.561294));
            markerR.ToolTip =
                new GMap.NET.WindowsForms.ToolTips.GMapBaloonToolTip(markerR);
            //Текст отображаемый при наведении на маркер.
            markerR.ToolTipText = "Объект №2";

            //Добавляем маркеры в список маркеров.
            //Зеленый маркер
            markersOverlay.Markers.Add(markerG);
            //Красный маркет
            markersOverlay.Markers.Add(markerR);
            //Добавляем в компонент, список маркеров.
            gMapControl1.Overlays.Add(markersOverlay);

            



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(gMapControl1.Position.ToString());
        }

       
    }
}
