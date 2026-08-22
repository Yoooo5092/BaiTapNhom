using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormNhapKho : Form
    {
        private QuanLyKhachHang qlKH;
        private Thuoc thuoc;

        public FormNhapKho(QuanLyKhachHang ql, Thuoc t)
        {
            InitializeComponent();
            qlKH = ql;
            thuoc = t;

            Text = "Nhập kho: " + thuoc.TenThuoc;
            lblThongTin.Text = string.Format("Thuốc: {0} ({1})\nTồn kho hiện tại: {2} {3}\nĐơn giá: {4:N0} VNĐ/{1}",
                thuoc.TenThuoc, thuoc.DonViTinh, thuoc.SoLuongTon, thuoc.DonViTinh, thuoc.DonGia);

            numSoLuongNhap.Value = 1;
            numSoLuongNhap.Focus();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuong = (int)numSoLuongNhap.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loi;
            if (qlKH.NhapKhoThuoc(thuoc.MaThuoc, soLuong, out loi))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}