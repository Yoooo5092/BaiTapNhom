using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;

namespace TichDiemTest
{
    /// <summary>
    // Form thống kê - hiển thị biểu đồ và thông tin tổng quan
    /// </summary>
    public partial class FormThongKe : Form
    {
        private QuanLyKhachHang qlKH;

        public FormThongKe(QuanLyKhachHang ql)
        {
            InitializeComponent();
            qlKH = ql;
            LoadThongKe();
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTongQuan = new Label();
            this.chartCapBac = new Chart();
            this.dgvTop = new DataGridView();
            this.btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapBac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Thống kê khách hàng";
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Panel top - thông tin tổng quan
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 120;
            panelTop.BackColor = SystemColors.ControlLightLight;
            panelTop.Padding = new Padding(20);

            lblTongQuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTongQuan.Dock = DockStyle.Fill;
            lblTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            panelTop.Controls.Add(lblTongQuan);

            // Chart - phân bố cấp bậc
            chartCapBac.Dock = DockStyle.Top;
            chartCapBac.Height = 250;
            var chartArea = new ChartArea("MainArea");
            chartCapBac.ChartAreas.Add(chartArea);
            var series = new Series("CapBac")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0} ({1:P0})",
                Font = new System.Drawing.Font("Segoe UI", 9F)
            };
            chartCapBac.Series.Add(series);
            chartCapBac.Legends.Add(new Legend("MainLegend") { Docking = Docking.Right });
            chartCapBac.Titles.Add(new Title("Phân bố cấp bậc khách hàng", Docking.Top, new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black));

            // DataGridView - Top khách hàng
            dgvTop.Dock = DockStyle.Fill;
            dgvTop.AllowUserToAddRows = false;
            dgvTop.AllowUserToDeleteRows = false;
            dgvTop.ReadOnly = true;
            dgvTop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop.BackgroundColor = SystemColors.Window;

            // Button đóng
            btnDong.Text = "Đóng";
            btnDong.Dock = DockStyle.Bottom;
            btnDong.Height = 50;
            btnDong.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.Controls.AddRange(new Control[] { dgvTop, chartCapBac, panelTop, btnDong });
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCapBac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).EndInit();
        }

        private void LoadThongKe()
        {
            var ds = qlKH.LayDanhSach();
            var tk = qlKH.ThongKe();
            var capBac = qlKH.ThongKeTheoCapBac();

            // Cập nhật label tổng quan
            lblTongQuan.Text = $"Tổng khách hàng: {tk.tongKH:N0}   |   Tổng điểm: {tk.tongDiem:N0}   |   Điểm cao nhất: {tk.caoNhat:N0}   |   Điểm thấp nhất: {tk.thapNhat:N0}";

            // Cập nhật chart
            var series = chartCapBac.Series["CapBac"];
            series.Points.Clear();
            foreach (var kvp in capBac)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            // Cập nhật top 10 khách hàng điểm cao nhất
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

        #region Designer fields
        private Panel panelTop;
        private Label lblTongQuan;
        private Chart chartCapBac;
        private DataGridView dgvTop;
        private Button btnDong;
        #endregion
    }
}