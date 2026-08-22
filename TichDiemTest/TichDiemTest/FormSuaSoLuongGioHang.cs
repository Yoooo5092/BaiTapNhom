using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormSuaSoLuongGioHang : Form
    {
        private ChiTietBanThuoc item;
        private int soLuongTon;

        public int SoLuongMoi { get; private set; }

        public FormSuaSoLuongGioHang(ChiTietBanThuoc ct)
        {
            InitializeComponent();
            item = ct;
            soLuongTon = 999999;

            Text = "Sửa số lượng: " + item.TenThuoc;
            lblTenThuoc.Text = item.TenThuoc + " (" + item.DonViTinh + ")";
            lblDonGia.Text = "Đơn giá: " + item.DonGia.ToString("N0") + " VNĐ";
            lblThanhTien.Text = "Thành tiền: " + item.ThanhTien.ToString("N0") + " VNĐ";

            numSoLuong.Value = item.SoLuong;
            numSoLuong.Minimum = 0;
            numSoLuong.Maximum = soLuongTon;
            numSoLuong.ValueChanged += NumSoLuong_ValueChanged;
        }

        public void SetSoLuongTon(int ton)
        {
            soLuongTon = ton;
            numSoLuong.Maximum = ton;
            if (numSoLuong.Value > ton) numSoLuong.Value = ton;
        }

        private void NumSoLuong_ValueChanged(object sender, EventArgs e)
        {
            int sl = (int)numSoLuong.Value;
            lblThanhTien.Text = "Thành tiền: " + (item.DonGia * sl).ToString("N0") + " VNĐ";
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            SoLuongMoi = (int)numSoLuong.Value;
            DialogResult = DialogResult.OK;
        }
    }
}