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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace BanksSearchApp
{
    public partial class ExstentedFindForm : Form
    {
        List<Bankomat> bankomats = new List<Bankomat>();
        DbData.BanksDB db = new BanksDB();
        public ExstentedFindForm()
        {
            InitializeComponent();
            List<string> CurrencyChangeVariants = new List<string>() { "USD", "EUR", "RUR" };
            List<string> servicesForcCheckedListBox = new List<string>() { "Снятие наличных", "Обмен валют", "Оплата ЖКХ", "Оплата мобильной связи", "Погашение кредитов" };
            comboBox1.DataSource = CurrencyChangeVariants;
            checkedListBox1.DataSource = servicesForcCheckedListBox;
            //  ..  comboBox2.DataSource = CurrencyChangeVariants;
            //  comboBox3.DataSource = CurrencyChangeVariants;
        }

        private void ExstentedFindForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Bank> bank = new List<Bank>();
            if (tabControl1.SelectedTab == tabPage1)
            {
                bankomats = null;
            
            
            //if (textBox4.Text==null&& textBox5.Text == null && textBox6.Text == null)
            //{
            //    
            //}
        
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                bankomats = db.Bankomats.Where(x => x.CityName == textBox1.Text).ToList();
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    bankomats= bankomats.Where(x => x.StreetName == textBox2.Text).ToList();
                    if (!string.IsNullOrEmpty(textBox3.Text))
                    {
                        bankomats = bankomats.Where(x => x.HomeNumber == textBox3.Text).ToList();
                    }
                }
            }
            else
            {
                bankomats = db.Bankomats.ToList();
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    bankomats = bankomats.Where(x => x.StreetName == textBox2.Text).ToList();
                    if (!string.IsNullOrEmpty(textBox3.Text))
                    {
                        bankomats = bankomats.Where(x => x.HomeNumber == textBox3.Text).ToList();
                    }
                }
            }
            //if(textBox5.Text==null)
            // = sdf.Bankomats.ToList().Where(x=>x.CityName==textBox1.Text&&
            //x.StreetName==(textBox2.Text==null?:textBox2.Text)&&
            //x.HomeNumber==(textBox3.Text==null?string.Empty:textBox3.Text)).ToList();
            listBox1.DataSource = bankomats.Select(x=>x.BankomatName).ToList();

                //List<string> FinderUsingAdress = new List<string>();
                //if (textBox1.Text != null) { FinderUsingAdress.Add(textBox1.Text);}
                //if (textBox2.Text != null) { FinderUsingAdress.Add(textBox2.Text); }
                //if (textBox3.Text != null) { FinderUsingAdress.Add(textBox3.Text); }
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                checkedListBox1.DataSource = db.Services;
                checkedListBox1.ValueMember = "ServiceId";
                checkedListBox1.DisplayMember = "ServiceName";
                List< Currency> bankToCompare = new List<Currency>();
                double bfrom = Double.Parse(textBox4.Text);
                double bto = Double.Parse(textBox5.Text);
                double sfrom = Double.Parse(textBox6.Text);
                double sto = Double.Parse(textBox7.Text);
                if (comboBox1.Text=="USD")
                {
                    //foreach (var onebank in db.Banks)
                    //{
                    //    bankToCompare.AddRange(onebank.Currencies.Where(currencies => bfrom > currencies.CurrencyBuyV && currencies.CurrencyBuyV < bto));
                    //}
                }
           //     bankomats=bankToCompare.Select(anotherThing=>anotherThing.)
                //foreach(var bankinb in )

            }

            List<string> checkedStuffInString = new List<string>();
            if (tabControl1.SelectedTab == tabPage3)
            {
                List<string> checkedItemsInString = new List<string>();
                List<Bank> bankForChecked = new List<Bank>();
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; ++i)
                {
                    checkedItemsInString.Add(checkedListBox1.CheckedItems[i].ToString());
                }
                //foreach (var bankcomp in db.Banks)
                //{
                //    if (checkedItemsInString.Intersect(bankcomp.Services.Select(s=>s.ServiceName)))
                //        bankForChecked.Add(bankcomp);
                //}
                
              //  db.Banks.Select(b=>b.Services).Select()
             //   db.Banks.Where(b=>b.Services.Where())
                // CheckedListBox ad = new CheckedListBox();ad.d
                
               // List<string> allCheckBoxesFromService = new List<string>() {checkBox1.Text, checkBox2.Text , checkBox3.Text , checkBox4.Text , checkBox5.Text };
                List<Service> resultServiceList = new List<Service>();
                

                List<Bank> temporaryBanks = new List<Bank>();
                foreach (var tbank in db.Banks)
                {
                    //if (resultServiceList.Intersect(tbank.Services.Select(s=>s.ServiceName).ToList()))
                    //{
                    //    temporaryBanks.Add();
                    //}
                    
                }
               

            }
        }

        //public List<> ReturnBankomatsFromCurrencyFinder(string textBoxText, Bankomat bankomat)
        //{

        //    return bankomat;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            ResultBankomatsForm rbf = new ResultBankomatsForm();
            rbf.MdiParent = this.MdiParent;
            rbf.WindowState = FormWindowState.Normal;
            
            rbf.Show();

            GMapControl gMapControl;
            
            DbData.BanksDB sdf = new BanksDB();
            gMapControl = new GMapControl();
            gMapControl.Dock = DockStyle.Fill;
            rbf.Controls.Add(gMapControl);
            //dataGridView1.Controls.Add(gMapControl);
            gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl.Bearing = 0;
            gMapControl.MaxZoom = 18;
            gMapControl.MinZoom = 2;
            gMapControl.Zoom = 17;
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl.CanDragMap = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);
            gMapControl.MarkersEnabled = true;
                GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                    new GMap.NET.WindowsForms.GMapOverlay(gMapControl, "marker");
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

                foreach (var bankomat in bankomats)
                {
                    //GMapOverlay markersOverlay1 = new GMapOverlay(gMapControl1, "marker");
                    // GMapMarkerGoogleGreen markerG1 = new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY));
                    // markerG.ToolTip = new GMapRoundedToolTip(new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY)));
                    // markerG.ToolTipText = bankomat.BankomatName;
                    markersOverlay.Markers.Add(new GMapMarkerGoogleGreen(new PointLatLng(bankomat.CoordinateX, bankomat.CoordinateY))
                    {
                        ToolTipText = bankomat.BankomatName + Environment.NewLine + bankomat.CityName + Environment.NewLine
                    });

                    gMapControl.Overlays.Add(new GMapOverlay(gMapControl, "marker"));
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
                gMapControl.Overlays.Add(markersOverlay);

                // СОБЯТИЯ ПО КАРТЕ !
                // gMapControl1.MouseClick += gMapControl1_MouseClick;

            



        }
    }
}
