using DTO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormRestaurantMap : Form
    {
        private FormRestaurantAddEdit formParent;
        private Restaurant restaurant;
        public FormRestaurantMap(FormRestaurantAddEdit _formParent, Restaurant _restaurant)
        {
            this.formParent = _formParent;
            this.restaurant = _restaurant;
            InitializeComponent();
        }

        private void FormRestaurantMap_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = Properties.Settings.Default.Google_API_KEY;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            mainMap.CacheLocation = @"CacheMaps";
            mainMap.DragButton = MouseButtons.Left;
            mainMap.MapProvider = GMapProviders.GoogleMap;
            mainMap.ShowCenter = false;
            mainMap.MinZoom = 5;
            mainMap.MaxZoom = 30;
            mainMap.Zoom = 18;

            double lat;
            double lng;
            if (this.restaurant != null)
            {
                lat = this.restaurant.Lat;
                lng = this.restaurant.Lng;
            } else
            {
                lat = 10.9806545;
                lng = 106.672259;
            }

            mainMap.Position = new PointLatLng(lat, lng);

            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            mainMap.Overlays.Add(markers);
        }

        private void mainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = mainMap.FromLocalToLatLng(e.X, e.Y);
            //MessageBox.Show("Bạn có muốn chọn vị trí này không ?", "Chọn Vị Trí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            formParent.SetPostionLatLng(point.Lat, point.Lng);

            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            mainMap.Overlays.Clear();
            mainMap.Overlays.Add(markers);
        }
    }
}
