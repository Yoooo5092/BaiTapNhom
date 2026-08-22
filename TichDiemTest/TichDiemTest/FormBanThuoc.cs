using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormBanThuoc : Form
    {
        private QuanLyKhachHang qlKH;
        private KhachHang khachHang;
        private List<Thuoc> danhSachThuoc;
        private List<ChiTietBanThuoc> gioHang = new List<ChiTietBanThuoc>();
        private Thuoc thuocDangChon;

        public FormBanThuoc(QuanLyKhachHang ql, KhachHang kh)
        {
            InitializeComponent();
            qlKH = ql;
            khachHang = kh;
            danhSachThuoc = qlKH.LayDanhSachThuoc();

            Text = "Bán thuốc - " + kh.HoTen;
            lblKhachHang.Text = string.Format("Khách: {0} | SĐT: {1} | Điểm: {2:N0}",
                kh.HoTen, kh.SoDienThoai, kh.DiemTichLuy);

            LoadDanhSachThuoc();
            CapNhatGioHang();
            qlKH.DanhSachThuocDaThayDoi += delegate
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(LoadDanhSachThuoc));
                }
                else
                {
                    LoadDanhSachThuoc();
                }
            };
        }

        private void LoadDanhSachThuoc()
        {
            string tuKhoa = "";
            if (txtTimKiemThuoc.Text != null) tuKhoa = txtTimKiemThuoc.Text.Trim();
            var ds = string.IsNullOrEmpty(tuKhoa) ? danhSachThuoc : qlKH.TimKiemThuoc(tuKhoa);

            var filtered = new List<Thuoc>();
            foreach (var t in ds)
            {
                if (t.SoLuongTon > 0) filtered.Add(t);
            }

            var displayList = new List<object>();
            foreach (var t in filtered)
            {
                displayList.Add(new
                {
                    t.MaThuoc,
                    t.TenThuoc,
                    t.DonViTinh,
                    DonGia = t.DonGia.ToString("N0"),
                    t.SoLuongTon,
                    ThanhTien = (t.DonGia * 1).ToString("N0")
                });
            }

            dgvThuoc.DataSource = null;
            dgvThuoc.DataSource = displayList;

            if (dgvThuoc.Columns["MaThuoc"] != null) dgvThuoc.Columns["MaThuoc"].Visible = false;
            if (dgvThuoc.Columns["DonGia"] != null) dgvThuoc.Columns["DonGia"].HeaderText = "Đơn giá (VNĐ)";
            if (dgvThuoc.Columns["SoLuongTon"] != null)
            {
                dgvThuoc.Columns["SoLuongTon"].HeaderText = "Tồn";
                dgvThuoc.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvThuoc.Columns["ThanhTien"] != null)
            {
                string dvt = filtered.Count > 0 ? filtered[0].DonViTinh : "";
                dgvThuoc.Columns["ThanhTien"].HeaderText = "Thành tiền (1 " + dvt + ")";
                dgvThuoc.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            lblCountThuoc.Text = filtered.Count + " thuốc";
        }

        private void TxtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachThuoc();
        }

        private void DgvThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuoc.CurrentRow != null && dgvThuoc.CurrentRow.DataBoundItem != null)
            {
                var item = dgvThuoc.CurrentRow.DataBoundItem;
                int maThuoc = (int)item.GetType().GetProperty("MaThuoc").GetValue(item);
                thuocDangChon = danhSachThuoc.Find(delegate(Thuoc t) { return t.MaThuoc == maThuoc; });

                if (thuocDangChon != null)
                {
                    lblThuocInfo.Text = string.Format("{0} - {1:N0} VNĐ/{2} - Tồn: {3} {2}",
                        thuocDangChon.TenThuoc, thuocDangChon.DonGia, thuocDangChon.DonViTinh, thuocDangChon.SoLuongTon);
                    numSoLuongBan.Maximum = thuocDangChon.SoLuongTon;
                    numSoLuongBan.Value = Math.Min(1, thuocDangChon.SoLuongTon);
                    numSoLuongBan.Enabled = thuocDangChon.SoLuongTon > 0;
                    btnThemVaoGio.Enabled = thuocDangChon.SoLuongTon > 0;
                }
            }
        }

        private void BtnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null) return;

            int soLuong = (int)numSoLuongBan.Value;
            if (soLuong <= 0) return;

            // Kiểm tra đã có trong giỏ chưa
            var existing = gioHang.Find(delegate(ChiTietBanThuoc x) { return x.MaThuoc == thuocDangChon.MaThuoc; });
            if (existing != null)
            {
                if (existing.SoLuong + soLuong > thuocDangChon.SoLuongTon)
                {
                    MessageBox.Show("Vượt quá tồn kho! Tối đa có thể thêm: " + (thuocDangChon.SoLuongTon - existing.SoLuong), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existing.SoLuong += soLuong;
            }
            else
            {
                gioHang.Add(new ChiTietBanThuoc(thuocDangChon, soLuong));
            }

            CapNhatGioHang();
        }

        private void CapNhatGioHang()
        {
            var displayList = new List<object>();
            foreach (var x in gioHang)
            {
                displayList.Add(new
                {
                    x.TenThuoc,
                    x.DonViTinh,
                    x.SoLuong,
                    DonGia = x.DonGia.ToString("N0"),
                    ThanhTien = x.ThanhTien.ToString("N0")
                });
            }

            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = displayList;

            if (dgvGioHang.Columns["DonGia"] != null) dgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
            if (dgvGioHang.Columns["ThanhTien"] != null) dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";

            decimal tongTien = 0;
            foreach (var item in gioHang) tongTien += item.ThanhTien;

            int diemCong = (int)Math.Floor(tongTien / 1000);

            lblTongTien.Text = string.Format("Tổng tiền: {0:N0} VNĐ", tongTien);
            lblDiemCong.Text = string.Format("Điểm cộng: +{0:N0} điểm (1000 VNĐ = 1 điểm)", diemCong);
            lblDiemSau.Text = string.Format("Điểm sau giao dịch: {0:N0} điểm", khachHang.DiemTichLuy + diemCong);

            btnThanhToan.Enabled = gioHang.Count > 0;
        }

        private void DgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gioHang.Count)
            {
                var item = gioHang[e.RowIndex];
                using (var frm = new FormSuaSoLuongGioHang(item))
                {
                    int tonKho = qlKH.LayThuocTheoMa(item.MaThuoc).SoLuongTon + item.SoLuong;
                    frm.SetSoLuongTon(tonKho);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (frm.SoLuongMoi == 0)
                        {
                            gioHang.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            item.SoLuong = frm.SoLuongMoi;
                        }
                        CapNhatGioHang();
                    }
                }
            }
        }

        private void BtnXoaGio_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0) return;
            gioHang.Clear();
            CapNhatGioHang();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0) return;

            decimal tongTien = 0;
            foreach (var item in gioHang) tongTien += item.ThanhTien;
            int diemCong = (int)Math.Floor(tongTien / 1000);

            var result = MessageBox.Show(
                string.Format("Xác nhận thanh toán?\n\nTổng tiền: {0:N0} VNĐ\nĐiểm cộng: +{1:N0}\nĐiểm khách sau GD: {2:N0}",
                tongTien, diemCong, khachHang.DiemTichLuy + diemCong),
                "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string loi;
                int diemThucTe;
                decimal tienThucTe;
                if (qlKH.BanThuoc(khachHang.MaKH, new List<ChiTietBanThuoc>(gioHang), out loi, out diemThucTe, out tienThucTe))
                {
                    MessageBox.Show(
                        string.Format("Thanh toán thành công!\n\nTổng tiền: {0:N0} VNĐ\nĐiểm cộng: +{1:N0}\nĐiểm hiện tại: {2:N0}",
                        tienThucTe, diemThucTe, khachHang.DiemTichLuy + diemThucTe),
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}