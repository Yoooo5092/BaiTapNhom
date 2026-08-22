using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TichDiemTest
{
    public static class DatabaseHelper
    {
        private static string connectionString = "";

        public static void Initialize(string server, string database, string user, string password)
        {
            connectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};Connection Timeout=5;", server, database, user, password);
        }

        public static void Initialize(string connStr)
        {
            connectionString = connStr;
        }

        public static bool IsInitialized
        {
            get { return !string.IsNullOrWhiteSpace(connectionString); }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            if (!IsInitialized) return false;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            if (!IsInitialized) return dt;

            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0) cmd.Parameters.AddRange(parameters);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            if (!IsInitialized) return -1;

            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            if (!IsInitialized) return null;

            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn scalar: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void CreateTablesIfNotExist()
        {
            if (!IsInitialized) return;

            string[] createTables = new string[]
            {
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='KhachHang' AND xtype='U')
                CREATE TABLE KhachHang (
                    MaKH INT IDENTITY(1,1) PRIMARY KEY,
                    HoTen NVARCHAR(100) NOT NULL,
                    SoDienThoai VARCHAR(11) NOT NULL UNIQUE,
                    Email NVARCHAR(100),
                    DiemTichLuy INT DEFAULT 0,
                    NgayDangKy DATETIME DEFAULT GETDATE()
                )",

                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Thuoc' AND xtype='U')
                CREATE TABLE Thuoc (
                    MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
                    TenThuoc NVARCHAR(100) NOT NULL,
                    DonViTinh NVARCHAR(20) NOT NULL,
                    DonGia DECIMAL(18,0) NOT NULL DEFAULT 0,
                    SoLuongTon INT NOT NULL DEFAULT 0,
                    NhaSanXuat NVARCHAR(100),
                    HanSuDung DATE,
                    MoTa NVARCHAR(500),
                    CONSTRAINT UQ_Thuoc_Ten_DVT UNIQUE (TenThuoc, DonViTinh)
                )",

                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LichSuGiaoDich' AND xtype='U')
                CREATE TABLE LichSuGiaoDich (
                    MaGiaoDich VARCHAR(8) PRIMARY KEY,
                    MaKH INT NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
                    NgayGio DATETIME NOT NULL DEFAULT GETDATE(),
                    LoaiGiaoDich NVARCHAR(20) NOT NULL,
                    SoDiemThayDoi INT NOT NULL,
                    TongTien DECIMAL(18,0) DEFAULT 0,
                    ChiTietThuoc NVARCHAR(MAX)
                )",

                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Qua' AND xtype='U')
                CREATE TABLE Qua (
                    MaQua INT IDENTITY(1,1) PRIMARY KEY,
                    TenQua NVARCHAR(100) NOT NULL,
                    MoTa NVARCHAR(500),
                    DiemCan INT NOT NULL DEFAULT 0,
                    SoLuongTon INT NOT NULL DEFAULT 0,
                    DonViTinh NVARCHAR(20) DEFAULT N'Cái',
                    HinhAnh NVARCHAR(255),
                    TrangThai BIT DEFAULT 1,
                    NgayTao DATETIME DEFAULT GETDATE()
                )",

                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ChiTietDoiQua' AND xtype='U')
                CREATE TABLE ChiTietDoiQua (
                    MaGiaoDich INT IDENTITY(1,1) PRIMARY KEY,
                    MaKH INT NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
                    MaQua INT NOT NULL FOREIGN KEY REFERENCES Qua(MaQua),
                    TenQua NVARCHAR(100) NOT NULL,
                    SoLuong INT NOT NULL,
                    DiemTru INT NOT NULL,
                    NgayDoi DATETIME DEFAULT GETDATE()
                )"
            };

            foreach (var sql in createTables)
            {
                ExecuteNonQuery(sql);
            }
        }
    }
}