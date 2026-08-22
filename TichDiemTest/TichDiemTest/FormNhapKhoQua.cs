using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormNhapKhoQua : Form
    {
        private QuanLyKhachHang qlKH;
        private Qua qua;

        public FormNhapKhoQua(QuanLyKhachHang ql, Qua q)
        {
            InitializeComponent();
            qlKH = ql;
            qua = q;

            Text = "Nhập kho quà: " + qua.TenQua;
            lblThongTin.Text = string.Format("Quà: {0} ({1})\nTồn kho hiện tại: {2} {3}\nĐiểm cần: {4:N0} điểm/{1}",
                qua.TenQua, qua.DonViTinh, qua.SoLuongTon, qua.DonViTinh, qua.DiemCan);

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
            if (qlKH.NhapKhoQua(qua.MaQua, soLuong, out loi))
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