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
    public partial class FormFoodToRestaurant : Form
    {
        private Food food;
        public FormFoodToRestaurant(Food _food)
        {
            InitializeComponent();
            this.food = _food;
        }

        private void FormFoodToRestaurant_Load(object sender, EventArgs e)
        {
            cboRestaurant.DataSource = RestaurantBUS.Instance.GetList();
            cboRestaurant.DisplayMember = "Name";
            cboRestaurant.ValueMember = "Id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(numPrice.Value);
            if (cboRestaurant.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà hàng !");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Giá sản phải là số nguyên dương !");
                return;
            }

            FoodBUS.Instance.InsertToRestaurant(Convert.ToInt32(cboRestaurant.SelectedValue), food.Id, price);

            MessageBox.Show("Thêm món ăn vào nhà hàng thành công !");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
