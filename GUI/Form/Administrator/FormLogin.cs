using DTO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (QLDiaDiemNhaHang.Properties.Settings.Default.Username != String.Empty)
                txtUsername.Text = QLDiaDiemNhaHang.Properties.Settings.Default.Username;
            if (QLDiaDiemNhaHang.Properties.Settings.Default.Password != String.Empty)
                txtPassword.Text = QLDiaDiemNhaHang.Properties.Settings.Default.Password;

            cbxRemember.Checked = true;
            lblMessage.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.Trim();
            String password = txtPassword.Text.Trim();
            bool isRemember = cbxRemember.Checked;

            Account account = BUS.AccountBUS.Instance.GetAccount(username, password);
            if (account != null)
            {
                FormManagement frmMng = new FormManagement(account);
                frmMng.Show();
                this.Hide();

                if (isRemember)
                {
                    QLDiaDiemNhaHang.Properties.Settings.Default.Username = username;
                    QLDiaDiemNhaHang.Properties.Settings.Default.Password = password;
                } else
                {
                    QLDiaDiemNhaHang.Properties.Settings.Default.Username = String.Empty;
                    QLDiaDiemNhaHang.Properties.Settings.Default.Password = String.Empty;
                }

                QLDiaDiemNhaHang.Properties.Settings.Default.Save();
            } else
            {
                lblMessage.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
