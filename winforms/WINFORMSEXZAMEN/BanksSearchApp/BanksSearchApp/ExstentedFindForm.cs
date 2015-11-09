using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            checkedListBox1.ValueMember = "ServiceId";
            checkedListBox1.DisplayMember = "ServiceName";
            checkedListBox1.DataSource = db.Services.ToList();


            List<string> servicesForcCheckedListBox = new List<string>() { "Снятие наличных", "Обмен валют", "Оплата ЖКХ", "Оплата мобильной связи", "Погашение кредитов" };

            comboBox1.ValueMember = "CurrencyId";
            comboBox1.DisplayMember = "CurrencyName";
            comboBox1.DataSource = new List <string>
            {
                "USD", "EUR", "RUR"
            };
        }

        private void ExstentedFindForm_Load(object sender, EventArgs e)
        {
            checkedListBox1.ValueMember = "ServiceId";
            checkedListBox1.DisplayMember = "ServiceName";
            checkedListBox1.DataSource = db.Services.ToList();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bankomats.Clear();
                List<Bank> bank = new List<Bank>();
                if (tabControl1.SelectedTab == tabPage1)
                {
                    bankomats = null;
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        bankomats = db.Bankomats.Where(x => x.CityName == textBox1.Text).ToList();
                        if (!string.IsNullOrEmpty(textBox2.Text))
                        {
                            bankomats = bankomats.Where(x => x.StreetName == textBox2.Text).ToList();
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
                    listBox1.DataSource = bankomats.Select(x => x.BankomatName).ToList();

                }


                if (tabControl1.SelectedTab == tabPage2)
                {
                    string currentCurrency = (string)comboBox1.SelectedItem;

                    if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) &&
                        string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text))
                    {
                        MessageBox.Show("Заполните значения");
                    }
                    else
                    {
                        if (!(string.IsNullOrEmpty(textBox4.Text)) && !(string.IsNullOrEmpty(textBox5.Text)))
                        {

                            foreach (var b in db.Bankomats)
                            {
                                foreach (var c in b.Currencies)
                                {
                                    if (c.CurrencyBuyV > Double.Parse(textBox4.Text) &&
                                        c.CurrencyBuyV < Double.Parse(textBox5.Text) && c.CurrencyName == currentCurrency)
                                    {

                                        bankomats.Add(b);
                                    }
                                }
                            }
                        }

                        if (!(string.IsNullOrEmpty(textBox6.Text)) && !(string.IsNullOrEmpty(textBox7.Text)))
                        {

                            foreach (var b in db.Bankomats)
                            {
                                foreach (var c in b.Currencies)
                                {
                                    if (c.CurrencyBuyV > Double.Parse(textBox4.Text) &&
                                        c.CurrencyBuyV < Double.Parse(textBox4.Text) && c.CurrencyName == currentCurrency)
                                    {
                                        bankomats.Add(b);
                                    }
                                }
                            }
                        }
                    }
                    listBox1.DisplayMember = "BankomatName";
                    listBox1.DataSource = bankomats.ToList();
                }

                if (tabControl1.SelectedTab == tabPage3)
                {
                    bankomats.Clear();
                    List<Service> checkedServices = new List<Service>();

                    foreach (var chS in checkedListBox1.SelectedItems)
                    {
                        checkedServices.Add((Service)chS);
                    }

                    foreach (var chS in checkedServices)
                    {
                        bankomats.AddRange(db.BankomatToServices.Include(x => x.Bankomat).Where(x => x.ServiceId == chS.ServiceId).Select(x => x.Bankomat).ToList());
                    }

                    listBox1.DisplayMember = "BankomatName";
                    listBox1.DataSource = bankomats.Distinct().ToList().ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }


        private
            void button2_Click(object sender, EventArgs e)
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

            gMapControl.Overlays.Add(markersOverlay);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
        }
    }
}
