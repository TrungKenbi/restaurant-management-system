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
    public partial class FormFoodAddEdit : Form
    {
        private FormFood frmParent;
        private ACTION_TYPE action;
        private Food food;

        public enum ACTION_TYPE { VIEW, CREATE, EDIT }
        public FormFoodAddEdit(FormFood frm, ACTION_TYPE action)
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

        private void FormFoodAddEdit_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        public void SetActionButton(String buttonName)
        {
            btnAction.Text = buttonName;
        }

        public void SetDataForm(Food r)
        {
            if (r == null)
                return;

            txtName.Text = r.Name;
            rtbDesc.Text = r.Description;
            this.food = r;
        }

        public void DisableEdit()
        {
            txtName.Enabled = false;
            rtbDesc.Enabled = false;
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
                        string name = txtName.Text;
                        string desc = rtbDesc.Text;
                        int id = FoodBUS.Instance.Insert(name, desc);
                        frmParent.LoadFoodData();
                        MessageBox.Show("Thêm món ăn thành công !");
                        break;
                    }
                case ACTION_TYPE.EDIT:
                    {
                        try
                        {
                            this.food.Name = txtName.Text;
                            this.food.Description = rtbDesc.Text;
                            FoodBUS.Instance.Update(this.food);
                            frmParent.LoadFoodData();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message.ToString());
                        }

                        MessageBox.Show("Sửa thông tin món ăn thành công !");

                        break;
                    }
            }
        }
    }
}
