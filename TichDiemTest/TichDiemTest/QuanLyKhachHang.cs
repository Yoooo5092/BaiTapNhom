using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TichDiemTest
{
    public class QuanLyKhachHang
    {
        public event Action DuLieuDaThayDoi;
        public event Action DanhSachThuocDaThayDoi;
        public event Action DanhSachQuaDaThayDoi;

        public QuanLyKhachHang()
        {
            if (DatabaseHelper.IsInitialized)
            {
                DatabaseHelper.CreateTablesIfNotExist();
            }
        }

        #region Khách hàng
        public List<KhachHang> LayDanhSach()
        {
            var list = new List<KhachHang>();
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM KhachHang ORDER BY MaKH DESC");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new KhachHang
                {
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                    DiemTichLuy = Convert.ToInt32(row["DiemTichLuy"]),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"])
                });
            }
            return list;
        }

        public bool Them(KhachHang kh, out string loi)
        {
            loi = "";
            if (!kh.HopLe(out loi)) return false;

            var check = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @sdt",
                new SqlParameter("@sdt", kh.SoDienThoai));
            if (check != null && Convert.ToInt32(check) > 0)
            {
                loi = "Số điện thoại đã tồn tại trong hệ thống";
                return false;
            }

            int result = DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiemTichLuy, NgayDangKy) VALUES (@ten, @sdt, @email, @diem, @ngay)",
                new SqlParameter("@ten", kh.HoTen),
                new SqlParameter("@sdt", kh.SoDienThoai),
                new SqlParameter("@email", string.IsNullOrEmpty(kh.Email) ? (object)DBNull.Value : kh.Email),
                new SqlParameter("@diem", kh.DiemTichLuy),
                new SqlParameter("@ngay", kh.NgayDangKy));

            if (result > 0)
            {
                if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
                return true;
            }
            loi = "Không thể thêm khách hàng";
            return false;
        }

        public bool CapNhat(KhachHang khMoi, out string loi)
        {
            loi = "";
            if (!khMoi.HopLe(out loi)) return false;

            var check = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @sdt AND MaKH != @ma",
                new SqlParameter("@sdt", khMoi.SoDienThoai),
                new SqlParameter("@ma", khMoi.MaKH));
            if (check != null && Convert.ToInt32(check) > 0)
            {
                loi = "Số điện thoại đã được dùng bởi khách hàng khác";
                return false;
            }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE KhachHang SET HoTen = @ten, SoDienThoai = @sdt, Email = @email WHERE MaKH = @ma",
                new SqlParameter("@ten", khMoi.HoTen),
                new SqlParameter("@sdt", khMoi.SoDienThoai),
                new SqlParameter("@email", string.IsNullOrEmpty(khMoi.Email) ? (object)DBNull.Value : khMoi.Email),
                new SqlParameter("@ma", khMoi.MaKH));

            if (result > 0)
            {
                if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy thông tin khách hàng";
            return false;
        }

        public bool Xoa(int maKH, out string loi)
        {
            loi = "";
            DatabaseHelper.ExecuteNonQuery("DELETE FROM ChiTietDoiQua WHERE MaKH = @ma", new SqlParameter("@ma", maKH));
            DatabaseHelper.ExecuteNonQuery("DELETE FROM LichSuGiaoDich WHERE MaKH = @ma", new SqlParameter("@ma", maKH));

            int result = DatabaseHelper.ExecuteNonQuery("DELETE FROM KhachHang WHERE MaKH = @ma", new SqlParameter("@ma", maKH));
            if (result > 0)
            {
                if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
                return true;
            }
            loi = "Không thể xóa khách hàng này";
            return false;
        }

        public List<KhachHang> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return LayDanhSach();

            var list = new List<KhachHang>();
            var dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM KhachHang WHERE HoTen LIKE @kw OR SoDienThoai LIKE @kw OR Email LIKE @kw ORDER BY MaKH DESC",
                new SqlParameter("@kw", "%" + tuKhoa.Trim() + "%"));

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new KhachHang
                {
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                    DiemTichLuy = Convert.ToInt32(row["DiemTichLuy"]),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"])
                });
            }
            return list;
        }

        public KhachHang LayTheoMa(int maKH)
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM KhachHang WHERE MaKH = @ma", new SqlParameter("@ma", maKH));
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new KhachHang
                {
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                    DiemTichLuy = Convert.ToInt32(row["DiemTichLuy"]),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"])
                };
            }
            return null;
        }

        public bool CongDiem(int maKH, int diem, out string loi)
        {
            loi = "";
            var kh = LayTheoMa(maKH);
            if (kh == null) { loi = "Không tìm thấy khách hàng"; return false; }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @diem WHERE MaKH = @ma",
                new SqlParameter("@diem", diem),
                new SqlParameter("@ma", maKH));

            if (result > 0)
            {
                ThemLichSu(new LichSuGiaoDich(maKH, "Cộng điểm", diem));
                if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
                return true;
            }
            loi = "Lỗi cộng điểm";
            return false;
        }

        public bool DoiQua(int maKH, int diem, out string loi)
        {
            loi = "";
            var kh = LayTheoMa(maKH);
            if (kh == null) { loi = "Không tìm thấy khách hàng"; return false; }
            if (kh.DiemTichLuy < diem) { loi = "Điểm tích lũy không đủ"; return false; }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy - @diem WHERE MaKH = @ma",
                new SqlParameter("@diem", diem),
                new SqlParameter("@ma", maKH));

            if (result > 0)
            {
                ThemLichSu(new LichSuGiaoDich(maKH, "Đổi quà", -diem));
                if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
                return true;
            }
            loi = "Lỗi trừ điểm";
            return false;
        }

        public bool BanThuoc(int maKH, List<ChiTietBanThuoc> chiTietBan, out string loi, out int diemCong, out decimal tongTien)
        {
            loi = "";
            diemCong = 0;
            tongTien = 0;

            var kh = LayTheoMa(maKH);
            if (kh == null) { loi = "Chưa chọn khách hàng hoặc khách không tồn tại!"; return false; }

            foreach (var ct in chiTietBan)
            {
                var thuoc = LayThuocTheoMa(ct.MaThuoc);
                if (thuoc == null) { loi = "Không tìm thấy thuốc: " + ct.TenThuoc; return false; }
                if (thuoc.SoLuongTon < ct.SoLuong)
                {
                    loi = string.Format("Thuốc '{0}' chỉ còn tồn {1} {2}", thuoc.TenThuoc, thuoc.SoLuongTon, thuoc.DonViTinh);
                    return false;
                }
            }

            foreach (var ct in chiTietBan)
            {
                tongTien += ct.ThanhTien;
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Thuoc SET SoLuongTon = SoLuongTon - @sl WHERE MaThuoc = @ma",
                    new SqlParameter("@sl", ct.SoLuong),
                    new SqlParameter("@ma", ct.MaThuoc));
            }

            diemCong = (int)Math.Floor(tongTien / 1000);
            if (diemCong > 0)
            {
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @diem WHERE MaKH = @ma",
                    new SqlParameter("@diem", diemCong),
                    new SqlParameter("@ma", maKH));
            }

            ThemLichSu(new LichSuGiaoDich(maKH, "Bán thuốc", diemCong, tongTien, chiTietBan));

            if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
            if (DanhSachThuocDaThayDoi != null) DanhSachThuocDaThayDoi();
            return true;
        }

        public bool DoiQuaTuKho(int maKH, int maQua, int soLuong, out string loi)
        {
            loi = "";
            var kh = LayTheoMa(maKH);
            if (kh == null) { loi = "Chưa chọn khách hàng!"; return false; }

            var qua = LayQuaTheoMa(maQua);
            if (qua == null) { loi = "Không tìm thấy thông tin quà tặng!"; return false; }
            if (qua.SoLuongTon < soLuong) { loi = string.Format("Quà '{0}' chỉ còn tồn {1} {2}", qua.TenQua, qua.SoLuongTon, qua.DonViTinh); return false; }

            int tongDiemCan = qua.DiemCan * soLuong;
            if (kh.DiemTichLuy < tongDiemCan)
            {
                loi = string.Format("Điểm tích lũy không đủ! Cần {0:N0} điểm (khách hiện có: {1:N0} điểm)", tongDiemCan, kh.DiemTichLuy);
                return false;
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Qua SET SoLuongTon = SoLuongTon - @sl WHERE MaQua = @ma",
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@ma", maQua));

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE KhachHang SET DiemTichLuy = 0 WHERE MaKH = @ma",
                new SqlParameter("@ma", maKH));

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO ChiTietDoiQua (MaKH, MaQua, TenQua, SoLuong, DiemTru) VALUES (@makh, @maqua, @ten, @sl, @diem)",
                new SqlParameter("@makh", maKH),
                new SqlParameter("@maqua", maQua),
                new SqlParameter("@ten", qua.TenQua),
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@diem", tongDiemCan));

            ThemLichSu(new LichSuGiaoDich(maKH, "Đổi quà", -tongDiemCan));

            if (DuLieuDaThayDoi != null) DuLieuDaThayDoi();
            if (DanhSachQuaDaThayDoi != null) DanhSachQuaDaThayDoi();
            return true;
        }
        #endregion

        #region Thuốc
        public List<Thuoc> LayDanhSachThuoc()
        {
            var list = new List<Thuoc>();
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Thuoc ORDER BY MaThuoc DESC");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Thuoc
                {
                    MaThuoc = Convert.ToInt32(row["MaThuoc"]),
                    TenThuoc = row["TenThuoc"].ToString(),
                    DonViTinh = row["DonViTinh"].ToString(),
                    DonGia = Convert.ToDecimal(row["DonGia"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    NhaSanXuat = row["NhaSanXuat"] != DBNull.Value ? row["NhaSanXuat"].ToString() : "",
                    HanSuDung = row["HanSuDung"] != DBNull.Value ? Convert.ToDateTime(row["HanSuDung"]) : DateTime.Now.AddYears(2),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : ""
                });
            }
            return list;
        }

        public List<Thuoc> TimKiemThuoc(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return LayDanhSachThuoc();

            var list = new List<Thuoc>();
            var dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Thuoc WHERE TenThuoc LIKE @kw OR DonViTinh LIKE @kw OR NhaSanXuat LIKE @kw ORDER BY MaThuoc DESC",
                new SqlParameter("@kw", "%" + tuKhoa.Trim() + "%"));

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Thuoc
                {
                    MaThuoc = Convert.ToInt32(row["MaThuoc"]),
                    TenThuoc = row["TenThuoc"].ToString(),
                    DonViTinh = row["DonViTinh"].ToString(),
                    DonGia = Convert.ToDecimal(row["DonGia"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    NhaSanXuat = row["NhaSanXuat"] != DBNull.Value ? row["NhaSanXuat"].ToString() : "",
                    HanSuDung = row["HanSuDung"] != DBNull.Value ? Convert.ToDateTime(row["HanSuDung"]) : DateTime.Now.AddYears(2),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : ""
                });
            }
            return list;
        }

        public Thuoc LayThuocTheoMa(int maThuoc)
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Thuoc WHERE MaThuoc = @ma", new SqlParameter("@ma", maThuoc));
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Thuoc
                {
                    MaThuoc = Convert.ToInt32(row["MaThuoc"]),
                    TenThuoc = row["TenThuoc"].ToString(),
                    DonViTinh = row["DonViTinh"].ToString(),
                    DonGia = Convert.ToDecimal(row["DonGia"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    NhaSanXuat = row["NhaSanXuat"] != DBNull.Value ? row["NhaSanXuat"].ToString() : "",
                    HanSuDung = row["HanSuDung"] != DBNull.Value ? Convert.ToDateTime(row["HanSuDung"]) : DateTime.Now.AddYears(2),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : ""
                };
            }
            return null;
        }

        public bool ThemThuoc(Thuoc thuoc, out string loi)
        {
            loi = "";
            if (!thuoc.HopLe(out loi)) return false;

            var check = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Thuoc WHERE TenThuoc = @ten AND DonViTinh = @dvt",
                new SqlParameter("@ten", thuoc.TenThuoc),
                new SqlParameter("@dvt", thuoc.DonViTinh));
            if (check != null && Convert.ToInt32(check) > 0)
            {
                loi = "Thuốc đã tồn tại (trùng cả tên và đơn vị tính)";
                return false;
            }

            int result = DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, NhaSanXuat, HanSuDung, MoTa) VALUES (@ten, @dvt, @gia, @ton, @nsx, @hsd, @mota)",
                new SqlParameter("@ten", thuoc.TenThuoc),
                new SqlParameter("@dvt", thuoc.DonViTinh),
                new SqlParameter("@gia", thuoc.DonGia),
                new SqlParameter("@ton", thuoc.SoLuongTon),
                new SqlParameter("@nsx", string.IsNullOrEmpty(thuoc.NhaSanXuat) ? (object)DBNull.Value : thuoc.NhaSanXuat),
                new SqlParameter("@hsd", thuoc.HanSuDung),
                new SqlParameter("@mota", string.IsNullOrEmpty(thuoc.MoTa) ? (object)DBNull.Value : thuoc.MoTa));

            if (result > 0)
            {
                if (DanhSachThuocDaThayDoi != null) DanhSachThuocDaThayDoi();
                return true;
            }
            loi = "Lỗi thêm thuốc";
            return false;
        }

        public bool CapNhatThuoc(Thuoc thuocMoi, out string loi)
        {
            loi = "";
            if (!thuocMoi.HopLe(out loi)) return false;

            var check = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Thuoc WHERE TenThuoc = @ten AND DonViTinh = @dvt AND MaThuoc != @ma",
                new SqlParameter("@ten", thuocMoi.TenThuoc),
                new SqlParameter("@dvt", thuocMoi.DonViTinh),
                new SqlParameter("@ma", thuocMoi.MaThuoc));
            if (check == null)
            {
                loi = "Thuốc không tồn tại";
                return false;
            }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE Thuoc SET TenThuoc = @ten, DonViTinh = @dvt, DonGia = @gia, SoLuongTon = @ton, NhaSanXuat = @nsx, HanSuDung = @hsd, MoTa = @mota WHERE MaThuoc = @ma",
                new SqlParameter("@ten", thuocMoi.TenThuoc),
                new SqlParameter("@dvt", thuocMoi.DonViTinh),
                new SqlParameter("@gia", thuocMoi.DonGia),
                new SqlParameter("@ton", thuocMoi.SoLuongTon),
                new SqlParameter("@nsx", string.IsNullOrEmpty(thuocMoi.NhaSanXuat) ? (object)DBNull.Value : thuocMoi.NhaSanXuat),
                new SqlParameter("@hsd", thuocMoi.HanSuDung),
                new SqlParameter("@mota", string.IsNullOrEmpty(thuocMoi.MoTa) ? (object)DBNull.Value : thuocMoi.MoTa),
                new SqlParameter("@ma", thuocMoi.MaThuoc));

            if (result > 0)
            {
                if (DanhSachThuocDaThayDoi != null) DanhSachThuocDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy thuốc cần sửa";
            return false;
        }

        public bool XoaThuoc(int maThuoc, out string loi)
        {
            loi = "";
            int result = DatabaseHelper.ExecuteNonQuery("DELETE FROM Thuoc WHERE MaThuoc = @ma", new SqlParameter("@ma", maThuoc));
            if (result > 0)
            {
                if (DanhSachThuocDaThayDoi != null) DanhSachThuocDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy thuốc hoặc thuốc đang được tham chiếu";
            return false;
        }

        public bool NhapKhoThuoc(int maThuoc, int soLuong, out string loi)
        {
            loi = "";
            if (soLuong <= 0) { loi = "Số lượng nhập phải lớn hơn 0"; return false; }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE Thuoc SET SoLuongTon = SoLuongTon + @sl WHERE MaThuoc = @ma",
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@ma", maThuoc));

            if (result > 0)
            {
                if (DanhSachThuocDaThayDoi != null) DanhSachThuocDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy thuốc";
            return false;
        }
        #endregion

        #region Quà
        public List<Qua> LayDanhSachQua()
        {
            var list = new List<Qua>();
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Qua ORDER BY MaQua DESC");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Qua
                {
                    MaQua = Convert.ToInt32(row["MaQua"]),
                    TenQua = row["TenQua"].ToString(),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : "",
                    DiemCan = Convert.ToInt32(row["DiemCan"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    DonViTinh = row["DonViTinh"].ToString(),
                    HinhAnh = row["HinhAnh"] != DBNull.Value ? row["HinhAnh"].ToString() : "",
                    TrangThai = Convert.ToBoolean(row["TrangThai"]),
                    NgayTao = Convert.ToDateTime(row["NgayTao"])
                });
            }
            return list;
        }

        public List<Qua> LayDanhSachQuaSanSang()
        {
            var list = new List<Qua>();
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Qua WHERE TrangThai = 1 AND SoLuongTon > 0 ORDER BY DiemCan ASC");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Qua
                {
                    MaQua = Convert.ToInt32(row["MaQua"]),
                    TenQua = row["TenQua"].ToString(),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : "",
                    DiemCan = Convert.ToInt32(row["DiemCan"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    DonViTinh = row["DonViTinh"].ToString(),
                    HinhAnh = row["HinhAnh"] != DBNull.Value ? row["HinhAnh"].ToString() : "",
                    TrangThai = Convert.ToBoolean(row["TrangThai"]),
                    NgayTao = Convert.ToDateTime(row["NgayTao"])
                });
            }
            return list;
        }

        public Qua LayQuaTheoMa(int maQua)
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Qua WHERE MaQua = @ma", new SqlParameter("@ma", maQua));
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Qua
                {
                    MaQua = Convert.ToInt32(row["MaQua"]),
                    TenQua = row["TenQua"].ToString(),
                    MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : "",
                    DiemCan = Convert.ToInt32(row["DiemCan"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    DonViTinh = row["DonViTinh"].ToString(),
                    HinhAnh = row["HinhAnh"] != DBNull.Value ? row["HinhAnh"].ToString() : "",
                    TrangThai = Convert.ToBoolean(row["TrangThai"]),
                    NgayTao = Convert.ToDateTime(row["NgayTao"])
                };
            }
            return null;
        }

        public bool ThemQua(Qua qua, out string loi)
        {
            loi = "";
            if (!qua.HopLe(out loi)) return false;

            int result = DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Qua (TenQua, MoTa, DiemCan, SoLuongTon, DonViTinh, HinhAnh, TrangThai, NgayTao) VALUES (@ten, @mota, @diem, @ton, @dvt, @anh, @tt, @ngay)",
                new SqlParameter("@ten", qua.TenQua),
                new SqlParameter("@mota", string.IsNullOrEmpty(qua.MoTa) ? (object)DBNull.Value : qua.MoTa),
                new SqlParameter("@diem", qua.DiemCan),
                new SqlParameter("@ton", qua.SoLuongTon),
                new SqlParameter("@dvt", qua.DonViTinh),
                new SqlParameter("@anh", string.IsNullOrEmpty(qua.HinhAnh) ? (object)DBNull.Value : qua.HinhAnh),
                new SqlParameter("@tt", qua.TrangThai),
                new SqlParameter("@ngay", qua.NgayTao));

            if (result > 0)
            {
                if (DanhSachQuaDaThayDoi != null) DanhSachQuaDaThayDoi();
                return true;
            }
            loi = "Lỗi thêm quà";
            return false;
        }

        public bool CapNhatQua(Qua quaMoi, out string loi)
        {
            loi = "";
            if (!quaMoi.HopLe(out loi)) return false;

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE Qua SET TenQua = @ten, MoTa = @mota, DiemCan = @diem, SoLuongTon = @ton, DonViTinh = @dvt, HinhAnh = @anh, TrangThai = @tt WHERE MaQua = @ma",
                new SqlParameter("@ten", quaMoi.TenQua),
                new SqlParameter("@mota", string.IsNullOrEmpty(quaMoi.MoTa) ? (object)DBNull.Value : quaMoi.MoTa),
                new SqlParameter("@diem", quaMoi.DiemCan),
                new SqlParameter("@ton", quaMoi.SoLuongTon),
                new SqlParameter("@dvt", quaMoi.DonViTinh),
                new SqlParameter("@anh", string.IsNullOrEmpty(quaMoi.HinhAnh) ? (object)DBNull.Value : quaMoi.HinhAnh),
                new SqlParameter("@tt", quaMoi.TrangThai),
                new SqlParameter("@ma", quaMoi.MaQua));

            if (result > 0)
            {
                if (DanhSachQuaDaThayDoi != null) DanhSachQuaDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy thông tin quà";
            return false;
        }

        public bool XoaQua(int maQua, out string loi)
        {
            loi = "";
            int result = DatabaseHelper.ExecuteNonQuery("DELETE FROM Qua WHERE MaQua = @ma", new SqlParameter("@ma", maQua));
            if (result > 0)
            {
                if (DanhSachQuaDaThayDoi != null) DanhSachQuaDaThayDoi();
                return true;
            }
            loi = "Không thể xóa quà tặng";
            return false;
        }

        public bool NhapKhoQua(int maQua, int soLuong, out string loi)
        {
            loi = "";
            if (soLuong <= 0) { loi = "Số lượng nhập phải lớn hơn 0"; return false; }

            int result = DatabaseHelper.ExecuteNonQuery(
                "UPDATE Qua SET SoLuongTon = SoLuongTon + @sl WHERE MaQua = @ma",
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@ma", maQua));

            if (result > 0)
            {
                if (DanhSachQuaDaThayDoi != null) DanhSachQuaDaThayDoi();
                return true;
            }
            loi = "Không tìm thấy quà";
            return false;
        }
        #endregion

        #region Lịch sử
        private void ThemLichSu(LichSuGiaoDich ls)
        {
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO LichSuGiaoDich (MaGiaoDich, MaKH, NgayGio, LoaiGiaoDich, SoDiemThayDoi, TongTien, ChiTietThuoc) VALUES (@magd, @makh, @ngay, @loai, @diem, @tien, @ct)",
                new SqlParameter("@magd", ls.MaGiaoDich),
                new SqlParameter("@makh", ls.MaKH),
                new SqlParameter("@ngay", ls.NgayGio),
                new SqlParameter("@loai", ls.LoaiGiaoDich),
                new SqlParameter("@diem", ls.SoDiemThayDoi),
                new SqlParameter("@tien", ls.TongTien),
                new SqlParameter("@ct", string.IsNullOrEmpty(ls.ChiTietToString()) ? (object)DBNull.Value : ls.ChiTietToString()));
        }

        public List<LichSuGiaoDich> LayLichSuTheoKH(int maKH)
        {
            var list = new List<LichSuGiaoDich>();
            var dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM LichSuGiaoDich WHERE MaKH = @ma ORDER BY NgayGio DESC",
                new SqlParameter("@ma", maKH));

            foreach (DataRow row in dt.Rows)
            {
                var ls = new LichSuGiaoDich
                {
                    MaGiaoDich = row["MaGiaoDich"].ToString(),
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    NgayGio = Convert.ToDateTime(row["NgayGio"]),
                    LoaiGiaoDich = row["LoaiGiaoDich"].ToString(),
                    SoDiemThayDoi = Convert.ToInt32(row["SoDiemThayDoi"]),
                    TongTien = Convert.ToDecimal(row["TongTien"]),
                    ChiTietThuoc = new List<ChiTietBanThuoc>()
                };

                string ctStr = row["ChiTietThuoc"] != DBNull.Value ? row["ChiTietThuoc"].ToString() : "";
                if (!string.IsNullOrEmpty(ctStr))
                {
                    var parts = ctStr.Split(';');
                    foreach (var p in parts)
                    {
                        var ct = ChiTietBanThuoc.TuChuoi(p);
                        if (ct != null) ls.ChiTietThuoc.Add(ct);
                    }
                }
                list.Add(ls);
            }
            return list;
        }

        public List<LichSuGiaoDich> LayTatCaLichSu()
        {
            var list = new List<LichSuGiaoDich>();
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM LichSuGiaoDich ORDER BY NgayGio DESC");
            foreach (DataRow row in dt.Rows)
            {
                var ls = new LichSuGiaoDich
                {
                    MaGiaoDich = row["MaGiaoDich"].ToString(),
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    NgayGio = Convert.ToDateTime(row["NgayGio"]),
                    LoaiGiaoDich = row["LoaiGiaoDich"].ToString(),
                    SoDiemThayDoi = Convert.ToInt32(row["SoDiemThayDoi"]),
                    TongTien = Convert.ToDecimal(row["TongTien"]),
                    ChiTietThuoc = new List<ChiTietBanThuoc>()
                };

                string ctStr = row["ChiTietThuoc"] != DBNull.Value ? row["ChiTietThuoc"].ToString() : "";
                if (!string.IsNullOrEmpty(ctStr))
                {
                    var parts = ctStr.Split(';');
                    foreach (var p in parts)
                    {
                        var ct = ChiTietBanThuoc.TuChuoi(p);
                        if (ct != null) ls.ChiTietThuoc.Add(ct);
                    }
                }
                list.Add(ls);
            }
            return list;
        }
        #endregion

        #region Thống kê
        public List<ThongKeNgayItem> ThongKeTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            var dt = DatabaseHelper.ExecuteQuery(
                "SELECT CAST(NgayGio AS DATE) as Ngay, SUM(TongTien) as DoanhThu, COUNT(*) as SoHoaDon, SUM(SoDiemThayDoi) as DiemCong " +
                "FROM LichSuGiaoDich WHERE LoaiGiaoDich = N'Bán thuốc' AND CAST(NgayGio AS DATE) >= @tuNgay AND CAST(NgayGio AS DATE) <= @denNgay " +
                "GROUP BY CAST(NgayGio AS DATE) ORDER BY Ngay",
                new SqlParameter("@tuNgay", tuNgay.Date),
                new SqlParameter("@denNgay", denNgay.Date));

            var result = new List<ThongKeNgayItem>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(new ThongKeNgayItem
                {
                    Ngay = Convert.ToDateTime(row["Ngay"]),
                    DoanhThu = Convert.ToDecimal(row["DoanhThu"]),
                    SoHoaDon = Convert.ToInt32(row["SoHoaDon"]),
                    DiemCong = Convert.ToInt32(row["DiemCong"])
                });
            }

            var fullResult = new List<ThongKeNgayItem>();
            for (var d = tuNgay.Date; d <= denNgay.Date; d = d.AddDays(1))
            {
                var found = result.Find(delegate (ThongKeNgayItem x) { return x.Ngay.Date == d; });
                if (found != null)
                    fullResult.Add(found);
                else
                    fullResult.Add(new ThongKeNgayItem { Ngay = d, DoanhThu = 0, SoHoaDon = 0, DiemCong = 0 });
            }
            return fullResult;
        }

        public List<TopThuocItem> TopThuocBanChay(DateTime? tuNgay = null, DateTime? denNgay = null, int top = 10)
        {
            var lichSu = LayTatCaLichSu().FindAll(delegate (LichSuGiaoDich x)
            {
                return x.LoaiGiaoDich == "Bán thuốc" && x.ChiTietThuoc != null;
            });

            if (tuNgay.HasValue) lichSu = lichSu.FindAll(delegate (LichSuGiaoDich x) { return x.NgayGio.Date >= tuNgay.Value.Date; });
            if (denNgay.HasValue) lichSu = lichSu.FindAll(delegate (LichSuGiaoDich x) { return x.NgayGio.Date <= denNgay.Value.Date; });

            var chiTietList = new List<ChiTietBanThuoc>();
            foreach (var ls in lichSu) chiTietList.AddRange(ls.ChiTietThuoc);

            var groups = new Dictionary<string, Tuple<int, decimal>>();
            foreach (var ct in chiTietList)
            {
                string key = ct.TenThuoc + " (" + ct.DonViTinh + ")";
                if (groups.ContainsKey(key))
                {
                    var g = groups[key];
                    groups[key] = Tuple.Create(g.Item1 + ct.SoLuong, g.Item2 + ct.ThanhTien);
                }
                else
                {
                    groups[key] = Tuple.Create(ct.SoLuong, ct.ThanhTien);
                }
            }

            var sorted = new List<TopThuocItem>();
            foreach (var kvp in groups)
            {
                sorted.Add(new TopThuocItem
                {
                    TenThuoc = kvp.Key,
                    SoLuongBan = kvp.Value.Item1,
                    DoanhThu = kvp.Value.Item2
                });
            }

            sorted.Sort(delegate (TopThuocItem x, TopThuocItem y) { return y.SoLuongBan.CompareTo(x.SoLuongBan); });
            if (sorted.Count > top) sorted = sorted.GetRange(0, top);
            return sorted;
        }

        public List<TopKhachHangItem> TopKhachHangMuaNhieu(DateTime? tuNgay = null, DateTime? denNgay = null, int top = 10)
        {
            var lichSu = LayTatCaLichSu().FindAll(delegate (LichSuGiaoDich x) { return x.LoaiGiaoDich == "Bán thuốc"; });

            if (tuNgay.HasValue) lichSu = lichSu.FindAll(delegate (LichSuGiaoDich x) { return x.NgayGio.Date >= tuNgay.Value.Date; });
            if (denNgay.HasValue) lichSu = lichSu.FindAll(delegate (LichSuGiaoDich x) { return x.NgayGio.Date <= denNgay.Value.Date; });

            var groups = new Dictionary<int, Tuple<int, int, decimal>>();
            foreach (var x in lichSu)
            {
                int key = x.MaKH;
                if (groups.ContainsKey(key))
                {
                    var g = groups[key];
                    groups[key] = Tuple.Create(g.Item1 + x.SoDiemThayDoi, g.Item2 + 1, g.Item3 + x.TongTien);
                }
                else
                {
                    groups[key] = Tuple.Create(x.SoDiemThayDoi, 1, x.TongTien);
                }
            }

            var sorted = new List<TopKhachHangItem>();
            foreach (var kvp in groups)
            {
                var kh = LayTheoMa(kvp.Key);
                sorted.Add(new TopKhachHangItem
                {
                    MaKH = kvp.Key,
                    TenKH = kh != null ? kh.HoTen : "N/A",
                    TongDiem = kvp.Value.Item1,
                    SoLanMua = kvp.Value.Item2,
                    TongTienMua = kvp.Value.Item3
                });
            }

            sorted.Sort(delegate (TopKhachHangItem x, TopKhachHangItem y) { return y.TongTienMua.CompareTo(x.TongTienMua); });
            if (sorted.Count > top) sorted = sorted.GetRange(0, top);
            return sorted;
        }

        public ThongKeDonGian LayThongKeDonGian()
        {
            var result = new ThongKeDonGian();

            var dtKH = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) as TongKH, ISNULL(SUM(DiemTichLuy),0) as TongDiem FROM KhachHang");
            if (dtKH.Rows.Count > 0)
            {
                result.TongKhachHang = Convert.ToInt32(dtKH.Rows[0]["TongKH"]);
                result.TongDiemTichLuy = Convert.ToInt32(dtKH.Rows[0]["TongDiem"]);
            }

            var dtHomNay = DatabaseHelper.ExecuteQuery(
                "SELECT ISNULL(SUM(TongTien),0) as DoanhThu, COUNT(*) as SoHD FROM LichSuGiaoDich WHERE LoaiGiaoDich = N'Bán thuốc' AND CAST(NgayGio AS DATE) = CAST(GETDATE() AS DATE)");
            if (dtHomNay.Rows.Count > 0)
            {
                result.DoanhThuHomNay = Convert.ToDecimal(dtHomNay.Rows[0]["DoanhThu"]);
                result.SoDonHomNay = Convert.ToInt32(dtHomNay.Rows[0]["SoHD"]);
            }

            var dtThangNay = DatabaseHelper.ExecuteQuery(
                "SELECT ISNULL(SUM(TongTien),0) as DoanhThu, COUNT(*) as SoHD FROM LichSuGiaoDich WHERE LoaiGiaoDich = N'Bán thuốc' AND MONTH(NgayGio) = MONTH(GETDATE()) AND YEAR(NgayGio) = YEAR(GETDATE())");
            if (dtThangNay.Rows.Count > 0)
            {
                result.DoanhThuThangNay = Convert.ToDecimal(dtThangNay.Rows[0]["DoanhThu"]);
                result.SoDonThangNay = Convert.ToInt32(dtThangNay.Rows[0]["SoHD"]);
            }

            var dtThuocSapHet = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) FROM Thuoc WHERE SoLuongTon <= 10");
            if (dtThuocSapHet.Rows.Count > 0) result.ThuocSapHetHang = Convert.ToInt32(dtThuocSapHet.Rows[0][0]);

            var dtQuaSapHet = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) FROM Qua WHERE SoLuongTon <= 5 AND TrangThai = 1");
            if (dtQuaSapHet.Rows.Count > 0) result.QuaSapHetHang = Convert.ToInt32(dtQuaSapHet.Rows[0][0]);

            return result;
        }
        #endregion
    }

    #region Các class dữ liệu thống kê (Data Transfer Objects)
    public class ThongKeNgayItem
    {
        public DateTime Ngay { get; set; }
        public decimal DoanhThu { get; set; }
        public int SoHoaDon { get; set; }
        public int DiemCong { get; set; }
    }

    public class ThongKeDonGian
    {
        public int TongKhachHang { get; set; }
        public int TongDiemTichLuy { get; set; }
        public decimal DoanhThuHomNay { get; set; }
        public int SoDonHomNay { get; set; }
        public decimal DoanhThuThangNay { get; set; }
        public int SoDonThangNay { get; set; }
        public int ThuocSapHetHang { get; set; }
        public int QuaSapHetHang { get; set; }
    }

    public class TopThuocItem
    {
        public string TenThuoc { get; set; }
        public int SoLuongBan { get; set; }
        public decimal DoanhThu { get; set; }
    }

    public class TopKhachHangItem
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public int TongDiem { get; set; }
        public int SoLanMua { get; set; }
        public decimal TongTienMua { get; set; }
    }
    #endregion
}