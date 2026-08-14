using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TichDiemTest
{
    /// <summary>
    // Form chính - quản lý khách hàng tích điểm
    /// </summary>
    public partial class Form1 : Form
    {
        private QuanLyKhachHang qlKH = new QuanLyKhachHang();
        private ContextMenuStrip cmsGrid;
        private string fileTestPath = "test.txt";
        private int soLuong = 0;
        public Form1()
        {
            string loi = "";
            InitializeComponent();
            SetupUI();
            SetupEvents(); 
            qlKH.NhapTuFile(fileTestPath, out loi, out soLuong);
        }

        private void SetupUI()
        {
            // Form properties
            this.Text = "Quản Lý Tích Điểm Khách Hàng";
            this.Size = new Size(1000, 650);
            this.MinimumSize = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9.5F);

            // ===== TOOLSTRIP (Thanh công cụ) =====
            ToolStrip ts = new ToolStrip
            {
                ImageScalingSize = new Size(24, 24),
                GripStyle = ToolStripGripStyle.Hidden,
                Padding = new Padding(5, 2, 5, 2),
                BackColor = SystemColors.ControlLightLight
            };

            var btnThem = TaoButton("Thêm", "Thêm khách hàng mới (Ctrl+N)", ThemKhachHang);
            var btnSua = TaoButton("Sửa", "Cập nhật thông tin (F2)", SuaKhachHang);
            var btnXoa = TaoButton("Xóa", "Xóa khách hàng (Delete)", XoaKhachHang);
            var sep1 = new ToolStripSeparator();

            var btnCongDiem = TaoButton("Cộng điểm", "Cộng điểm cho khách hàng (F3)", () => XuLyDiem(true));
            var btnDoiQua = TaoButton("Đổi quà", "Trừ điểm đổi quà (F4)", () => XuLyDiem(false));
            var sep2 = new ToolStripSeparator();

            var btnNhapFile = TaoButton("Nhập file", "Nhập từ test.txt (Ctrl+I)", NhapTuFile);
            var btnXuatFile = TaoButton("Xuất file", "Xuất ra khachhang.txt (Ctrl+E)", XuatRaFile);
            var sep3 = new ToolStripSeparator();

            var btnThongKe = TaoButton("Thống kê", "Xem báo cáo thống kê (F5)", MoThongKe);

            ts.Items.AddRange(new ToolStripItem[] {
                btnThem, btnSua, btnXoa, sep1,
                btnCongDiem, btnDoiQua, sep2,
                btnNhapFile, btnXuatFile, sep3,
                btnThongKe
            });

            // ===== SEARCH PANEL =====
            Panel pnlSearch = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(10, 5, 10, 5),
                BackColor = SystemColors.ControlLightLight
            };

            Label lblSearch = new Label
            {
                Text = "Tìm kiếm:",
                Location = new Point(10, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F)
            };

            TextBox txtSearch = new TextBox
            {
                Name = "txtTimKiem",
                Location = new Point(90, 12),
                Size = new Size(300, 25),
                Font = new Font("Segoe UI", 9.5F)
            };
            txtSearch.TextChanged += TxtTimKiem_TextChanged;

            Button btnClear = new Button
            {
                Text = "✕",
                Location = new Point(400, 12),
                Size = new Size(28, 25),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gray
            };
            btnClear.FlatAppearance.BorderColor = Color.LightGray;
            btnClear.Click += (s, e) => txtSearch.Clear();

            Label lblCount = new Label
            {
                Name = "lblCount",
                Text = "0 khách hàng",
                Location = new Point(450, 15),
                AutoSize = true,
                ForeColor = Color.DimGray
            };

            pnlSearch.Controls.AddRange(new Control[] { lblSearch, txtSearch, btnClear, lblCount });

            // ===== DATAGRIDVIEW =====
            DataGridView dgv = new DataGridView
            {
                Name = "dgvKhachHang",
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                RowTemplate = { Height = 35 },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(245, 245, 250) },
                GridColor = Color.LightGray,
                BorderStyle = BorderStyle.None,
                BackgroundColor = Color.White,
                EnableHeadersVisualStyles = false,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(41, 128, 185),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Padding = new Padding(5),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                ColumnHeadersHeight = 40,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            };

            // Columns
            dgv.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "MaKH", HeaderText = "Mã KH", DataPropertyName = "MaKH", FillWeight = 50, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } },
                new DataGridViewTextBoxColumn { Name = "HoTen", HeaderText = "Họ tên", DataPropertyName = "HoTen", FillWeight = 150 },
                new DataGridViewTextBoxColumn { Name = "SoDienThoai", HeaderText = "Số ĐT", DataPropertyName = "SoDienThoai", FillWeight = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } },
                new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", FillWeight = 180 },
                new DataGridViewTextBoxColumn { Name = "DiemTichLuy", HeaderText = "Điểm", DataPropertyName = "DiemTichLuy", FillWeight = 80, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) } },
                new DataGridViewTextBoxColumn { Name = "CapBac", HeaderText = "Cấp bậc", DataPropertyName = "CapBac", FillWeight = 90, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } },
                new DataGridViewTextBoxColumn { Name = "NgayDangKy", HeaderText = "Ngày ĐK", DataPropertyName = "NgayDangKy", FillWeight = 100, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "dd/MM/yyyy" } }
            });

            // Context Menu Strip cho right-click
            cmsGrid = new ContextMenuStrip();
            cmsGrid.Items.Add("Cập nhật", null, (s, e) => SuaKhachHang()).Font = new Font("Segoe UI", 9.5F);
            cmsGrid.Items.Add("Cộng điểm", null, (s, e) => XuLyDiem(true)).Font = new Font("Segoe UI", 9.5F);
            cmsGrid.Items.Add("Đổi quà", null, (s, e) => XuLyDiem(false)).Font = new Font("Segoe UI", 9.5F);
            cmsGrid.Items.Add(new ToolStripSeparator());
            cmsGrid.Items.Add("Xóa", null, (s, e) => XoaKhachHang()).Font = new Font("Segoe UI", 9.5F);
            cmsGrid.Opening += CmsGrid_Opening;

            dgv.ContextMenuStrip = cmsGrid;
            dgv.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) SuaKhachHang(); };
            dgv.KeyDown += Dgv_KeyDown;
            dgv.SelectionChanged += Dgv_SelectionChanged;

            // ===== STATUS STRIP =====
            StatusStrip ss = new StatusStrip();
            ToolStripStatusLabel lblStatus = new ToolStripStatusLabel { Name = "lblStatus", Text = "Sẵn sàng", Spring = true, TextAlign = ContentAlignment.MiddleLeft };
            ToolStripStatusLabel lblVersion = new ToolStripStatusLabel { Text = "v1.0 - Lab Project", ForeColor = Color.Gray };
            ss.Items.AddRange(new ToolStripItem[] { lblStatus, lblVersion });

            // ===== LAYOUT =====
            Panel pnlMain = new Panel { Dock = DockStyle.Fill, Padding = new Padding(5) };
            pnlMain.Controls.Add(dgv);
            pnlMain.Controls.Add(pnlSearch); // Top
            pnlMain.Controls.Add(ts); // Top (above search)

            // Thứ tự add: toolbar -> search -> grid
            this.Controls.Add(pnlMain);
            this.Controls.Add(ss);

            // Lưu reference
            this.dgvKhachHang = dgv;
            this.txtTimKiem = txtSearch;
            this.lblCount = lblCount;
            this.lblStatus = lblStatus;
        }

        private ToolStripButton TaoButton(string text, string tooltip, Action click)
        {
            var btn = new ToolStripButton(text)
            {
                ToolTipText = tooltip,
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Font = new Font("Segoe UI", 9.5F),
                Padding = new Padding(10, 2, 10, 2),
                Margin = new Padding(2, 1, 2, 1)
            };
            btn.Click += (s, e) => click?.Invoke();
            return btn;
        }

        private void SetupEvents()
        {
            qlKH.DuLieuDaThayDoi += () => CapNhatDanhSach();
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
        }


        private void CapNhatDanhSach()
        {
            string tuKhoa = txtTimKiem?.Text?.Trim() ?? "";
            var ds = string.IsNullOrEmpty(tuKhoa) ? qlKH.LayDanhSach() : qlKH.TimKiem(tuKhoa);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = ds;

            // Format lại columns sau khi bind
            if (dgvKhachHang.Columns["DiemTichLuy"] != null)
                dgvKhachHang.Columns["DiemTichLuy"].DefaultCellStyle.Format = "N0";
            if (dgvKhachHang.Columns["NgayDangKy"] != null)
                dgvKhachHang.Columns["NgayDangKy"].DefaultCellStyle.Format = "dd/MM/yyyy";

            lblCount.Text = $"{ds.Count} khách hàng";
        }

        // ===== EVENT HANDLERS =====
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        private void CmsGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = dgvKhachHang.CurrentRow == null;
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) SuaKhachHang();
            else if (e.KeyCode == Keys.Delete) XoaKhachHang();
            else if (e.KeyCode == Keys.F3) XuLyDiem(true);
            else if (e.KeyCode == Keys.F4) XuLyDiem(false);
            else if (e.KeyCode == Keys.Enter) SuaKhachHang();
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            // Có thể hiển thị chi tiết ở status bar
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) ThemKhachHang();
            else if (e.Control && e.KeyCode == Keys.I) NhapTuFile();
            else if (e.Control && e.KeyCode == Keys.E) XuatRaFile();
            else if (e.KeyCode == Keys.F5) MoThongKe();
            else if (e.KeyCode == Keys.Escape) Close();
        }

        // ===== CRUD OPERATIONS =====
        private void ThemKhachHang()
        {
            using (var frm = new FormKhachHang(qlKH))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    HienThiStatus($"Đã thêm: {frm.KetQua.HoTen}");
                }
            }
        }

        private void SuaKhachHang()
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            using (var frm = new FormKhachHang(qlKH, kh))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    HienThiStatus($"Đã cập nhật: {frm.KetQua.HoTen}");
                }
            }
        }

        private void XoaKhachHang()
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            var result = MessageBox.Show(
                $"Xóa khách hàng: {kh.HoTen} ({kh.SoDienThoai})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string loi;
                if (qlKH.Xoa(kh.MaKH, out loi))
                {
                    HienThiStatus($"Đã xóa: {kh.HoTen}");
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XuLyDiem(bool laCongDiem)
        {
            var kh = LayKhachHangDangChon();
            if (kh == null) return;

            using (var frm = new FormDiem(qlKH, kh, laCongDiem))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    string action = laCongDiem ? "cộng" : "trừ";
                    HienThiStatus($"Đã {action} điểm cho: {kh.HoTen}");
                }
            }
        }

        private KhachHang LayKhachHangDangChon()
        {
            if (dgvKhachHang.CurrentRow?.DataBoundItem is KhachHang kh)
                return kh;
            return null;
        }

        // ===== FILE OPERATIONS =====
        private void NhapTuFile()
        {
            // Thử đọc test.txt trong thư mục chạy, nếu không có thì cho chọn file
            string filePath = fileTestPath;
            if (!File.Exists(filePath))
            {
                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Chọn file nhập dữ liệu"
                })
                {
                    if (ofd.ShowDialog() != DialogResult.OK) return;
                    filePath = ofd.FileName;
                }
            }

            string loi;
            int soLuong;
            if (qlKH.NhapTuFile(filePath, out loi, out soLuong))
            {
                HienThiStatus($"Đã nhập {soLuong} khách hàng từ file");
                MessageBox.Show($"Nhập thành công {soLuong} khách hàng từ:\n{filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(loi, "Lỗi nhập file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuatRaFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = "khachhang.txt",
                Title = "Lưu danh sách khách hàng"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                string loi;
                if (qlKH.XuatRaFile(sfd.FileName, out loi))
                {
                    HienThiStatus($"Đã xuất ra file: {sfd.FileName}");
                    MessageBox.Show("Xuất file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MoThongKe()
        {
            using (var frm = new FormThongKe(qlKH))
            {
                frm.ShowDialog(this);
            }
        }

        private void HienThiStatus(string msg)
        {
            if (lblStatus != null) lblStatus.Text = msg;
        }

        // ===== DESIGNER FIELDS =====
        private DataGridView dgvKhachHang;
        private TextBox txtTimKiem;
        private Label lblCount;
        private ToolStripStatusLabel lblStatus;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}