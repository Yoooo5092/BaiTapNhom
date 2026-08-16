using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    public partial class FormDiem : Form
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.numTienHoaDon = new System.Windows.Forms.NumericUpDown();
            this.lblDiem = new System.Windows.Forms.Label();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTienHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(360, 25);
            this.lblTieuDe.TabIndex = 0;
            // 
            // lblThongTin
            // 
            this.lblThongTin.Location = new System.Drawing.Point(20, 45);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(360, 40);
            this.lblThongTin.TabIndex = 1;
            // 
            // lblTien
            // 
            this.lblTien.Location = new System.Drawing.Point(20, 90);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(360, 15);
            this.lblTien.TabIndex = 2;
            this.lblTien.Text = "Nhập tiền hóa đơn (VND):";
            // 
            // numTienHoaDon
            // 
            this.numTienHoaDon.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTienHoaDon.Location = new System.Drawing.Point(20, 110);
            this.numTienHoaDon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTienHoaDon.Name = "numTienHoaDon";
            this.numTienHoaDon.Size = new System.Drawing.Size(360, 20);
            this.numTienHoaDon.TabIndex = 3;
            this.numTienHoaDon.ThousandsSeparator = true;
            // 
            // lblDiem
            // 
            this.lblDiem.Location = new System.Drawing.Point(20, 140);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(360, 15);
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = "Số điểm:";
            // 
            // numDiem
            // 
            this.numDiem.Location = new System.Drawing.Point(20, 160);
            this.numDiem.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(360, 20);
            this.numDiem.TabIndex = 5;
            this.numDiem.ThousandsSeparator = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(180, 210);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(90, 35);
            this.btnXacNhan.TabIndex = 6;
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(280, 210);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            // 
            // FormDiem
            // 
            this.AcceptButton = this.btnXacNhan;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.numTienHoaDon);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numTienHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe, lblThongTin, lblTien, lblDiem;
        private System.Windows.Forms.NumericUpDown numTienHoaDon, numDiem;
        private System.Windows.Forms.Button btnXacNhan, btnHuy;
    }
}