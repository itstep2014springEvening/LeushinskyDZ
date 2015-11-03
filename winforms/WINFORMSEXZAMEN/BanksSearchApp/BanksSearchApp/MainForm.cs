using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbData;
using GMap.NET;

namespace BanksSearchApp
{
    public partial class MainForm : Form
    {
        GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                new GMap.NET.WindowsForms.GMapOverlay(new GMapControl(), "marker");
        DbData.BanksDB db = new BanksDB();
        GMapControl gMapControl1;
        List<Bankomat> bnmts = new List<Bankomat>();
        public bool isEditorModeOn = false;
        public MainForm()
        {
            InitializeComponent();
            //ToolStripSeparator tss = new ToolStripSeparator();
            var bankomatsToCb1 = db.Bankomats.ToList();
            comboBox1.ValueMember = "BankomatId";
            comboBox1.DisplayMember = "BankomatName";
            comboBox1.DataSource = bankomatsToCb1;

          
        Load += MainForm_Load;
            
        }

        
        void MainForm_Load(object sender, EventArgs e)
        {
            
            
            DbCreator dc = new DbCreator();
          // if (!db.Database.Exists())
          //  { 
                dc.DbDataInsert();
          //  }
            SetParamsMap();
            List<string> DataForLb1 = bnmts.OrderBy(x=>x.BankOwnerName).Select(lb1d => lb1d.BankomatName + Environment.NewLine).ToList();
            listBox1.ValueMember = "BankomatId";
            listBox1.DisplayMember = "BankomatName";
            listBox1.DataSource = DataForLb1;
        }
        

        // ПРИМЕР РАБОТЫ С КАРТОЙ ! 
        // (данный код используйте по своему усмотрению!)
        public void SetParamsMap()
        {
            DbData.BanksDB sdf = new BanksDB();
          //  DbCreator dm = new DbCreator();
            
            bnmts = sdf.Bankomats.ToList();
           // sdf.Database.Delete();
          //  if(sdf.Database.Exists())
            // Создание элемента, отображающего карту !
            gMapControl1 = new GMapControl();
            // Растягивание элемента на все окно!
            gMapControl1.Dock = DockStyle.Fill;
            // Добавление элемента 
           dataGridView1.Controls.Add(gMapControl1);
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Bearing = 0;
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.Zoom = 17;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);
            gMapControl1.MarkersEnabled = true;
            GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG =
                new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
                new GMap.NET.PointLatLng(53.902542, 27.561781));
            markerG.ToolTip =
                new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
            markerG.ToolTipText = "Объект №1";







            //gMapControl1.MarkersEnabled = true; 

            foreach (var bankomat in bnmts)
            {
                //GMapOverlay markersOverlay1 = new GMapOverlay(gMapControl1, "marker");
               // GMapMarkerGoogleGreen markerG1 = new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY));
               // markerG.ToolTip = new GMapRoundedToolTip(new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY)));
               // markerG.ToolTipText = bankomat.BankomatName;
                markersOverlay.Markers.Add(new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY))
                {
                    ToolTipText = bankomat.BankomatName+Environment.NewLine+bankomat.CityName+Environment.NewLine
                });
                
                gMapControl1.Overlays.Add(new GMapOverlay(gMapControl1, "marker"));
            }
            
















            //Инициализация нового КРАСНОГО маркера, с указанием его координат.
       //     GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markerR =
        //        new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(
                //Указываем координаты 
        //        new GMap.NET.PointLatLng(53.902752, 27.561294));
        //    markerR.ToolTip =
       //         new GMap.NET.WindowsForms.ToolTips.GMapBaloonToolTip(markerR);
            //Текст отображаемый при наведении на маркер.
         //   markerR.ToolTipText = "Объект №2";

            //Добавляем маркеры в список маркеров.
            //Зеленый маркер
         //   markersOverlay.Markers.Add(markerG);
            //Красный маркет
        //    markersOverlay.Markers.Add(markerR);
            //Добавляем в компонент, список маркеров.
            gMapControl1.Overlays.Add(markersOverlay);

            // СОБЯТИЯ ПО КАРТЕ !
            gMapControl1.OnMarkerClick += GMapControl1_OnMarkerClick; ;
        
        }

        private void GMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            
        }

        void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {

           // double X = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
           // double Y = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
           // GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "NewMarkers");
           // GMapMarkerGoogleGreen markerG =  new GMapMarkerGoogleGreen
           //                                (new GMap.NET.PointLatLng(Y, X));
           //markerG.ToolTip = new GMapRoundedToolTip(markerG);
           //markerG.ToolTipText = "Новый объект";
           //markersOverlay.Markers.Add(markerG);
           //gMapControl1.Overlays.Add(markersOverlay);

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void расширенныйПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExstentedFindForm eff = new ExstentedFindForm();//{MdiParent = this};
            eff.MdiParent = this.MdiParent;
            eff.WindowState = FormWindowState.Normal;
            eff.Show();
            

        }

        private void тутЧтонибудьТочноБудетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.WindowState =FormWindowState.Normal;
            //mf.MdiParent = this;
            mf.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExstentedFindForm eff = new ExstentedFindForm();//{MdiParent = this};
            eff.MdiParent = this.MdiParent;
            eff.WindowState = FormWindowState.Normal;
            eff.Show();
        }

        private void режимРедактораToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void AddToBankomatsList(List<Bankomat> bnmts)
        {
            
        }
        private void банкоматToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (режимРедактораToolStripMenuItem.Checked)
            {
                if (isEditorModeOn)
                {
                    AddANewBankomatForm aanbf = new AddANewBankomatForm();//{MdiParent = this};
                    aanbf.MdiParent = this.MdiParent;
                    aanbf.WindowState = FormWindowState.Normal;
                    aanbf.Show();
                }

            }
            else
            {
                if (
                    MessageBox.Show(
                        "Для добавления объектов необходимо включить режим редактора. Включить режим редактора сейчас?",
                        "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    isEditorModeOn = true;
                    режимРедактораToolStripMenuItem.CheckState=CheckState.Checked;
                    AddANewBankomatForm aanbf = new AddANewBankomatForm();//{MdiParent = this};
                    aanbf.MdiParent = this.MdiParent;
                    aanbf.WindowState = FormWindowState.Normal;
                    aanbf.Show();
                }
                else
                {
                    isEditorModeOn = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
            foreach (var atmToCb1 in db.Bankomats)
            {
                if (comboBox1.SelectedIndex == atmToCb1.BankomatId)
                {
                    gMapControl1.Position = new GMap.NET.PointLatLng(atmToCb1.CoordinateX, atmToCb1.CoordinateY);
                    gMapControl1.Zoom = 18;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void удалитьОбъектToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteBankomatForm dbf = new DeleteBankomatForm();
            dbf.MdiParent = this.MdiParent;
            dbf.WindowState = FormWindowState.Normal;
            dbf.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bankomat currentBankomat = db.Bankomats.FirstOrDefault(s => s.BankomatId == listBox1.SelectedIndex);

            //GMapOverlay ov = new GMapOverlay(gMapControl1,"id");
            //if (currentBankomat==null)
            //{
            //    currentBankomat = bnmts[0];
            //}
            //ov.Markers.Add(
            //    new GMapMarkerGoogleGreen(new PointLatLng(currentBankomat.CoordinateX, currentBankomat.CoordinateY)));
            //gMapControl1.ZoomAndCenterMarkers("id");
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maded by Ivan Lev");
        }
    }
    }

