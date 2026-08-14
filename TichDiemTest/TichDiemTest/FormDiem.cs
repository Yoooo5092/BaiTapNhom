using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    /// <summary>
    // Form cộng/trừ điểm cho khách hàng
    /// </summary>
    public partial class FormDiem : Form
    {
        private KhachHang khachHang;
        private QuanLyKhachHang qlKH;
        private bool laCongDiem; // true = cộng, false = trừ/đổi quà

        public FormDiem(QuanLyKhachHang ql, KhachHang kh, bool congDiem)
        {
            InitializeComponent();
            qlKH = ql;
            khachHang = kh;
            laCongDiem = congDiem;

            Text = laCongDiem ? "Cộng điểm" : "Đổi quà (trừ điểm)";
            lblTieuDe.Text = laCongDiem ? "Nhập số điểm cộng:" : "Nhập số điểm đổi quà:";
            btnXacNhan.Text = laCongDiem ? "Cộng điểm" : "Đổi quà";

            lblThongTin.Text = $"Khách hàng: {kh.HoTen} (SĐT: {kh.SoDienThoai})\nĐiểm hiện tại: {kh.DiemTichLuy:N0} | Cấp bậc: {kh.CapBac}";
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.numDiem = new NumericUpDown();
            this.btnXacNhan = new Button();
            this.btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "FormDiem";

            // Tiêu đề
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTieuDe.Location = new System.Drawing.Point(20, 20);
            lblTieuDe.Size = new System.Drawing.Size(360, 25);

            // Thông tin KH
            lblThongTin.Location = new System.Drawing.Point(20, 55);
            lblThongTin.Size = new System.Drawing.Size(360, 60);

            // Số điểm
            numDiem.Location = new System.Drawing.Point(20, 130);
            numDiem.Size = new System.Drawing.Size(360, 25);
            numDiem.Maximum = 1000000;
            numDiem.Minimum = 1;
            numDiem.Value = 100;

            // Buttons
            btnXacNhan.Location = new System.Drawing.Point(180, 180);
            btnXacNhan.Size = new System.Drawing.Size(90, 35);
            btnXacNhan.Click += BtnXacNhan_Click;

            btnHuy.Text = "Hủy";
            btnHuy.Location = new System.Drawing.Point(280, 180);
            btnHuy.Size = new System.Drawing.Size(90, 35);

            this.Controls.AddRange(new Control[] { lblTieuDe, lblThongTin, numDiem, btnXacNhan, btnHuy });
            this.AcceptButton = btnXacNhan;
            this.CancelButton = btnHuy;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            int diem = (int)numDiem.Value;
            string loi;

            bool ok = laCongDiem
                ? qlKH.CongDiem(khachHang.MaKH, diem, out loi)
                : qlKH.DoiQua(khachHang.MaKH, diem, out loi);

            if (ok)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Designer fields
        private Label lblTieuDe, lblThongTin;
        private NumericUpDown numDiem;
        private Button btnXacNhan, btnHuy;
        #endregion
    }
}