using BUS;
using DTO;
using QLDiaDiemNhaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSearch : Form
    {

        private FormSearchResult childForm;

        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            // Form
            this.Text = String.Empty;
            this.ControlBox = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.LoadRestaurantData();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadRestaurantData();
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        public void LoadRestaurantData()
        {
            // Refresh data
            drgvResult.Update();
            drgvResult.Refresh();

            // Load data from database to data grid view
            drgvResult.DataSource = RestaurantBUS.Instance.GetList(txtKeyword.Text);
            
            drgvResult.Columns["Name"].HeaderText = "Nhà hàng";
            drgvResult.Columns["Name"].Width = 250;
            drgvResult.Columns["Acreage"].HeaderText = "Diện tích";
            drgvResult.Columns["Capacity"].HeaderText = "Sức chứa";
            drgvResult.Columns["Star"].HeaderText = "Sao";
            drgvResult.Columns["Rating"].HeaderText = "Đánh giá";



            drgvResult.Columns["Id"].Visible = false;
            drgvResult.Columns["Description"].Visible = false;
            drgvResult.Columns["Address"].Visible = false;
            drgvResult.Columns["Email"].Visible = false;
            drgvResult.Columns["Hotline"].Visible = false;
            drgvResult.Columns["Lat"].Visible = false;
            drgvResult.Columns["Lng"].Visible = false;
        }

        private void drgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Restaurant selectedRestaurant = drgvResult.Rows[drgvResult.CurrentCell.RowIndex].DataBoundItem as Restaurant;
            if (selectedRestaurant == null)
                return;

            if (this.childForm != null)
                this.childForm.Close();

            this.childForm = new FormSearchResult(selectedRestaurant);
            this.childForm.Show();
        }
    }
}
