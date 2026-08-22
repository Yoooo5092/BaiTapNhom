using System;

namespace TichDiemTest
{
    public class Qua
    {
        public int MaQua { get; set; }
        public string TenQua { get; set; }
        public string MoTa { get; set; }
        public int DiemCan { get; set; }
        public int SoLuongTon { get; set; }
        public string DonViTinh { get; set; }
        public string HinhAnh { get; set; }
        public bool TrangThai { get; set; } // true = còn hàng, false = hết hàng/ngừng đổi
        public DateTime NgayTao { get; set; }

        public Qua()
        {
            DonViTinh = "Cái";
            SoLuongTon = 0;
            DiemCan = 0;
            TrangThai = true;
            NgayTao = DateTime.Now;
        }

        public Qua(int maQua, string tenQua, string moTa, int diemCan, int soLuongTon = 0, string donViTinh = "Cái", string hinhAnh = "", bool trangThai = true)
        {
            MaQua = maQua;
            TenQua = tenQua;
            MoTa = moTa;
            DiemCan = diemCan;
            SoLuongTon = soLuongTon;
            DonViTinh = donViTinh;
            HinhAnh = hinhAnh;
            TrangThai = trangThai;
            NgayTao = DateTime.Now;
        }

        public bool HopLe(out string loi)
        {
            loi = "";
            if (string.IsNullOrWhiteSpace(TenQua))
                loi = "Tên quà không được để trống";
            else if (DiemCan <= 0)
                loi = "Điểm cần phải lớn hơn 0";
            else if (SoLuongTon < 0)
                loi = "Số lượng tồn không được âm";
            else if (string.IsNullOrWhiteSpace(DonViTinh))
                loi = "Đơn vị tính không được để trống";
            return string.IsNullOrEmpty(loi);
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8:yyyy-MM-dd}",
                MaQua, TenQua, MoTa, DiemCan, SoLuongTon, DonViTinh, HinhAnh, TrangThai ? 1 : 0, NgayTao);
        }

        public static Qua TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 8)
                {
                    return new Qua
                    {
                        MaQua = int.Parse(parts[0]),
                        TenQua = parts[1],
                        MoTa = parts[2],
                        DiemCan = int.Parse(parts[3]),
                        SoLuongTon = int.Parse(parts[4]),
                        DonViTinh = parts[5],
                        HinhAnh = parts[6],
                        TrangThai = parts[7] == "1",
                        NgayTao = DateTime.Parse(parts[8])
                    };
                }
            }
            catch { }
            return null;
        }
    }

    public class ChiTietDoiQua
    {
        public int MaGiaoDich { get; set; }
        public int MaKH { get; set; }
        public int MaQua { get; set; }
        public string TenQua { get; set; }
        public int SoLuong { get; set; }
        public int DiemTru { get; set; }
        public DateTime NgayDoi { get; set; }

        public ChiTietDoiQua() { }

        public ChiTietDoiQua(int maKH, int maQua, string tenQua, int soLuong, int diemTru)
        {
            MaKH = maKH;
            MaQua = maQua;
            TenQua = tenQua;
            SoLuong = soLuong;
            DiemTru = diemTru;
            NgayDoi = DateTime.Now;
        }
    }
}