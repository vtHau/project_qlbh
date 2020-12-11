namespace QuanLi
{
    partial class frmEmployee
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSapXep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errNS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEmployee);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(993, 216);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(26, 21);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(960, 189);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.Click += new System.EventHandler(this.dgvEmployee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(196, 170);
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
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtEmail);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.label4);
            this.gbxInfo.Controls.Add(this.label7);
            this.gbxInfo.Controls.Add(this.label6);
            this.gbxInfo.Controls.Add(this.label5);
            this.gbxInfo.Controls.Add(this.label3);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.dtpNgaySinh);
            this.gbxInfo.Controls.Add(this.cbxGioiTinh);
            this.gbxInfo.Controls.Add(this.txtDiaChi);
            this.gbxInfo.Controls.Add(this.txtSDT);
            this.gbxInfo.Controls.Add(this.txtTenNV);
            this.gbxInfo.Controls.Add(this.txtMaNV);
            this.gbxInfo.Location = new System.Drawing.Point(12, 60);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(993, 98);
            this.gbxInfo.TabIndex = 3;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(625, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 22);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(767, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(371, 62);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(135, 22);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgaySinh_Validating);
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(371, 23);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(135, 24);
            this.cbxGioiTinh.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(770, 62);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(152, 22);
            this.txtDiaChi.TabIndex = 0;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(625, 23);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(127, 22);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(122, 64);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(151, 22);
            this.txtTenNV.TabIndex = 0;
            this.txtTenNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNV_Validating);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(122, 20);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(151, 22);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaNV_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhân viên";
            // 
            // cbxSapXep
            // 
            this.cbxSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep.FormattingEnabled = true;
            this.cbxSapXep.Items.AddRange(new object[] {
            "Mã nhân viên tăng dần",
            "Mã nhân viên giảm dần",
            "Tên nhân viên tăng dần",
            "Tên nhân viên giảm dần",
            "Giới tính Nam trước",
            "Giới tính Nữ trước",
            "Năm sinh tăng dần",
            "Năm sinh giảm dần"});
            this.cbxSapXep.Location = new System.Drawing.Point(803, 250);
            this.cbxSapXep.Name = "cbxSapXep";
            this.cbxSapXep.Size = new System.Drawing.Size(188, 24);
            this.cbxSapXep.TabIndex = 13;
            this.cbxSapXep.SelectedIndexChanged += new System.EventHandler(this.cbxSapXep_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sắp xếp theo:";
            // 
            // errNS
            // 
            this.errNS.BlinkRate = 0;
            this.errNS.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errNS.ContainerControl = this;
            // 
            // errMaNV
            // 
            this.errMaNV.BlinkRate = 0;
            this.errMaNV.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaNV.ContainerControl = this;
            // 
            // errTenNV
            // 
            this.errTenNV.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSapXep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSapXep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errNS;
        private System.Windows.Forms.ErrorProvider errMaNV;
        private System.Windows.Forms.ErrorProvider errTenNV;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errDC;
    }
}