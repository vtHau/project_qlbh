namespace QuanLi
{
    partial class frmIntro
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
            this.txtHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsWhat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHello.Location = new System.Drawing.Point(140, 226);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(737, 38);
            this.txtHello.TabIndex = 6;
            this.txtHello.Text = "Chào Mừng Đến Với Phần Mềm Quản Lí Bán Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lí Bán Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bạn hiện là: ";
            // 
            // txtIsWhat
            // 
            this.txtIsWhat.AutoSize = true;
            this.txtIsWhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsWhat.Location = new System.Drawing.Point(134, 465);
            this.txtIsWhat.Name = "txtIsWhat";
            this.txtIsWhat.Size = new System.Drawing.Size(115, 23);
            this.txtIsWhat.TabIndex = 6;
            this.txtIsWhat.Text = "Bạn hiện là: ";
            this.txtIsWhat.Click += new System.EventHandler(this.txtIsWhat_Click);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 490);
            this.Controls.Add(this.txtIsWhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmIntro";
            this.Text = "frmDefault";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtIsWhat;
    }
}