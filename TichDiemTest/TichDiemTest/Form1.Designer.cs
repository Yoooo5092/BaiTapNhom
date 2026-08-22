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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnThemKHQuick = new System.Windows.Forms.ToolStripButton();
            this.btnSuaKHQuick = new System.Windows.Forms.ToolStripButton();
            this.btnLichSuQuick = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuanLyThuoc = new System.Windows.Forms.ToolStripButton();
            this.btnQuanLyQua = new System.Windows.Forms.ToolStripButton();
            this.btnLamMoiAll = new System.Windows.Forms.ToolStripButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBanThuoc = new System.Windows.Forms.TabPage();
            this.splitContainerTong = new System.Windows.Forms.SplitContainer();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.dgvKHBan = new System.Windows.Forms.DataGridView();
            this.cmsKhachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlKHTop = new System.Windows.Forms.Panel();
            this.lblCountKHBan = new System.Windows.Forms.Label();
            this.txtTimKiemKHBan = new System.Windows.Forms.TextBox();
            this.lblKHTitle = new System.Windows.Forms.Label();
            this.splitContainerPhai = new System.Windows.Forms.SplitContainer();
            this.pnlThuocBan = new System.Windows.Forms.Panel();
            this.dgvThuocBan = new System.Windows.Forms.DataGridView();
            this.pnlThuocAction = new System.Windows.Forms.Panel();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongBan = new System.Windows.Forms.Label();
            this.lblThuocBanInfo = new System.Windows.Forms.Label();
            this.pnlThuocTop = new System.Windows.Forms.Panel();
            this.lblCountThuocBan = new System.Windows.Forms.Label();
            this.txtTimKiemThuocBan = new System.Windows.Forms.TextBox();
            this.lblThuocTitle = new System.Windows.Forms.Label();
            this.pnlGioHang = new System.Windows.Forms.Panel();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlThanhToanBan = new System.Windows.Forms.Panel();
            this.lblDiemSauBan = new System.Windows.Forms.Label();
            this.lblDiemCongBan = new System.Windows.Forms.Label();
            this.lblTongTienBan = new System.Windows.Forms.Label();
            this.pnlGioButtons = new System.Windows.Forms.Panel();
            this.btnXoaGio = new System.Windows.Forms.Button();
            this.btnThanhToanBan = new System.Windows.Forms.Button();
            this.pnlKHInfoBanner = new System.Windows.Forms.Panel();
            this.lblKHBanInfo = new System.Windows.Forms.Label();
            this.tabDoiQua = new System.Windows.Forms.TabPage();
            this.splitContainerDoiQua = new System.Windows.Forms.SplitContainer();
            this.pnlKHQua = new System.Windows.Forms.Panel();
            this.dgvKHQua = new System.Windows.Forms.DataGridView();
            this.pnlSearchKHQua = new System.Windows.Forms.Panel();
            this.txtTimKiemKHQua = new System.Windows.Forms.TextBox();
            this.lblKHQuaTitle = new System.Windows.Forms.Label();
            this.pnlQuaDoi = new System.Windows.Forms.Panel();
            this.dgvQuaDoi = new System.Windows.Forms.DataGridView();
            this.pnlQuaAction = new System.Windows.Forms.Panel();
            this.btnDoiQuaXacNhan = new System.Windows.Forms.Button();
            this.numSoLuongQua = new System.Windows.Forms.NumericUpDown();
            this.lblSLQua = new System.Windows.Forms.Label();
            this.lblQuaDoiInfo = new System.Windows.Forms.Label();
            this.pnlQuaTop = new System.Windows.Forms.Panel();
            this.lblCountQuaDoi = new System.Windows.Forms.Label();
            this.lblKHQuaInfo = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.pnlThongKeCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTongKH = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.lblSoDonHomNay = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblDoanhThuThangNay = new System.Windows.Forms.Label();
            this.lblSoDonThangNay = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.pnlCard5 = new System.Windows.Forms.Panel();
            this.lblThuocSapHet = new System.Windows.Forms.Label();
            this.lblCard5Title = new System.Windows.Forms.Label();
            this.pnlCard6 = new System.Windows.Forms.Panel();
            this.lblQuaSapHet = new System.Windows.Forms.Label();
            this.lblCard6Title = new System.Windows.Forms.Label();
            this.pnlThongKeBottom = new System.Windows.Forms.Panel();
            this.btnXemBaoCaoChiTiet = new System.Windows.Forms.Button();
            this.tsMain.SuspendLayout();
            this.ss.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBanThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTong)).BeginInit();
            this.splitContainerTong.Panel1.SuspendLayout();
            this.splitContainerTong.Panel2.SuspendLayout();
            this.splitContainerTong.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHBan)).BeginInit();
            this.pnlKHTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhai)).BeginInit();
            this.splitContainerPhai.Panel1.SuspendLayout();
            this.splitContainerPhai.Panel2.SuspendLayout();
            this.splitContainerPhai.SuspendLayout();
            this.pnlThuocBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocBan)).BeginInit();
            this.pnlThuocAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).BeginInit();
            this.pnlThuocTop.SuspendLayout();
            this.pnlGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlThanhToanBan.SuspendLayout();
            this.pnlGioButtons.SuspendLayout();
            this.pnlKHInfoBanner.SuspendLayout();
            this.tabDoiQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDoiQua)).BeginInit();
            this.splitContainerDoiQua.Panel1.SuspendLayout();
            this.splitContainerDoiQua.Panel2.SuspendLayout();
            this.splitContainerDoiQua.SuspendLayout();
            this.pnlKHQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHQua)).BeginInit();
            this.pnlSearchKHQua.SuspendLayout();
            this.pnlQuaDoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaDoi)).BeginInit();
            this.pnlQuaAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongQua)).BeginInit();
            this.pnlQuaTop.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.pnlThongKeCards.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard5.SuspendLayout();
            this.pnlCard6.SuspendLayout();
            this.pnlThongKeBottom.SuspendLayout();
            this.SuspendLayout();

            // tsMain
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnThemKHQuick,
                this.btnSuaKHQuick,
                this.btnLichSuQuick,
                this.toolStripSeparator1,
                this.btnQuanLyThuoc,
                this.btnQuanLyQua,
                this.btnLamMoiAll
            });
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tsMain.Size = new System.Drawing.Size(1200, 35);
            this.tsMain.TabIndex = 0;

            // btnThemKHQuick
            this.btnThemKHQuick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemKHQuick.Name = "btnThemKHQuick";
            this.btnThemKHQuick.Size = new System.Drawing.Size(124, 24);
            this.btnThemKHQuick.Text = "➕ Thêm khách";
            this.btnThemKHQuick.Click += new System.EventHandler(this.btnThemKHQuick_Click);

            // btnSuaKHQuick
            this.btnSuaKHQuick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaKHQuick.Name = "btnSuaKHQuick";
            this.btnSuaKHQuick.Size = new System.Drawing.Size(113, 24);
            this.btnSuaKHQuick.Text = "✏️ Sửa khách";
            this.btnSuaKHQuick.Click += new System.EventHandler(this.btnSuaKHQuick_Click);

            // btnLichSuQuick
            this.btnLichSuQuick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLichSuQuick.Name = "btnLichSuQuick";
            this.btnLichSuQuick.Size = new System.Drawing.Size(129, 24);
            this.btnLichSuQuick.Text = "📜 Lịch sử GD";
            this.btnLichSuQuick.Click += new System.EventHandler(this.btnLichSuQuick_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);

            // btnQuanLyThuoc
            this.btnQuanLyThuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(139, 24);
            this.btnQuanLyThuoc.Text = "💊 Kho Thuốc";
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);

            // btnQuanLyQua
            this.btnQuanLyQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuanLyQua.Name = "btnQuanLyQua";
            this.btnQuanLyQua.Size = new System.Drawing.Size(130, 24);
            this.btnQuanLyQua.Text = "🎁 Kho Quà";
            this.btnQuanLyQua.Click += new System.EventHandler(this.btnQuanLyQua_Click);

            // btnLamMoiAll
            this.btnLamMoiAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLamMoiAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoiAll.Name = "btnLamMoiAll";
            this.btnLamMoiAll.Size = new System.Drawing.Size(107, 24);
            this.btnLamMoiAll.Text = "🔄 Làm mới";
            this.btnLamMoiAll.Click += new System.EventHandler(this.btnLamMoiAll_Click);

            // ss
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatus
            });
            this.ss.Location = new System.Drawing.Point(0, 698);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(1200, 22);
            this.ss.TabIndex = 1;

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Sẵn sàng";

            // tabControl
            this.tabControl.Controls.Add(this.tabBanThuoc);
            this.tabControl.Controls.Add(this.tabDoiQua);
            this.tabControl.Controls.Add(this.tabThongKe);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ItemSize = new System.Drawing.Size(220, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 663);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;

            // tabBanThuoc
            this.tabBanThuoc.Controls.Add(this.splitContainerTong);
            this.tabBanThuoc.Location = new System.Drawing.Point(4, 39);
            this.tabBanThuoc.Name = "tabBanThuoc";
            this.tabBanThuoc.Padding = new System.Windows.Forms.Padding(6);
            this.tabBanThuoc.Size = new System.Drawing.Size(1192, 620);
            this.tabBanThuoc.TabIndex = 0;
            this.tabBanThuoc.Text = "💊 Bán thuốc & Khách hàng";
            this.tabBanThuoc.UseVisualStyleBackColor = true;

            // splitContainerTong
            this.splitContainerTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTong.Location = new System.Drawing.Point(6, 6);
            this.splitContainerTong.Name = "splitContainerTong";
            this.splitContainerTong.Panel1.Controls.Add(this.pnlKhachHang);
            this.splitContainerTong.Panel1MinSize = 280;
            this.splitContainerTong.Panel2.Controls.Add(this.splitContainerPhai);
            this.splitContainerTong.Panel2MinSize = 650;
            this.splitContainerTong.Size = new System.Drawing.Size(1180, 608);
            this.splitContainerTong.SplitterDistance = 330;
            this.splitContainerTong.TabIndex = 0;

            // pnlKhachHang
            this.pnlKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhachHang.Controls.Add(this.dgvKHBan);
            this.pnlKhachHang.Controls.Add(this.pnlKHTop);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(330, 608);
            this.pnlKhachHang.TabIndex = 0;

            // dgvKHBan
            this.dgvKHBan.AllowUserToAddRows = false;
            this.dgvKHBan.AllowUserToDeleteRows = false;
            this.dgvKHBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKHBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvKHBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHBan.ContextMenuStrip = this.cmsKhachHang;
            this.dgvKHBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHBan.Location = new System.Drawing.Point(0, 70);
            this.dgvKHBan.MultiSelect = false;
            this.dgvKHBan.Name = "dgvKHBan";
            this.dgvKHBan.ReadOnly = true;
            this.dgvKHBan.RowHeadersVisible = false;
            this.dgvKHBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKHBan.Size = new System.Drawing.Size(328, 536);
            this.dgvKHBan.TabIndex = 1;
            this.dgvKHBan.SelectionChanged += new System.EventHandler(this.DgvKHBan_SelectionChanged);
            this.dgvKHBan.DoubleClick += new System.EventHandler(this.DgvKHBan_DoubleClick);



            // cmsKhachHang
            this.cmsKhachHang.Name = "cmsKhachHang";
            this.cmsKhachHang.Size = new System.Drawing.Size(61, 4);

            // pnlKHTop
            this.pnlKHTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlKHTop.Controls.Add(this.lblCountKHBan);
            this.pnlKHTop.Controls.Add(this.txtTimKiemKHBan);
            this.pnlKHTop.Controls.Add(this.lblKHTitle);
            this.pnlKHTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKHTop.Location = new System.Drawing.Point(0, 0);
            this.pnlKHTop.Name = "pnlKHTop";
            this.pnlKHTop.Padding = new System.Windows.Forms.Padding(8);
            this.pnlKHTop.Size = new System.Drawing.Size(328, 70);
            this.pnlKHTop.TabIndex = 0;

            // lblCountKHBan
            this.lblCountKHBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountKHBan.AutoSize = true;
            this.lblCountKHBan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCountKHBan.ForeColor = System.Drawing.Color.Gray;
            this.lblCountKHBan.Location = new System.Drawing.Point(260, 11);
            this.lblCountKHBan.Name = "lblCountKHBan";
            this.lblCountKHBan.Size = new System.Drawing.Size(46, 15);
            this.lblCountKHBan.TabIndex = 2;
            this.lblCountKHBan.Text = "0 khách";

            // txtTimKiemKHBan
            this.txtTimKiemKHBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiemKHBan.Location = new System.Drawing.Point(8, 37);
            this.txtTimKiemKHBan.Name = "txtTimKiemKHBan";
            this.txtTimKiemKHBan.Size = new System.Drawing.Size(312, 25);
            this.txtTimKiemKHBan.TabIndex = 1;
            this.txtTimKiemKHBan.TextChanged += new System.EventHandler(this.TxtTimKiemKHBan_TextChanged);

            // lblKHTitle
            this.lblKHTitle.AutoSize = true;
            this.lblKHTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKHTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblKHTitle.Location = new System.Drawing.Point(5, 8);
            this.lblKHTitle.Name = "lblKHTitle";
            this.lblKHTitle.Size = new System.Drawing.Size(123, 19);
            this.lblKHTitle.TabIndex = 0;
            this.lblKHTitle.Text = "👥 KHÁCH HÀNG";

            // splitContainerPhai
            this.splitContainerPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPhai.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPhai.Name = "splitContainerPhai";
            this.splitContainerPhai.Panel1.Controls.Add(this.pnlThuocBan);
            this.splitContainerPhai.Panel1MinSize = 350;
            this.splitContainerPhai.Panel2.Controls.Add(this.pnlGioHang);
            this.splitContainerPhai.Panel2MinSize = 320;
            this.splitContainerPhai.Size = new System.Drawing.Size(846, 608);
            this.splitContainerPhai.SplitterDistance = 440;
            this.splitContainerPhai.TabIndex = 0;

            // pnlThuocBan
            this.pnlThuocBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThuocBan.Controls.Add(this.dgvThuocBan);
            this.pnlThuocAction = new System.Windows.Forms.Panel();
            this.pnlThuocBan.Controls.Add(this.pnlThuocAction);
            this.pnlThuocBan.Controls.Add(this.pnlThuocTop);
            this.pnlThuocBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThuocBan.Location = new System.Drawing.Point(0, 0);
            this.pnlThuocBan.Name = "pnlThuocBan";
            this.pnlThuocBan.Size = new System.Drawing.Size(440, 608);
            this.pnlThuocBan.TabIndex = 0;

            // dgvThuocBan
            this.dgvThuocBan.AllowUserToAddRows = false;
            this.dgvThuocBan.AllowUserToDeleteRows = false;
            this.dgvThuocBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuocBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuocBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuocBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuocBan.Location = new System.Drawing.Point(0, 70);
            this.dgvThuocBan.MultiSelect = false;
            this.dgvThuocBan.Name = "dgvThuocBan";
            this.dgvThuocBan.ReadOnly = true;
            this.dgvThuocBan.RowHeadersVisible = false;
            this.dgvThuocBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuocBan.Size = new System.Drawing.Size(438, 466);
            this.dgvThuocBan.TabIndex = 1;
            this.dgvThuocBan.SelectionChanged += new System.EventHandler(this.DgvThuocBan_SelectionChanged);

            // pnlThuocAction
            this.pnlThuocAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlThuocAction.Controls.Add(this.btnThemVaoGio);
            this.pnlThuocAction.Controls.Add(this.numSoLuongBan);
            this.pnlThuocAction.Controls.Add(this.lblSoLuongBan);
            this.pnlThuocAction.Controls.Add(this.lblThuocBanInfo);
            this.pnlThuocAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThuocAction.Location = new System.Drawing.Point(0, 536);
            this.pnlThuocAction.Name = "pnlThuocAction";
            this.pnlThuocAction.Padding = new System.Windows.Forms.Padding(8);
            this.pnlThuocAction.Size = new System.Drawing.Size(438, 70);
            this.pnlThuocAction.TabIndex = 2;

            // btnThemVaoGio
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnThemVaoGio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemVaoGio.Enabled = false;
            this.btnThemVaoGio.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(310, 8);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(120, 54);
            this.btnThemVaoGio.TabIndex = 3;
            this.btnThemVaoGio.Text = "➕ Thêm giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.BtnThemVaoGio_Click);

            // numSoLuongBan
            this.numSoLuongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numSoLuongBan.Location = new System.Drawing.Point(225, 27);
            this.numSoLuongBan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongBan.Name = "numSoLuongBan";
            this.numSoLuongBan.Size = new System.Drawing.Size(75, 27);
            this.numSoLuongBan.TabIndex = 2;
            this.numSoLuongBan.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblSoLuongBan
            this.lblSoLuongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuongBan.AutoSize = true;
            this.lblSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuongBan.Location = new System.Drawing.Point(225, 8);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuongBan.TabIndex = 1;
            this.lblSoLuongBan.Text = "Số lượng:";

            // lblThuocBanInfo
            this.lblThuocBanInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblThuocBanInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThuocBanInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblThuocBanInfo.Location = new System.Drawing.Point(8, 8);
            this.lblThuocBanInfo.Name = "lblThuocBanInfo";
            this.lblThuocBanInfo.Size = new System.Drawing.Size(200, 54);
            this.lblThuocBanInfo.TabIndex = 0;
            this.lblThuocBanInfo.Text = "Chọn thuốc từ danh sách";
            this.lblThuocBanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlThuocTop
            this.pnlThuocTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlThuocTop.Controls.Add(this.lblCountThuocBan);
            this.pnlThuocTop.Controls.Add(this.txtTimKiemThuocBan);
            this.pnlThuocTop.Controls.Add(this.lblThuocTitle);
            this.pnlThuocTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThuocTop.Location = new System.Drawing.Point(0, 0);
            this.pnlThuocTop.Name = "pnlThuocTop";
            this.pnlThuocTop.Padding = new System.Windows.Forms.Padding(8);
            this.pnlThuocTop.Size = new System.Drawing.Size(438, 70);
            this.pnlThuocTop.TabIndex = 0;

            // lblCountThuocBan
            this.lblCountThuocBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountThuocBan.AutoSize = true;
            this.lblCountThuocBan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCountThuocBan.ForeColor = System.Drawing.Color.Gray;
            this.lblCountThuocBan.Location = new System.Drawing.Point(370, 11);
            this.lblCountThuocBan.Name = "lblCountThuocBan";
            this.lblCountThuocBan.Size = new System.Drawing.Size(48, 15);
            this.lblCountThuocBan.TabIndex = 2;
            this.lblCountThuocBan.Text = "0 thuốc";

            // txtTimKiemThuocBan
            this.txtTimKiemThuocBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiemThuocBan.Location = new System.Drawing.Point(8, 37);
            this.txtTimKiemThuocBan.Name = "txtTimKiemThuocBan";
            this.txtTimKiemThuocBan.Size = new System.Drawing.Size(422, 25);
            this.txtTimKiemThuocBan.TabIndex = 1;
            this.txtTimKiemThuocBan.TextChanged += new System.EventHandler(this.TxtTimKiemThuocBan_TextChanged);

            // lblThuocTitle
            this.lblThuocTitle.AutoSize = true;
            this.lblThuocTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThuocTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblThuocTitle.Location = new System.Drawing.Point(5, 8);
            this.lblThuocTitle.Name = "lblThuocTitle";
            this.lblThuocTitle.Size = new System.Drawing.Size(123, 19);
            this.lblThuocTitle.TabIndex = 0;
            this.lblThuocTitle.Text = "💊 KHO THUỐC";

            // pnlGioHang
            this.pnlGioHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGioHang.Controls.Add(this.dgvGioHang);
            this.pnlGioHang.Controls.Add(this.pnlThanhToanBan);
            this.pnlGioHang.Controls.Add(this.pnlKHInfoBanner);
            this.pnlGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGioHang.Location = new System.Drawing.Point(0, 0);
            this.pnlGioHang.Name = "pnlGioHang";
            this.pnlGioHang.Size = new System.Drawing.Size(402, 608);
            this.pnlGioHang.TabIndex = 0;

            // dgvGioHang
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 50);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(400, 416);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGioHang_CellDoubleClick);

            // pnlThanhToanBan
            this.pnlThanhToanBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThanhToanBan.Controls.Add(this.lblDiemSauBan);
            this.pnlThanhToanBan.Controls.Add(this.lblDiemCongBan);
            this.pnlThanhToanBan.Controls.Add(this.lblTongTienBan);
            this.pnlThanhToanBan.Controls.Add(this.pnlGioButtons);
            this.pnlThanhToanBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThanhToanBan.Location = new System.Drawing.Point(0, 466);
            this.pnlThanhToanBan.Name = "pnlThanhToanBan";
            this.pnlThanhToanBan.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThanhToanBan.Size = new System.Drawing.Size(400, 140);
            this.pnlThanhToanBan.TabIndex = 2;

            // lblDiemSauBan
            this.lblDiemSauBan.AutoSize = true;
            this.lblDiemSauBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDiemSauBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDiemSauBan.Location = new System.Drawing.Point(10, 58);
            this.lblDiemSauBan.Name = "lblDiemSauBan";
            this.lblDiemSauBan.Size = new System.Drawing.Size(89, 15);
            this.lblDiemSauBan.TabIndex = 2;
            this.lblDiemSauBan.Text = "Điểm sau GD: 0";

            // lblDiemCongBan
            this.lblDiemCongBan.AutoSize = true;
            this.lblDiemCongBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiemCongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDiemCongBan.Location = new System.Drawing.Point(10, 36);
            this.lblDiemCongBan.Name = "lblDiemCongBan";
            this.lblDiemCongBan.Size = new System.Drawing.Size(95, 17);
            this.lblDiemCongBan.TabIndex = 1;
            this.lblDiemCongBan.Text = "Điểm cộng: +0";

            // lblTongTienBan
            this.lblTongTienBan.AutoSize = true;
            this.lblTongTienBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTienBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongTienBan.Location = new System.Drawing.Point(10, 10);
            this.lblTongTienBan.Name = "lblTongTienBan";
            this.lblTongTienBan.Size = new System.Drawing.Size(107, 21);
            this.lblTongTienBan.TabIndex = 0;
            this.lblTongTienBan.Text = "Tổng: 0 VNĐ";

            // pnlGioButtons
            this.pnlGioButtons.Controls.Add(this.btnXoaGio);
            this.pnlGioButtons.Controls.Add(this.btnThanhToanBan);
            this.pnlGioButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGioButtons.Location = new System.Drawing.Point(10, 84);
            this.pnlGioButtons.Name = "pnlGioButtons";
            this.pnlGioButtons.Size = new System.Drawing.Size(380, 46);
            this.pnlGioButtons.TabIndex = 3;

            // btnXoaGio
            this.btnXoaGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaGio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoaGio.FlatAppearance.BorderSize = 0;
            this.btnXoaGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaGio.Location = new System.Drawing.Point(0, 0);
            this.btnXoaGio.Name = "btnXoaGio";
            this.btnXoaGio.Size = new System.Drawing.Size(90, 46);
            this.btnXoaGio.TabIndex = 1;
            this.btnXoaGio.Text = "🗑️ Hủy giỏ";
            this.btnXoaGio.UseVisualStyleBackColor = false;
            this.btnXoaGio.Click += new System.EventHandler(this.BtnXoaGio_Click);

            // btnThanhToanBan
            this.btnThanhToanBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThanhToanBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThanhToanBan.Enabled = false;
            this.btnThanhToanBan.FlatAppearance.BorderSize = 0;
            this.btnThanhToanBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToanBan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanBan.Location = new System.Drawing.Point(98, 0);
            this.btnThanhToanBan.Name = "btnThanhToanBan";
            this.btnThanhToanBan.Size = new System.Drawing.Size(282, 46);
            this.btnThanhToanBan.TabIndex = 0;
            this.btnThanhToanBan.Text = "💳 THANH TOÁN (TÍCH ĐIỂM)";
            this.btnThanhToanBan.UseVisualStyleBackColor = false;
            this.btnThanhToanBan.Click += new System.EventHandler(this.BtnThanhToanBan_Click);

            // pnlKHInfoBanner
            this.pnlKHInfoBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlKHInfoBanner.Controls.Add(this.lblKHBanInfo);
            this.pnlKHInfoBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKHInfoBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlKHInfoBanner.Name = "pnlKHInfoBanner";
            this.pnlKHInfoBanner.Padding = new System.Windows.Forms.Padding(8);
            this.pnlKHInfoBanner.Size = new System.Drawing.Size(400, 50);
            this.pnlKHInfoBanner.TabIndex = 0;

            // lblKHBanInfo
            this.lblKHBanInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKHBanInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKHBanInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblKHBanInfo.Location = new System.Drawing.Point(8, 8);
            this.lblKHBanInfo.Name = "lblKHBanInfo";
            this.lblKHBanInfo.Size = new System.Drawing.Size(384, 34);
            this.lblKHBanInfo.TabIndex = 0;
            this.lblKHBanInfo.Text = "👉 Vui lòng chọn khách hàng";
            this.lblKHBanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // tabDoiQua
            this.tabDoiQua.Controls.Add(this.splitContainerDoiQua);
            this.tabDoiQua.Location = new System.Drawing.Point(4, 39);
            this.tabDoiQua.Name = "tabDoiQua";
            this.tabDoiQua.Padding = new System.Windows.Forms.Padding(6);
            this.tabDoiQua.Size = new System.Drawing.Size(1192, 620);
            this.tabDoiQua.TabIndex = 1;
            this.tabDoiQua.Text = "🎁 Đổi quà tặng";
            this.tabDoiQua.UseVisualStyleBackColor = true;

            // splitContainerDoiQua
            this.splitContainerDoiQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDoiQua.Location = new System.Drawing.Point(6, 6);
            this.splitContainerDoiQua.Name = "splitContainerDoiQua";
            this.splitContainerDoiQua.Panel1.Controls.Add(this.pnlKHQua);
            this.splitContainerDoiQua.Panel1MinSize = 350;
            this.splitContainerDoiQua.Panel2.Controls.Add(this.pnlQuaDoi);
            this.splitContainerDoiQua.Panel2MinSize = 450;
            this.splitContainerDoiQua.Size = new System.Drawing.Size(1180, 608);
            this.splitContainerDoiQua.SplitterDistance = 450;
            this.splitContainerDoiQua.TabIndex = 0;

            // pnlKHQua
            this.pnlKHQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKHQua.Controls.Add(this.dgvKHQua);
            this.pnlKHQua.Controls.Add(this.pnlSearchKHQua);
            this.pnlKHQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKHQua.Location = new System.Drawing.Point(0, 0);
            this.pnlKHQua.Name = "pnlKHQua";
            this.pnlKHQua.Size = new System.Drawing.Size(450, 608);
            this.pnlKHQua.TabIndex = 0;

            // dgvKHQua
            this.dgvKHQua.AllowUserToAddRows = false;
            this.dgvKHQua.AllowUserToDeleteRows = false;
            this.dgvKHQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKHQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKHQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHQua.Location = new System.Drawing.Point(0, 70);
            this.dgvKHQua.MultiSelect = false;
            this.dgvKHQua.Name = "dgvKHQua";
            this.dgvKHQua.ReadOnly = true;
            this.dgvKHQua.RowHeadersVisible = false;
            this.dgvKHQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKHQua.Size = new System.Drawing.Size(448, 536);
            this.dgvKHQua.TabIndex = 1;
            this.dgvKHQua.SelectionChanged += new System.EventHandler(this.DgvKHQua_SelectionChanged);

            // pnlSearchKHQua
            this.pnlSearchKHQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlSearchKHQua.Controls.Add(this.txtTimKiemKHQua);
            this.pnlSearchKHQua.Controls.Add(this.lblKHQuaTitle);
            this.pnlSearchKHQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchKHQua.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchKHQua.Name = "pnlSearchKHQua";
            this.pnlSearchKHQua.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSearchKHQua.Size = new System.Drawing.Size(448, 70);
            this.pnlSearchKHQua.TabIndex = 0;

            // txtTimKiemKHQua
            this.txtTimKiemKHQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiemKHQua.Location = new System.Drawing.Point(8, 37);
            this.txtTimKiemKHQua.Name = "txtTimKiemKHQua";
            this.txtTimKiemKHQua.Size = new System.Drawing.Size(432, 25);
            this.txtTimKiemKHQua.TabIndex = 1;
            this.txtTimKiemKHQua.TextChanged += new System.EventHandler(this.TxtTimKiemKHQua_TextChanged);

            // lblKHQuaTitle
            this.lblKHQuaTitle.AutoSize = true;
            this.lblKHQuaTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKHQuaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblKHQuaTitle.Location = new System.Drawing.Point(5, 8);
            this.lblKHQuaTitle.Name = "lblKHQuaTitle";
            this.lblKHQuaTitle.Size = new System.Drawing.Size(189, 19);
            this.lblKHQuaTitle.TabIndex = 0;
            this.lblKHQuaTitle.Text = "1. CHỌN KHÁCH ĐỔI QUÀ";

            // pnlQuaDoi
            this.pnlQuaDoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuaDoi.Controls.Add(this.dgvQuaDoi);
            this.pnlQuaDoi.Controls.Add(this.pnlQuaAction);
            this.pnlQuaDoi.Controls.Add(this.pnlQuaTop);
            this.pnlQuaDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuaDoi.Location = new System.Drawing.Point(0, 0);
            this.pnlQuaDoi.Name = "pnlQuaDoi";
            this.pnlQuaDoi.Size = new System.Drawing.Size(726, 608);
            this.pnlQuaDoi.TabIndex = 0;

            // dgvQuaDoi
            this.dgvQuaDoi.AllowUserToAddRows = false;
            this.dgvQuaDoi.AllowUserToDeleteRows = false;
            this.dgvQuaDoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuaDoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuaDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuaDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuaDoi.Location = new System.Drawing.Point(0, 70);
            this.dgvQuaDoi.MultiSelect = false;
            this.dgvQuaDoi.Name = "dgvQuaDoi";
            this.dgvQuaDoi.ReadOnly = true;
            this.dgvQuaDoi.RowHeadersVisible = false;
            this.dgvQuaDoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuaDoi.Size = new System.Drawing.Size(724, 466);
            this.dgvQuaDoi.TabIndex = 1;
            this.dgvQuaDoi.SelectionChanged += new System.EventHandler(this.DgvQuaDoi_SelectionChanged);

            // pnlQuaAction
            this.pnlQuaAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlQuaAction.Controls.Add(this.btnDoiQuaXacNhan);
            this.pnlQuaAction.Controls.Add(this.numSoLuongQua);
            this.pnlQuaAction.Controls.Add(this.lblSLQua);
            this.pnlQuaAction.Controls.Add(this.lblQuaDoiInfo);
            this.pnlQuaAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlQuaAction.Location = new System.Drawing.Point(0, 536);
            this.pnlQuaAction.Name = "pnlQuaAction";
            this.pnlQuaAction.Padding = new System.Windows.Forms.Padding(10);
            this.pnlQuaAction.Size = new System.Drawing.Size(724, 70);
            this.pnlQuaAction.TabIndex = 2;

            // btnDoiQuaXacNhan
            this.btnDoiQuaXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDoiQuaXacNhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoiQuaXacNhan.Enabled = false;
            this.btnDoiQuaXacNhan.FlatAppearance.BorderSize = 0;
            this.btnDoiQuaXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiQuaXacNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDoiQuaXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnDoiQuaXacNhan.Location = new System.Drawing.Point(574, 10);
            this.btnDoiQuaXacNhan.Name = "btnDoiQuaXacNhan";
            this.btnDoiQuaXacNhan.Size = new System.Drawing.Size(140, 50);
            this.btnDoiQuaXacNhan.TabIndex = 3;
            this.btnDoiQuaXacNhan.Text = "🎁 ĐỔI QUÀ";
            this.btnDoiQuaXacNhan.UseVisualStyleBackColor = false;
            this.btnDoiQuaXacNhan.Click += new System.EventHandler(this.BtnDoiQuaXacNhan_Click);

            // numSoLuongQua
            this.numSoLuongQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuongQua.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numSoLuongQua.Location = new System.Drawing.Point(475, 26);
            this.numSoLuongQua.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongQua.Name = "numSoLuongQua";
            this.numSoLuongQua.Size = new System.Drawing.Size(85, 27);
            this.numSoLuongQua.TabIndex = 2;
            this.numSoLuongQua.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblSLQua
            this.lblSLQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSLQua.AutoSize = true;
            this.lblSLQua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSLQua.Location = new System.Drawing.Point(475, 7);
            this.lblSLQua.Name = "lblSLQua";
            this.lblSLQua.Size = new System.Drawing.Size(57, 15);
            this.lblSLQua.TabIndex = 1;
            this.lblSLQua.Text = "Số lượng:";

            // lblQuaDoiInfo
            this.lblQuaDoiInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuaDoiInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuaDoiInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuaDoiInfo.Location = new System.Drawing.Point(10, 10);
            this.lblQuaDoiInfo.Name = "lblQuaDoiInfo";
            this.lblQuaDoiInfo.Size = new System.Drawing.Size(450, 50);
            this.lblQuaDoiInfo.TabIndex = 0;
            this.lblQuaDoiInfo.Text = "Chọn quà tặng từ danh sách";
            this.lblQuaDoiInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlQuaTop
            this.pnlQuaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlQuaTop.Controls.Add(this.lblCountQuaDoi);
            this.pnlQuaTop.Controls.Add(this.lblKHQuaInfo);
            this.pnlQuaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuaTop.Location = new System.Drawing.Point(0, 0);
            this.pnlQuaTop.Name = "pnlQuaTop";
            this.pnlQuaTop.Padding = new System.Windows.Forms.Padding(8);
            this.pnlQuaTop.Size = new System.Drawing.Size(724, 70);
            this.pnlQuaTop.TabIndex = 0;

            // lblCountQuaDoi
            this.lblCountQuaDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountQuaDoi.AutoSize = true;
            this.lblCountQuaDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountQuaDoi.ForeColor = System.Drawing.Color.Gray;
            this.lblCountQuaDoi.Location = new System.Drawing.Point(630, 12);
            this.lblCountQuaDoi.Name = "lblCountQuaDoi";
            this.lblCountQuaDoi.Size = new System.Drawing.Size(36, 15);
            this.lblCountQuaDoi.TabIndex = 1;
            this.lblCountQuaDoi.Text = "0 quà";

            // lblKHQuaInfo
            this.lblKHQuaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKHQuaInfo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblKHQuaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblKHQuaInfo.Location = new System.Drawing.Point(8, 8);
            this.lblKHQuaInfo.Name = "lblKHQuaInfo";
            this.lblKHQuaInfo.Size = new System.Drawing.Size(708, 54);
            this.lblKHQuaInfo.TabIndex = 0;
            this.lblKHQuaInfo.Text = "👈 Vui lòng chọn khách hàng cần đổi quà";
            this.lblKHQuaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // tabThongKe
            this.tabThongKe.Controls.Add(this.pnlThongKeCards);
            this.tabThongKe.Controls.Add(this.pnlThongKeBottom);
            this.tabThongKe.Location = new System.Drawing.Point(4, 39);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(15);
            this.tabThongKe.Size = new System.Drawing.Size(1192, 620);
            this.tabThongKe.TabIndex = 2;
            this.tabThongKe.Text = "📊 Thống kê nhanh";
            this.tabThongKe.UseVisualStyleBackColor = true;

            // pnlThongKeCards
            this.pnlThongKeCards.ColumnCount = 3;
            this.pnlThongKeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlThongKeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlThongKeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlThongKeCards.Controls.Add(this.pnlCard1, 0, 0);
            this.pnlThongKeCards.Controls.Add(this.pnlCard2, 1, 0);
            this.pnlThongKeCards.Controls.Add(this.pnlCard3, 2, 0);
            this.pnlThongKeCards.Controls.Add(this.pnlCard4, 0, 1);
            this.pnlThongKeCards.Controls.Add(this.pnlCard5, 1, 1);
            this.pnlThongKeCards.Controls.Add(this.pnlCard6, 2, 1);
            this.pnlThongKeCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongKeCards.Location = new System.Drawing.Point(15, 15);
            this.pnlThongKeCards.Name = "pnlThongKeCards";
            this.pnlThongKeCards.RowCount = 2;
            this.pnlThongKeCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlThongKeCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlThongKeCards.Size = new System.Drawing.Size(1162, 540);
            this.pnlThongKeCards.TabIndex = 0;

            // pnlCard1
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblTongKH);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(10, 10);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard1.Size = new System.Drawing.Size(367, 250);
            this.pnlCard1.TabIndex = 0;

            // lblTongKH
            this.lblTongKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongKH.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblTongKH.Location = new System.Drawing.Point(15, 45);
            this.lblTongKH.Name = "lblTongKH";
            this.lblTongKH.Size = new System.Drawing.Size(335, 188);
            this.lblTongKH.TabIndex = 1;
            this.lblTongKH.Text = "0";
            this.lblTongKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard1Title
            this.lblCard1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(335, 30);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "👥 TỔNG KHÁCH HÀNG";
            this.lblCard1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard2
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblTongDiem);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(397, 10);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard2.Size = new System.Drawing.Size(367, 250);
            this.pnlCard2.TabIndex = 1;

            // lblTongDiem
            this.lblTongDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDiem.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTongDiem.Location = new System.Drawing.Point(15, 45);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(335, 188);
            this.lblTongDiem.TabIndex = 1;
            this.lblTongDiem.Text = "0";
            this.lblTongDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard2Title
            this.lblCard2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(335, 30);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "⭐ TỔNG ĐIỂM TÍCH LŨY";
            this.lblCard2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard3
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblDoanhThuHomNay);
            this.pnlCard3.Controls.Add(this.lblSoDonHomNay);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(784, 10);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard3.Size = new System.Drawing.Size(368, 250);
            this.pnlCard3.TabIndex = 2;

            // lblDoanhThuHomNay
            this.lblDoanhThuHomNay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuHomNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(15, 45);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(336, 163);
            this.lblDoanhThuHomNay.TabIndex = 1;
            this.lblDoanhThuHomNay.Text = "0 VNĐ";
            this.lblDoanhThuHomNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSoDonHomNay
            this.lblSoDonHomNay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoDonHomNay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSoDonHomNay.ForeColor = System.Drawing.Color.Gray;
            this.lblSoDonHomNay.Location = new System.Drawing.Point(15, 208);
            this.lblSoDonHomNay.Name = "lblSoDonHomNay";
            this.lblSoDonHomNay.Size = new System.Drawing.Size(336, 25);
            this.lblSoDonHomNay.TabIndex = 2;
            this.lblSoDonHomNay.Text = "0 đơn hàng";
            this.lblSoDonHomNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard3Title
            this.lblCard3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(336, 30);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "💵 DOANH THU HÔM NAY";
            this.lblCard3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard4
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblDoanhThuThangNay);
            this.pnlCard4.Controls.Add(this.lblSoDonThangNay);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(10, 280);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard4.Size = new System.Drawing.Size(367, 250);
            this.pnlCard4.TabIndex = 3;

            // lblDoanhThuThangNay
            this.lblDoanhThuThangNay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThuThangNay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThangNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblDoanhThuThangNay.Location = new System.Drawing.Point(15, 45);
            this.lblDoanhThuThangNay.Name = "lblDoanhThuThangNay";
            this.lblDoanhThuThangNay.Size = new System.Drawing.Size(335, 163);
            this.lblDoanhThuThangNay.TabIndex = 1;
            this.lblDoanhThuThangNay.Text = "0 VNĐ";
            this.lblDoanhThuThangNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSoDonThangNay
            this.lblSoDonThangNay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoDonThangNay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSoDonThangNay.ForeColor = System.Drawing.Color.Gray;
            this.lblSoDonThangNay.Location = new System.Drawing.Point(15, 208);
            this.lblSoDonThangNay.Name = "lblSoDonThangNay";
            this.lblSoDonThangNay.Size = new System.Drawing.Size(335, 25);
            this.lblSoDonThangNay.TabIndex = 2;
            this.lblSoDonThangNay.Text = "0 đơn hàng";
            this.lblSoDonThangNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard4Title
            this.lblCard4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard4Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(335, 30);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "📅 DOANH THU THÁNG NÀY";
            this.lblCard4Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard5
            this.pnlCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard5.Controls.Add(this.lblThuocSapHet);
            this.pnlCard5.Controls.Add(this.lblCard5Title);
            this.pnlCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard5.Location = new System.Drawing.Point(397, 280);
            this.pnlCard5.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard5.Name = "pnlCard5";
            this.pnlCard5.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard5.Size = new System.Drawing.Size(367, 250);
            this.pnlCard5.TabIndex = 4;

            // lblThuocSapHet
            this.lblThuocSapHet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThuocSapHet.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblThuocSapHet.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblThuocSapHet.Location = new System.Drawing.Point(15, 45);
            this.lblThuocSapHet.Name = "lblThuocSapHet";
            this.lblThuocSapHet.Size = new System.Drawing.Size(335, 188);
            this.lblThuocSapHet.TabIndex = 1;
            this.lblThuocSapHet.Text = "0";
            this.lblThuocSapHet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard5Title
            this.lblCard5Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard5Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard5Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard5Title.Name = "lblCard5Title";
            this.lblCard5Title.Size = new System.Drawing.Size(335, 30);
            this.lblCard5Title.TabIndex = 0;
            this.lblCard5Title.Text = "⚠️ THUỐC SẮP HẾT (≤10)";
            this.lblCard5Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard6
            this.pnlCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard6.Controls.Add(this.lblQuaSapHet);
            this.pnlCard6.Controls.Add(this.lblCard6Title);
            this.pnlCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard6.Location = new System.Drawing.Point(784, 280);
            this.pnlCard6.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCard6.Name = "pnlCard6";
            this.pnlCard6.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCard6.Size = new System.Drawing.Size(368, 250);
            this.pnlCard6.TabIndex = 5;

            // lblQuaSapHet
            this.lblQuaSapHet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuaSapHet.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblQuaSapHet.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblQuaSapHet.Location = new System.Drawing.Point(15, 45);
            this.lblQuaSapHet.Name = "lblQuaSapHet";
            this.lblQuaSapHet.Size = new System.Drawing.Size(336, 188);
            this.lblQuaSapHet.TabIndex = 1;
            this.lblQuaSapHet.Text = "0";
            this.lblQuaSapHet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCard6Title
            this.lblCard6Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCard6Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard6Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard6Title.Name = "lblCard6Title";
            this.lblCard6Title.Size = new System.Drawing.Size(336, 30);
            this.lblCard6Title.TabIndex = 0;
            this.lblCard6Title.Text = "⚠️ QUÀ SẮP HẾT (≤5)";
            this.lblCard6Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlThongKeBottom
            this.pnlThongKeBottom.Controls.Add(this.btnXemBaoCaoChiTiet);
            this.pnlThongKeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThongKeBottom.Location = new System.Drawing.Point(15, 555);
            this.pnlThongKeBottom.Name = "pnlThongKeBottom";
            this.pnlThongKeBottom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlThongKeBottom.Size = new System.Drawing.Size(1162, 50);
            this.pnlThongKeBottom.TabIndex = 1;

            // btnXemBaoCaoChiTiet
            this.btnXemBaoCaoChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnXemBaoCaoChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemBaoCaoChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCaoChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCaoChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCaoChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCaoChiTiet.Location = new System.Drawing.Point(922, 8);
            this.btnXemBaoCaoChiTiet.Name = "btnXemBaoCaoChiTiet";
            this.btnXemBaoCaoChiTiet.Size = new System.Drawing.Size(240, 42);
            this.btnXemBaoCaoChiTiet.TabIndex = 0;
            this.btnXemBaoCaoChiTiet.Text = "📈 XEM BÁO CÁO CHI TIẾT";
            this.btnXemBaoCaoChiTiet.UseVisualStyleBackColor = false;
            this.btnXemBaoCaoChiTiet.Click += new System.EventHandler(this.BtnXemBaoCaoChiTiet_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ss);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bán Thuốc & Tích Điểm Đổi Quà";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBanThuoc.ResumeLayout(false);
            this.splitContainerTong.Panel1.ResumeLayout(false);
            this.splitContainerTong.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTong)).EndInit();
            this.splitContainerTong.ResumeLayout(false);
            this.pnlKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHBan)).EndInit();
            this.pnlKHTop.ResumeLayout(false);
            this.pnlKHTop.PerformLayout();
            this.splitContainerPhai.Panel1.ResumeLayout(false);
            this.splitContainerPhai.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhai)).EndInit();
            this.splitContainerPhai.ResumeLayout(false);
            this.pnlThuocBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocBan)).EndInit();
            this.pnlThuocAction.ResumeLayout(false);
            this.pnlThuocAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).EndInit();
            this.pnlThuocTop.ResumeLayout(false);
            this.pnlThuocTop.PerformLayout();
            this.pnlGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlThanhToanBan.ResumeLayout(false);
            this.pnlThanhToanBan.PerformLayout();
            this.pnlGioButtons.ResumeLayout(false);
            this.pnlKHInfoBanner.ResumeLayout(false);
            this.tabDoiQua.ResumeLayout(false);
            this.splitContainerDoiQua.Panel1.ResumeLayout(false);
            this.splitContainerDoiQua.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDoiQua)).EndInit();
            this.splitContainerDoiQua.ResumeLayout(false);
            this.pnlKHQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHQua)).EndInit();
            this.pnlSearchKHQua.ResumeLayout(false);
            this.pnlSearchKHQua.PerformLayout();
            this.pnlQuaDoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaDoi)).EndInit();
            this.pnlQuaAction.ResumeLayout(false);
            this.pnlQuaAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongQua)).EndInit();
            this.pnlQuaTop.ResumeLayout(false);
            this.pnlQuaTop.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.pnlThongKeCards.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard5.ResumeLayout(false);
            this.pnlCard6.ResumeLayout(false);
            this.pnlThongKeBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnThemKHQuick;
        private ToolStripButton btnSuaKHQuick;
        private ToolStripButton btnLichSuQuick;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnQuanLyThuoc;
        private ToolStripButton btnQuanLyQua;
        private ToolStripButton btnLamMoiAll;
        private StatusStrip ss;
        private ToolStripStatusLabel lblStatus;
        private TabControl tabControl;
        private TabPage tabBanThuoc;
        private SplitContainer splitContainerTong;
        private Panel pnlKhachHang;
        private DataGridView dgvKHBan;
        private Panel pnlKHTop;
        private Label lblCountKHBan;
        private TextBox txtTimKiemKHBan;
        private Label lblKHTitle;
        private SplitContainer splitContainerPhai;
        private Panel pnlThuocBan;
        private DataGridView dgvThuocBan;
        private Panel pnlThuocAction;
        private Button btnThemVaoGio;
        private NumericUpDown numSoLuongBan;
        private Label lblSoLuongBan;
        private Label lblThuocBanInfo;
        private Panel pnlThuocTop;
        private Label lblCountThuocBan;
        private TextBox txtTimKiemThuocBan;
        private Label lblThuocTitle;
        private Panel pnlGioHang;
        private DataGridView dgvGioHang;
        private Panel pnlThanhToanBan;
        private Label lblDiemSauBan;
        private Label lblDiemCongBan;
        private Label lblTongTienBan;
        private Panel pnlGioButtons;
        private Button btnXoaGio;
        private Button btnThanhToanBan;
        private Panel pnlKHInfoBanner;
        private Label lblKHBanInfo;
        private ContextMenuStrip cmsKhachHang;
        private TabPage tabDoiQua;
        private SplitContainer splitContainerDoiQua;
        private Panel pnlKHQua;
        private DataGridView dgvKHQua;
        private Panel pnlSearchKHQua;
        private TextBox txtTimKiemKHQua;
        private Label lblKHQuaTitle;
        private Panel pnlQuaDoi;
        private DataGridView dgvQuaDoi;
        private Panel pnlQuaAction;
        private Button btnDoiQuaXacNhan;
        private NumericUpDown numSoLuongQua;
        private Label lblSLQua;
        private Label lblQuaDoiInfo;
        private Panel pnlQuaTop;
        private Label lblCountQuaDoi;
        private Label lblKHQuaInfo;
        private TabPage tabThongKe;
        private TableLayoutPanel pnlThongKeCards;
        private Panel pnlCard1;
        private Label lblTongKH;
        private Label lblCard1Title;
        private Panel pnlCard2;
        private Label lblTongDiem;
        private Label lblCard2Title;
        private Panel pnlCard3;
        private Label lblDoanhThuHomNay;
        private Label lblSoDonHomNay;
        private Label lblCard3Title;
        private Panel pnlCard4;
        private Label lblDoanhThuThangNay;
        private Label lblSoDonThangNay;
        private Label lblCard4Title;
        private Panel pnlCard5;
        private Label lblThuocSapHet;
        private Label lblCard5Title;
        private Panel pnlCard6;
        private Label lblQuaSapHet;
        private Label lblCard6Title;
        private Panel pnlThongKeBottom;
        private Button btnXemBaoCaoChiTiet;
    }
}