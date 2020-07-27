using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormRestaurantAddEdit : Form
    {

        private FormRestaurant frmParent;
        private ACTION_TYPE action;
        private Restaurant restaurant;

        private double tmpLat = 10.9806545;
        private double tmpLng = 106.672259;
        
        public enum ACTION_TYPE { VIEW, CREATE, EDIT }

        public FormRestaurantAddEdit(FormRestaurant frm, ACTION_TYPE action)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.action = action;
            switch (this.action)
            {
                case ACTION_TYPE.VIEW:
                    this.DisableEdit();
                    break;
                case ACTION_TYPE.CREATE:
                    this.SetActionButton("Thêm");
                    break;
                case ACTION_TYPE.EDIT:
                    this.SetActionButton("Sửa");
                    break;
            }
        }

        private void FormRestaurantAddEdit_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetActionButton(String buttonName)
        {
            btnAction.Text = buttonName;
        }

        public void SetDataForm(Restaurant r)
        {
            if (r == null)
                return;
            txtName.Text = r.Name;
            txtAddress.Text = r.Address;
            txtEmail.Text = r.Email;
            txtHotline.Text = r.Hotline;
            rtbDesc.Text = r.Description;

            txtAcreage.Text = r.Acreage.ToString();
            txtCapacity.Text = r.Capacity.ToString();
            txtStar.Text = r.Star.ToString();
            txtRating.Text = r.Rating.ToString();

            this.restaurant = r;
        }

        public void DisableEdit()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtHotline.Enabled = false;
            rtbDesc.Enabled = false;
            btnAction.Visible = false;
            //btnMap.Enabled = false;
        }

        public void SetPostionLatLng(double lat, double lng)
        {
            this.tmpLat = lat;
            this.tmpLng = lng;

            if (this.restaurant != null)
            {
                this.restaurant.Lat = lat;
                this.restaurant.Lng = lng;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case ACTION_TYPE.CREATE:
                    string name = txtName.Text;
                    string desc = rtbDesc.Text;
                    string address = txtAddress.Text;
                    string email = txtEmail.Text;
                    string hotline = txtHotline.Text;

                    int acreage = Convert.ToInt32(txtAcreage.Text);
                    int capacity = Convert.ToInt32(txtCapacity.Text);
                    int star = Convert.ToInt32(txtStar.Text);
                    double rating = Convert.ToDouble(txtRating.Text);

                    int id = RestaurantBUS.Instance.Insert(name, desc, address, email, hotline, this.tmpLat, this.tmpLng, acreage, capacity, star, rating);
                    frmParent.LoadRestaurantData();
                    MessageBox.Show("Thêm nhà hàng thành công !");
                    break;
                case ACTION_TYPE.EDIT:

                    try
                    {
                        this.restaurant.Name = txtName.Text;
                        this.restaurant.Description = rtbDesc.Text;
                        this.restaurant.Address = txtAddress.Text;
                        this.restaurant.Email = txtEmail.Text;
                        this.restaurant.Hotline = txtHotline.Text;

                        this.restaurant.Acreage = Convert.ToInt32(txtAcreage.Text);
                        this.restaurant.Capacity = Convert.ToInt32(txtCapacity.Text);
                        this.restaurant.Star = Convert.ToInt32(txtStar.Text);
                        this.restaurant.Rating = Convert.ToDouble(txtRating.Text);

                        RestaurantBUS.Instance.Update(this.restaurant);
                        frmParent.LoadRestaurantData();
                    } catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message.ToString());
                    }

                    
                    MessageBox.Show("Sửa thông tin nhà hàng thành công !");

                    break;
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormRestaurantMap frmMap = new FormRestaurantMap(this, this.restaurant);
            frmMap.ShowDialog();
        }
    }
}
