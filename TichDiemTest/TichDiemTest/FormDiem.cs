using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    /// <summary>
    // Form cộng/trừ điểm cho khách hàng
    /// </summary>
    public partial class FormDiem : Form
    {
        private KhachHang khachHang;
        private QuanLyKhachHang qlKH;
        private bool laCongDiem; // true = cộng, false = trừ/đổi quà

        public FormDiem(QuanLyKhachHang ql, KhachHang kh, bool congDiem)
        {
            InitializeComponent();
            qlKH = ql;
            khachHang = kh;
            laCongDiem = congDiem;

            Text = laCongDiem ? "Cộng điểm" : "Đổi quà (trừ điểm)";
            lblTieuDe.Text = laCongDiem ? "Nhập số điểm cộng:" : "Nhập số điểm đổi quà:";
            btnXacNhan.Text = laCongDiem ? "Cộng điểm" : "Đổi quà";

            lblThongTin.Text = $"Khách hàng: {kh.HoTen} (SĐT: {kh.SoDienThoai})\nĐiểm hiện tại: {kh.DiemTichLuy:N0} | Cấp bậc: {kh.CapBac}";
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(360, 25);
            this.lblTieuDe.TabIndex = 0;
            // 
            // lblThongTin
            // 
            this.lblThongTin.Location = new System.Drawing.Point(20, 55);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(360, 60);
            this.lblThongTin.TabIndex = 1;
            // 
            // numDiem
            // 
            this.numDiem.Location = new System.Drawing.Point(20, 130);
            this.numDiem.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDiem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(360, 20);
            this.numDiem.TabIndex = 2;
            this.numDiem.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(180, 180);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(90, 35);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Click += new System.EventHandler(this.BtnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(280, 180);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            // 
            // FormDiem
            // 
            this.AcceptButton = this.btnXacNhan;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            int diem = (int)numDiem.Value;
            string loi;

            bool ok = laCongDiem
                ? qlKH.CongDiem(khachHang.MaKH, diem, out loi)
                : qlKH.DoiQua(khachHang.MaKH, diem, out loi);

            if (ok)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Designer fields
        private Label lblTieuDe, lblThongTin;
        private NumericUpDown numDiem;

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {


        }

        private Button btnXacNhan, btnHuy;
        #endregion
    }
}