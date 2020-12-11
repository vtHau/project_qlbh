namespace QuanLi
{
    partial class frmUser
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSapXep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errMaKH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenKH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
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
            this.gbxInfo.Controls.Add(this.txtEmail);
            this.gbxInfo.Controls.Add(this.txtSDT);
            this.gbxInfo.Controls.Add(this.txtTenKH);
            this.gbxInfo.Controls.Add(this.txtMaKH);
            this.gbxInfo.Location = new System.Drawing.Point(12, 69);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(993, 98);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Emaii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khách hàng";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(397, 60);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(135, 22);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgaySinh_Validating);
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(397, 18);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(135, 24);
            this.cbxGioiTinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(808, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 22);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(652, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(652, 21);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(127, 22);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(145, 61);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(151, 22);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(145, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(151, 22);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaKH_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(206, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(514, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Làm mới";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(293, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(402, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(72, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUser);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(993, 216);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(17, 21);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(960, 189);
            this.dgvUser.TabIndex = 12;
            this.dgvUser.Click += new System.EventHandler(this.dgvUser_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "Khách hàng";
            // 
            // cbxSapXep
            // 
            this.cbxSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep.FormattingEnabled = true;
            this.cbxSapXep.Items.AddRange(new object[] {
            "Mã khách hàng tăng dần",
            "Mã khách hàng giảm dần",
            "Tên khách hàng tăng dần",
            "Tên kháchh hàng giảm dần",
            "Giới tính Nam trước",
            "Giới tính Nữ trước",
            "Năm sinh tăng dần",
            "Năm sinh giảm dần"});
            this.cbxSapXep.Location = new System.Drawing.Point(797, 253);
            this.cbxSapXep.Name = "cbxSapXep";
            this.cbxSapXep.Size = new System.Drawing.Size(188, 24);
            this.cbxSapXep.TabIndex = 12;
            this.cbxSapXep.SelectedIndexChanged += new System.EventHandler(this.cbxSapXep_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sắp xếp theo:";
            // 
            // errMaKH
            // 
            this.errMaKH.BlinkRate = 0;
            this.errMaKH.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaKH.ContainerControl = this;
            // 
            // errTenKH
            // 
            this.errTenKH.ContainerControl = this;
            // 
            // errNS
            // 
            this.errNS.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSapXep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxInfo);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxSapXep;
        private System.Windows.Forms.ErrorProvider errMaKH;
        private System.Windows.Forms.ErrorProvider errTenKH;
        private System.Windows.Forms.ErrorProvider errNS;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errDC;
    }
}