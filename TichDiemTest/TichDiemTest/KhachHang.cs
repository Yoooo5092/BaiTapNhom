using System;

namespace TichDiemTest
{
    /// <summary>
    /// Class đại diện cho một khách hàng - đơn giản, dễ hiểu cho sinh viên
    /// </summary>
    public class KhachHang
    {
        // Các thuộc tính cơ bản
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int DiemTichLuy { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string CapBac { get; set; } // Đồng, Bạc, Vàng, Kim cương

        // Constructor mặc định
        public KhachHang()
        {
            NgayDangKy = DateTime.Now;
            DiemTichLuy = 0;
            CapBac = "Đồng";
        }

        // Constructor đầy đủ
        public KhachHang(int maKH, string hoTen, string sdt, string email, int diem = 0)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SoDienThoai = sdt;
            Email = email;
            DiemTichLuy = diem;
            NgayDangKy = DateTime.Now;
            CapNhatCapBac();
        }

        /// <summary>
        /// Cập nhật cấp bạc dựa trên điểm tích lũy
        /// </summary>
        public void CapNhatCapBac()
        {
            if (DiemTichLuy >= 10000) CapBac = "Kim cương";
            else if (DiemTichLuy >= 5000) CapBac = "Vàng";
            else if (DiemTichLuy >= 1000) CapBac = "Bạc";
            else CapBac = "Đồng";
        }

        /// <summary>
        /// Cộng điểm cho khách hàng
        /// </summary>
        public void CongDiem(int diem)
        {
            if (diem > 0)
            {
                DiemTichLuy += diem;
                CapNhatCapBac();
            }
        }

        /// <summary>
        /// Trừ điểm (khi đổi quà)
        /// </summary>
        public bool TruDiem(int diem)
        {
            if (diem > 0 && DiemTichLuy >= diem)
            {
                DiemTichLuy -= diem;
                CapNhatCapBac();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Chuyển đối tượng thành chuỗi để lưu file (dạng CSV)
        /// </summary>
        public override string ToString()
        {
            return $"{MaKH}|{HoTen}|{SoDienThoai}|{Email}|{DiemTichLuy}|{NgayDangKy:yyyy-MM-dd}|{CapBac}";
        }

        /// <summary>
        /// Tạo khách hàng từ chuỗi đọc từ file
        /// </summary>
        public static KhachHang TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 6)
                {
                    return new KhachHang
                    {
                        MaKH = int.Parse(parts[0]),
                        HoTen = parts[1],
                        SoDienThoai = parts[2],
                        Email = parts[3],
                        DiemTichLuy = int.Parse(parts[4]),
                        NgayDangKy = DateTime.Parse(parts[5]),
                        CapBac = parts.Length > 6 ? parts[6] : "Đồng"
                    };
                }
            }
            catch { }
            return null;
        }

        /// <summary>
        /// Kiểm tra thông tin hợp lệ
        /// </summary>
        public bool HopLe(out string loi)
        {
            loi = "";
            if (string.IsNullOrWhiteSpace(HoTen)) loi = "Họ tên không được để trống";
            else if (string.IsNullOrWhiteSpace(SoDienThoai)) loi = "Số điện thoại không được để trống";
            else if (SoDienThoai.Length < 9 || SoDienThoai.Length > 11) loi = "Số điện thoại phải từ 9-11 chữ số";
            else if (!string.IsNullOrWhiteSpace(Email) && !Email.Contains("@")) loi = "Email không đúng định dạng";
            return string.IsNullOrEmpty(loi);
        }
    }
}