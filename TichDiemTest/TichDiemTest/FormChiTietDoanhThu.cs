using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TichDiemTest
{
    public partial class FormChiTietDoanhThu : Form
    {
        private QuanLyKhachHang qlKH;
        private DateTime tuNgay;
        private DateTime denNgay;

        public FormChiTietDoanhThu(QuanLyKhachHang ql, DateTime tu, DateTime den)
        {
            InitializeComponent();
            qlKH = ql;
            tuNgay = tu;
            denNgay = den;

            Text = string.Format("Chi tiết doanh thu ({0} - {1})", tu.ToString("dd/MM/yyyy"), den.ToString("dd/MM/yyyy"));
            LoadData();
        }

        private void LoadData()
        {
            var data = qlKH.ThongKeTheoNgay(tuNgay, denNgay);

            decimal tongDoanhThu = 0;
            int tongHoaDon = 0;
            foreach (var d in data)
            {
                tongDoanhThu += d.DoanhThu;
                tongHoaDon += d.SoHoaDon;
            }

            lblTongQuan.Text = string.Format(
                "📊 {0} - {1}\n" +
                "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                "💵 Tổng doanh thu: {2:N0} VNĐ     🧾 Tổng hóa đơn: {3:N0}     📅 Số ngày: {4}",
                tuNgay.ToString("dd/MM/yyyy"), denNgay.ToString("dd/MM/yyyy"),
                tongDoanhThu, tongHoaDon, data.Count);

            var displayList = new List<object>();
            foreach (var d in data)
            {
                displayList.Add(new
                {
                    Ngay = d.Ngay.ToString("dd/MM/yyyy"),
                    DoanhThu = d.DoanhThu.ToString("N0") + " VNĐ",
                    d.SoHoaDon,
                    DiemCong = "+" + d.DiemCong.ToString("N0"),
                    TrungBinhHD = d.SoHoaDon > 0 ? (d.DoanhThu / d.SoHoaDon).ToString("N0") + " VNĐ" : "0 VNĐ"
                });
            }

            dgvChiTiet.DataSource = displayList;

            if (dgvChiTiet.Columns["DoanhThu"] != null) dgvChiTiet.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (dgvChiTiet.Columns["SoHoaDon"] != null) dgvChiTiet.Columns["SoHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvChiTiet.Columns["DiemCong"] != null) dgvChiTiet.Columns["DiemCong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (dgvChiTiet.Columns["TrungBinhHD"] != null)
            {
                dgvChiTiet.Columns["TrungBinhHD"].HeaderText = "TB/Hóa đơn";
                dgvChiTiet.Columns["TrungBinhHD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            LoadChart(data);
        }

        private void LoadChart(List<ThongKeNgayItem> data)
        {
            chartNgay.Series.Clear();
            chartNgay.ChartAreas.Clear();
            chartNgay.Titles.Clear();
            chartNgay.Legends.Clear();

            var area = new ChartArea("MainArea");
            area.AxisX.Title = "Ngày";
            area.AxisX.LabelStyle.Format = "dd/MM";
            area.AxisX.Interval = Math.Max(1, data.Count / 10);
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisY.LabelStyle.Format = "N0";
            chartNgay.ChartAreas.Add(area);

            var seriesDT = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 123, 255),
                IsValueShownAsLabel = data.Count <= 30,
                LabelFormat = "N0",
                Font = new Font("Segoe UI", 8F)
            };

            var seriesHD = new Series("Số HD")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.FromArgb(220, 53, 69),
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                YAxisType = AxisType.Secondary,
                IsValueShownAsLabel = data.Count <= 30,
                LabelFormat = "N0"
            };

            chartNgay.Series.Add(seriesDT);
            chartNgay.Series.Add(seriesHD);

            area.AxisY2.Enabled = AxisEnabled.True;
            area.AxisY2.Title = "Số hóa đơn";
            area.AxisY2.Minimum = 0;

            foreach (var d in data)
            {
                seriesDT.Points.AddXY(d.Ngay.ToString("dd/MM"), (double)d.DoanhThu);
                seriesHD.Points.AddXY(d.Ngay.ToString("dd/MM"), (double)d.SoHoaDon);
            }

            var title = new Title(string.Format("Doanh thu theo ngày ({0} - {1})",
                tuNgay.ToString("dd/MM/yyyy"), denNgay.ToString("dd/MM/yyyy")),
                Docking.Top, new Font("Segoe UI", 11F, FontStyle.Bold), Color.Black);
            chartNgay.Titles.Add(title);

            var legend = new Legend { Docking = Docking.Bottom };
            chartNgay.Legends.Add(legend);
        }
    }
}