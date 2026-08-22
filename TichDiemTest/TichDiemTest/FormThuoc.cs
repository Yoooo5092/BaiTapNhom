using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormThuoc : Form
    {
        private QuanLyKhachHang qlKH;
        private Thuoc thuocDangChon;
        private bool laThemMoi = true;

        public FormThuoc(QuanLyKhachHang ql)
        {
            InitializeComponent();
            qlKH = ql;
            LoadDanhSachThuoc();
            qlKH.DanhSachThuocDaThayDoi += delegate { LoadDanhSachThuoc(); };
            numSoLuongTon.Enabled = false;
        }

        private void LoadDanhSachThuoc()
        {
            string tuKhoa = "";
            if (txtTimKiemThuoc.Text != null) tuKhoa = txtTimKiemThuoc.Text.Trim();
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSachThuoc() : qlKH.TimKiemThuoc(tuKhoa);

            var displayList = new List<object>();
            foreach (var t in ds)
            {
                string trangThai = t.SoLuongTon == 0 ? "Hết hàng" : (t.HanSuDung <= DateTime.Now.AddDays(30) ? "Sắp hết hạn" : "Còn hàng");
                displayList.Add(new
                {
                    t.MaThuoc,
                    t.TenThuoc,
                    t.DonViTinh,
                    DonGia = t.DonGia.ToString("N0"),
                    t.SoLuongTon,
                    t.NhaSanXuat,
                    HanSuDung = t.HanSuDung.ToString("dd/MM/yyyy"),
                    TrangThai = trangThai
                });
            }

            dgvThuoc.DataSource = null;
            dgvThuoc.DataSource = displayList;

            FormatGrid();
            lblCountThuoc.Text = ds.Count + " thuốc";
        }

        private void FormatGrid()
        {
            if (dgvThuoc.Columns["MaThuoc"] != null) dgvThuoc.Columns["MaThuoc"].Visible = false;
            if (dgvThuoc.Columns["DonGia"] != null)
            {
                dgvThuoc.Columns["DonGia"].HeaderText = "Đơn giá (VNĐ)";
                dgvThuoc.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvThuoc.Columns["SoLuongTon"] != null)
            {
                dgvThuoc.Columns["SoLuongTon"].HeaderText = "Tồn kho";
                dgvThuoc.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvThuoc.Columns["HanSuDung"] != null) dgvThuoc.Columns["HanSuDung"].HeaderText = "Hạn SD";
            if (dgvThuoc.Columns["TrangThai"] != null)
            {
                dgvThuoc.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvThuoc.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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
                thuocDangChon = qlKH.LayThuocTheoMa(maThuoc);
                HienThiThongTinThuoc(thuocDangChon);
                laThemMoi = false;
                btnLuuThuoc.Text = "Cập nhật";
            }
        }

        private void HienThiThongTinThuoc(Thuoc t)
        {
            if (t == null) return;
            txtTenThuoc.Text = t.TenThuoc;
            txtDonViTinh.Text = t.DonViTinh;
            numDonGia.Value = t.DonGia;
            numSoLuongTon.Value = t.SoLuongTon;
            txtNhaSanXuat.Text = t.NhaSanXuat;
            dtpHanSuDung.Value = t.HanSuDung;
            txtMoTa.Text = t.MoTa;
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            laThemMoi = true;
            btnLuuThuoc.Text = "Thêm";
            txtTenThuoc.Focus();
        }

        private void ClearForm()
        {
            txtTenThuoc.Clear();
            txtDonViTinh.Text = "Viên";
            numDonGia.Value = 0;
            numSoLuongTon.Value = 0;
            txtNhaSanXuat.Clear();
            dtpHanSuDung.Value = DateTime.Now.AddYears(2);
            txtMoTa.Clear();
            thuocDangChon = null;
        }

        private void BtnLuuThuoc_Click(object sender, EventArgs e)
        {
            string loi;
            var thuoc = new Thuoc
            {
                TenThuoc = txtTenThuoc.Text.Trim(),
                DonViTinh = txtDonViTinh.Text.Trim(),
                DonGia = numDonGia.Value,
                SoLuongTon = (int)numSoLuongTon.Value,
                NhaSanXuat = txtNhaSanXuat.Text.Trim(),
                HanSuDung = dtpHanSuDung.Value,
                MoTa = txtMoTa.Text.Trim(),
                MaThuoc = thuocDangChon.MaThuoc
            };

            bool ok = laThemMoi
                ? qlKH.ThemThuoc(thuoc, out loi)
                : qlKH.CapNhatThuoc(thuoc, out loi);

            if (ok)
            {
                MessageBox.Show(laThemMoi ? "Đã thêm thuốc!" : "Đã cập nhật thuốc!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                laThemMoi = true;
                btnLuuThuoc.Text = "Thêm";
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null || laThemMoi)
            {
                MessageBox.Show("Chọn thuốc để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Xóa thuốc: " + thuocDangChon.TenThuoc + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.XoaThuoc(thuocDangChon.MaThuoc, out loi))
                {
                    MessageBox.Show("Đã xóa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    laThemMoi = true;
                    btnLuuThuoc.Text = "Thêm";
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnNhapKho_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null || laThemMoi)
            {
                MessageBox.Show("Chọn thuốc để nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new FormNhapKho(qlKH, thuocDangChon))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadDanhSachThuoc();
                }
            }
        }

        private void BtnXuatFileThuoc_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt",
                FileName = "danh_sach_thuoc_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã,Tên thuốc,Đơn vị,Đơn giá,Tồn kho,Nhà SX,Hạn sử dụng,Mô tả");
                            var ds = qlKH.LayDanhSachThuoc();
                            foreach (var t in ds)
                            {
                                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",{3},{4},\"{5}\",{6},\"{7}\"",
                                    t.MaThuoc, t.TenThuoc, t.DonViTinh, t.DonGia, t.SoLuongTon, t.NhaSanXuat, t.HanSuDung.ToString("yyyy-MM-dd"), t.MoTa));
                            }
                        }
                        MessageBox.Show("Xuất file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}