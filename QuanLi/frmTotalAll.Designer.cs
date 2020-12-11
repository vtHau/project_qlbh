namespace QuanLi
{
    partial class frmTotalAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalAll));
            this.label8 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.Label();
            this.txtHD = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(418, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 63);
            this.label8.TabIndex = 5;
            this.label8.Text = "Thống kê";
            // 
            // txtSP
            // 
            this.txtSP.AutoSize = true;
            this.txtSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtSP.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtSP.Image = ((System.Drawing.Image)(resources.GetObject("txtSP.Image")));
            this.txtSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSP.Location = new System.Drawing.Point(12, 374);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(202, 46);
            this.txtSP.TabIndex = 5;
            this.txtSP.Text = "Sản phẩm:";
            // 
            // txtHD
            // 
            this.txtHD.AutoSize = true;
            this.txtHD.BackColor = System.Drawing.SystemColors.Window;
            this.txtHD.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtHD.Image = ((System.Drawing.Image)(resources.GetObject("txtHD.Image")));
            this.txtHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHD.Location = new System.Drawing.Point(12, 289);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(177, 46);
            this.txtHD.TabIndex = 5;
            this.txtHD.Text = "Hóa đơn:";
            this.txtHD.Click += new System.EventHandler(this.txtHD_Click);
            // 
            // txtNV
            // 
            this.txtNV.AutoSize = true;
            this.txtNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtNV.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtNV.Image = ((System.Drawing.Image)(resources.GetObject("txtNV.Image")));
            this.txtNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNV.Location = new System.Drawing.Point(12, 192);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(210, 46);
            this.txtNV.TabIndex = 5;
            this.txtNV.Text = "Nhân Viên:";
            this.txtNV.Click += new System.EventHandler(this.txtNV_Click);
            // 
            // txtKH
            // 
            this.txtKH.AutoSize = true;
            this.txtKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtKH.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtKH.Image = ((System.Drawing.Image)(resources.GetObject("txtKH.Image")));
            this.txtKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKH.Location = new System.Drawing.Point(12, 113);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(256, 46);
            this.txtKH.TabIndex = 5;
            this.txtKH.Text = "  Khách hàng:";
            // 
            // frmTotalAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1150, 554);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTotalAll";
            this.Text = "frmTotalAll";
            this.Load += new System.EventHandler(this.frmTotalAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtSP;
        private System.Windows.Forms.Label txtHD;
        private System.Windows.Forms.Label txtNV;
        private System.Windows.Forms.Label txtKH;
    }
}