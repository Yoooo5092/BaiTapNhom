using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;

namespace TichDiemTest
{
    public partial class FormThongKe : Form
    {
        private QuanLyKhachHang qlKH;

        public FormThongKe(QuanLyKhachHang ql)
        {
            InitializeComponent();
            qlKH = ql;
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            var ds = qlKH.LayDanhSach();
            var tk = qlKH.ThongKe();
            var capBac = qlKH.ThongKeTheoCapBac();

            lblTongQuan.Text = $"Tổng khách hàng: {tk.tongKH:N0}   |   Tổng điểm: {tk.tongDiem:N0}   |   Điểm cao nhất: {tk.caoNhat:N0}   |   Điểm thấp nhất: {tk.thapNhat:N0}";

            var series = chartCapBac.Series["CapBac"];
            series.Points.Clear();
            foreach (var kvp in capBac)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            var top10 = ds.OrderByDescending(x => x.DiemTichLuy).Take(10).ToList();
            dgvTop.DataSource = top10.Select((x, i) => new
            {
                STT = i + 1,
                x.MaKH,
                x.HoTen,
                x.SoDienThoai,
                x.Email,
                Điểm = x.DiemTichLuy,
                x.CapBac,
                NgàyĐK = x.NgayDangKy.ToString("dd/MM/yyyy")
            }).ToList();
        }
    }
}