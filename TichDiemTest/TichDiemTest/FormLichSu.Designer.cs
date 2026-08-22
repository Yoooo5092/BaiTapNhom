using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormLichSu
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cboLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.pnlFilter);
            this.pnlTop.Controls.Add(this.pnlInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(980, 135);
            this.pnlTop.TabIndex = 0;

            // pnlFilter
            this.pnlFilter.Controls.Add(this.btnXuatExcel);
            this.pnlFilter.Controls.Add(this.btnXemChiTiet);
            this.pnlFilter.Controls.Add(this.btnLoc);
            this.pnlFilter.Controls.Add(this.txtTimKiem);
            this.pnlFilter.Controls.Add(this.lblTimKiem);
            this.pnlFilter.Controls.Add(this.cboLoaiGiaoDich);
            this.pnlFilter.Controls.Add(this.lblLoai);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(10, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlFilter.Size = new System.Drawing.Size(960, 45);
            this.pnlFilter.TabIndex = 1;

            // btnXuatExcel
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXuatExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(850, 10);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(110, 35);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "📤 Xuất CSV";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.BtnXuatExcel_Click);

            // btnXemChiTiet
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(735, 10);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(115, 35);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "🔍 Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.BtnXemChiTiet_Click);

            // btnLoc
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(645, 10);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 35);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "🔄 Làm mới";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.BtnLoc_Click);

            // txtTimKiem
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(520, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(115, 25);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTimKiem_KeyDown);

            // lblTimKiem
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimKiem.Location = new System.Drawing.Point(455, 10);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Padding = new System.Windows.Forms.Padding(6, 4, 4, 0);
            this.lblTimKiem.Size = new System.Drawing.Size(65, 21);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm kiếm:";

            // cboLoaiGiaoDich
            this.cboLoaiGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboLoaiGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiGiaoDich.Items.AddRange(new object[] {
                "Tất cả",
                "Bán thuốc",
                "Cộng điểm",
                "Đổi quà"
            });
            this.cboLoaiGiaoDich.Location = new System.Drawing.Point(345, 10);
            this.cboLoaiGiaoDich.Name = "cboLoaiGiaoDich";
            this.cboLoaiGiaoDich.Size = new System.Drawing.Size(110, 25);
            this.cboLoaiGiaoDich.TabIndex = 5;
            this.cboLoaiGiaoDich.SelectedIndexChanged += new System.EventHandler(this.CboLoaiGiaoDich_SelectedIndexChanged);

            // lblLoai
            this.lblLoai.AutoSize = true;
            this.lblLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoai.Location = new System.Drawing.Point(305, 10);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Padding = new System.Windows.Forms.Padding(6, 4, 4, 0);
            this.lblLoai.Size = new System.Drawing.Size(40, 21);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loại:";

            // dtpDenNgay
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(195, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);

            // lblDenNgay
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDenNgay.Location = new System.Drawing.Point(155, 10);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Padding = new System.Windows.Forms.Padding(6, 4, 4, 0);
            this.lblDenNgay.Size = new System.Drawing.Size(40, 21);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến:";

            // dtpTuNgay
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(45, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpTuNgay.TabIndex = 1;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);

            // lblTuNgay
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTuNgay.Location = new System.Drawing.Point(0, 10);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.lblTuNgay.Size = new System.Drawing.Size(45, 21);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlInfo.Controls.Add(this.lblTongQuan);
            this.pnlInfo.Controls.Add(this.lblThongTin);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(12);
            this.pnlInfo.Size = new System.Drawing.Size(960, 70);
            this.pnlInfo.TabIndex = 0;

            // lblTongQuan
            this.lblTongQuan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTongQuan.Location = new System.Drawing.Point(12, 38);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Size = new System.Drawing.Size(936, 20);
            this.lblTongQuan.TabIndex = 1;
            this.lblTongQuan.Text = "Tổng GD: 0 | Điểm cộng: +0 | Điểm trừ: -0 | Doanh thu: 0 VNĐ | Số hóa đơn: 0";

            // lblThongTin
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblThongTin.Location = new System.Drawing.Point(12, 12);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(936, 25);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Khách hàng: [Tên] - SĐT: [SĐT] (Điểm: [Điểm])";

            // dgvLichSu
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.Location = new System.Drawing.Point(0, 135);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(980, 425);
            this.dgvLichSu.TabIndex = 1;
            this.dgvLichSu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLichSu_CellDoubleClick);

            // pnlBottom
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(980, 50);
            this.pnlBottom.TabIndex = 2;

            // btnDong
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(860, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 30);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler((s, e) => this.Close());

            // FormLichSu
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FormLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch sử giao dịch khách hàng";
            this.pnlTop.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Panel pnlTop;
        private Panel pnlInfo;
        private Label lblThongTin;
        private Label lblTongQuan;
        private Panel pnlFilter;
        private Button btnXuatExcel;
        private Button btnXemChiTiet;
        private Button btnLoc;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private ComboBox cboLoaiGiaoDich;
        private Label lblLoai;
        private DateTimePicker dtpDenNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblTuNgay;
        private DataGridView dgvLichSu;
        private Panel pnlBottom;
        private Button btnDong;
    }
}