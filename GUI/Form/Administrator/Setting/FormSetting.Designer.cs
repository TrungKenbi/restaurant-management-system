namespace QLDiaDiemNhaHang
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSetting = new System.Windows.Forms.TabControl();
            this.tabSettingChangePassword = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabSetting.SuspendLayout();
            this.tabSettingChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.tabSettingChangePassword);
            this.tabSetting.Controls.Add(this.tabPage2);
            this.tabSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSetting.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetting.Location = new System.Drawing.Point(0, 0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.SelectedIndex = 0;
            this.tabSetting.Size = new System.Drawing.Size(1194, 545);
            this.tabSetting.TabIndex = 0;
            // 
            // tabSettingChangePassword
            // 
            this.tabSettingChangePassword.Controls.Add(this.btnChangePassword);
            this.tabSettingChangePassword.Controls.Add(this.txtRePass);
            this.tabSettingChangePassword.Controls.Add(this.txtNewPass);
            this.tabSettingChangePassword.Controls.Add(this.txtOldPass);
            this.tabSettingChangePassword.Controls.Add(this.label3);
            this.tabSettingChangePassword.Controls.Add(this.label2);
            this.tabSettingChangePassword.Controls.Add(this.label1);
            this.tabSettingChangePassword.Location = new System.Drawing.Point(4, 44);
            this.tabSettingChangePassword.Name = "tabSettingChangePassword";
            this.tabSettingChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettingChangePassword.Size = new System.Drawing.Size(1186, 497);
            this.tabSettingChangePassword.TabIndex = 0;
            this.tabSettingChangePassword.Text = "Đổi mật khẩu";
            this.tabSettingChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChangePassword.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnChangePassword.IconColor = System.Drawing.Color.White;
            this.btnChangePassword.IconSize = 32;
            this.btnChangePassword.Location = new System.Drawing.Point(398, 345);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Rotation = 0D;
            this.btnChangePassword.Size = new System.Drawing.Size(213, 45);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRePass.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.Location = new System.Drawing.Point(681, 235);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(337, 52);
            this.txtRePass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(681, 162);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(337, 52);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPass.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(681, 90);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(337, 52);
            this.txtOldPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 57);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt hệ thống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1194, 545);
            this.Controls.Add(this.tabSetting);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.tabSetting.ResumeLayout(false);
            this.tabSettingChangePassword.ResumeLayout(false);
            this.tabSettingChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSetting;
        private System.Windows.Forms.TabPage tabSettingChangePassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnChangePassword;
    }
}