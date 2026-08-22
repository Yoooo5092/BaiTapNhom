using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormQua : Form
    {
        private QuanLyKhachHang qlKH;
        private Qua quaDangChon;
        private bool laThemMoi = true;

        public FormQua(QuanLyKhachHang ql)
        {
            InitializeComponent();
            qlKH = ql;
            LoadDanhSachQua();
            qlKH.DanhSachQuaDaThayDoi += () => LoadDanhSachQua();
            numSoLuongTon.Enabled = false;
        }

        private void LoadDanhSachQua()
        {
            string tuKhoa = "";
            if (txtTimKiemQua.Text != null) tuKhoa = txtTimKiemQua.Text.Trim();
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSachQua() : qlKH.LayDanhSachQua().FindAll(delegate(Qua q)
            {
                return q.TenQua.ToLower().Contains(tuKhoa.ToLower()) ||
                       q.DonViTinh.ToLower().Contains(tuKhoa.ToLower());
            });

            var displayList = new List<object>();
            foreach (var q in ds)
            {
                string trangThai = q.TrangThai ? (q.SoLuongTon == 0 ? "Hết hàng" : (q.SoLuongTon <= 5 ? "Sắp hết" : "Còn hàng")) : "Ngừng đổi";
                displayList.Add(new
                {
                    q.MaQua,
                    q.TenQua,
                    q.MoTa,
                    q.DiemCan,
                    q.SoLuongTon,
                    q.DonViTinh,
                    TrangThai = trangThai
                });
            }

            dgvQua.DataSource = null;
            dgvQua.DataSource = displayList;

            FormatGrid();
            lblCountQua.Text = ds.Count + " quà";
        }

        private void FormatGrid()
        {
            if (dgvQua.Columns["MaQua"] != null) dgvQua.Columns["MaQua"].Visible = false;
            if (dgvQua.Columns["MoTa"] != null) dgvQua.Columns["MoTa"].Visible = false;
            if (dgvQua.Columns["DiemCan"] != null)
            {
                dgvQua.Columns["DiemCan"].HeaderText = "Điểm cần";
                dgvQua.Columns["DiemCan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvQua.Columns["SoLuongTon"] != null)
            {
                dgvQua.Columns["SoLuongTon"].HeaderText = "Tồn kho";
                dgvQua.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvQua.Columns["TrangThai"] != null)
            {
                dgvQua.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvQua.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void TxtTimKiemQua_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachQua();
        }

        private void DgvQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQua.CurrentRow != null && dgvQua.CurrentRow.DataBoundItem != null)
            {
                var item = dgvQua.CurrentRow.DataBoundItem;
                int maQua = (int)item.GetType().GetProperty("MaQua").GetValue(item);
                quaDangChon = qlKH.LayQuaTheoMa(maQua);
                HienThiThongTinQua(quaDangChon);
                laThemMoi = false;
                btnLuuQua.Text = "Cập nhật";
            }
        }

        private void HienThiThongTinQua(Qua q)
        {
            if (q == null) return;
            txtTenQua.Text = q.TenQua;
            txtMoTa.Text = q.MoTa;
            numDiemCan.Value = q.DiemCan;
            numSoLuongTon.Value = q.SoLuongTon;
            txtDonViTinh.Text = q.DonViTinh;
            txtHinhAnh.Text = q.HinhAnh;
            chkTrangThai.Checked = q.TrangThai;
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            laThemMoi = true;
            btnLuuQua.Text = "Thêm";
            txtTenQua.Focus();
        }

        private void ClearForm()
        {
            txtTenQua.Clear();
            txtMoTa.Clear();
            numDiemCan.Value = 0;
            numSoLuongTon.Value = 0;
            txtDonViTinh.Text = "Cái";
            txtHinhAnh.Clear();
            chkTrangThai.Checked = true;
            quaDangChon = null;
        }

        private void BtnLuuQua_Click(object sender, EventArgs e)
        {
            string loi;
            var qua = new Qua
            {
                TenQua = txtTenQua.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                DiemCan = (int)numDiemCan.Value,
                SoLuongTon = (int)numSoLuongTon.Value,
                DonViTinh = txtDonViTinh.Text.Trim(),
                HinhAnh = txtHinhAnh.Text.Trim(),
                TrangThai = chkTrangThai.Checked,
                NgayTao = DateTime.Now
            };

            bool ok;

            if (laThemMoi)
            {
                ok = qlKH.ThemQua(qua, out loi);
            }
            else
            {
                // Ensure the ID is explicitly copied before updating
                qua.MaQua = quaDangChon.MaQua;
                ok = qlKH.CapNhatQua(qua, out loi);
            }

            if (ok)
            {
                MessageBox.Show(laThemMoi ? "Đã thêm quà!" : "Đã cập nhật quà!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                laThemMoi = true;
                btnLuuQua.Text = "Thêm";
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXoaQua_Click(object sender, EventArgs e)
        {
            if (quaDangChon == null || laThemMoi)
            {
                MessageBox.Show("Chọn quà để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Xóa quà: " + quaDangChon.TenQua + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.XoaQua(quaDangChon.MaQua, out loi))
                {
                    MessageBox.Show("Đã xóa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    laThemMoi = true;
                    btnLuuQua.Text = "Thêm";
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnNhapKhoQua_Click(object sender, EventArgs e)
        {
            if (quaDangChon == null || laThemMoi)
            {
                MessageBox.Show("Chọn quà để nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new FormNhapKhoQua(qlKH, quaDangChon))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadDanhSachQua();
                }
            }
        }
    }
}