using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormDiem : Form
    {
        private KhachHang khachHang;
        private QuanLyKhachHang qlKH;
        private bool laCongDiem;

        // Cờ (flag) dùng để tránh vòng lặp vô hạn khi 2 ô nhảy số gọi chéo nhau
        private bool dangCapNhat = false;

        public FormDiem(QuanLyKhachHang ql, KhachHang kh, bool congDiem)
        {
            InitializeComponent();
            qlKH = ql;
            khachHang = kh;
            laCongDiem = congDiem;

            Text = laCongDiem ? "Cộng điểm" : "Đổi quà (trừ điểm)";
            lblTieuDe.Text = laCongDiem ? "Thông tin hóa đơn & cộng điểm" : "Thông tin đổi quà";
            btnXacNhan.Text = laCongDiem ? "Cộng điểm" : "Đổi quà";

            lblThongTin.Text = $"Khách hàng: {kh.HoTen} (SĐT: {kh.SoDienThoai})\nĐiểm hiện tại: {kh.DiemTichLuy:N0} | Cấp bậc: {kh.CapBac}";

            if (!laCongDiem)
            {
                lblTien.Visible = false;
                numTienHoaDon.Visible = false;
                lblDiem.Location = new System.Drawing.Point(20, 90);
                numDiem.Location = new System.Drawing.Point(20, 110);
            }

            numTienHoaDon.ValueChanged += NumTienHoaDon_ValueChanged;
            numDiem.ValueChanged += NumDiem_ValueChanged;
            btnXacNhan.Click += BtnXacNhan_Click;
        }

        private void NumTienHoaDon_ValueChanged(object sender, EventArgs e)
        {
            if (dangCapNhat) return;
            dangCapNhat = true;
            numDiem.Value = Math.Floor(numTienHoaDon.Value / 1000);
            dangCapNhat = false;
        }

        private void NumDiem_ValueChanged(object sender, EventArgs e)
        {
            if (dangCapNhat) return;
            dangCapNhat = true;
            numTienHoaDon.Value = numDiem.Value * 1000;

            dangCapNhat = false;
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            int diem = (int)numDiem.Value;

            if (diem <= 0)
            {
                MessageBox.Show("Số điểm phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
    }
}