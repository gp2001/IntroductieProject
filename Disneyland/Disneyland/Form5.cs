using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Disneyland
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            
           // System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/plattegronden/");
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(48.867374, 2.784018);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 12;
            gMapControl1.DragButton = MouseButtons.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 lijst = new Form6();
            lijst.Show();
            this.Hide();
        }
    }
}
