using System;
using System.Collections.Generic;

namespace TichDiemTest
{
    public class LichSuGiaoDich
    {
        public string MaGiaoDich { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayGio { get; set; }
        public string LoaiGiaoDich { get; set; }
        public int SoDiemThayDoi { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietBanThuoc> ChiTietThuoc { get; set; }

        public LichSuGiaoDich()
        {
            ChiTietThuoc = new List<ChiTietBanThuoc>();
        }

        public LichSuGiaoDich(int maKH, string loaiGiaoDich, int soDiemThayDoi, decimal tongTien = 0, List<ChiTietBanThuoc> chiTiet = null)
        {
            MaGiaoDich = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            MaKH = maKH;
            NgayGio = DateTime.Now;
            LoaiGiaoDich = loaiGiaoDich;
            SoDiemThayDoi = soDiemThayDoi;
            TongTien = tongTien;
            ChiTietThuoc = chiTiet != null ? chiTiet : new List<ChiTietBanThuoc>();
        }

        public string ChiTietToString()
        {
            if (ChiTietThuoc == null || ChiTietThuoc.Count == 0) return "";
            var list = new List<string>();
            foreach (var x in ChiTietThuoc) list.Add(x.ToString());
            return string.Join(";", list);
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2:yyyy-MM-dd HH:mm:ss}|{3}|{4}|{5}|{6}",
                MaGiaoDich, MaKH, NgayGio, LoaiGiaoDich, SoDiemThayDoi, TongTien, ChiTietToString());
        }

        public static LichSuGiaoDich TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 5)
                {
                    var ls = new LichSuGiaoDich
                    {
                        MaGiaoDich = parts[0],
                        MaKH = int.Parse(parts[1]),
                        NgayGio = DateTime.Parse(parts[2]),
                        LoaiGiaoDich = parts[3],
                        SoDiemThayDoi = int.Parse(parts[4]),
                        TongTien = 0,
                        ChiTietThuoc = new List<ChiTietBanThuoc>()
                    };

                    if (parts.Length > 5)
                    {
                        decimal tien;
                        if (decimal.TryParse(parts[5], out tien)) ls.TongTien = tien;
                    }

                    if (parts.Length > 6 && !string.IsNullOrEmpty(parts[6]))
                    {
                        var chiTiets = parts[6].Split(';');
                        foreach (var ct in chiTiets)
                        {
                            var ctObj = ChiTietBanThuoc.TuChuoi(ct);
                            if (ctObj != null) ls.ChiTietThuoc.Add(ctObj);
                        }
                    }

                    return ls;
                }
            }
            catch { }
            return null;
        }
    }
}