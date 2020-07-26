using DTO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormSearchResult : Form
    {
        private PointLatLng currentPostion;
        private GeoCoordinateWatcher Watcher;
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


            Watcher = new GeoCoordinateWatcher();
            Watcher.StatusChanged += Watcher_StatusChanged;
            bool started = this.Watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
            if (!started)
                Debug.WriteLine("GeoCoordinateWatcher timed out on start.");
        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                // Display the latitude and longitude.
                if (Watcher.Position.Location.IsUnknown)
                {
                    Debug.WriteLine("Cannot find location data");
                }
                else
                {
                    Debug.WriteLine("Lat: {0}, Long: {1}", Watcher.Position.Location.Latitude, Watcher.Position.Location.Longitude);
                    Debug.WriteLine("Lat Map: {0}, Long Map: {1}", mainMap.Position.Lat, mainMap.Position.Lng);
                    this.currentPostion = new PointLatLng(Watcher.Position.Location.Latitude, Watcher.Position.Location.Longitude);
                }
            }
        }

        private void mainMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = mainMap.FromLocalToLatLng(e.X, e.Y);
            //txtLat.Text = point.Lat.ToString();
            //txtLng.Text = point.Lng.ToString();
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
                    //txtLat.Text = point.Lat.ToString();
                    //txtLng.Text = point.Lng.ToString();

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
