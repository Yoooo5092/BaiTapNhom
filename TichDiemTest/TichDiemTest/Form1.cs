using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class Form1 : Form
    {
        private QuanLyKhachHang qlKH = new QuanLyKhachHang();
        private string fileTestPath = "test.txt";
        private int soLuong = 0;

        public Form1()
        {
            string loi = "";
            InitializeComponent();
            SetupEvents();
            qlKH.NhapTuFile(fileTestPath, out loi, out soLuong);
        }

        private void SetupEvents()
        {
            qlKH.DuLieuDaThayDoi += () => CapNhatDanhSach();
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;

            cmsGrid.Items.Clear();
            cmsGrid.Items.Add("Cập nhật", null, (s, e) => SuaKhachHang());
            cmsGrid.Items.Add("Cộng điểm", null, (s, e) => XuLyDiem(true));
            cmsGrid.Items.Add("Đổi quà", null, (s, e) => XuLyDiem(false));
            cmsGrid.Items.Add("Xem lịch sử", null, (s, e) => XemLichSu()); // Dòng mới chèn thêm
            cmsGrid.Items.Add(new ToolStripSeparator());
            cmsGrid.Items.Add("Xóa", null, (s, e) => XoaKhachHang());

            // 2. Gắn sự kiện click chuột phải để bôi xanh dòng
            dgvKhachHang.CellMouseDown += DgvKhachHang_CellMouseDown;
        }

        private void DgvKhachHang_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra nếu là click chuột phải và click vào vùng có dữ liệu
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvKhachHang.ClearSelection();
                dgvKhachHang.Rows[e.RowIndex].Selected = true;
                dgvKhachHang.CurrentCell = dgvKhachHang.Rows[e.RowIndex].Cells[0];
            }
        }

        private void CapNhatDanhSach()
        {
            string tuKhoa = txtTimKiem?.Text?.Trim() ?? "";
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSach() : qlKH.TimKiem(tuKhoa);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = ds;

            // Format lại columns sau khi bind
            if (dgvKhachHang.Columns["DiemTichLuy"] != null)
                dgvKhachHang.Columns["DiemTichLuy"].DefaultCellStyle.Format = "N0";
            if (dgvKhachHang.Columns["NgayDangKy"] != null)
                dgvKhachHang.Columns["NgayDangKy"].DefaultCellStyle.Format = "dd/MM/yyyy";

            lblCount.Text = $"{ds.Count} khách hàng";
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) ThemKhachHang();
            else if (e.Control && e.KeyCode == Keys.I) NhapTuFile();
            else if (e.Control && e.KeyCode == Keys.E) XuatRaFile();
            else if (e.KeyCode == Keys.F5) MoThongKe();
            else if (e.KeyCode == Keys.Escape) Close();
        }

        private void ThemKhachHang()
        {
            using (var frm = new FormKhachHang(qlKH))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    HienThiStatus($"Đã thêm: {frm.KetQua.HoTen}");
                }
            }
        }

        private void SuaKhachHang()
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            using (var frm = new FormKhachHang(qlKH, kh))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    HienThiStatus($"Đã cập nhật: {frm.KetQua.HoTen}");
                }
            }
        }

        private void XoaKhachHang()
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            var result = MessageBox.Show(
                $"Xóa khách hàng: {kh.HoTen} ({kh.SoDienThoai})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.Xoa(kh.MaKH, out loi))
                {
                    HienThiStatus($"Đã xóa: {kh.HoTen}");
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XuLyDiem(bool laCongDiem)
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            using (var frm = new FormDiem(qlKH, kh, laCongDiem))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    string action = laCongDiem ? "cộng" : "trừ";
                    HienThiStatus($"Đã {action} điểm cho: {kh.HoTen}");
                }
            }
        }

        private KhachHang LayKhachHangDangChon()
        {
            if (dgvKhachHang.CurrentRow?.DataBoundItem is KhachHang kh)
                return kh;
            return null;
        }

        private void NhapTuFile()
        {
            string filePath = fileTestPath;
            if (!File.Exists(filePath))
            {
                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Chọn file nhập dữ liệu"
                })
                {
                    if (ofd.ShowDialog() != DialogResult.OK) return;
                    filePath = ofd.FileName;
                }
            }

            string loi;
            int soLuong;
            if (qlKH.NhapTuFile(filePath, out loi, out soLuong))
            {
                HienThiStatus($"Đã nhập {soLuong} khách hàng từ file");
                MessageBox.Show($"Nhập thành công {soLuong} khách hàng từ:\n{filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(loi, "Lỗi nhập file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuatRaFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = "khachhang.txt",
                Title = "Lưu danh sách khách hàng"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                string loi;
                if (qlKH.XuatRaFile(sfd.FileName, out loi))
                {
                    HienThiStatus($"Đã xuất ra file: {sfd.FileName}");
                    MessageBox.Show("Xuất file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XemLichSu()
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            using (var frm = new FormLichSu(qlKH, kh))
            {
                frm.ShowDialog(this);
            }
        }

        private void MoThongKe()
        {
            using (var frm = new FormThongKe(qlKH))
            {
                frm.ShowDialog(this);
            }
        }

        private void HienThiStatus(string msg)
        {
            if (lblStatus != null) lblStatus.Text = msg;
        }

        private void btnThem_Click(object sender, EventArgs e) { ThemKhachHang(); }
        private void btnSua_Click(object sender, EventArgs e) { SuaKhachHang(); }
        private void btnXoa_Click(object sender, EventArgs e) { XoaKhachHang(); }
        private void btnCongDiem_Click(object sender, EventArgs e) { XuLyDiem(true); }
        private void btnDoiQua_Click(object sender, EventArgs e) { XuLyDiem(false); }
        private void btnNhapFile_Click(object sender, EventArgs e) { NhapTuFile(); }
        private void btnXuatFile_Click(object sender, EventArgs e) { XuatRaFile(); }
        private void btnThongKe_Click(object sender, EventArgs e) { MoThongKe(); }
        private void btnClear_Click(object sender, EventArgs e) { txtTimKiem.Clear(); }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) SuaKhachHang();
        }
    }
}