namespace QLDiaDiemNhaHang
{
    partial class FormSearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchResult));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFindPath = new System.Windows.Forms.GroupBox();
            this.mainMap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHotline = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblAcreage = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumFood = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.btnFindPath.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.18518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.81482F));
            this.tableLayoutPanel1.Controls.Add(this.btnFindPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1620, 614);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnFindPath
            // 
            this.btnFindPath.Controls.Add(this.mainMap);
            this.btnFindPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindPath.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPath.Location = new System.Drawing.Point(1058, 3);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(559, 608);
            this.btnFindPath.TabIndex = 3;
            this.btnFindPath.TabStop = false;
            this.btnFindPath.Text = "Bản đồ chỉ đường";
            // 
            // mainMap
            // 
            this.mainMap.Bearing = 0F;
            this.mainMap.CanDragMap = true;
            this.mainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMap.GrayScaleMode = false;
            this.mainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMap.LevelsKeepInMemory = 5;
            this.mainMap.Location = new System.Drawing.Point(3, 28);
            this.mainMap.MarkersEnabled = true;
            this.mainMap.MaxZoom = 2;
            this.mainMap.MinZoom = 2;
            this.mainMap.MouseWheelZoomEnabled = true;
            this.mainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainMap.Name = "mainMap";
            this.mainMap.NegativeMode = false;
            this.mainMap.PolygonsEnabled = true;
            this.mainMap.RetryLoadTile = 0;
            this.mainMap.RoutesEnabled = true;
            this.mainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMap.ShowTileGridLines = false;
            this.mainMap.Size = new System.Drawing.Size(553, 577);
            this.mainMap.TabIndex = 1;
            this.mainMap.Zoom = 0D;
            this.mainMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMap_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbDesc);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 608);
            this.panel1.TabIndex = 2;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbDesc.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(0, 310);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(1049, 298);
            this.rtbDesc.TabIndex = 1;
            this.rtbDesc.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumFood);
            this.groupBox1.Controls.Add(this.lblHotline);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblRating);
            this.groupBox1.Controls.Add(this.lblStar);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblAcreage);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 608);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Hàng";
            // 
            // lblHotline
            // 
            this.lblHotline.AutoSize = true;
            this.lblHotline.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotline.Location = new System.Drawing.Point(25, 195);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(196, 30);
            this.lblHotline.TabIndex = 0;
            this.lblHotline.Text = "[RestaurantHotline]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "[RestaurantName]";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(633, 195);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(191, 30);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "[RestaurantRating]";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.Location = new System.Drawing.Point(633, 149);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(169, 30);
            this.lblStar.TabIndex = 0;
            this.lblStar.Text = "[RestaurantStar]";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(633, 102);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(212, 30);
            this.lblCapacity.TabIndex = 0;
            this.lblCapacity.Text = "[RestaurantCapacity]";
            // 
            // lblAcreage
            // 
            this.lblAcreage.AutoSize = true;
            this.lblAcreage.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcreage.Location = new System.Drawing.Point(633, 47);
            this.lblAcreage.Name = "lblAcreage";
            this.lblAcreage.Size = new System.Drawing.Size(208, 30);
            this.lblAcreage.TabIndex = 0;
            this.lblAcreage.Text = "[RestaurantAcreage]";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(25, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(205, 30);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "[RestaurantAddress]";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(25, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(181, 30);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "[RestaurantEmail]";
            // 
            // lblNumFood
            // 
            this.lblNumFood.AutoSize = true;
            this.lblNumFood.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFood.Location = new System.Drawing.Point(25, 252);
            this.lblNumFood.Name = "lblNumFood";
            this.lblNumFood.Size = new System.Drawing.Size(178, 30);
            this.lblNumFood.TabIndex = 0;
            this.lblNumFood.Text = "[RestaurantFood]";
            // 
            // FormSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Nhà Hàng Và Chỉ Dẫn";
            this.Load += new System.EventHandler(this.FormSearchResult_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.btnFindPath.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox btnFindPath;
        private GMap.NET.WindowsForms.GMapControl mainMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblAcreage;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumFood;
    }
}