using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

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
            DateTime denNgay = DateTime.Now.Date;
            DateTime tuNgay = GetTuNgayTheoChon(denNgay);

            if (cboThoiGian.SelectedItem != null && cboThoiGian.SelectedItem.ToString() == "Tùy chỉnh")
            {
                tuNgay = dtpTuNgay.Value.Date;
                denNgay = dtpDenNgay.Value.Date;
            }

            // Cập nhật tổng quan
            var tk = qlKH.LayThongKeDonGian();
            lblTongQuan.Text = string.Format(
                "📊 TỔNG QUAN\n" +
                "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                "👥 Tổng khách hàng: {0:N0}     💰 Tổng điểm tích lũy: {1:N0}\n" +
                "💵 Doanh thu hôm nay: {2:N0} VNĐ     🧾 Số đơn hôm nay: {3:N0}\n" +
                "📅 Doanh thu tháng này: {4:N0} VNĐ     🧾 Số đơn tháng này: {5:N0}\n" +
                "⚠️ Thuốc sắp hết: {6}     ⚠️ Quà sắp hết: {7}",
                tk.TongKhachHang, tk.TongDiemTichLuy,
                tk.DoanhThuHomNay, tk.SoDonHomNay,
                tk.DoanhThuThangNay, tk.SoDonThangNay,
                tk.ThuocSapHetHang, tk.QuaSapHetHang);

            // Biểu đồ doanh thu theo ngày
            LoadChartDoanhThu(tuNgay, denNgay);

            // Top thuốc bán chạy
            LoadTopThuoc(tuNgay, denNgay);

            // Top khách hàng mua nhiều
            LoadTopKhachHang(tuNgay, denNgay);
        }

        private DateTime GetTuNgayTheoChon(DateTime denNgay)
        {
            string chon = cboThoiGian.SelectedItem != null ? cboThoiGian.SelectedItem.ToString() : "Tháng này";
            if (chon == "Hôm nay") return denNgay;
            if (chon == "Tuần này") return denNgay.AddDays(-(int)denNgay.DayOfWeek);
            if (chon == "Tháng này") return new DateTime(denNgay.Year, denNgay.Month, 1);
            if (chon == "Quý này") return new DateTime(denNgay.Year, ((denNgay.Month - 1) / 3) * 3 + 1, 1);
            if (chon == "Năm này") return new DateTime(denNgay.Year, 1, 1);
            return new DateTime(denNgay.Year, denNgay.Month, 1);
        }

        private void LoadChartDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            var data = qlKH.ThongKeTheoNgay(tuNgay, denNgay);

            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Legends.Clear();

            var area = new ChartArea("MainArea");
            area.AxisX.Title = "Ngày";
            area.AxisX.LabelStyle.Format = "dd/MM";
            area.AxisX.Interval = Math.Max(1, data.Count / 10);
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisY.LabelStyle.Format = "N0";
            chartDoanhThu.ChartAreas.Add(area);

            var seriesDoanhThu = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 123, 255),
                BorderWidth = 1,
                IsValueShownAsLabel = data.Count <= 30,
                LabelFormat = "N0",
                Font = new Font("Segoe UI", 8F)
            };

            var seriesHoaDon = new Series("Số hóa đơn")
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

            chartDoanhThu.Series.Add(seriesDoanhThu);
            chartDoanhThu.Series.Add(seriesHoaDon);

            area.AxisY2.Enabled = AxisEnabled.True;
            area.AxisY2.Title = "Số hóa đơn";
            area.AxisY2.Minimum = 0;

            foreach (var d in data)
            {
                seriesDoanhThu.Points.AddXY(d.Ngay.ToString("dd/MM"), (double)d.DoanhThu);
                seriesHoaDon.Points.AddXY(d.Ngay.ToString("dd/MM"), (double)d.SoHoaDon);
            }

            var title = new Title(string.Format("Doanh thu & Số hóa đơn ({0} - {1})",
                tuNgay.ToString("dd/MM/yyyy"), denNgay.ToString("dd/MM/yyyy")),
                Docking.Top, new Font("Segoe UI", 11F, FontStyle.Bold), Color.Black);
            chartDoanhThu.Titles.Add(title);

            var legend = new Legend { Docking = Docking.Bottom };
            chartDoanhThu.Legends.Add(legend);
        }

        private void LoadTopThuoc(DateTime tuNgay, DateTime denNgay)
        {
            var topThuoc = qlKH.TopThuocBanChay(tuNgay, denNgay, 10);

            // Chart
            chartTopThuoc.Series.Clear();
            chartTopThuoc.ChartAreas.Clear();
            chartTopThuoc.Titles.Clear();
            chartTopThuoc.Legends.Clear();

            var area2 = new ChartArea("MainArea");
            area2.AxisX.Title = "Thuốc";
            area2.AxisX.LabelStyle.Angle = -45;
            area2.AxisX.Interval = 1;
            area2.AxisY.Title = "Số lượng bán";
            area2.AxisY.LabelStyle.Format = "N0";
            chartTopThuoc.ChartAreas.Add(area2);

            var series = new Series("Số lượng bán")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.FromArgb(40, 167, 69),
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                Font = new Font("Segoe UI", 8F)
            };
            chartTopThuoc.Series.Add(series);

            foreach (var t in topThuoc)
            {
                series.Points.AddXY(t.TenThuoc, t.SoLuongBan);
            }

            var title2 = new Title(string.Format("Top 10 thuốc bán chạy ({0} - {1})",
                tuNgay.ToString("dd/MM/yyyy"), denNgay.ToString("dd/MM/yyyy")),
                Docking.Top, new Font("Segoe UI", 11F, FontStyle.Bold), Color.Black);
            chartTopThuoc.Titles.Add(title2);

            // Grid
            var displayList = new List<TopThuocGridModel>();
            for (int i = 0; i < topThuoc.Count; i++)
            {
                var t = topThuoc[i];
                displayList.Add(new TopThuocGridModel
                {
                    STT = i + 1,
                    TenThuoc = t.TenThuoc,
                    SoLuongBan = t.SoLuongBan,
                    DoanhThu = t.DoanhThu.ToString("N0") + " VNĐ"
                });
            }

            dgvTopThuoc.DataSource = null;
            dgvTopThuoc.DataSource = displayList;

            if (dgvTopThuoc.Columns.Count > 0)
            {
                if (dgvTopThuoc.Columns.Contains("STT"))
                {
                    dgvTopThuoc.Columns["STT"].HeaderText = "STT";
                    dgvTopThuoc.Columns["STT"].FillWeight = 40;
                    dgvTopThuoc.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvTopThuoc.Columns.Contains("TenThuoc"))
                {
                    dgvTopThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                    dgvTopThuoc.Columns["TenThuoc"].FillWeight = 200;
                }
                if (dgvTopThuoc.Columns.Contains("SoLuongBan"))
                {
                    dgvTopThuoc.Columns["SoLuongBan"].HeaderText = "SL bán";
                    dgvTopThuoc.Columns["SoLuongBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTopThuoc.Columns["SoLuongBan"].FillWeight = 80;
                }
                if (dgvTopThuoc.Columns.Contains("DoanhThu"))
                {
                    dgvTopThuoc.Columns["DoanhThu"].HeaderText = "Doanh thu";
                    dgvTopThuoc.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTopThuoc.Columns["DoanhThu"].FillWeight = 120;
                }
            }
        }

        private void LoadTopKhachHang(DateTime tuNgay, DateTime denNgay)
        {
            var topKH = qlKH.TopKhachHangMuaNhieu(tuNgay, denNgay, 10);

            var displayList = new List<TopKhachHangGridModel>();
            for (int i = 0; i < topKH.Count; i++)
            {
                var x = topKH[i];
                displayList.Add(new TopKhachHangGridModel
                {
                    STT = i + 1,
                    TenKH = x.TenKH,
                    SoLanMua = x.SoLanMua,
                    TongTien = x.TongTienMua.ToString("N0") + " VNĐ",
                    TongDiem = x.TongDiem.ToString("N0")
                });
            }

            dgvTopKhachHang.DataSource = null;
            dgvTopKhachHang.DataSource = displayList;

            if (dgvTopKhachHang.Columns.Count > 0)
            {
                if (dgvTopKhachHang.Columns.Contains("STT"))
                {
                    dgvTopKhachHang.Columns["STT"].HeaderText = "STT";
                    dgvTopKhachHang.Columns["STT"].FillWeight = 40;
                    dgvTopKhachHang.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvTopKhachHang.Columns.Contains("TenKH"))
                {
                    dgvTopKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
                    dgvTopKhachHang.Columns["TenKH"].FillWeight = 180;
                }
                if (dgvTopKhachHang.Columns.Contains("SoLanMua"))
                {
                    dgvTopKhachHang.Columns["SoLanMua"].HeaderText = "Số lần mua";
                    dgvTopKhachHang.Columns["SoLanMua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTopKhachHang.Columns["SoLanMua"].FillWeight = 80;
                }
                if (dgvTopKhachHang.Columns.Contains("TongTien"))
                {
                    dgvTopKhachHang.Columns["TongTien"].HeaderText = "Tổng tiền mua";
                    dgvTopKhachHang.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTopKhachHang.Columns["TongTien"].FillWeight = 120;
                }
                if (dgvTopKhachHang.Columns.Contains("TongDiem"))
                {
                    dgvTopKhachHang.Columns["TongDiem"].HeaderText = "Điểm tích lũy";
                    dgvTopKhachHang.Columns["TongDiem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTopKhachHang.Columns["TongDiem"].FillWeight = 100;
                }
            }
        }

        private void CboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustom = cboThoiGian.SelectedItem != null && cboThoiGian.SelectedItem.ToString() == "Tùy chỉnh";
            dtpTuNgay.Enabled = isCustom;
            dtpDenNgay.Enabled = isCustom;
            LoadThongKe();
        }

        private void Dtp_Custom_ValueChanged(object sender, EventArgs e)
        {
            if (cboThoiGian.SelectedItem != null && cboThoiGian.SelectedItem.ToString() == "Tùy chỉnh")
                LoadThongKe();
        }

        private void BtnXuatBaoCao_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "BaoCao_ThongKe_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(lblTongQuan.Text.Replace("\n", " | "));
                            sw.WriteLine("");
                            sw.WriteLine("=== TOP THUỐC BÁN CHẠY ===");
                            sw.WriteLine("STT,Tên thuốc,Số lượng bán,Doanh thu (VNĐ)");
                            var topThuoc = qlKH.TopThuocBanChay(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date, 20);
                            int idx = 0;
                            foreach (var t in topThuoc)
                            {
                                idx++;
                                sw.WriteLine(string.Format("{0},\"{1}\",{2},{3}", idx, t.TenThuoc, t.SoLuongBan, t.DoanhThu));
                            }
                            sw.WriteLine("");
                            sw.WriteLine("=== TOP KHÁCH HÀNG MUA NHIỀU ===");
                            sw.WriteLine("STT,Tên KH,Số lần mua,Tổng tiền (VNĐ),Điểm tích lũy");
                            var topKH = qlKH.TopKhachHangMuaNhieu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date, 20);
                            idx = 0;
                            foreach (var k in topKH)
                            {
                                idx++;
                                sw.WriteLine(string.Format("{0},\"{1}\",{2},{3},{4}", idx, k.TenKH, k.SoLanMua, k.TongTienMua, k.TongDiem));
                            }
                        }
                        MessageBox.Show("Xuất báo cáo thành công!\n" + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnXemChiTietNgay_Click(object sender, EventArgs e)
        {
            using (var frm = new FormChiTietDoanhThu(qlKH, dtpTuNgay.Value.Date, dtpDenNgay.Value.Date))
            {
                frm.ShowDialog(this);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class TopThuocGridModel
    {
        public int STT { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuongBan { get; set; }
        public string DoanhThu { get; set; }
    }

    public class TopKhachHangGridModel
    {
        public int STT { get; set; }
        public string TenKH { get; set; }
        public int SoLanMua { get; set; }
        public string TongTien { get; set; }
        public string TongDiem { get; set; }
    }
}