using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormBanThuoc
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.pnlThuocSearch = new System.Windows.Forms.Panel();
            this.lblCountThuoc = new System.Windows.Forms.Label();
            this.txtTimKiemThuoc = new System.Windows.Forms.TextBox();
            this.lblSearchThuoc = new System.Windows.Forms.Label();
            this.pnlThuocInfo = new System.Windows.Forms.Panel();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongBan = new System.Windows.Forms.Label();
            this.lblThuocInfo = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.lblDiemSau = new System.Windows.Forms.Label();
            this.lblDiemCong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXoaGio = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.pnlThuocSearch.SuspendLayout();
            this.pnlThuocInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlLeft);
            this.splitContainerMain.Panel1MinSize = 400;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlRight);
            this.splitContainerMain.Panel2MinSize = 350;
            this.splitContainerMain.Size = new System.Drawing.Size(900, 600);
            this.splitContainerMain.SplitterDistance = 500;
            this.splitContainerMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvThuoc);
            this.pnlLeft.Controls.Add(this.pnlThuocSearch);
            this.pnlLeft.Controls.Add(this.pnlThuocInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLeft.Size = new System.Drawing.Size(500, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(5, 45);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(490, 460);
            this.dgvThuoc.TabIndex = 2;
            this.dgvThuoc.SelectionChanged += new System.EventHandler(this.DgvThuoc_SelectionChanged);
            // 
            // pnlThuocSearch
            // 
            this.pnlThuocSearch.Controls.Add(this.lblCountThuoc);
            this.pnlThuocSearch.Controls.Add(this.txtTimKiemThuoc);
            this.pnlThuocSearch.Controls.Add(this.lblSearchThuoc);
            this.pnlThuocSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThuocSearch.Location = new System.Drawing.Point(5, 5);
            this.pnlThuocSearch.Name = "pnlThuocSearch";
            this.pnlThuocSearch.Size = new System.Drawing.Size(490, 40);
            this.pnlThuocSearch.TabIndex = 0;
            // 
            // lblCountThuoc
            // 
            this.lblCountThuoc.AutoSize = true;
            this.lblCountThuoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountThuoc.Location = new System.Drawing.Point(410, 0);
            this.lblCountThuoc.Name = "lblCountThuoc";
            this.lblCountThuoc.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblCountThuoc.Size = new System.Drawing.Size(80, 23);
            this.lblCountThuoc.TabIndex = 2;
            this.lblCountThuoc.Text = "0 thuốc";
            this.lblCountThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimKiemThuoc
            // 
            this.txtTimKiemThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemThuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemThuoc.Location = new System.Drawing.Point(75, 0);
            this.txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            this.txtTimKiemThuoc.Size = new System.Drawing.Size(335, 25);
            this.txtTimKiemThuoc.TabIndex = 1;
            this.txtTimKiemThuoc.TextChanged += new System.EventHandler(this.TxtTimKiemThuoc_TextChanged);
            // 
            // lblSearchThuoc
            // 
            this.lblSearchThuoc.AutoSize = true;
            this.lblSearchThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchThuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchThuoc.Location = new System.Drawing.Point(0, 0);
            this.lblSearchThuoc.Name = "lblSearchThuoc";
            this.lblSearchThuoc.Padding = new System.Windows.Forms.Padding(0, 8, 5, 0);
            this.lblSearchThuoc.Size = new System.Drawing.Size(75, 27);
            this.lblSearchThuoc.TabIndex = 0;
            this.lblSearchThuoc.Text = "Tìm thuốc:";
            // 
            // pnlThuocInfo
            // 
            this.pnlThuocInfo.Controls.Add(this.btnThemVaoGio);
            this.pnlThuocInfo.Controls.Add(this.numSoLuongBan);
            this.pnlThuocInfo.Controls.Add(this.lblSoLuongBan);
            this.pnlThuocInfo.Controls.Add(this.lblThuocInfo);
            this.pnlThuocInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThuocInfo.Location = new System.Drawing.Point(5, 505);
            this.pnlThuocInfo.Name = "pnlThuocInfo";
            this.pnlThuocInfo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlThuocInfo.Size = new System.Drawing.Size(490, 90);
            this.pnlThuocInfo.TabIndex = 1;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnThemVaoGio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemVaoGio.Enabled = false;
            this.btnThemVaoGio.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(355, 5);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(130, 80);
            this.btnThemVaoGio.TabIndex = 3;
            this.btnThemVaoGio.Text = "➕ Thêm\nvào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.BtnThemVaoGio_Click);
            // 
            // numSoLuongBan
            // 
            this.numSoLuongBan.Enabled = false;
            this.numSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numSoLuongBan.Location = new System.Drawing.Point(220, 35);
            this.numSoLuongBan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuongBan.Name = "numSoLuongBan";
            this.numSoLuongBan.Size = new System.Drawing.Size(100, 29);
            this.numSoLuongBan.TabIndex = 2;
            this.numSoLuongBan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongBan
            // 
            this.lblSoLuongBan.AutoSize = true;
            this.lblSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuongBan.Location = new System.Drawing.Point(220, 10);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(67, 19);
            this.lblSoLuongBan.TabIndex = 1;
            this.lblSoLuongBan.Text = "Số lượng:";
            // 
            // lblThuocInfo
            // 
            this.lblThuocInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblThuocInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThuocInfo.Location = new System.Drawing.Point(5, 5);
            this.lblThuocInfo.Name = "lblThuocInfo";
            this.lblThuocInfo.Size = new System.Drawing.Size(210, 80);
            this.lblThuocInfo.TabIndex = 0;
            this.lblThuocInfo.Text = "Chọn thuốc từ danh sách";
            this.lblThuocInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvGioHang);
            this.pnlRight.Controls.Add(this.pnlThanhToan);
            this.pnlRight.Controls.Add(this.pnlKhachHang);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRight.Size = new System.Drawing.Size(396, 600);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlKhachHang.Controls.Add(this.lblKhachHang);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhachHang.Location = new System.Drawing.Point(5, 5);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKhachHang.Size = new System.Drawing.Size(386, 60);
            this.pnlKhachHang.TabIndex = 0;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKhachHang.Location = new System.Drawing.Point(10, 10);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(366, 40);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng";
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(5, 65);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(386, 385);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGioHang_CellDoubleClick);
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThanhToan.Controls.Add(this.lblDiemSau);
            this.pnlThanhToan.Controls.Add(this.lblDiemCong);
            this.pnlThanhToan.Controls.Add(this.lblTongTien);
            this.pnlThanhToan.Controls.Add(this.btnXoaGio);
            this.pnlThanhToan.Controls.Add(this.btnThanhToan);
            this.pnlThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThanhToan.Location = new System.Drawing.Point(5, 450);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThanhToan.Size = new System.Drawing.Size(386, 145);
            this.pnlThanhToan.TabIndex = 2;
            // 
            // lblDiemSau
            // 
            this.lblDiemSau.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiemSau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDiemSau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDiemSau.Location = new System.Drawing.Point(10, 58);
            this.lblDiemSau.Name = "lblDiemSau";
            this.lblDiemSau.Size = new System.Drawing.Size(246, 22);
            this.lblDiemSau.TabIndex = 4;
            this.lblDiemSau.Text = "Điểm sau GD: 0";
            // 
            // lblDiemCong
            // 
            this.lblDiemCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiemCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDiemCong.Location = new System.Drawing.Point(10, 36);
            this.lblDiemCong.Name = "lblDiemCong";
            this.lblDiemCong.Size = new System.Drawing.Size(246, 22);
            this.lblDiemCong.TabIndex = 3;
            this.lblDiemCong.Text = "Điểm cộng: +0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongTien.Location = new System.Drawing.Point(10, 10);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(246, 26);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // btnXoaGio
            // 
            this.btnXoaGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaGio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoaGio.FlatAppearance.BorderSize = 0;
            this.btnXoaGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaGio.Location = new System.Drawing.Point(256, 10);
            this.btnXoaGio.Name = "btnXoaGio";
            this.btnXoaGio.Size = new System.Drawing.Size(120, 55);
            this.btnXoaGio.TabIndex = 1;
            this.btnXoaGio.Text = "🗑️ Xóa giỏ";
            this.btnXoaGio.UseVisualStyleBackColor = false;
            this.btnXoaGio.Click += new System.EventHandler(this.BtnXoaGio_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(10, 85);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(366, 50);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "💳 THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // FormBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormBanThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bán thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.pnlThuocSearch.ResumeLayout(false);
            this.pnlThuocSearch.PerformLayout();
            this.pnlThuocInfo.ResumeLayout(false);
            this.pnlThuocInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlThanhToan.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private SplitContainer splitContainerMain;
        private Panel pnlLeft;
        private DataGridView dgvThuoc;
        private Panel pnlThuocSearch;
        private Label lblCountThuoc;
        private TextBox txtTimKiemThuoc;
        private Label lblSearchThuoc;
        private Panel pnlThuocInfo;
        private Button btnThemVaoGio;
        private NumericUpDown numSoLuongBan;
        private Label lblSoLuongBan;
        private Label lblThuocInfo;
        private Panel pnlRight;
        private Panel pnlKhachHang;
        private Label lblKhachHang;
        private DataGridView dgvGioHang;
        private Panel pnlThanhToan;
        private Label lblDiemSau;
        private Label lblDiemCong;
        private Label lblTongTien;
        private Button btnXoaGio;
        private Button btnThanhToan;
    }
}