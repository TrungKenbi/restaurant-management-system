using DTO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormSearchResult : Form
    {
        private Restaurant restaurant;
        public FormSearchResult(Restaurant _restaurant)
        {
            this.restaurant = _restaurant;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormSearchResult_Load(object sender, EventArgs e)
        {
            this.lblName.Text = this.restaurant.Name;
            this.lblAddress.Text = "Địa chỉ: " + this.restaurant.Address;
            this.lblEmail.Text = "Email: " + this.restaurant.Email;
            this.lblHotline.Text = "Hotline: " + String.Format("{0:### ### ####}", this.restaurant.Hotline);
            this.rtbDesc.Text = this.restaurant.Description;


            GMapProviders.GoogleMap.ApiKey = @Properties.Settings.Default.Google_API_KEY;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            mainMap.CacheLocation = @"CacheMaps";
            mainMap.DragButton = MouseButtons.Left;
            mainMap.MapProvider = GMapProviders.GoogleMap;
            mainMap.ShowCenter = false;
            mainMap.MinZoom = 5;
            mainMap.MaxZoom = 30;
            mainMap.Zoom = 18;

            double lat = this.restaurant.Lat;
            double lng = this.restaurant.Lng;

            mainMap.Position = new PointLatLng(lat, lng);


            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            mainMap.Overlays.Add(markers);
        }

        private void mainMap_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    PointLatLng point = mainMap.FromLocalToLatLng(e.X, e.Y);
                    Debug.WriteLine(point.Lat.ToString() + "|" + point.Lng.ToString());
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
