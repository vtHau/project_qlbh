namespace QuanLi
{
    partial class frmChangePass
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNewPassPre = new System.Windows.Forms.TextBox();
            this.changePass = new System.Windows.Forms.Button();
            this.lblNoti = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.errCurrPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNewPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNewPassPre = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurrPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassPre)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mật Khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCurrPass);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu cũ";
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrPass.Location = new System.Drawing.Point(6, 21);
            this.txtCurrPass.Multiline = true;
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.PasswordChar = '*';
            this.txtCurrPass.Size = new System.Drawing.Size(189, 25);
            this.txtCurrPass.TabIndex = 0;
            this.txtCurrPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrPass_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Location = new System.Drawing.Point(10, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật khẩu mới";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(6, 21);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(188, 25);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPass_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewPassPre);
            this.groupBox3.Location = new System.Drawing.Point(9, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNewPassPre
            // 
            this.txtNewPassPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassPre.Location = new System.Drawing.Point(6, 21);
            this.txtNewPassPre.Multiline = true;
            this.txtNewPassPre.Name = "txtNewPassPre";
            this.txtNewPassPre.PasswordChar = '*';
            this.txtNewPassPre.Size = new System.Drawing.Size(188, 25);
            this.txtNewPassPre.TabIndex = 1;
            this.txtNewPassPre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassPre_Validating);
            // 
            // changePass
            // 
            this.changePass.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePass.Location = new System.Drawing.Point(53, 199);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(122, 44);
            this.changePass.TabIndex = 8;
            this.changePass.Text = "Cập Nhật";
            this.changePass.UseVisualStyleBackColor = true;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Location = new System.Drawing.Point(47, 183);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(0, 17);
            this.lblNoti.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoti);
            this.panel1.Controls.Add(this.changePass);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(40, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 260);
            this.panel1.TabIndex = 10;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::QuanLi.Properties.Resources.exit2;
            this.pbExit.Location = new System.Drawing.Point(278, -3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(31, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 11;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // errCurrPass
            // 
            this.errCurrPass.ContainerControl = this;
            // 
            // errNewPass
            // 
            this.errNewPass.ContainerControl = this;
            // 
            // errNewPassPre
            // 
            this.errNewPassPre.ContainerControl = this;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(311, 349);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePass";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurrPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNewPassPre;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ErrorProvider errCurrPass;
        private System.Windows.Forms.ErrorProvider errNewPass;
        private System.Windows.Forms.ErrorProvider errNewPassPre;
        private System.Windows.Forms.TextBox txtCurrPass;
    }
}