using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormKhachHang
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblCapBac = new System.Windows.Forms.Label();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(180, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(180, 76);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDiem
            // 
            this.txtDiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDiem.Location = new System.Drawing.Point(180, 170);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 9;
            // 
            // txtCapBac
            // 
            this.txtCapBac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCapBac.Location = new System.Drawing.Point(180, 208);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.Size = new System.Drawing.Size(100, 20);
            this.txtCapBac.TabIndex = 11;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNgayDK.Location = new System.Drawing.Point(180, 134);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(100, 20);
            this.txtNgayDK.TabIndex = 13;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(62, 53);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 23);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(62, 79);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(100, 23);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số ĐT:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(62, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblDiem
            // 
            this.lblDiem.Location = new System.Drawing.Point(62, 170);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(100, 18);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.Text = "Điểm:";
            // 
            // lblCapBac
            // 
            this.lblCapBac.Location = new System.Drawing.Point(62, 211);
            this.lblCapBac.Name = "lblCapBac";
            this.lblCapBac.Size = new System.Drawing.Size(100, 23);
            this.lblCapBac.TabIndex = 10;
            this.lblCapBac.Text = "Cấp bậc:";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.Location = new System.Drawing.Point(62, 134);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(100, 23);
            this.lblNgayDK.TabIndex = 12;
            this.lblNgayDK.Text = "Ngày ĐK:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(65, 302);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 35);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(190, 302);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            // 
            // FormKhachHang
            // 
            this.AcceptButton = this.btnLuu;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.lblCapBac);
            this.Controls.Add(this.txtCapBac);
            this.Controls.Add(this.lblNgayDK);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private TextBox txtHoTen, txtSDT, txtEmail, txtDiem, txtCapBac, txtNgayDK;
        private Label lblHoTen, lblSDT, lblEmail, lblDiem, lblCapBac, lblNgayDK;
        private Button btnLuu, btnHuy;
    }
}
