using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormLichSu : Form
    {
        private DataGridView dgvLichSu;
        private Label lblThongTin;

        public FormLichSu(QuanLyKhachHang ql, KhachHang kh)
        {
            // Thiết lập UI cơ bản
            this.Text = "Lịch sử giao dịch";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            lblThongTin = new Label
            {
                Text = $"Khách hàng: {kh.HoTen} - SĐT: {kh.SoDienThoai} (Hiện có: {kh.DiemTichLuy:N0} điểm)",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            dgvLichSu = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            this.Controls.Add(dgvLichSu);
            this.Controls.Add(lblThongTin);

            // Đổ dữ liệu lịch sử của khách này lên lưới
            var lichSu = ql.LayLichSuTheoKH(kh.MaKH);
            dgvLichSu.DataSource = lichSu;

            if (lichSu.Count > 0)
            {
                dgvLichSu.Columns["MaGiaoDich"].HeaderText = "Mã GD";
                dgvLichSu.Columns["MaKH"].Visible = false; // Ẩn cột mã KH đi cho đẹp
                dgvLichSu.Columns["NgayGio"].HeaderText = "Ngày giờ";
                dgvLichSu.Columns["NgayGio"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvLichSu.Columns["LoaiGiaoDich"].HeaderText = "Loại giao dịch";
                dgvLichSu.Columns["SoDiemThayDoi"].HeaderText = "Điểm thay đổi";
            }
        }
    }
}