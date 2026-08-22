using System;
using System.Drawing;
using System.Windows.Forms;

namespace TichDiemTest
{
    partial class FormNhapKhoQua
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
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.Location = new System.Drawing.Point(20, 20);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(360, 60);
            this.lblThongTin.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(20, 90);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(98, 19);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng nhập:";
            // 
            // numSoLuongNhap
            // 
            this.numSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSoLuongNhap.Location = new System.Drawing.Point(20, 115);
            this.numSoLuongNhap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoLuongNhap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuongNhap.Name = "numSoLuongNhap";
            this.numSoLuongNhap.Size = new System.Drawing.Size(360, 25);
            this.numSoLuongNhap.TabIndex = 2;
            this.numSoLuongNhap.ThousandsSeparator = true;
            this.numSoLuongNhap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(180, 160);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 35);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.BtnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHuy.Location = new System.Drawing.Point(286, 160);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormNhapKhoQua
            // 
            this.AcceptButton = this.btnXacNhan;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.numSoLuongNhap);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhapKhoQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Label lblThongTin;
        private Label lblSoLuong;
        private NumericUpDown numSoLuongNhap;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}