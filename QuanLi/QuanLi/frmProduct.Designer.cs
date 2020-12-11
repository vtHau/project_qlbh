namespace QuanLi
{
    partial class frmProduct
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDM = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.errMaSP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenSP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxSapXep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errNS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDM = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxSortDM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProduct);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(993, 225);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(82, 21);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(828, 189);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(190, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(514, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Làm mới";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(293, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(402, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(72, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 38);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(198, 15);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(151, 28);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaSP_Validating);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(198, 61);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(151, 31);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenSP_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá(VNĐ)";
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.label7);
            this.gbxInfo.Controls.Add(this.label6);
            this.gbxInfo.Controls.Add(this.cbxDM);
            this.gbxInfo.Controls.Add(this.txtSoLuong);
            this.gbxInfo.Controls.Add(this.label5);
            this.gbxInfo.Controls.Add(this.dtpNgaySinh);
            this.gbxInfo.Controls.Add(this.label4);
            this.gbxInfo.Controls.Add(this.label3);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.txtGia);
            this.gbxInfo.Controls.Add(this.txtTenSP);
            this.gbxInfo.Controls.Add(this.txtMaSP);
            this.gbxInfo.Location = new System.Drawing.Point(12, 60);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(993, 98);
            this.gbxInfo.TabIndex = 3;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // cbxDM
            // 
            this.cbxDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDM.FormattingEnabled = true;
            this.cbxDM.Items.AddRange(new object[] {
            "Điện Thoại",
            "Phụ Kiện Điện Thoại",
            "Laptop",
            "Phụ Kiện Laptop"});
            this.cbxDM.Location = new System.Drawing.Point(792, 61);
            this.cbxDM.Name = "cbxDM";
            this.cbxDM.Size = new System.Drawing.Size(121, 24);
            this.cbxDM.TabIndex = 7;
            this.cbxDM.Validating += new System.ComponentModel.CancelEventHandler(this.cbxDM_Validating);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(792, 14);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 29);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoLuong_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày nhập";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(513, 61);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(151, 22);
            this.dtpNgaySinh.TabIndex = 4;
           
            this.dtpNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgaySinh_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sản phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(513, 14);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(151, 29);
            this.txtGia.TabIndex = 2;
    
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            this.txtGia.Validating += new System.ComponentModel.CancelEventHandler(this.txtGia_Validating);
            // 
            // errMaSP
            // 
            this.errMaSP.ContainerControl = this;
            // 
            // errTenSP
            // 
            this.errTenSP.ContainerControl = this;
            // 
            // errGia
            // 
            this.errGia.ContainerControl = this;
            // 
            // cbxSapXep
            // 
            this.cbxSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep.FormattingEnabled = true;
            this.cbxSapXep.Items.AddRange(new object[] {
            "Mã sản phẩm tăng dần",
            "Mã sản phẩm giảm dần",
            "Tên sản phẩm tăng dần",
            "Tên sản phẩm giảm dần",
            "Giá tăng dần",
            "Giá giảm dần",
            "Sản phẩm mới nhất",
            "Sản phẩm cũ nhất"});
            this.cbxSapXep.Location = new System.Drawing.Point(648, 254);
            this.cbxSapXep.Name = "cbxSapXep";
            this.cbxSapXep.Size = new System.Drawing.Size(188, 24);
            this.cbxSapXep.TabIndex = 13;
            this.cbxSapXep.SelectedIndexChanged += new System.EventHandler(this.cbxSapXep_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sắp xếp theo: ";
            // 
            // errNS
            // 
            this.errNS.ContainerControl = this;
            // 
            // errSoLuong
            // 
            this.errSoLuong.ContainerControl = this;
            // 
            // errDM
            // 
            this.errDM.ContainerControl = this;
            // 
            // cbxSortDM
            // 
            this.cbxSortDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSortDM.FormattingEnabled = true;
            this.cbxSortDM.Items.AddRange(new object[] {
            "Tất cả",
            "Điện Thoại",
            "Phụ Kiện Điện Thoại",
            "Laptop",
            "Phụ Kiện Laptop"});
            this.cbxSortDM.Location = new System.Drawing.Point(269, 254);
            this.cbxSortDM.Name = "cbxSortDM";
            this.cbxSortDM.Size = new System.Drawing.Size(163, 24);
            this.cbxSortDM.TabIndex = 15;
            this.cbxSortDM.SelectedIndexChanged += new System.EventHandler(this.cbxSortDM_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Danh mục:";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSortDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSapXep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ErrorProvider errMaSP;
        private System.Windows.Forms.ErrorProvider errTenSP;
        private System.Windows.Forms.ErrorProvider errGia;
        private System.Windows.Forms.ComboBox cbxSapXep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ErrorProvider errNS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDM;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ErrorProvider errSoLuong;
        private System.Windows.Forms.ErrorProvider errDM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxSortDM;
    }
}