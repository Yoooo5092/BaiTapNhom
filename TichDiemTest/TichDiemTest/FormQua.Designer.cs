using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormQua
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvQua = new System.Windows.Forms.DataGridView();
            this.pnlSearchQua = new System.Windows.Forms.Panel();
            this.lblCountQua = new System.Windows.Forms.Label();
            this.txtTimKiemQua = new System.Windows.Forms.TextBox();
            this.lblSearchQua = new System.Windows.Forms.Label();
            this.pnlInfoQua = new System.Windows.Forms.Panel();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.numSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.numDiemCan = new System.Windows.Forms.NumericUpDown();
            this.lblDiemCan = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenQua = new System.Windows.Forms.TextBox();
            this.lblTenQua = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuuQua = new System.Windows.Forms.Button();
            this.btnNhapKhoQua = new System.Windows.Forms.Button();
            this.btnXoaQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQua)).BeginInit();
            this.pnlSearchQua.SuspendLayout();
            this.pnlInfoQua.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemCan)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.dgvQua);
            this.splitContainer.Panel1.Controls.Add(this.pnlSearchQua);
            this.splitContainer.Panel1MinSize = 400;
            this.splitContainer.Panel2.Controls.Add(this.pnlInfoQua);
            this.splitContainer.Panel2MinSize = 350;
            this.splitContainer.Size = new System.Drawing.Size(950, 620);
            this.splitContainer.SplitterDistance = 560;
            this.splitContainer.TabIndex = 0;

            // dgvQua
            this.dgvQua.AllowUserToAddRows = false;
            this.dgvQua.AllowUserToDeleteRows = false;
            this.dgvQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQua.Location = new System.Drawing.Point(0, 40);
            this.dgvQua.MultiSelect = false;
            this.dgvQua.Name = "dgvQua";
            this.dgvQua.ReadOnly = true;
            this.dgvQua.RowHeadersVisible = false;
            this.dgvQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQua.Size = new System.Drawing.Size(560, 580);
            this.dgvQua.TabIndex = 1;
            this.dgvQua.SelectionChanged += new System.EventHandler(this.DgvQua_SelectionChanged);

            // pnlSearchQua
            this.pnlSearchQua.Controls.Add(this.lblCountQua);
            this.pnlSearchQua.Controls.Add(this.txtTimKiemQua);
            this.pnlSearchQua.Controls.Add(this.lblSearchQua);
            this.pnlSearchQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchQua.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchQua.Name = "pnlSearchQua";
            this.pnlSearchQua.Padding = new System.Windows.Forms.Padding(6);
            this.pnlSearchQua.Size = new System.Drawing.Size(560, 40);
            this.pnlSearchQua.TabIndex = 0;

            // lblCountQua
            this.lblCountQua.AutoSize = true;
            this.lblCountQua.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountQua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountQua.Location = new System.Drawing.Point(474, 6);
            this.lblCountQua.Name = "lblCountQua";
            this.lblCountQua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblCountQua.Size = new System.Drawing.Size(80, 19);
            this.lblCountQua.TabIndex = 2;
            this.lblCountQua.Text = "0 quà";
            this.lblCountQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtTimKiemQua
            this.txtTimKiemQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemQua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemQua.Location = new System.Drawing.Point(76, 6);
            this.txtTimKiemQua.Name = "txtTimKiemQua";
            this.txtTimKiemQua.Size = new System.Drawing.Size(398, 25);
            this.txtTimKiemQua.TabIndex = 1;
            this.txtTimKiemQua.TextChanged += new System.EventHandler(this.TxtTimKiemQua_TextChanged);

            // lblSearchQua
            this.lblSearchQua.AutoSize = true;
            this.lblSearchQua.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchQua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchQua.Location = new System.Drawing.Point(6, 6);
            this.lblSearchQua.Name = "lblSearchQua";
            this.lblSearchQua.Padding = new System.Windows.Forms.Padding(0, 4, 5, 0);
            this.lblSearchQua.Size = new System.Drawing.Size(70, 23);
            this.lblSearchQua.TabIndex = 0;
            this.lblSearchQua.Text = "Tìm kiếm:";

            // pnlInfoQua
            this.pnlInfoQua.Controls.Add(this.gbThongTin);
            this.pnlInfoQua.Controls.Add(this.flpButtons);
            this.pnlInfoQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoQua.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoQua.Name = "pnlInfoQua";
            this.pnlInfoQua.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInfoQua.Size = new System.Drawing.Size(386, 620);
            this.pnlInfoQua.TabIndex = 0;

            // gbThongTin
            this.gbThongTin.Controls.Add(this.chkTrangThai);
            this.gbThongTin.Controls.Add(this.txtHinhAnh);
            this.gbThongTin.Controls.Add(this.lblHinhAnh);
            this.gbThongTin.Controls.Add(this.txtDonViTinh);
            this.gbThongTin.Controls.Add(this.lblDonViTinh);
            this.gbThongTin.Controls.Add(this.numSoLuongTon);
            this.gbThongTin.Controls.Add(this.lblSoLuongTon);
            this.gbThongTin.Controls.Add(this.numDiemCan);
            this.gbThongTin.Controls.Add(this.lblDiemCan);
            this.gbThongTin.Controls.Add(this.txtMoTa);
            this.gbThongTin.Controls.Add(this.lblMoTa);
            this.gbThongTin.Controls.Add(this.txtTenQua);
            this.gbThongTin.Controls.Add(this.lblTenQua);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbThongTin.Location = new System.Drawing.Point(10, 10);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.gbThongTin.Size = new System.Drawing.Size(366, 510);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin quà tặng";

            // chkTrangThai
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTrangThai.Location = new System.Drawing.Point(8, 381);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.chkTrangThai.Size = new System.Drawing.Size(350, 27);
            this.chkTrangThai.TabIndex = 12;
            this.chkTrangThai.Text = "Đang áp dụng đổi quà";
            this.chkTrangThai.UseVisualStyleBackColor = true;

            // txtHinhAnh
            this.txtHinhAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHinhAnh.Location = new System.Drawing.Point(8, 357);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(350, 24);
            this.txtHinhAnh.TabIndex = 11;

            // lblHinhAnh
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHinhAnh.Location = new System.Drawing.Point(8, 336);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblHinhAnh.Size = new System.Drawing.Size(63, 21);
            this.lblHinhAnh.TabIndex = 10;
            this.lblHinhAnh.Text = "Hình ảnh:";

            // txtDonViTinh
            this.txtDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonViTinh.Location = new System.Drawing.Point(8, 312);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(350, 24);
            this.txtDonViTinh.TabIndex = 9;

            // lblDonViTinh
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDonViTinh.Location = new System.Drawing.Point(8, 291);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDonViTinh.Size = new System.Drawing.Size(75, 21);
            this.lblDonViTinh.TabIndex = 8;
            this.lblDonViTinh.Text = "Đơn vị tính:";

            // numSoLuongTon
            this.numSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.numSoLuongTon.Location = new System.Drawing.Point(8, 267);
            this.numSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numSoLuongTon.Name = "numSoLuongTon";
            this.numSoLuongTon.Size = new System.Drawing.Size(350, 24);
            this.numSoLuongTon.TabIndex = 7;
            this.numSoLuongTon.ThousandsSeparator = true;

            // lblSoLuongTon
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoLuongTon.Location = new System.Drawing.Point(8, 246);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblSoLuongTon.Size = new System.Drawing.Size(59, 21);
            this.lblSoLuongTon.TabIndex = 6;
            this.lblSoLuongTon.Text = "Tồn kho:";

            // numDiemCan
            this.numDiemCan.Dock = System.Windows.Forms.DockStyle.Top;
            this.numDiemCan.Location = new System.Drawing.Point(8, 222);
            this.numDiemCan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numDiemCan.Name = "numDiemCan";
            this.numDiemCan.Size = new System.Drawing.Size(350, 24);
            this.numDiemCan.TabIndex = 5;
            this.numDiemCan.ThousandsSeparator = true;

            // lblDiemCan
            this.lblDiemCan.AutoSize = true;
            this.lblDiemCan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiemCan.Location = new System.Drawing.Point(8, 201);
            this.lblDiemCan.Name = "lblDiemCan";
            this.lblDiemCan.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDiemCan.Size = new System.Drawing.Size(66, 21);
            this.lblDiemCan.TabIndex = 4;
            this.lblDiemCan.Text = "Điểm cần:";

            // txtMoTa
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMoTa.Location = new System.Drawing.Point(8, 90);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(350, 111);
            this.txtMoTa.TabIndex = 3;

            // lblMoTa
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMoTa.Location = new System.Drawing.Point(8, 69);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblMoTa.Size = new System.Drawing.Size(46, 21);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả:";

            // txtTenQua
            this.txtTenQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenQua.Location = new System.Drawing.Point(8, 45);
            this.txtTenQua.Name = "txtTenQua";
            this.txtTenQua.Size = new System.Drawing.Size(350, 24);
            this.txtTenQua.TabIndex = 1;

            // lblTenQua
            this.lblTenQua.AutoSize = true;
            this.lblTenQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenQua.Location = new System.Drawing.Point(8, 24);
            this.lblTenQua.Name = "lblTenQua";
            this.lblTenQua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblTenQua.Size = new System.Drawing.Size(59, 21);
            this.lblTenQua.TabIndex = 0;
            this.lblTenQua.Text = "Tên quà:";

            // flpButtons
            this.flpButtons.Controls.Add(this.btnThemMoi);
            this.flpButtons.Controls.Add(this.btnLuuQua);
            this.flpButtons.Controls.Add(this.btnNhapKhoQua);
            this.flpButtons.Controls.Add(this.btnXoaQua);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.Location = new System.Drawing.Point(10, 520);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(2);
            this.flpButtons.Size = new System.Drawing.Size(366, 90);
            this.flpButtons.TabIndex = 1;

            // btnThemMoi
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(5, 5);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(170, 35);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "🆕 Làm mới form";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.BtnThemMoi_Click);

            // btnLuuQua
            this.btnLuuQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLuuQua.FlatAppearance.BorderSize = 0;
            this.btnLuuQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuQua.ForeColor = System.Drawing.Color.White;
            this.btnLuuQua.Location = new System.Drawing.Point(181, 5);
            this.btnLuuQua.Margin = new System.Windows.Forms.Padding(3);
            this.btnLuuQua.Name = "btnLuuQua";
            this.btnLuuQua.Size = new System.Drawing.Size(170, 35);
            this.btnLuuQua.TabIndex = 1;
            this.btnLuuQua.Text = "💾 Lưu quà";
            this.btnLuuQua.UseVisualStyleBackColor = false;
            this.btnLuuQua.Click += new System.EventHandler(this.BtnLuuQua_Click);

            // btnNhapKhoQua
            this.btnNhapKhoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNhapKhoQua.FlatAppearance.BorderSize = 0;
            this.btnNhapKhoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKhoQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNhapKhoQua.ForeColor = System.Drawing.Color.White;
            this.btnNhapKhoQua.Location = new System.Drawing.Point(5, 46);
            this.btnNhapKhoQua.Margin = new System.Windows.Forms.Padding(3);
            this.btnNhapKhoQua.Name = "btnNhapKhoQua";
            this.btnNhapKhoQua.Size = new System.Drawing.Size(170, 35);
            this.btnNhapKhoQua.TabIndex = 2;
            this.btnNhapKhoQua.Text = "📦 Nhập kho";
            this.btnNhapKhoQua.UseVisualStyleBackColor = false;
            this.btnNhapKhoQua.Click += new System.EventHandler(this.BtnNhapKhoQua_Click);

            // btnXoaQua
            this.btnXoaQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaQua.FlatAppearance.BorderSize = 0;
            this.btnXoaQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaQua.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnXoaQua.ForeColor = System.Drawing.Color.White;
            this.btnXoaQua.Location = new System.Drawing.Point(181, 46);
            this.btnXoaQua.Margin = new System.Windows.Forms.Padding(3);
            this.btnXoaQua.Name = "btnXoaQua";
            this.btnXoaQua.Size = new System.Drawing.Size(170, 35);
            this.btnXoaQua.TabIndex = 3;
            this.btnXoaQua.Text = "🗑️ Xóa quà";
            this.btnXoaQua.UseVisualStyleBackColor = false;
            this.btnXoaQua.Click += new System.EventHandler(this.BtnXoaQua_Click);

            // FormQua
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FormQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý kho quà tặng";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQua)).EndInit();
            this.pnlSearchQua.ResumeLayout(false);
            this.pnlSearchQua.PerformLayout();
            this.pnlInfoQua.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemCan)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private SplitContainer splitContainer;
        private DataGridView dgvQua;
        private Panel pnlSearchQua;
        private Label lblCountQua;
        private TextBox txtTimKiemQua;
        private Label lblSearchQua;
        private Panel pnlInfoQua;
        private GroupBox gbThongTin;
        private CheckBox chkTrangThai;
        private TextBox txtHinhAnh;
        private Label lblHinhAnh;
        private TextBox txtDonViTinh;
        private Label lblDonViTinh;
        private NumericUpDown numSoLuongTon;
        private Label lblSoLuongTon;
        private NumericUpDown numDiemCan;
        private Label lblDiemCan;
        private TextBox txtMoTa;
        private Label lblMoTa;
        private TextBox txtTenQua;
        private Label lblTenQua;
        private FlowLayoutPanel flpButtons;
        private Button btnThemMoi;
        private Button btnLuuQua;
        private Button btnNhapKhoQua;
        private Button btnXoaQua;
    }
}