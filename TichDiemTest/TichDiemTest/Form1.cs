using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class Form1 : Form
    {
        private QuanLyKhachHang qlKH;
        private KhachHang khachHangBanDangChon;
        private Thuoc thuocDangChon;
        private List<ChiTietBanThuoc> gioHang = new List<ChiTietBanThuoc>();

        private KhachHang khachHangQuaDangChon;
        private Qua quaDangChon;

        public Form1()
        {
            InitializeComponent();
            qlKH = new QuanLyKhachHang();
            SetupEvents();
            LoadAllData();
        }

        private void SetupEvents()
        {
            qlKH.DuLieuDaThayDoi += delegate
            {
                if (InvokeRequired) Invoke(new Action(LoadAllData));
                else LoadAllData();
            };
            qlKH.DanhSachThuocDaThayDoi += delegate
            {
                if (InvokeRequired) Invoke(new Action(LoadThuocData));
                else LoadThuocData();
            };
            qlKH.DanhSachQuaDaThayDoi += delegate
            {
                if (InvokeRequired) Invoke(new Action(LoadQuaData));
                else LoadQuaData();
            };

            KeyDown += Form1_KeyDown;
            KeyPreview = true;

            // Context menu cho danh sách khách hàng tab bán thuốc
            cmsKhachHang.Items.Clear();
            cmsKhachHang.Items.Add("✏️ Sửa khách hàng", null, delegate { SuaKhachHang(); });
            cmsKhachHang.Items.Add("📜 Xem lịch sử giao dịch", null, delegate { XemLichSuKhachHang(); });
            cmsKhachHang.Items.Add("⭐ Cộng/Trừ điểm trực tiếp", null, delegate { XuLyDiemThuCong(); });
            cmsKhachHang.Items.Add(new ToolStripSeparator());
            cmsKhachHang.Items.Add("🗑️ Xóa khách hàng", null, delegate { XoaKhachHang(); });

            dgvKHBan.CellMouseDown += DgvKHBan_CellMouseDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) ThemKhachHang();
            else if (e.Control && e.KeyCode == Keys.R) LoadAllData();
            else if (e.KeyCode == Keys.F5) tabControl.SelectedTab = tabThongKe;
            else if (e.KeyCode == Keys.Escape) Close();
        }

        private void LoadAllData()
        {
            LoadKhachHangBanData();
            LoadThuocData();
            LoadKhachHangQuaData();
            LoadQuaData();
            LoadThongKeData();
        }

        #region TAB 1: BÁN THUỐC & KHÁCH HÀNG
        private void LoadKhachHangBanData()
        {
            string tuKhoa = txtTimKiemKHBan.Text != null ? txtTimKiemKHBan.Text.Trim() : "";
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSach() : qlKH.TimKiem(tuKhoa);

            var displayList = new List<object>();
            foreach (var kh in ds)
            {
                displayList.Add(new
                {
                    kh.MaKH,
                    kh.HoTen,
                    kh.SoDienThoai,
                    kh.DiemTichLuy
                });
            }

            dgvKHBan.DataSource = null;
            dgvKHBan.DataSource = displayList;

            if (dgvKHBan.Columns["MaKH"] != null) dgvKHBan.Columns["MaKH"].Visible = false;
            if (dgvKHBan.Columns["HoTen"] != null) dgvKHBan.Columns["HoTen"].HeaderText = "Họ tên KH";
            if (dgvKHBan.Columns["SoDienThoai"] != null) dgvKHBan.Columns["SoDienThoai"].HeaderText = "SĐT";
            if (dgvKHBan.Columns["DiemTichLuy"] != null)
            {
                dgvKHBan.Columns["DiemTichLuy"].HeaderText = "Điểm";
                dgvKHBan.Columns["DiemTichLuy"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            lblCountKHBan.Text = ds.Count + " khách";
        }

        private void TxtTimKiemKHBan_TextChanged(object sender, EventArgs e)
        {
            LoadKhachHangBanData();
        }

        private void DgvKHBan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvKHBan.ClearSelection();
                dgvKHBan.Rows[e.RowIndex].Selected = true;
                dgvKHBan.CurrentCell = dgvKHBan.Rows[e.RowIndex].Cells[1];
            }
        }

        private void DgvKHBan_DoubleClick(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void DgvKHBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKHBan.CurrentRow != null && dgvKHBan.CurrentRow.DataBoundItem != null)
            {
                var item = dgvKHBan.CurrentRow.DataBoundItem;
                int maKH = (int)item.GetType().GetProperty("MaKH").GetValue(item);
                khachHangBanDangChon = qlKH.LayTheoMa(maKH);
                CapNhatThongTinKHBan();
            }
            else
            {
                khachHangBanDangChon = null;
                CapNhatThongTinKHBan();
            }
        }

        private void CapNhatThongTinKHBan()
        {
            if (khachHangBanDangChon != null)
            {
                lblKHBanInfo.Text = string.Format("👤 Khách: {0}  |  📞 {1}  |  ⭐ Điểm: {2:N0}",
                    khachHangBanDangChon.HoTen, khachHangBanDangChon.SoDienThoai, khachHangBanDangChon.DiemTichLuy);
            }
            else
            {
                lblKHBanInfo.Text = "👉 Vui lòng chọn hoặc thêm khách hàng bên trái";
            }
            CapNhatGioHang();
        }

        private void LoadThuocData()
        {
            string tuKhoa = txtTimKiemThuocBan.Text != null ? txtTimKiemThuocBan.Text.Trim() : "";
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSachThuoc() : qlKH.TimKiemThuoc(tuKhoa);

            var filtered = new List<Thuoc>();
            foreach (var t in ds) if (t.SoLuongTon > 0) filtered.Add(t);

            var displayList = new List<object>();
            foreach (var t in filtered)
            {
                displayList.Add(new
                {
                    t.MaThuoc,
                    t.TenThuoc,
                    t.DonViTinh,
                    DonGia = t.DonGia.ToString("N0"),
                    t.SoLuongTon
                });
            }

            dgvThuocBan.DataSource = null;
            dgvThuocBan.DataSource = displayList;

            if (dgvThuocBan.Columns["MaThuoc"] != null) dgvThuocBan.Columns["MaThuoc"].Visible = false;
            if (dgvThuocBan.Columns["TenThuoc"] != null) dgvThuocBan.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            if (dgvThuocBan.Columns["DonViTinh"] != null) dgvThuocBan.Columns["DonViTinh"].HeaderText = "ĐVT";
            if (dgvThuocBan.Columns["DonGia"] != null)
            {
                dgvThuocBan.Columns["DonGia"].HeaderText = "Đơn giá (VNĐ)";
                dgvThuocBan.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvThuocBan.Columns["SoLuongTon"] != null)
            {
                dgvThuocBan.Columns["SoLuongTon"].HeaderText = "Tồn";
                dgvThuocBan.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            lblCountThuocBan.Text = filtered.Count + " thuốc";
        }

        private void TxtTimKiemThuocBan_TextChanged(object sender, EventArgs e)
        {
            LoadThuocData();
        }

        private void DgvThuocBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuocBan.CurrentRow != null && dgvThuocBan.CurrentRow.DataBoundItem != null)
            {
                var item = dgvThuocBan.CurrentRow.DataBoundItem;
                int maThuoc = (int)item.GetType().GetProperty("MaThuoc").GetValue(item);
                thuocDangChon = qlKH.LayThuocTheoMa(maThuoc);

                if (thuocDangChon != null)
                {
                    lblThuocBanInfo.Text = string.Format("{0} - {1:N0} đ/{2} (Tồn: {3})",
                        thuocDangChon.TenThuoc, thuocDangChon.DonGia, thuocDangChon.DonViTinh, thuocDangChon.SoLuongTon);
                    numSoLuongBan.Maximum = thuocDangChon.SoLuongTon;
                    numSoLuongBan.Value = Math.Min(1, thuocDangChon.SoLuongTon);
                    numSoLuongBan.Enabled = thuocDangChon.SoLuongTon > 0;
                    btnThemVaoGio.Enabled = thuocDangChon.SoLuongTon > 0;
                }
            }
            else
            {
                thuocDangChon = null;
                lblThuocBanInfo.Text = "Chọn thuốc để bán";
                btnThemVaoGio.Enabled = false;
            }
        }

        private void BtnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null) return;

            int soLuong = (int)numSoLuongBan.Value;
            if (soLuong <= 0) return;

            var existing = gioHang.Find(x => x.MaThuoc == thuocDangChon.MaThuoc);
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
                    x.MaThuoc,
                    x.TenThuoc,
                    x.DonViTinh,
                    x.SoLuong,
                    DonGia = x.DonGia.ToString("N0"),
                    ThanhTien = x.ThanhTien.ToString("N0")
                });
            }

            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = displayList;

            if (dgvGioHang.Columns["MaThuoc"] != null) dgvGioHang.Columns["MaThuoc"].Visible = false;
            if (dgvGioHang.Columns["TenThuoc"] != null) dgvGioHang.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            if (dgvGioHang.Columns["DonViTinh"] != null) dgvGioHang.Columns["DonViTinh"].HeaderText = "ĐVT";
            if (dgvGioHang.Columns["SoLuong"] != null)
            {
                dgvGioHang.Columns["SoLuong"].HeaderText = "SL";
                dgvGioHang.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvGioHang.Columns["DonGia"] != null)
            {
                dgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvGioHang.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvGioHang.Columns["ThanhTien"] != null)
            {
                dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            decimal tongTien = 0;
            foreach (var item in gioHang) tongTien += item.ThanhTien;
            int diemCong = (int)Math.Floor(tongTien / 1000);

            lblTongTienBan.Text = string.Format("Tổng: {0:N0} VNĐ", tongTien);
            lblDiemCongBan.Text = string.Format("Điểm cộng: +{0:N0}", diemCong);
            lblDiemSauBan.Text = khachHangBanDangChon != null ? string.Format("Điểm sau GD: {0:N0}", khachHangBanDangChon.DiemTichLuy + diemCong) : "Chưa chọn khách";

            btnThanhToanBan.Enabled = gioHang.Count > 0 && khachHangBanDangChon != null;
        }

        private void DgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gioHang.Count)
            {
                var item = gioHang[e.RowIndex];
                using (var frm = new FormSuaSoLuongGioHang(item))
                {
                    var thuocGoc = qlKH.LayThuocTheoMa(item.MaThuoc);
                    int tonKho = (thuocGoc != null ? thuocGoc.SoLuongTon : 0) + item.SoLuong;
                    frm.SetSoLuongTon(tonKho);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (frm.SoLuongMoi == 0) gioHang.RemoveAt(e.RowIndex);
                        else item.SoLuong = frm.SoLuongMoi;
                        CapNhatGioHang();
                    }
                }
            }
        }

        private void BtnXoaGio_Click(object sender, EventArgs e)
        {
            gioHang.Clear();
            CapNhatGioHang();
        }

        private void BtnThanhToanBan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0 || khachHangBanDangChon == null) return;

            decimal tongTien = 0;
            foreach (var item in gioHang) tongTien += item.ThanhTien;
            int diemCong = (int)Math.Floor(tongTien / 1000);

            var result = MessageBox.Show(
                string.Format("Xác nhận thanh toán đơn hàng?\n\n- Khách hàng: {0}\n- Tổng tiền: {1:N0} VNĐ\n- Điểm cộng: +{2:N0}\n- Điểm mới: {3:N0}",
                khachHangBanDangChon.HoTen, tongTien, diemCong, khachHangBanDangChon.DiemTichLuy + diemCong),
                "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string loi;
                int diemThucTe;
                decimal tienThucTe;
                if (qlKH.BanThuoc(khachHangBanDangChon.MaKH, new List<ChiTietBanThuoc>(gioHang), out loi, out diemThucTe, out tienThucTe))
                {
                    MessageBox.Show(string.Format("Thanh toán thành công!\nTổng tiền: {0:N0} VNĐ\nĐã cộng: +{1:N0} điểm", tienThucTe, diemThucTe),
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gioHang.Clear();
                    CapNhatGioHang();
                    lblStatus.Text = "Đã bán thuốc cho: " + khachHangBanDangChon.HoTen;
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemKhachHang()
        {
            using (var frm = new FormKhachHang(qlKH))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    lblStatus.Text = "Đã thêm khách: " + frm.KetQua.HoTen;
                    LoadKhachHangBanData();
                    LoadKhachHangQuaData();
                }
            }
        }

        private void SuaKhachHang()
        {
            if (khachHangBanDangChon == null) { MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var frm = new FormKhachHang(qlKH, khachHangBanDangChon))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    lblStatus.Text = "Đã cập nhật: " + frm.KetQua.HoTen;
                    LoadKhachHangBanData();
                    LoadKhachHangQuaData();
                }
            }
        }

        private void XoaKhachHang()
        {
            if (khachHangBanDangChon == null) { MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var result = MessageBox.Show("Xóa khách hàng: " + khachHangBanDangChon.HoTen + " (" + khachHangBanDangChon.SoDienThoai + ") cùng toàn bộ lịch sử?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.Xoa(khachHangBanDangChon.MaKH, out loi))
                {
                    lblStatus.Text = "Đã xóa: " + khachHangBanDangChon.HoTen;
                    khachHangBanDangChon = null;
                    LoadKhachHangBanData();
                    LoadKhachHangQuaData();
                }
                else MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XemLichSuKhachHang()
        {
            if (khachHangBanDangChon == null) { MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var frm = new FormLichSu(qlKH, khachHangBanDangChon)) frm.ShowDialog(this);
        }

        private void XuLyDiemThuCong()
        {
            if (khachHangBanDangChon == null) { MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using (var frm = new FormDiem(qlKH, khachHangBanDangChon, true))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    lblStatus.Text = "Đã cập nhật điểm cho: " + khachHangBanDangChon.HoTen;
                }
            }
        }
        #endregion

        #region TAB 2: ĐỔI QUÀ TẶNG
        private void LoadKhachHangQuaData()
        {
            string tuKhoa = txtTimKiemKHQua.Text != null ? txtTimKiemKHQua.Text.Trim() : "";
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSach() : qlKH.TimKiem(tuKhoa);

            var displayList = new List<object>();
            foreach (var kh in ds)
            {
                displayList.Add(new
                {
                    kh.MaKH,
                    kh.HoTen,
                    kh.SoDienThoai,
                    kh.DiemTichLuy
                });
            }

            dgvKHQua.DataSource = null;
            dgvKHQua.DataSource = displayList;

            if (dgvKHQua.Columns["MaKH"] != null) dgvKHQua.Columns["MaKH"].Visible = false;
            if (dgvKHQua.Columns["HoTen"] != null) dgvKHQua.Columns["HoTen"].HeaderText = "Khách hàng";
            if (dgvKHQua.Columns["SoDienThoai"] != null) dgvKHQua.Columns["SoDienThoai"].HeaderText = "SĐT";
            if (dgvKHQua.Columns["DiemTichLuy"] != null)
            {
                dgvKHQua.Columns["DiemTichLuy"].HeaderText = "Điểm";
                dgvKHQua.Columns["DiemTichLuy"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void TxtTimKiemKHQua_TextChanged(object sender, EventArgs e)
        {
            LoadKhachHangQuaData();
        }

        private void DgvKHQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKHQua.CurrentRow != null && dgvKHQua.CurrentRow.DataBoundItem != null)
            {
                var item = dgvKHQua.CurrentRow.DataBoundItem;
                int maKH = (int)item.GetType().GetProperty("MaKH").GetValue(item);
                khachHangQuaDangChon = qlKH.LayTheoMa(maKH);
                CapNhatThongTinKHQua();
            }
            else
            {
                khachHangQuaDangChon = null;
                CapNhatThongTinKHQua();
            }
        }

        private void CapNhatThongTinKHQua()
        {
            if (khachHangQuaDangChon != null)
            {
                lblKHQuaInfo.Text = string.Format("👤 {0}  |  📞 {1}  |  ⭐ Điểm hiện tại: {2:N0}",
                    khachHangQuaDangChon.HoTen, khachHangQuaDangChon.SoDienThoai, khachHangQuaDangChon.DiemTichLuy);
            }
            else
            {
                lblKHQuaInfo.Text = "👈 Vui lòng chọn khách hàng cần đổi quà";
            }
        }

        private void LoadQuaData()
        {
            var ds = qlKH.LayDanhSachQuaSanSang();

            var displayList = new List<object>();
            foreach (var q in ds)
            {
                displayList.Add(new
                {
                    q.MaQua,
                    q.TenQua,
                    q.DiemCan,
                    q.SoLuongTon,
                    q.DonViTinh
                });
            }

            dgvQuaDoi.DataSource = null;
            dgvQuaDoi.DataSource = displayList;

            if (dgvQuaDoi.Columns["MaQua"] != null) dgvQuaDoi.Columns["MaQua"].Visible = false;
            if (dgvQuaDoi.Columns["TenQua"] != null) dgvQuaDoi.Columns["TenQua"].HeaderText = "Tên quà tặng";
            if (dgvQuaDoi.Columns["DiemCan"] != null)
            {
                dgvQuaDoi.Columns["DiemCan"].HeaderText = "Điểm cần";
                dgvQuaDoi.Columns["DiemCan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvQuaDoi.Columns["SoLuongTon"] != null)
            {
                dgvQuaDoi.Columns["SoLuongTon"].HeaderText = "Tồn";
                dgvQuaDoi.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvQuaDoi.Columns["DonViTinh"] != null) dgvQuaDoi.Columns["DonViTinh"].HeaderText = "ĐVT";

            lblCountQuaDoi.Text = ds.Count + " quà có sẵn";
        }

        private void DgvQuaDoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuaDoi.CurrentRow != null && dgvQuaDoi.CurrentRow.DataBoundItem != null)
            {
                var item = dgvQuaDoi.CurrentRow.DataBoundItem;
                int maQua = (int)item.GetType().GetProperty("MaQua").GetValue(item);
                quaDangChon = qlKH.LayQuaTheoMa(maQua);

                if (quaDangChon != null)
                {
                    lblQuaDoiInfo.Text = string.Format("🎁 {0}  |  Điểm cần: {1:N0}/{2}  |  Tồn: {3} {2}",
                        quaDangChon.TenQua, quaDangChon.DiemCan, quaDangChon.DonViTinh, quaDangChon.SoLuongTon);
                    numSoLuongQua.Maximum = quaDangChon.SoLuongTon;
                    numSoLuongQua.Value = Math.Min(1, quaDangChon.SoLuongTon);
                    numSoLuongQua.Enabled = quaDangChon.SoLuongTon > 0;
                    btnDoiQuaXacNhan.Enabled = quaDangChon.SoLuongTon > 0;
                }
            }
            else
            {
                quaDangChon = null;
                lblQuaDoiInfo.Text = "Chọn quà tặng từ danh sách";
                btnDoiQuaXacNhan.Enabled = false;
            }
        }

        private void BtnDoiQuaXacNhan_Click(object sender, EventArgs e)
        {
            if (quaDangChon == null || khachHangQuaDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn cả Khách hàng và Quà tặng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuong = (int)numSoLuongQua.Value;
            if (soLuong <= 0) return;

            int tongDiemCan = quaDangChon.DiemCan * soLuong;

            if (khachHangQuaDangChon.DiemTichLuy < tongDiemCan)
            {
                MessageBox.Show(string.Format("Khách không đủ điểm! Cần {0:N0} điểm nhưng chỉ có {1:N0} điểm.", tongDiemCan, khachHangQuaDangChon.DiemTichLuy),
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show(
                string.Format("Xác nhận đổi quà tặng?\n\n- Khách: {0}\n- Quà: {1} (x{2})\n- Điểm còn lại: 0",
                khachHangQuaDangChon.HoTen, quaDangChon.TenQua, soLuong),
                "Xác nhận đổi quà", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.DoiQuaTuKho(khachHangQuaDangChon.MaKH, quaDangChon.MaQua, soLuong, out loi))
                {
                    MessageBox.Show("Đổi quà thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "Đã đổi quà cho: " + khachHangQuaDangChon.HoTen;
                    LoadQuaData();
                    LoadKhachHangQuaData();
                    LoadKhachHangBanData();
                }
                else MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TAB 3: THỐNG KÊ
        private void LoadThongKeData()
        {
            var tk = qlKH.LayThongKeDonGian();

            lblTongKH.Text = tk.TongKhachHang.ToString("N0");
            lblTongDiem.Text = tk.TongDiemTichLuy.ToString("N0");
            lblDoanhThuHomNay.Text = tk.DoanhThuHomNay.ToString("N0") + " VNĐ";
            lblSoDonHomNay.Text = tk.SoDonHomNay.ToString("N0") + " đơn";
            lblDoanhThuThangNay.Text = tk.DoanhThuThangNay.ToString("N0") + " VNĐ";
            lblSoDonThangNay.Text = tk.SoDonThangNay.ToString("N0") + " đơn";
            lblThuocSapHet.Text = tk.ThuocSapHetHang.ToString();
            lblQuaSapHet.Text = tk.QuaSapHetHang.ToString();

            lblThuocSapHet.ForeColor = tk.ThuocSapHetHang > 0 ? Color.Red : Color.ForestGreen;
            lblQuaSapHet.ForeColor = tk.QuaSapHetHang > 0 ? Color.Red : Color.ForestGreen;
        }

        private void BtnXemBaoCaoChiTiet_Click(object sender, EventArgs e)
        {
            using (var frm = new FormThongKe(qlKH)) frm.ShowDialog(this);
        }
        #endregion

        private void btnThemKHQuick_Click(object sender, EventArgs e) { ThemKhachHang(); }
        private void btnSuaKHQuick_Click(object sender, EventArgs e) { SuaKhachHang(); }
        private void btnXoaKHQuick_Click(object sender, EventArgs e) { XoaKhachHang(); }
        private void btnLichSuQuick_Click(object sender, EventArgs e) { XemLichSuKhachHang(); }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            using (var frm = new FormThuoc(qlKH)) frm.ShowDialog(this);
        }

        private void btnQuanLyQua_Click(object sender, EventArgs e)
        {
            using (var frm = new FormQua(qlKH)) frm.ShowDialog(this);
        }

        private void btnLamMoiAll_Click(object sender, EventArgs e)
        {
            LoadAllData();
            lblStatus.Text = "Đã làm mới dữ liệu toàn hệ thống";
        }
    }
}