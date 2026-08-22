using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormThuoc
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
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.pnlSearchThuoc = new System.Windows.Forms.Panel();
            this.lblCountThuoc = new System.Windows.Forms.Label();
            this.txtTimKiemThuoc = new System.Windows.Forms.TextBox();
            this.lblSearchThuoc = new System.Windows.Forms.Label();
            this.pnlInfoThuoc = new System.Windows.Forms.Panel();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.lblHanSuDung = new System.Windows.Forms.Label();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.numSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuuThuoc = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnXuatFileThuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.pnlSearchThuoc.SuspendLayout();
            this.pnlInfoThuoc.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.dgvThuoc);
            this.splitContainer.Panel1.Controls.Add(this.pnlSearchThuoc);
            this.splitContainer.Panel1MinSize = 400;
            this.splitContainer.Panel2.Controls.Add(this.pnlInfoThuoc);
            this.splitContainer.Panel2MinSize = 350;
            this.splitContainer.Size = new System.Drawing.Size(950, 620);
            this.splitContainer.SplitterDistance = 560;
            this.splitContainer.TabIndex = 0;

            // dgvThuoc
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(0, 40);
            this.dgvThuoc.MultiSelect = false;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(560, 580);
            this.dgvThuoc.TabIndex = 1;
            this.dgvThuoc.SelectionChanged += new System.EventHandler(this.DgvThuoc_SelectionChanged);

            // pnlSearchThuoc
            this.pnlSearchThuoc.Controls.Add(this.lblCountThuoc);
            this.pnlSearchThuoc.Controls.Add(this.txtTimKiemThuoc);
            this.pnlSearchThuoc.Controls.Add(this.lblSearchThuoc);
            this.pnlSearchThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchThuoc.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchThuoc.Name = "pnlSearchThuoc";
            this.pnlSearchThuoc.Padding = new System.Windows.Forms.Padding(6);
            this.pnlSearchThuoc.Size = new System.Drawing.Size(560, 40);
            this.pnlSearchThuoc.TabIndex = 0;

            // lblCountThuoc
            this.lblCountThuoc.AutoSize = true;
            this.lblCountThuoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountThuoc.Location = new System.Drawing.Point(474, 6);
            this.lblCountThuoc.Name = "lblCountThuoc";
            this.lblCountThuoc.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblCountThuoc.Size = new System.Drawing.Size(80, 19);
            this.lblCountThuoc.TabIndex = 2;
            this.lblCountThuoc.Text = "0 thuốc";
            this.lblCountThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtTimKiemThuoc
            this.txtTimKiemThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemThuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemThuoc.Location = new System.Drawing.Point(76, 6);
            this.txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            this.txtTimKiemThuoc.Size = new System.Drawing.Size(398, 25);
            this.txtTimKiemThuoc.TabIndex = 1;
            this.txtTimKiemThuoc.TextChanged += new System.EventHandler(this.TxtTimKiemThuoc_TextChanged);

            // lblSearchThuoc
            this.lblSearchThuoc.AutoSize = true;
            this.lblSearchThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchThuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchThuoc.Location = new System.Drawing.Point(6, 6);
            this.lblSearchThuoc.Name = "lblSearchThuoc";
            this.lblSearchThuoc.Padding = new System.Windows.Forms.Padding(0, 4, 5, 0);
            this.lblSearchThuoc.Size = new System.Drawing.Size(70, 23);
            this.lblSearchThuoc.TabIndex = 0;
            this.lblSearchThuoc.Text = "Tìm kiếm:";

            // pnlInfoThuoc
            this.pnlInfoThuoc.Controls.Add(this.gbThongTin);
            this.pnlInfoThuoc.Controls.Add(this.flpButtons);
            this.pnlInfoThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoThuoc.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoThuoc.Name = "pnlInfoThuoc";
            this.pnlInfoThuoc.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInfoThuoc.Size = new System.Drawing.Size(386, 620);
            this.pnlInfoThuoc.TabIndex = 0;

            // gbThongTin
            this.gbThongTin.Controls.Add(this.txtMoTa);
            this.gbThongTin.Controls.Add(this.lblMoTa);
            this.gbThongTin.Controls.Add(this.dtpHanSuDung);
            this.gbThongTin.Controls.Add(this.lblHanSuDung);
            this.gbThongTin.Controls.Add(this.txtNhaSanXuat);
            this.gbThongTin.Controls.Add(this.lblNhaSanXuat);
            this.gbThongTin.Controls.Add(this.numSoLuongTon);
            this.gbThongTin.Controls.Add(this.lblSoLuongTon);
            this.gbThongTin.Controls.Add(this.numDonGia);
            this.gbThongTin.Controls.Add(this.lblDonGia);
            this.gbThongTin.Controls.Add(this.txtDonViTinh);
            this.gbThongTin.Controls.Add(this.lblDonViTinh);
            this.gbThongTin.Controls.Add(this.txtTenThuoc);
            this.gbThongTin.Controls.Add(this.lblTenThuoc);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbThongTin.Location = new System.Drawing.Point(10, 10);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.gbThongTin.Size = new System.Drawing.Size(366, 475);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin thuốc";

            // txtMoTa
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Location = new System.Drawing.Point(8, 360);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(350, 107);
            this.txtMoTa.TabIndex = 13;

            // lblMoTa
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMoTa.Location = new System.Drawing.Point(8, 339);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblMoTa.Size = new System.Drawing.Size(46, 21);
            this.lblMoTa.TabIndex = 12;
            this.lblMoTa.Text = "Mô tả:";

            // dtpHanSuDung
            this.dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpHanSuDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSuDung.Location = new System.Drawing.Point(8, 315);
            this.dtpHanSuDung.MinDate = new System.DateTime(2020, 1, 1);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(350, 24);
            this.dtpHanSuDung.TabIndex = 11;

            // lblHanSuDung
            this.lblHanSuDung.AutoSize = true;
            this.lblHanSuDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHanSuDung.Location = new System.Drawing.Point(8, 294);
            this.lblHanSuDung.Name = "lblHanSuDung";
            this.lblHanSuDung.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblHanSuDung.Size = new System.Drawing.Size(86, 21);
            this.lblHanSuDung.TabIndex = 10;
            this.lblHanSuDung.Text = "Hạn sử dụng:";

            // txtNhaSanXuat
            this.txtNhaSanXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(8, 270);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(350, 24);
            this.txtNhaSanXuat.TabIndex = 9;

            // lblNhaSanXuat
            this.lblNhaSanXuat.AutoSize = true;
            this.lblNhaSanXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhaSanXuat.Location = new System.Drawing.Point(8, 249);
            this.lblNhaSanXuat.Name = "lblNhaSanXuat";
            this.lblNhaSanXuat.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblNhaSanXuat.Size = new System.Drawing.Size(89, 21);
            this.lblNhaSanXuat.TabIndex = 8;
            this.lblNhaSanXuat.Text = "Nhà sản xuất:";

            // numSoLuongTon
            this.numSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.numSoLuongTon.Location = new System.Drawing.Point(8, 225);
            this.numSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numSoLuongTon.Name = "numSoLuongTon";
            this.numSoLuongTon.Size = new System.Drawing.Size(350, 24);
            this.numSoLuongTon.TabIndex = 7;
            this.numSoLuongTon.ThousandsSeparator = true;

            // lblSoLuongTon
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoLuongTon.Location = new System.Drawing.Point(8, 204);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblSoLuongTon.Size = new System.Drawing.Size(59, 21);
            this.lblSoLuongTon.TabIndex = 6;
            this.lblSoLuongTon.Text = "Tồn kho:";

            // numDonGia
            this.numDonGia.DecimalPlaces = 0;
            this.numDonGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.numDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numDonGia.Location = new System.Drawing.Point(8, 180);
            this.numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(350, 24);
            this.numDonGia.TabIndex = 5;
            this.numDonGia.ThousandsSeparator = true;

            // lblDonGia
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDonGia.Location = new System.Drawing.Point(8, 159);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDonGia.Size = new System.Drawing.Size(95, 21);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá (VNĐ):";

            // txtDonViTinh
            this.txtDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonViTinh.Location = new System.Drawing.Point(8, 135);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(350, 24);
            this.txtDonViTinh.TabIndex = 3;

            // lblDonViTinh
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDonViTinh.Location = new System.Drawing.Point(8, 114);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDonViTinh.Size = new System.Drawing.Size(75, 21);
            this.lblDonViTinh.TabIndex = 2;
            this.lblDonViTinh.Text = "Đơn vị tính:";

            // txtTenThuoc
            this.txtTenThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenThuoc.Location = new System.Drawing.Point(8, 90);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(350, 24);
            this.txtTenThuoc.TabIndex = 1;

            // lblTenThuoc
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenThuoc.Location = new System.Drawing.Point(8, 69);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblTenThuoc.Size = new System.Drawing.Size(68, 21);
            this.lblTenThuoc.TabIndex = 0;
            this.lblTenThuoc.Text = "Tên thuốc:";

            // flpButtons
            this.flpButtons.Controls.Add(this.btnThemMoi);
            this.flpButtons.Controls.Add(this.btnLuuThuoc);
            this.flpButtons.Controls.Add(this.btnNhapKho);
            this.flpButtons.Controls.Add(this.btnXoaThuoc);
            this.flpButtons.Controls.Add(this.btnXuatFileThuoc);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.Location = new System.Drawing.Point(10, 485);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(2);
            this.flpButtons.Size = new System.Drawing.Size(366, 125);
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
            this.btnThemMoi.Size = new System.Drawing.Size(170, 34);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "🆕 Làm mới form";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.BtnThemMoi_Click);

            // btnLuuThuoc
            this.btnLuuThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLuuThuoc.FlatAppearance.BorderSize = 0;
            this.btnLuuThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuThuoc.ForeColor = System.Drawing.Color.White;
            this.btnLuuThuoc.Location = new System.Drawing.Point(181, 5);
            this.btnLuuThuoc.Margin = new System.Windows.Forms.Padding(3);
            this.btnLuuThuoc.Name = "btnLuuThuoc";
            this.btnLuuThuoc.Size = new System.Drawing.Size(170, 34);
            this.btnLuuThuoc.TabIndex = 1;
            this.btnLuuThuoc.Text = "💾 Lưu thuốc";
            this.btnLuuThuoc.UseVisualStyleBackColor = false;
            this.btnLuuThuoc.Click += new System.EventHandler(this.BtnLuuThuoc_Click);

            // btnNhapKho
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(5, 45);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(3);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(170, 34);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "📦 Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.BtnNhapKho_Click);

            // btnXoaThuoc
            this.btnXoaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaThuoc.FlatAppearance.BorderSize = 0;
            this.btnXoaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.White;
            this.btnXoaThuoc.Location = new System.Drawing.Point(181, 45);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(170, 34);
            this.btnXoaThuoc.TabIndex = 3;
            this.btnXoaThuoc.Text = "🗑️ Xóa thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.BtnXoaThuoc_Click);

            // btnXuatFileThuoc
            this.btnXuatFileThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnXuatFileThuoc.FlatAppearance.BorderSize = 0;
            this.btnXuatFileThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnXuatFileThuoc.ForeColor = System.Drawing.Color.White;
            this.btnXuatFileThuoc.Location = new System.Drawing.Point(5, 85);
            this.btnXuatFileThuoc.Margin = new System.Windows.Forms.Padding(3);
            this.btnXuatFileThuoc.Name = "btnXuatFileThuoc";
            this.btnXuatFileThuoc.Size = new System.Drawing.Size(346, 34);
            this.btnXuatFileThuoc.TabIndex = 4;
            this.btnXuatFileThuoc.Text = "📤 Xuất danh sách (CSV)";
            this.btnXuatFileThuoc.UseVisualStyleBackColor = false;
            this.btnXuatFileThuoc.Click += new System.EventHandler(this.BtnXuatFileThuoc_Click);

            // FormThuoc
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FormThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý kho thuốc";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.pnlSearchThuoc.ResumeLayout(false);
            this.pnlSearchThuoc.PerformLayout();
            this.pnlInfoThuoc.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private SplitContainer splitContainer;
        private DataGridView dgvThuoc;
        private Panel pnlSearchThuoc;
        private Label lblCountThuoc;
        private TextBox txtTimKiemThuoc;
        private Label lblSearchThuoc;
        private Panel pnlInfoThuoc;
        private GroupBox gbThongTin;
        private TextBox txtMoTa;
        private Label lblMoTa;
        private DateTimePicker dtpHanSuDung;
        private Label lblHanSuDung;
        private TextBox txtNhaSanXuat;
        private Label lblNhaSanXuat;
        private NumericUpDown numSoLuongTon;
        private Label lblSoLuongTon;
        private NumericUpDown numDonGia;
        private Label lblDonGia;
        private TextBox txtDonViTinh;
        private Label lblDonViTinh;
        private TextBox txtTenThuoc;
        private Label lblTenThuoc;
        private FlowLayoutPanel flpButtons;
        private Button btnThemMoi;
        private Button btnLuuThuoc;
        private Button btnNhapKho;
        private Button btnXoaThuoc;
        private Button btnXuatFileThuoc;
    }
}