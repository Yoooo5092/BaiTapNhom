using System;
using System.Collections.Generic;

namespace TichDiemTest
{
    public class Thuoc
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string NhaSanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string MoTa { get; set; }

        public Thuoc()
        {
            DonViTinh = "Viên";
            SoLuongTon = 0;
            DonGia = 0;
            HanSuDung = DateTime.Now.AddYears(2);
        }

        public Thuoc(int maThuoc, string tenThuoc, string dvt, decimal donGia, int soLuongTon = 0, string nhaSX = "", DateTime? hanSuDung = null, string moTa = "")
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            DonViTinh = dvt;
            DonGia = donGia;
            SoLuongTon = soLuongTon;
            NhaSanXuat = nhaSX;
            HanSuDung = hanSuDung.HasValue ? hanSuDung.Value : DateTime.Now.AddYears(2);
            MoTa = moTa;
        }

        public decimal ThanhTien(int soLuong)
        {
            return DonGia * soLuong;
        }

        public bool HopLe(out string loi)
        {
            loi = "";
            if (string.IsNullOrWhiteSpace(TenThuoc))
                loi = "Tên thuốc không được để trống";
            else if (string.IsNullOrWhiteSpace(DonViTinh))
                loi = "Đơn vị tính không được để trống";
            else if (DonGia < 0)
                loi = "Đơn giá không được âm";
            else if (SoLuongTon < 0)
                loi = "Số lượng tồn không được âm";
            return string.IsNullOrEmpty(loi);
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6:yyyy-MM-dd}|{7}",
                MaThuoc, TenThuoc, DonViTinh, DonGia, SoLuongTon, NhaSanXuat, HanSuDung, MoTa);
        }

        public static Thuoc TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 5)
                {
                    var thuoc = new Thuoc
                    {
                        MaThuoc = int.Parse(parts[0]),
                        TenThuoc = parts[1],
                        DonViTinh = parts[2],
                        DonGia = decimal.Parse(parts[3]),
                        SoLuongTon = int.Parse(parts[4]),
                        NhaSanXuat = "",
                        HanSuDung = DateTime.Now.AddYears(2),
                        MoTa = ""
                    };

                    if (parts.Length > 5) thuoc.NhaSanXuat = parts[5];
                    if (parts.Length > 6)
                    {
                        DateTime hs;
                        if (DateTime.TryParse(parts[6], out hs)) thuoc.HanSuDung = hs;
                    }
                    if (parts.Length > 7) thuoc.MoTa = parts[7];

                    return thuoc;
                }
            }
            catch { }
            return null;
        }
    }

    public class ChiTietBanThuoc
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }

        public ChiTietBanThuoc() { }

        public ChiTietBanThuoc(Thuoc thuoc, int soLuong)
        {
            MaThuoc = thuoc.MaThuoc;
            TenThuoc = thuoc.TenThuoc;
            DonViTinh = thuoc.DonViTinh;
            DonGia = thuoc.DonGia;
            SoLuong = soLuong;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}",
                MaThuoc, TenThuoc, DonViTinh, DonGia, SoLuong);
        }

        public static ChiTietBanThuoc TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 5)
                {
                    return new ChiTietBanThuoc
                    {
                        MaThuoc = int.Parse(parts[0]),
                        TenThuoc = parts[1],
                        DonViTinh = parts[2],
                        DonGia = decimal.Parse(parts[3]),
                        SoLuong = int.Parse(parts[4])
                    };
                }
            }
            catch { }
            return null;
        }
    }
}