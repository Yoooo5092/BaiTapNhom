using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormLichSu : Form
    {
        private QuanLyKhachHang qlKH;
        private KhachHang khachHang;

        public FormLichSu(QuanLyKhachHang ql, KhachHang kh)
        {
            InitializeComponent();
            qlKH = ql;
            khachHang = kh;

            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;

            lblThongTin.Text = string.Format("Khách hàng: {0} - SĐT: {1} (Điểm: {2:N0})",
                khachHang.HoTen, khachHang.SoDienThoai, khachHang.DiemTichLuy);

            LoadLichSu();
        }

        private void LoadLichSu()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            string loai = cboLoaiGiaoDich.SelectedItem != null ? cboLoaiGiaoDich.SelectedItem.ToString() : "Tất cả";
            string tuKhoa = txtTimKiem.Text != null ? txtTimKiem.Text.Trim().ToLower() : "";

            var lichSu = qlKH.LayLichSuTheoKH(khachHang.MaKH);

            // Lọc theo ngày
            var filtered = new List<LichSuGiaoDich>();
            foreach (var x in lichSu)
            {
                if (x.NgayGio.Date >= tuNgay && x.NgayGio.Date <= denNgay)
                    filtered.Add(x);
            }
            lichSu = filtered;

            // Lọc theo loại giao dịch
            if (loai != "Tất cả")
            {
                filtered = new List<LichSuGiaoDich>();
                foreach (var x in lichSu)
                {
                    if (x.LoaiGiaoDich == loai)
                        filtered.Add(x);
                }
                lichSu = filtered;
            }

            // Lọc theo từ khóa
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                filtered = new List<LichSuGiaoDich>();
                foreach (var x in lichSu)
                {
                    bool match = x.MaGiaoDich.ToLower().Contains(tuKhoa) ||
                                 x.LoaiGiaoDich.ToLower().Contains(tuKhoa) ||
                                 (x.ChiTietThuoc != null && x.ChiTietThuoc.Exists(ct => ct.TenThuoc.ToLower().Contains(tuKhoa)));
                    if (match) filtered.Add(x);
                }
                lichSu = filtered;
            }

            var displayList = new List<LichSuGridModel>();
            foreach (var x in lichSu)
            {
                displayList.Add(new LichSuGridModel
                {
                    MaGiaoDich = x.MaGiaoDich,
                    NgayGio = x.NgayGio.ToString("dd/MM/yyyy HH:mm"),
                    LoaiGiaoDich = x.LoaiGiaoDich,
                    SoDiem = x.SoDiemThayDoi > 0 ? "+" + x.SoDiemThayDoi.ToString("N0") : x.SoDiemThayDoi.ToString("N0"),
                    TongTien = x.TongTien > 0 ? x.TongTien.ToString("N0") + " VNĐ" : "",
                    SoLuongThuoc = x.ChiTietThuoc != null ? x.ChiTietThuoc.Count : 0
                });
            }

            dgvLichSu.DataSource = null;
            dgvLichSu.DataSource = displayList;

            FormatGrid();
            CapNhatTongQuan(lichSu);
        }

        private void FormatGrid()
        {
            if (dgvLichSu.Columns.Count == 0) return;

            if (dgvLichSu.Columns.Contains("MaGiaoDich"))
            {
                dgvLichSu.Columns["MaGiaoDich"].HeaderText = "Mã GD";
                dgvLichSu.Columns["MaGiaoDich"].FillWeight = 80;
            }
            if (dgvLichSu.Columns.Contains("NgayGio"))
            {
                dgvLichSu.Columns["NgayGio"].HeaderText = "Ngày giờ";
                dgvLichSu.Columns["NgayGio"].FillWeight = 120;
            }
            if (dgvLichSu.Columns.Contains("LoaiGiaoDich"))
            {
                dgvLichSu.Columns["LoaiGiaoDich"].HeaderText = "Loại GD";
                dgvLichSu.Columns["LoaiGiaoDich"].FillWeight = 90;
            }
            if (dgvLichSu.Columns.Contains("SoDiem"))
            {
                dgvLichSu.Columns["SoDiem"].HeaderText = "Điểm thay đổi";
                dgvLichSu.Columns["SoDiem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLichSu.Columns["SoDiem"].FillWeight = 90;
            }
            if (dgvLichSu.Columns.Contains("TongTien"))
            {
                dgvLichSu.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvLichSu.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLichSu.Columns["TongTien"].FillWeight = 110;
            }
            if (dgvLichSu.Columns.Contains("SoLuongThuoc"))
            {
                dgvLichSu.Columns["SoLuongThuoc"].HeaderText = "SL thuốc";
                dgvLichSu.Columns["SoLuongThuoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLichSu.Columns["SoLuongThuoc"].FillWeight = 60;
            }
        }

        private void CapNhatTongQuan(List<LichSuGiaoDich> lichSu)
        {
            int tongGiaoDich = lichSu.Count;
            int tongDiemCong = 0;
            int tongDiemTru = 0;
            decimal tongTien = 0;
            int soHoaDonBan = 0;

            foreach (var x in lichSu)
            {
                if (x.SoDiemThayDoi > 0) tongDiemCong += x.SoDiemThayDoi;
                else tongDiemTru += Math.Abs(x.SoDiemThayDoi);
                if (x.LoaiGiaoDich == "Bán thuốc")
                {
                    tongTien += x.TongTien;
                    soHoaDonBan++;
                }
            }

            lblTongQuan.Text = string.Format(
                "Tổng GD: {0} | Điểm cộng: +{1:N0} | Điểm trừ: -{2:N0} | Doanh thu: {3:N0} VNĐ | Số hóa đơn: {4}",
                tongGiaoDich, tongDiemCong, tongDiemTru, tongTien, soHoaDonBan);
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            LoadLichSu();
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow == null || dgvLichSu.CurrentRow.DataBoundItem == null) return;

            var item = dgvLichSu.CurrentRow.DataBoundItem as LichSuGridModel;
            if (item == null) return;

            var ls = qlKH.LayLichSuTheoKH(khachHang.MaKH).Find(x => x.MaGiaoDich == item.MaGiaoDich);
            if (ls == null) return;

            string detail = "Mã GD: " + ls.MaGiaoDich + "\n";
            detail += "Ngày giờ: " + ls.NgayGio.ToString("dd/MM/yyyy HH:mm:ss") + "\n";
            detail += "Loại: " + ls.LoaiGiaoDich + "\n";
            detail += "Điểm thay đổi: " + (ls.SoDiemThayDoi > 0 ? "+" : "") + ls.SoDiemThayDoi.ToString("N0") + "\n";

            if (ls.TongTien > 0)
                detail += "Tổng tiền: " + ls.TongTien.ToString("N0") + " VNĐ\n";

            if (ls.ChiTietThuoc != null && ls.ChiTietThuoc.Count > 0)
            {
                detail += "\n--- CHI TIẾT THUỐC ---\n";
                foreach (var ct in ls.ChiTietThuoc)
                {
                    detail += string.Format("{0} x {1} {2} = {3:N0} VNĐ\n", ct.TenThuoc, ct.SoLuong, ct.DonViTinh, ct.ThanhTien);
                }
            }

            MessageBox.Show(detail, "Chi tiết giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "LichSu_" + khachHang.HoTen.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã GD,Ngày giờ,Loại GD,Điểm thay đổi,Tổng tiền (VNĐ),Số loại thuốc,Chi tiết");
                            var lichSu = qlKH.LayLichSuTheoKH(khachHang.MaKH);
                            foreach (var ls in lichSu)
                            {
                                string chiTiet = "";
                                if (ls.ChiTietThuoc != null)
                                {
                                    var list = new List<string>();
                                    foreach (var ct in ls.ChiTietThuoc)
                                    {
                                        list.Add(ct.TenThuoc + " x" + ct.SoLuong + " " + ct.DonViTinh);
                                    }
                                    chiTiet = string.Join("; ", list);
                                }
                                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",{3},{4},{5},\"{6}\"",
                                    ls.MaGiaoDich,
                                    ls.NgayGio.ToString("yyyy-MM-dd HH:mm:ss"),
                                    ls.LoaiGiaoDich,
                                    ls.SoDiemThayDoi,
                                    ls.TongTien,
                                    ls.ChiTietThuoc != null ? ls.ChiTietThuoc.Count : 0,
                                    chiTiet.Replace("\"", "\"\"")));
                            }
                        }
                        MessageBox.Show("Xuất file thành công!\n" + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DgvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) BtnXemChiTiet_Click(sender, e);
        }

        private void TxtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadLichSu();
        }

        private void CboLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichSu();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadLichSu();
        }
    }

    public class LichSuGridModel
    {
        public string MaGiaoDich { get; set; }
        public string NgayGio { get; set; }
        public string LoaiGiaoDich { get; set; }
        public string SoDiem { get; set; }
        public string TongTien { get; set; }
        public int SoLuongThuoc { get; set; }
    }
}