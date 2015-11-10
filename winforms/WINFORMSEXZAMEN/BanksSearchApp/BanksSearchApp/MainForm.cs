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
            
            if (db.Bankomats.ToList().Count<1)
            {
                DbCreator dc = new DbCreator();
            
         
                dc.DbDataInsert();
              }
            SetParamsMap();
            List<string> DataForLb1 = bnmts.OrderBy(x=>x.BankOwnerName).Select(lb1d => lb1d.BankomatName + Environment.NewLine).ToList();
            listBox1.ValueMember = "BankomatId";
            listBox1.DisplayMember = "BankomatName";
            listBox1.DataSource = DataForLb1;
        }
        

        
        public void SetParamsMap()
        {
            DbData.BanksDB sdf = new BanksDB();
        
            bnmts = sdf.Bankomats.ToList();
         
            gMapControl1 = new GMapControl();
  
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







           

            foreach (var bankomat in bnmts)
            {
              
                markersOverlay.Markers.Add(new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY))
                {
                    ToolTipText = bankomat.BankOwnerName+Environment.NewLine + bankomat.BankomatName+Environment.NewLine+bankomat.CityName+", "+bankomat.StreetName +", " + bankomat.HomeNumber
                    
                });
                
                gMapControl1.Overlays.Add(new GMapOverlay(gMapControl1, "marker"));
            }
            
            gMapControl1.Overlays.Add(markersOverlay);

           
            gMapControl1.OnMarkerClick += GMapControl1_OnMarkerClick; ;
        
        }

        private void GMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            
        }

        void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {

         
            
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

        private void банкоматToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteBankomatForm dbf = new DeleteBankomatForm();
            dbf.MdiParent = this.MdiParent;
            dbf.WindowState = FormWindowState.Normal;
            dbf.Show();
        }

        private void банкоматToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBankomatForm ebf = new EditBankomatForm();
            ebf.MdiParent = this.MdiParent;
            ebf.WindowState = FormWindowState.Normal;
            ebf.Show();
        }

        private void курсToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrenceChangeForm ccf = new CurrenceChangeForm();
            ccf.MdiParent = this.MdiParent;
            ccf.WindowState = FormWindowState.Normal;
            ccf.Show();
        }

        private void банкToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void банкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBankForm abf = new AddBankForm();
            abf.MdiParent = this.MdiParent;
            abf.WindowState = FormWindowState.Normal;
            abf.Show();
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ExstentedFindForm eff = new ExstentedFindForm();
            eff.MdiParent = this.MdiParent;
            eff.WindowState = FormWindowState.Normal;
            eff.Show();
        }

        private void добавитьОбъектToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddANewBankomatForm aanbf = new AddANewBankomatForm();
            aanbf.MdiParent = this.MdiParent;
            aanbf.WindowState = FormWindowState.Normal;
            aanbf.Show();
        }

        private void редактироватьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBankomatForm ebf = new EditBankomatForm();
            ebf.MdiParent = this.MdiParent;
            ebf.WindowState = FormWindowState.Normal;
            ebf.Show();
        }

        private void простойПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void курсToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CursCompareTable cct = new CursCompareTable();
            cct.MdiParent = this.MdiParent;
            cct.WindowState = FormWindowState.Maximized;
            cct.Show();
        }
    }
    }

