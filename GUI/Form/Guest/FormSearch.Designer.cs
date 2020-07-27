namespace GUI
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.drgvResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(296, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm Nhà Hàng Tiệc Cưới";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.DarkOrange;
            this.btnClose.IconSize = 64;
            this.btnClose.Location = new System.Drawing.Point(991, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(752, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(170, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKeyword.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(184, 120);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(561, 42);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // drgvResult
            // 
            this.drgvResult.AllowUserToAddRows = false;
            this.drgvResult.AllowUserToDeleteRows = false;
            this.drgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgvResult.Location = new System.Drawing.Point(0, 190);
            this.drgvResult.Name = "drgvResult";
            this.drgvResult.ReadOnly = true;
            this.drgvResult.RowHeadersWidth = 62;
            this.drgvResult.RowTemplate.Height = 28;
            this.drgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drgvResult.Size = new System.Drawing.Size(1067, 407);
            this.drgvResult.TabIndex = 10;
            this.drgvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgvResult_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 190);
            this.panel1.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnLogin.IconColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.IconSize = 64;
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(64, 64);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 407);
            this.panel2.TabIndex = 12;
            // 
            // FormSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.drgvResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Nhà Hàng";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSearch_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.drgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView drgvResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnLogin;
    }
}

