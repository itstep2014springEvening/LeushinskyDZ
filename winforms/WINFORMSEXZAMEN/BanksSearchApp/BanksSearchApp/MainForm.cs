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
        GMapControl gMapControl1;
        List<Bankomat> bnmts = new List<Bankomat>();
        public bool isEditorModeOn = false;
        public MainForm()
        {
            InitializeComponent();
            //ToolStripSeparator tss = new ToolStripSeparator();
            
            Load += MainForm_Load;
            
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            DbData.BanksDB sdf = new BanksDB();
            
            DbCreator dc = new DbCreator();
          //  if (!sdf.Database.Exists())
         //  {
                dc.DbDataInsert();
          //  }
            SetParamsMap();
            List<string> DataForLb1 = bnmts.OrderBy(x=>x.BankOwnerName).Select(lb1d => lb1d.BankomatName + Environment.NewLine).ToList();
            listBox1.DataSource = DataForLb1;
        }
        

        // ПРИМЕР РАБОТЫ С КАРТОЙ ! 
        // (данный код используйте по своему усмотрению!)
        void SetParamsMap()
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

// ОБЩИЕ НАСТРОЙКИ КАРТЫ 
            //Указываем, что будем использовать карты OpenStreetMap.
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            // Указываем источник данных карты (выбран: интренети или локальный кэш)
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

           
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;
    
      // МАСШТАБИРОВАНИЕ
            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Указываем, что при загрузке карты будет использоваться 
            //16ти кратной приближение.
            gMapControl1.Zoom = 17;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
           //MapControl1.Position= new PointLatLng

  // НАВИГАЦИЯ ПО КАРТЕ 
            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту  помощью правой кнопки мыши. 
            gMapControl1.CanDragMap = true;

            //Указываем что перетаскивание карты осуществляется 
            //с использованием левой клавишей мыши. По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            //Указываем элементу управления, что необходимо при открытии карты
            // прейти по координатам 
            gMapControl1.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);


// ОТОБРАЖЕНИЕ МАРКЕРОВ НА КАРТЕ 
            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
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
           // gMapControl1.MouseClick += gMapControl1_MouseClick;
        
        }

       

        void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double X = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "NewMarkers");
            GMapMarkerGoogleGreen markerG =  new GMapMarkerGoogleGreen
                                           (new GMap.NET.PointLatLng(Y, X));
           markerG.ToolTip = new GMapRoundedToolTip(markerG);
           markerG.ToolTipText = "Новый объект";
           markersOverlay.Markers.Add(markerG);
           gMapControl1.Overlays.Add(markersOverlay);

            
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
        }
    }

