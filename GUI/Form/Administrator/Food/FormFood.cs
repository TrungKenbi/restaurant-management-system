using BUS;
using DTO;
using System;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            this.LoadFoodData();
        }

        public void LoadFoodData()
        {
            // Refresh data
            drgvFood.Update();
            drgvFood.Refresh();

            // Load data from database to data grid view
            drgvFood.DataSource = FoodBUS.Instance.GetList();
            drgvFood.Columns["Id"].Width = 50;
            drgvFood.Columns["Id"].HeaderText = "STT";
            drgvFood.Columns["Name"].HeaderText = "Tên Món Ăn";
            drgvFood.Columns["Description"].HeaderText = "Mô Tả Món Ăn";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFoodAddEdit formNewRestaurant = new FormFoodAddEdit(this, FormFoodAddEdit.ACTION_TYPE.CREATE);
            formNewRestaurant.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Food selectedFood = drgvFood.Rows[drgvFood.CurrentCell.RowIndex].DataBoundItem as Food;

            if (selectedFood == null)
            {
                MessageBox.Show("Bạn phải chọn món ăn !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormFoodAddEdit formNewRestaurant = new FormFoodAddEdit(this, FormFoodAddEdit.ACTION_TYPE.EDIT);
            formNewRestaurant.SetDataForm(selectedFood);
            formNewRestaurant.ShowDialog();
        }

        private void drgvFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Food selectedFood = drgvFood.Rows[drgvFood.CurrentCell.RowIndex].DataBoundItem as Food;
            if (selectedFood == null)
                return;

            FormFoodAddEdit formNewRestaurant = new FormFoodAddEdit(this, FormFoodAddEdit.ACTION_TYPE.VIEW);
            formNewRestaurant.SetDataForm(selectedFood);
            formNewRestaurant.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Food selectedFood = drgvFood.Rows[drgvFood.CurrentCell.RowIndex].DataBoundItem as Food;

            if (selectedFood == null)
            {
                MessageBox.Show("Bạn phải chọn món ăn !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn: " + selectedFood.Name, "Xóa Món Ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FoodBUS.Instance.Delete(selectedFood.Id);
                MessageBox.Show("Xóa món ăn thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadFoodData();
            }
        }

        private void btnToRestaurant_Click(object sender, EventArgs e)
        {
            Food selectedFood = drgvFood.Rows[drgvFood.CurrentCell.RowIndex].DataBoundItem as Food;
            FormFoodToRestaurant frm = new FormFoodToRestaurant(selectedFood);
            frm.ShowDialog();
        }
    }
}
