using BUS;
using DTO;
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
    public partial class FormRestaurant : Form
    {
        public FormRestaurant()
        {
            InitializeComponent();
        }

        private void FormRestaurant_Load(object sender, EventArgs e)
        {
            LoadRestaurantData();
        }

        public void LoadRestaurantData()
        {
            // Refresh data
            drgvRestaurant.Update();
            drgvRestaurant.Refresh();


            // Load data from database to data grid view
            drgvRestaurant.DataSource = RestaurantBUS.Instance.GetList();
            drgvRestaurant.Columns["Id"].Visible = false;
            drgvRestaurant.Columns["Name"].HeaderText = "Nhà Hàng";
            drgvRestaurant.Columns["Description"].HeaderText = "Mô Tả";
            drgvRestaurant.Columns["Address"].HeaderText = "Địa Chỉ";
            drgvRestaurant.Columns["Email"].HeaderText = "Email";
            drgvRestaurant.Columns["Hotline"].HeaderText = "Hotline";
            drgvRestaurant.Columns["Lat"].Visible = false;
            drgvRestaurant.Columns["Lng"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormRestaurantAddEdit formNewRestaurant = new FormRestaurantAddEdit(this, FormRestaurantAddEdit.ACTION_TYPE.CREATE);
            formNewRestaurant.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Restaurant selectedRestaurant = drgvRestaurant.Rows[drgvRestaurant.CurrentCell.RowIndex].DataBoundItem as Restaurant;

            if (selectedRestaurant == null)
            {
                MessageBox.Show("Bạn phải chọn nhà hàng !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormRestaurantAddEdit formNewRestaurant = new FormRestaurantAddEdit(this, FormRestaurantAddEdit.ACTION_TYPE.EDIT);
            formNewRestaurant.SetDataForm(selectedRestaurant);
            formNewRestaurant.ShowDialog();
        }

        private void drgvRestaurant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Restaurant selectedRestaurant = drgvRestaurant.Rows[drgvRestaurant.CurrentCell.RowIndex].DataBoundItem as Restaurant;
            if (selectedRestaurant == null)
                return;

            FormRestaurantAddEdit formNewRestaurant = new FormRestaurantAddEdit(this, FormRestaurantAddEdit.ACTION_TYPE.VIEW);
            formNewRestaurant.SetDataForm(selectedRestaurant);
            formNewRestaurant.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Restaurant selectedRestaurant = drgvRestaurant.Rows[drgvRestaurant.CurrentCell.RowIndex].DataBoundItem as Restaurant;

            if (selectedRestaurant == null)
            {
                MessageBox.Show("Bạn phải chọn nhà hàng !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà hàng: " + selectedRestaurant.Name, "Xóa Nhà Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestaurantBUS.Instance.Delete(selectedRestaurant.Id);
                MessageBox.Show("Xóa nhà hàng thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadRestaurantData();
            }
        }
    }
}
