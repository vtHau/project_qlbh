namespace QuanLi
{
    partial class frmExportFIle
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
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errNoiLuu = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiLuu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Image = global::QuanLi.Properties.Resources.exit2;
            this.pbExit.Location = new System.Drawing.Point(526, -3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(31, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 8;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Xuất Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên File: ";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Location = new System.Drawing.Point(120, 83);
            this.txtTenFile.Multiline = true;
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(343, 29);
            this.txtTenFile.TabIndex = 11;
            this.txtTenFile.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenFile_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Xuất Hóa Đơn";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errNoiLuu
            // 
            this.errNoiLuu.ContainerControl = this;
            // 
            // frmExportFIle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(557, 222);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExportFIle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExportFIle";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiLuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errNoiLuu;
    }
}