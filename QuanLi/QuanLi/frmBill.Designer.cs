namespace QuanLi
{
    partial class frmBill
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errMaHD = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.gbxDetailBill = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbxSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaHD2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.btnSua2 = new System.Windows.Forms.Button();
            this.btnHuyBo2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.errSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.Label();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.errProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.cbxSapXep = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSapXep2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNL = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHD)).BeginInit();
            this.gbxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.gbxDetailBill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvBill);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(601, 309);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(19, 21);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 62;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(562, 278);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.Click += new System.EventHandler(this.dgvBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(601, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(481, 21);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Làm mới";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 21);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(368, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(44, 21);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(152, 21);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.cbxKH);
            this.gbxInfo.Controls.Add(this.cbxNV);
            this.gbxInfo.Controls.Add(this.dtpNgayLap);
            this.gbxInfo.Controls.Add(this.label4);
            this.gbxInfo.Controls.Add(this.label3);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.txtMaHD);
            this.gbxInfo.Location = new System.Drawing.Point(12, 63);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxInfo.Size = new System.Drawing.Size(601, 97);
            this.gbxInfo.TabIndex = 4;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin";
            // 
            // cbxKH
            // 
            this.cbxKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(412, 60);
            this.cbxKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(169, 24);
            this.cbxKH.TabIndex = 5;
            // 
            // cbxNV
            // 
            this.cbxNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(412, 23);
            this.cbxNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(169, 24);
            this.cbxNV.TabIndex = 5;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(123, 57);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(151, 22);
            this.dtpNgayLap.TabIndex = 4;
            this.dtpNgayLap.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgayLap_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(123, 23);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(151, 27);
            this.txtMaHD.TabIndex = 0;
            this.txtMaHD.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaHD_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hóa Đơn";
            // 
            // errMaHD
            // 
            this.errMaHD.ContainerControl = this;
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.dgvCTHD);
            this.gbxList.Location = new System.Drawing.Point(640, 279);
            this.gbxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxList.Name = "gbxList";
            this.gbxList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxList.Size = new System.Drawing.Size(640, 234);
            this.gbxList.TabIndex = 3;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "Chi tiết hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(9, 21);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 62;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(623, 205);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.Click += new System.EventHandler(this.dgvCTHD_Click);
            // 
            // gbxDetailBill
            // 
            this.gbxDetailBill.Controls.Add(this.txtSoLuong);
            this.gbxDetailBill.Controls.Add(this.cbxSP);
            this.gbxDetailBill.Controls.Add(this.label5);
            this.gbxDetailBill.Controls.Add(this.label6);
            this.gbxDetailBill.Controls.Add(this.label7);
            this.gbxDetailBill.Controls.Add(this.label9);
            this.gbxDetailBill.Controls.Add(this.txtGia);
            this.gbxDetailBill.Controls.Add(this.txtMaHD2);
            this.gbxDetailBill.Location = new System.Drawing.Point(640, 63);
            this.gbxDetailBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetailBill.Name = "gbxDetailBill";
            this.gbxDetailBill.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetailBill.Size = new System.Drawing.Size(643, 97);
            this.gbxDetailBill.TabIndex = 4;
            this.gbxDetailBill.TabStop = false;
            this.gbxDetailBill.Text = "Chi tiết";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(447, 64);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(151, 26);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoLuong_Validating);
            // 
            // cbxSP
            // 
            this.cbxSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSP.FormattingEnabled = true;
            this.cbxSP.Location = new System.Drawing.Point(125, 27);
            this.cbxSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSP.Name = "cbxSP";
            this.cbxSP.Size = new System.Drawing.Size(151, 24);
            this.cbxSP.TabIndex = 6;
            this.cbxSP.SelectedIndexChanged += new System.EventHandler(this.cbxSP_SelectedIndexChanged);
            this.cbxSP.Validating += new System.ComponentModel.CancelEventHandler(this.cbxSP_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Lượng(Mua)(Cái)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá(VNĐ)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng(Còn lại)(Cái)";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(125, 60);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(151, 27);
            this.txtGia.TabIndex = 0;
            this.txtGia.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaHD_Validating);
            // 
            // txtMaHD2
            // 
            this.txtMaHD2.Location = new System.Drawing.Point(447, 27);
            this.txtMaHD2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD2.Multiline = true;
            this.txtMaHD2.Name = "txtMaHD2";
            this.txtMaHD2.Size = new System.Drawing.Size(151, 27);
            this.txtMaHD2.TabIndex = 0;
            this.txtMaHD2.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaHD_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem2);
            this.groupBox1.Controls.Add(this.btnSua2);
            this.groupBox1.Controls.Add(this.btnHuyBo2);
            this.groupBox1.Controls.Add(this.btnXoa2);
            this.groupBox1.Controls.Add(this.btnLuu2);
            this.groupBox1.Location = new System.Drawing.Point(640, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(643, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính năng";
            // 
            // btnThem2
            // 
            this.btnThem2.Location = new System.Drawing.Point(175, 21);
            this.btnThem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(75, 39);
            this.btnThem2.TabIndex = 5;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnSua2
            // 
            this.btnSua2.Location = new System.Drawing.Point(281, 21);
            this.btnSua2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua2.Name = "btnSua2";
            this.btnSua2.Size = new System.Drawing.Size(75, 39);
            this.btnSua2.TabIndex = 4;
            this.btnSua2.Text = "Sửa";
            this.btnSua2.UseVisualStyleBackColor = true;
            this.btnSua2.Click += new System.EventHandler(this.btnSua2_Click);
            // 
            // btnHuyBo2
            // 
            this.btnHuyBo2.Location = new System.Drawing.Point(499, 21);
            this.btnHuyBo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyBo2.Name = "btnHuyBo2";
            this.btnHuyBo2.Size = new System.Drawing.Size(75, 39);
            this.btnHuyBo2.TabIndex = 3;
            this.btnHuyBo2.Text = "Làm Mới";
            this.btnHuyBo2.UseVisualStyleBackColor = true;
            this.btnHuyBo2.Click += new System.EventHandler(this.btnHuyBo2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Location = new System.Drawing.Point(389, 21);
            this.btnXoa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(75, 39);
            this.btnXoa2.TabIndex = 2;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnLuu2
            // 
            this.btnLuu2.Location = new System.Drawing.Point(68, 21);
            this.btnLuu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(75, 39);
            this.btnLuu2.TabIndex = 1;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // errSoLuong
            // 
            this.errSoLuong.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(727, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tổng tiền: ";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.AutoSize = true;
            this.txtTotalMoney.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(855, 548);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(79, 28);
            this.txtTotalMoney.TabIndex = 5;
            this.txtTotalMoney.Text = "0 VNĐ";
            // 
            // btnExportFile
            // 
            this.btnExportFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.Location = new System.Drawing.Point(1140, 529);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(141, 44);
            this.btnExportFile.TabIndex = 6;
            this.btnExportFile.Text = "Xuất Hóa Đơn";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // errProduct
            // 
            this.errProduct.ContainerControl = this;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::QuanLi.Properties.Resources.exit2;
            this.pbExit.Location = new System.Drawing.Point(1275, -3);
            this.pbExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(31, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // cbxSapXep
            // 
            this.cbxSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep.FormattingEnabled = true;
            this.cbxSapXep.Items.AddRange(new object[] {
            "Mã hóa đơn tăng dần",
            "Mã hóa đơn giảm dần",
            "Ngày lập tăng dần",
            "Ngày lập giảm dần",
            "Tên người lập tăng dần",
            "Tên người lập giảm dần",
            "Tên người mua tăng dần",
            "Tên người mua giảm dần"});
            this.cbxSapXep.Location = new System.Drawing.Point(425, 253);
            this.cbxSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSapXep.Name = "cbxSapXep";
            this.cbxSapXep.Size = new System.Drawing.Size(188, 24);
            this.cbxSapXep.TabIndex = 13;
            this.cbxSapXep.SelectedIndexChanged += new System.EventHandler(this.cbxSapXep_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sắp xếp theo:";
            // 
            // cbxSapXep2
            // 
            this.cbxSapXep2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep2.FormattingEnabled = true;
            this.cbxSapXep2.Items.AddRange(new object[] {
            "Mã sản phầm tăng dần",
            "Mã sản phầm giảm dần",
            "Tên sản phầm tăng dần",
            "Tên sản phầm giảm dần",
            "Số lượng tăng dần",
            "Số lượng giảm dần",
            "Tổng tiền tăng dần",
            "Tổng tiền giảm dần"});
            this.cbxSapXep2.Location = new System.Drawing.Point(1093, 249);
            this.cbxSapXep2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSapXep2.Name = "cbxSapXep2";
            this.cbxSapXep2.Size = new System.Drawing.Size(188, 24);
            this.cbxSapXep2.TabIndex = 15;
            this.cbxSapXep2.SelectedIndexChanged += new System.EventHandler(this.cbxSapXep2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(964, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Sắp xếp theo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errNL
            // 
            this.errNL.ContainerControl = this;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1308, 592);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxSapXep2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxSapXep);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxDetailBill);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHD)).EndInit();
            this.gbxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.gbxDetailBill.ResumeLayout(false);
            this.gbxDetailBill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxKH;
        private System.Windows.Forms.ComboBox cbxNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errMaHD;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox gbxDetailBill;
        private System.Windows.Forms.ComboBox cbxSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaHD2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.ErrorProvider errSoLuong;
        private System.Windows.Forms.Button btnHuyBo2;
        private System.Windows.Forms.Button btnSua2;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Label txtTotalMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errProduct;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ComboBox cbxSapXep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSapXep2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errNL;
    }
}