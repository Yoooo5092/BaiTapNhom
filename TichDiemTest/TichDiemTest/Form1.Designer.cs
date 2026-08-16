using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCongDiem = new System.Windows.Forms.ToolStripButton();
            this.btnDoiQua = new System.Windows.Forms.ToolStripButton();
            this.btnNhapFile = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.btnThongKe = new System.Windows.Forms.ToolStripButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.ts.SuspendLayout();
            this.ss.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.Controls.Add(this.dgvKhachHang);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(984, 558);

            // dgvKhachHang
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.ContextMenuStrip = this.cmsGrid;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(5, 55);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(974, 498);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);

            // cmsGrid
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(61, 4);

            // pnlSearch
            this.pnlSearch.Controls.Add(this.lblCount);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(5, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(974, 50);

            // lblCount
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(450, 15);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(76, 13);
            this.lblCount.Text = "0 khách hàng";

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(400, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 23);
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(90, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 20);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 13);
            this.lblSearch.Text = "Tìm kiếm:";

            // ts
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem, this.btnSua, this.btnXoa, new System.Windows.Forms.ToolStripSeparator(),
            this.btnCongDiem, this.btnDoiQua, new System.Windows.Forms.ToolStripSeparator(),
            this.btnNhapFile, this.btnXuatFile, new System.Windows.Forms.ToolStripSeparator(),
            this.btnThongKe});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(984, 30);

            // ToolStrip Buttons
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnCongDiem.Text = "Cộng điểm";
            this.btnCongDiem.Click += new System.EventHandler(this.btnCongDiem_Click);

            this.btnDoiQua.Text = "Đổi quà";
            this.btnDoiQua.Click += new System.EventHandler(this.btnDoiQua_Click);

            this.btnNhapFile.Text = "Nhập file";
            this.btnNhapFile.Click += new System.EventHandler(this.btnNhapFile_Click);

            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);

            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // ss
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.ss.Location = new System.Drawing.Point(0, 588);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(984, 22);

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 17);
            this.lblStatus.Text = "Sẵn sàng";

            // Form1
            this.ClientSize = new System.Drawing.Size(984, 610);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ss);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tích Điểm Khách Hàng";

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCongDiem;
        private System.Windows.Forms.ToolStripButton btnDoiQua;
        private System.Windows.Forms.ToolStripButton btnNhapFile;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
        private System.Windows.Forms.ToolStripButton btnThongKe;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}