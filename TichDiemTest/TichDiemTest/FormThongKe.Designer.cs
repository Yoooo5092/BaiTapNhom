using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TichDiemTest
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.chartCapBac = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTop = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapBac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Controls.Add(this.lblTongQuan);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(800, 120);
            this.panelTop.TabIndex = 2;
            // 
            // lblTongQuan
            // 
            this.lblTongQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongQuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongQuan.Location = new System.Drawing.Point(0, 0);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Size = new System.Drawing.Size(100, 23);
            this.lblTongQuan.TabIndex = 0;
            this.lblTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartCapBac
            // 
            chartArea1.Name = "MainArea";
            this.chartCapBac.ChartAreas.Add(chartArea1);
            this.chartCapBac.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "MainLegend";
            this.chartCapBac.Legends.Add(legend1);
            this.chartCapBac.Location = new System.Drawing.Point(0, 120);
            this.chartCapBac.Name = "chartCapBac";
            series1.ChartArea = "MainArea";
            series1.Legend = "MainLegend";
            series1.Name = "CapBac";
            this.chartCapBac.Series.Add(series1);
            this.chartCapBac.Size = new System.Drawing.Size(800, 250);
            this.chartCapBac.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Phân bố cấp bậc khách hàng";
            this.chartCapBac.Titles.Add(title1);
            // 
            // dgvTop
            // 
            this.dgvTop.AllowUserToAddRows = false;
            this.dgvTop.AllowUserToDeleteRows = false;
            this.dgvTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTop.Location = new System.Drawing.Point(0, 370);
            this.dgvTop.Name = "dgvTop";
            this.dgvTop.ReadOnly = true;
            this.dgvTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop.Size = new System.Drawing.Size(800, 130);
            this.dgvTop.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDong.Location = new System.Drawing.Point(0, 500);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(800, 50);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            // 
            // FormThongKe
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvTop);
            this.Controls.Add(this.chartCapBac);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnDong);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê khách hàng";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCapBac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Panel panelTop;
        private Label lblTongQuan;
        private Chart chartCapBac;
        private DataGridView dgvTop;
        private Button btnDong;
    }
}
