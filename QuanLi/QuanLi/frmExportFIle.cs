using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class frmExportFIle : Form
    {
        public string pathFile;
        public string person;
        public string user;
        public int count;
        public int getMoney;
        public DataGridView dgvCTHD;
        public DataTable DTKH;

        public frmExportFIle()
        {
            InitializeComponent();
        }

        public frmExportFIle(string strMaHD, string strPerson, string strUser, int iCount, int iGetMoney, DataGridView dgvHD, DataTable dtKH) : this()
        {
            person = strPerson;
            user = strUser;
            count = iCount;
            getMoney = iGetMoney;
            dgvCTHD = dgvHD;
            DTKH = dtKH;
            txtTenFile.Text = strMaHD + "_" + strUser + "_" + iGetMoney;
        }

        private string getDataDGV(int i, int j)
        {
            return dgvCTHD.Rows[i].Cells[j].Value.ToString();
        }


        private void pbExit_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            this.Close();
        }

        private void txtTenFile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenFile.Text.Trim()))
            {
                e.Cancel = true;
                txtTenFile.Focus();
                errNoiLuu.SetError(txtTenFile, "Vui lòng nhập tên File để lưu");
            }
            else if (txtTenFile.Text.Trim().Length > 100)
            {
                e.Cancel = true;
                txtTenFile.Focus();
                errNoiLuu.SetError(txtTenFile, "Tên File quá dài");
            }
            else
            {
                e.Cancel = false;
                errNoiLuu.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string fileName = txtTenFile.Text.Trim();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = fileName + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Gặp vấn đề khi ghi dữ liệu vào ổ đĩa" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document PrintFile = new Document(iTextSharp.text.PageSize.HALFLETTER);
                                PdfWriter.GetInstance(PrintFile, stream);

                                string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                                string exeDir = Path.GetDirectoryName(exeFile);
                                string pFontVN = Path.Combine(exeDir, @"Fonts_VietNam\Font_GD.ttf");

                                MessageBox.Show(pFontVN);

                                BaseFont bFontVN = BaseFont.CreateFont(pFontVN, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                                iTextSharp.text.Font FontHeader = new iTextSharp.text.Font(bFontVN, 20, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                                iTextSharp.text.Font FontProduct = new iTextSharp.text.Font(bFontVN, 13, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.DARK_GRAY);
                                iTextSharp.text.Font FontTime = new iTextSharp.text.Font(bFontVN, 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

                                PdfPTable table = new PdfPTable(1);
                                table.DefaultCell.Padding = 3;
                                table.DefaultCell.MinimumHeight = 20;
                                table.WidthPercentage = 100;
                                table.DefaultCell.BorderWidth = 1;

                                Paragraph products = new Paragraph();

                                Paragraph title = new Paragraph(new Phrase($"\n              Chi Tiết Hóa Đơn\n\n", FontHeader));
                                products.Add(title);

                                Paragraph titleUser = new Paragraph(new Phrase("                        Thông Tin Khách Hàng\n\n", FontProduct));
                                products.Add(titleUser);

                                string ten = "           Tên khách hàng: " + DTKH.Rows[0][0].ToString() + "\n";
                                string sdt = "           Số điện thoại: " + DTKH.Rows[0][1].ToString() + " \n";
                                string diaChi = "           Địa chỉ: " + DTKH.Rows[0][2].ToString() + " \n";
                                string line = "       --------------------------------------------------------------------------\n\n";

                                Paragraph infoUser = new Paragraph(ten + sdt + diaChi + line, FontProduct);
                                products.Add(infoUser);

                                Paragraph titleProduct = new Paragraph(new Phrase("                           Danh Sách Sản Phẩm\n\n", FontProduct));
                                products.Add(titleProduct);

                                for (int i = 0; i < count; i++)
                                {
                                    Paragraph product = new Paragraph();

                                    for (int j = 1; j <= 4; j += 4)
                                    {
                                        string tenSP = "        * Tên sản phẩm: " + getDataDGV(i, j) + "\n";
                                        string soLuong = "        * Số lượng: " + getDataDGV(i, j + 1) + " cái \n";
                                        string gia = "        * Giá: " + getDataDGV(i, j + 2) + " VNĐ \n";
                                        string tongTien = "        * Thành tiền: " + getDataDGV(i, j + 3) + " VNĐ \n";
                                        string lastLine = "                  *****************************\n\n";

                                        Paragraph infoProduct = new Paragraph(tenSP + soLuong + gia + tongTien + lastLine, FontProduct);
                                        product.Add(infoProduct);
                                    }
                                    products.Add(product);
                                }

                                string money = "         -Tổng tiền là: " + getMoney + " VNĐ";

                                Paragraph totalMoney = new Paragraph(line + money, FontProduct);
                                totalMoney.Alignment = Element.ALIGN_CENTER;
                                products.Add(totalMoney);

                                string strPersonPrint = "\n\n                                                                            Người in: " + person;
                                Paragraph personPrint = new Paragraph(strPersonPrint, FontTime);
                                personPrint.Alignment = Element.ALIGN_CENTER;
                                personPrint.PaddingTop = 50;
                                products.Add(personPrint);

                                DateTime time = DateTime.Now;
                                string timePrint = "\n                                                                            Ngày in: " + time.ToString() + "\n\n";
                                Paragraph print = new Paragraph(timePrint, FontTime);
                                print.Alignment = Element.ALIGN_CENTER;
                                print.PaddingTop = 5;
                                products.Add(print);

                                table.AddCell(products);

                                PrintFile.Open();
                                PrintFile.Add(table);
                                PrintFile.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Xuất hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
