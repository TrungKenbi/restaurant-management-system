using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QLDiaDiemNhaHang
{
    public partial class FormEmployer : Form
    {
        public FormEmployer()
        {
            InitializeComponent();
        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {
            this.LoadEmployerData();
        }

        public void LoadEmployerData()
        {
            // Refresh data
            drgvEmployer.Update();
            drgvEmployer.Refresh();

            // Load data from database to data grid view
            drgvEmployer.DataSource = AccountBUS.Instance.GetList();
            drgvEmployer.Columns["Id"].Visible = false;
            drgvEmployer.Columns["Password"].Visible = false;
            drgvEmployer.Columns["Username"].HeaderText = "Tên tài khoản";
            drgvEmployer.Columns["Role"].HeaderText = "Chức vụ";
            drgvEmployer.Columns["TimeCreated"].HeaderText = "Ngày tạo tài khoản";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEmployerAddEdit formNewRestaurant = new FormEmployerAddEdit(this, FormEmployerAddEdit.ACTION_TYPE.CREATE);
            formNewRestaurant.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Account selectedAccount = drgvEmployer.Rows[drgvEmployer.CurrentCell.RowIndex].DataBoundItem as Account;

            if (selectedAccount == null)
            {
                MessageBox.Show("Bạn phải chọn nhà hàng !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormEmployerAddEdit formNewRestaurant = new FormEmployerAddEdit(this, FormEmployerAddEdit.ACTION_TYPE.EDIT);
            formNewRestaurant.SetDataForm(selectedAccount);
            formNewRestaurant.ShowDialog();
        }

        private void drgvEmployer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Account selectedAccount = drgvEmployer.Rows[drgvEmployer.CurrentCell.RowIndex].DataBoundItem as Account;
            if (selectedAccount == null)
                return;

            FormEmployerAddEdit formNewRestaurant = new FormEmployerAddEdit(this, FormEmployerAddEdit.ACTION_TYPE.VIEW);
            formNewRestaurant.SetDataForm(selectedAccount);
            formNewRestaurant.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Account selectedAccount = drgvEmployer.Rows[drgvEmployer.CurrentCell.RowIndex].DataBoundItem as Account;

            if (selectedAccount == null)
            {
                MessageBox.Show("Bạn phải chọn nhân viên !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên: " + selectedAccount.Username, "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountBUS.Instance.Delete(selectedAccount.Id);
                MessageBox.Show("Xóa nhà hàng thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadEmployerData();
            }
        }
    }
}
