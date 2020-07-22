using BUS;
using DTO;
using GUI;
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
    public partial class FormSetting : Form
    {
        private FormManagement parentForm;
        public FormSetting(FormManagement _parentForm)
        {
            InitializeComponent();
            this.parentForm = _parentForm;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Account account = this.parentForm.GetAccount();
            if (txtOldPass.Text != String.Empty && txtOldPass.Text == account.Password)
            {
                if (txtNewPass.Text == txtRePass.Text)
                {
                    if (txtNewPass.Text.Length >= 6)
                    {
                        account.Password = txtNewPass.Text;
                        AccountBUS.Instance.Update(account);
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Nhập lại mật khẩu phải giống với mật khẩu mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
                MessageBox.Show("Mật khẩu cũ không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
