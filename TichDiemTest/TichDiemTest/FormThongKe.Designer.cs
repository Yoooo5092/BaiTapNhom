using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TichDiemTest
{
    partial class FormThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnXemChiTietNgay = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cboThoiGian = new System.Windows.Forms.ComboBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTopThuoc = new System.Windows.Forms.TabPage();
            this.splitContainerTopThuoc = new System.Windows.Forms.SplitContainer();
            this.chartTopThuoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopThuoc = new System.Windows.Forms.DataGridView();
            this.tabTopKhachHang = new System.Windows.Forms.TabPage();
            this.dgvTopKhachHang = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.tabTopThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopThuoc)).BeginInit();
            this.splitContainerTopThuoc.Panel1.SuspendLayout();
            this.splitContainerTopThuoc.Panel2.SuspendLayout();
            this.splitContainerTopThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopThuoc)).BeginInit();
            this.tabTopKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopKhachHang)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlTop.Controls.Add(this.lblTongQuan);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlTop.Size = new System.Drawing.Size(1000, 90);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTongQuan
            // 
            this.lblTongQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongQuan.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lblTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTongQuan.Location = new System.Drawing.Point(20, 15);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Size = new System.Drawing.Size(960, 60);
            this.lblTongQuan.TabIndex = 0;
            this.lblTongQuan.Text = "Đang tải...";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.btnXemChiTietNgay);
            this.pnlFilter.Controls.Add(this.btnXuatBaoCao);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.cboThoiGian);
            this.pnlFilter.Controls.Add(this.lblThoiGian);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 90);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1000, 55);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnXemChiTietNgay
            // 
            this.btnXemChiTietNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnXemChiTietNgay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemChiTietNgay.FlatAppearance.BorderSize = 0;
            this.btnXemChiTietNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTietNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemChiTietNgay.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTietNgay.Location = new System.Drawing.Point(718, 10);
            this.btnXemChiTietNgay.Name = "btnXemChiTietNgay";
            this.btnXemChiTietNgay.Size = new System.Drawing.Size(130, 33);
            this.btnXemChiTietNgay.TabIndex = 7;
            this.btnXemChiTietNgay.Text = "📅 Chi tiết ngày";
            this.btnXemChiTietNgay.UseVisualStyleBackColor = false;
            this.btnXemChiTietNgay.Click += new System.EventHandler(this.BtnXemChiTietNgay_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXuatBaoCao.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXuatBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(848, 10);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(135, 33);
            this.btnXuatBaoCao.TabIndex = 6;
            this.btnXuatBaoCao.Text = "📤 Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.BtnXuatBaoCao_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(528, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 25);
            this.dtpDenNgay.TabIndex = 5;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.Dtp_Custom_ValueChanged);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenNgay.Location = new System.Drawing.Point(488, 10);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.lblDenNgay.Size = new System.Drawing.Size(40, 24);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(368, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 25);
            this.dtpTuNgay.TabIndex = 3;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.Dtp_Custom_ValueChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuNgay.Location = new System.Drawing.Point(328, 10);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.lblTuNgay.Size = new System.Drawing.Size(40, 24);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ:";
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiGian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThoiGian.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Quý này",
            "Năm này",
            "Tùy chỉnh"});
            this.cboThoiGian.Location = new System.Drawing.Point(113, 10);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(215, 25);
            this.cboThoiGian.TabIndex = 1;
            this.cboThoiGian.SelectedIndexChanged += new System.EventHandler(this.CboThoiGian_SelectedIndexChanged);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblThoiGian.Location = new System.Drawing.Point(15, 10);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.lblThoiGian.Size = new System.Drawing.Size(98, 24);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Khoảng thời gian:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabTopThuoc);
            this.tabControl.Controls.Add(this.tabTopKhachHang);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 145);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 455);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.chartDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 34);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.tabDoanhThu.Size = new System.Drawing.Size(992, 417);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "📈 Doanh thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // chartDoanhThu
            // 
            chartArea1.AxisX.LabelStyle.Format = "dd/MM";
            chartArea1.AxisX.Title = "Ngày";
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea1.Name = "MainArea";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "MainLegend";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(10, 10);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "N0";
            series1.Legend = "MainLegend";
            series1.Name = "Doanh thu";
            series2.ChartArea = "MainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "N0";
            series2.Legend = "MainLegend";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.MarkerSize = 6;
            series2.Name = "Số hóa đơn";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(972, 397);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // tabTopThuoc
            // 
            this.tabTopThuoc.Controls.Add(this.splitContainerTopThuoc);
            this.tabTopThuoc.Location = new System.Drawing.Point(4, 34);
            this.tabTopThuoc.Name = "tabTopThuoc";
            this.tabTopThuoc.Padding = new System.Windows.Forms.Padding(10);
            this.tabTopThuoc.Size = new System.Drawing.Size(992, 417);
            this.tabTopThuoc.TabIndex = 1;
            this.tabTopThuoc.Text = "💊 Top thuốc";
            this.tabTopThuoc.UseVisualStyleBackColor = true;
            // 
            // splitContainerTopThuoc
            // 
            this.splitContainerTopThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTopThuoc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTopThuoc.Location = new System.Drawing.Point(10, 10);
            this.splitContainerTopThuoc.Name = "splitContainerTopThuoc";
            this.splitContainerTopThuoc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTopThuoc.Panel1
            // 
            this.splitContainerTopThuoc.Panel1.Controls.Add(this.chartTopThuoc);
            this.splitContainerTopThuoc.Panel1MinSize = 250;
            // 
            // splitContainerTopThuoc.Panel2
            // 
            this.splitContainerTopThuoc.Panel2.Controls.Add(this.dgvTopThuoc);
            this.splitContainerTopThuoc.Panel2MinSize = 150;
            this.splitContainerTopThuoc.Size = new System.Drawing.Size(972, 397);
            this.splitContainerTopThuoc.SplitterDistance = 250;
            this.splitContainerTopThuoc.TabIndex = 0;
            // 
            // chartTopThuoc
            // 
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.AxisX.Title = "Thuốc";
            chartArea2.AxisY.LabelStyle.Format = "N0";
            chartArea2.AxisY.Title = "Số lượng bán";
            chartArea2.Name = "MainArea";
            this.chartTopThuoc.ChartAreas.Add(chartArea2);
            this.chartTopThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTopThuoc.Location = new System.Drawing.Point(0, 0);
            this.chartTopThuoc.Name = "chartTopThuoc";
            series3.ChartArea = "MainArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "N0";
            series3.Name = "Số lượng bán";
            this.chartTopThuoc.Series.Add(series3);
            this.chartTopThuoc.Size = new System.Drawing.Size(972, 250);
            this.chartTopThuoc.TabIndex = 0;
            this.chartTopThuoc.Text = "chart2";
            // 
            // dgvTopThuoc
            // 
            this.dgvTopThuoc.AllowUserToAddRows = false;
            this.dgvTopThuoc.AllowUserToDeleteRows = false;
            this.dgvTopThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvTopThuoc.Name = "dgvTopThuoc";
            this.dgvTopThuoc.ReadOnly = true;
            this.dgvTopThuoc.RowHeadersVisible = false;
            this.dgvTopThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopThuoc.Size = new System.Drawing.Size(972, 143);
            this.dgvTopThuoc.TabIndex = 0;
            // 
            // tabTopKhachHang
            // 
            this.tabTopKhachHang.Controls.Add(this.dgvTopKhachHang);
            this.tabTopKhachHang.Location = new System.Drawing.Point(4, 34);
            this.tabTopKhachHang.Name = "tabTopKhachHang";
            this.tabTopKhachHang.Padding = new System.Windows.Forms.Padding(10);
            this.tabTopKhachHang.Size = new System.Drawing.Size(992, 417);
            this.tabTopKhachHang.TabIndex = 2;
            this.tabTopKhachHang.Text = "👑 Top khách hàng";
            this.tabTopKhachHang.UseVisualStyleBackColor = true;
            // 
            // dgvTopKhachHang
            // 
            this.dgvTopKhachHang.AllowUserToAddRows = false;
            this.dgvTopKhachHang.AllowUserToDeleteRows = false;
            this.dgvTopKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopKhachHang.Location = new System.Drawing.Point(10, 10);
            this.dgvTopKhachHang.Name = "dgvTopKhachHang";
            this.dgvTopKhachHang.ReadOnly = true;
            this.dgvTopKhachHang.RowHeadersVisible = false;
            this.dgvTopKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopKhachHang.Size = new System.Drawing.Size(972, 397);
            this.dgvTopKhachHang.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 600);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(1000, 50);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(870, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 30);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler((s, e) => this.Close());
            // 
            // FormThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "📊 Thống kê & Báo cáo doanh thu";
            this.pnlTop.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.tabTopThuoc.ResumeLayout(false);
            this.splitContainerTopThuoc.Panel1.ResumeLayout(false);
            this.splitContainerTopThuoc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopThuoc)).EndInit();
            this.splitContainerTopThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopThuoc)).EndInit();
            this.tabTopKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopKhachHang)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Panel pnlTop;
        private Label lblTongQuan;
        private Panel pnlFilter;
        private Button btnXemChiTietNgay;
        private Button btnXuatBaoCao;
        private DateTimePicker dtpDenNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblTuNgay;
        private ComboBox cboThoiGian;
        private Label lblThoiGian;
        private TabControl tabControl;
        private TabPage tabDoanhThu;
        private Chart chartDoanhThu;
        private TabPage tabTopThuoc;
        private SplitContainer splitContainerTopThuoc;
        private Chart chartTopThuoc;
        private DataGridView dgvTopThuoc;
        private TabPage tabTopKhachHang;
        private DataGridView dgvTopKhachHang;
        private Panel pnlBottom;
        private Button btnDong;
    }
}