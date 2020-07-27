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
    public partial class FormEmployerAddEdit : Form
    {
        private FormEmployer frmParent;
        private ACTION_TYPE action;
        private Account account;

        public enum ACTION_TYPE { VIEW, CREATE, EDIT }

        public FormEmployerAddEdit(FormEmployer frm, ACTION_TYPE action)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.action = action;
            cboRole.DataSource = Enum.GetValues(typeof(Account.RoleType));
            this.txtTimeCreated.Enabled = false;
            switch (this.action)
            {
                case ACTION_TYPE.VIEW:
                    this.DisableEdit();
                    break;
                case ACTION_TYPE.CREATE:
                    this.SetActionButton("Thêm");
                    this.txtTimeCreated.Visible = false;
                    this.lblTimeCreated.Visible = false;
                    break;
                case ACTION_TYPE.EDIT:
                    this.SetActionButton("Sửa");
                    break;
            }
        }

        private void FormEmployerAddEdit_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        public void SetActionButton(String buttonName)
        {
            btnAction.Text = buttonName;
        }

        public void SetDataForm(Account r)
        {
            if (r == null)
                return;

            txtUsername.Text = r.Username;
            txtPassword.Text = r.Password;
            txtTimeCreated.Text = r.TimeCreated.ToString();
            cboRole.SelectedIndex = (int)r.Role;
            this.account = r;
        }

        public void DisableEdit()
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            cboRole.Enabled = false;
            txtTimeCreated.Enabled = false;
            btnAction.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case ACTION_TYPE.CREATE:
                    {
                        string username = txtUsername.Text;
                        string password = txtPassword.Text;
                        Account.RoleType role;
                        Enum.TryParse<Account.RoleType>(cboRole.SelectedValue.ToString(), out role);
                        int id = AccountBUS.Instance.Insert(username, password, role);
                        frmParent.LoadEmployerData();
                        MessageBox.Show("Thêm nhân viên thành công !");
                        break;
                    }
                case ACTION_TYPE.EDIT:
                    {
                        try
                        {
                            this.account.Username = txtUsername.Text;
                            this.account.Password = txtPassword.Text;
                            Account.RoleType role;
                            Enum.TryParse<Account.RoleType>(cboRole.SelectedValue.ToString(), out role);
                            this.account.Role = role;
                            AccountBUS.Instance.Update(this.account);
                            frmParent.LoadEmployerData();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message.ToString());
                        }

                        MessageBox.Show("Sửa thông tin nhân viên thành công !");

                        break;
                    }
            }
        }
    }
}
