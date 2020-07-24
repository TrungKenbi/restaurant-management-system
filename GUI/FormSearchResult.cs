using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormSearchResult : Form
    {
        public FormSearchResult()
        {
            InitializeComponent();
        }

        private void FormSearchResult_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = Properties.Settings.Default.Google_API_KEY;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            mainMap.CacheLocation = @"CacheMaps";
            mainMap.DragButton = MouseButtons.Left;
            mainMap.MapProvider = GMapProviders.GoogleMap;
            mainMap.ShowCenter = false;
            mainMap.MinZoom = 5;
            mainMap.MaxZoom = 100;
            mainMap.Zoom = 18;

            double lat = 10.9872203997579;
            double lng = 106.664665024728;

            mainMap.Position = new PointLatLng(lat, lng);


            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            mainMap.Overlays.Add(markers);

        }

        public void LoadMapData(string url)
        {
        }

        private void mainMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = mainMap.FromLocalToLatLng(e.X, e.Y);
            txtLat.Text = point.Lat.ToString();
            txtLng.Text = point.Lng.ToString();
        }

        private void mainMap_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    // Left click
                    break;

                case MouseButtons.Right:

                    PointLatLng point = mainMap.FromLocalToLatLng(e.X, e.Y);
                    txtLat.Text = point.Lat.ToString();
                    txtLng.Text = point.Lng.ToString();

                    Debug.WriteLine(point.Lat.ToString() + "|" + point.Lng.ToString());


                    break;
                 
            }
        }
    }
}
