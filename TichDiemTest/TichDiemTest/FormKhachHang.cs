using System;
using System.Windows.Forms;
using System.Drawing;

namespace TichDiemTest
{
    public partial class FormKhachHang : Form
    {
        private KhachHang khachHang;
        private bool laThemMoi;
        private QuanLyKhachHang qlKH;

        public KhachHang KetQua { get; private set; }

        public FormKhachHang(QuanLyKhachHang ql, KhachHang kh = null)
        {
            InitializeComponent();
            qlKH = ql;
            laThemMoi = (kh == null);
            khachHang = kh ?? new KhachHang();

            Text = laThemMoi ? "Thêm khách hàng mới" : "Cập nhật khách hàng";
            btnLuu.Text = laThemMoi ? "Thêm" : "Cập nhật";

            if (!laThemMoi)
            {
                txtHoTen.Text = khachHang.HoTen;
                txtSDT.Text = khachHang.SoDienThoai;
                txtEmail.Text = khachHang.Email;
                txtDiem.Text = khachHang.DiemTichLuy.ToString();
                txtCapBac.Text = khachHang.CapBac;
                txtNgayDK.Text = khachHang.NgayDangKy.ToString("dd/MM/yyyy");

                txtDiem.ReadOnly = true;
                txtCapBac.ReadOnly = true;
                txtNgayDK.ReadOnly = true;
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string loi;
            khachHang.HoTen = txtHoTen.Text.Trim();
            khachHang.SoDienThoai = txtSDT.Text.Trim();
            khachHang.Email = txtEmail.Text.Trim();

            if (!khachHang.HopLe(out loi))
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (laThemMoi)
            {
                if (qlKH.Them(khachHang, out loi))
                {
                    KetQua = khachHang;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (qlKH.CapNhat(khachHang, out loi))
                {
                    KetQua = khachHang;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}