using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
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

            //BanksDB db = new BanksDB();
            //Bankomat dev1 = new Bankomat()
            //{
            //    Name = "Lolo",
            //    //Price = 333,
            //    //Country = "ahahaha"
            //};

            //Bankomat dev2 = new Bankomat()
            //{
            //    Name = "Koko",
            //   // Price = 333,
            //   // Country = "vivivi"
            //};

            //Bank banks = new Bank()
            //{
            //    Name = "Van",
            //    Date = DateTime.Now,
            //    Bankomats = new List<Bankomat>()
            //};
            //banks.Bankomats.AddRange(new[] { dev1, dev2 });

            //db.Banks.Add(banks);
            //db.SaveChanges();

            //foreach (var it in db.Banks)
            //{
            //    MessageBox.Show(it.Name);
            //}

            //Console.Read();

            var doc = new XmlDocument();
            doc.Load(@"kurs.xml");
            List<string> nodes = new List<string>();
            foreach (XmlNode node in doc.SelectNodes("banks"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    
                    //for(int i=3;i<=5;i++)
                    //nodes.Add(child.ChildNodes[i].Name+ child.ChildNodes[i].Attributes[1].InnerText+Environment.NewLine);

                    nodes.Add(child.ChildNodes[0].InnerText);
                }
            }

            listBox1.DataSource = nodes;
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
            gMapControl1.Position = new GMap.NET.PointLatLng(lat: 53.901813, lng: 27.560522);


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

        public class BankCurrency
        {
            public int BankId { get; set; }
            public string CurrencyName { get; set; }

            

        }
    }
}
