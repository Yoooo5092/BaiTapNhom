using System;

namespace TichDiemTest
{
    public class LichSuGiaoDich
    {
        public string MaGiaoDich { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayGio { get; set; }
        public string LoaiGiaoDich { get; set; }
        public int SoDiemThayDoi { get; set; }

        public LichSuGiaoDich() { }

        public LichSuGiaoDich(int maKH, string loaiGiaoDich, int soDiemThayDoi)
        {
            // Tạo mã giao dịch ngẫu nhiên 8 ký tự cho ngầu
            MaGiaoDich = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            MaKH = maKH;
            NgayGio = DateTime.Now;
            LoaiGiaoDich = loaiGiaoDich;
            SoDiemThayDoi = soDiemThayDoi;
        }

        public override string ToString()
        {
            return $"{MaGiaoDich}|{MaKH}|{NgayGio:yyyy-MM-dd HH:mm:ss}|{LoaiGiaoDich}|{SoDiemThayDoi}";
        }

        public static LichSuGiaoDich TuChuoi(string line)
        {
            try
            {
                var parts = line.Split('|');
                if (parts.Length >= 5)
                {
                    return new LichSuGiaoDich
                    {
                        MaGiaoDich = parts[0],
                        MaKH = int.Parse(parts[1]),
                        NgayGio = DateTime.Parse(parts[2]),
                        LoaiGiaoDich = parts[3],
                        SoDiemThayDoi = int.Parse(parts[4])
                    };
                }
            }
            catch { }
            return null;
        }
    }
}