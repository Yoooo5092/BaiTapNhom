using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TichDiemTest
{
    public class QuanLyKhachHang
    {
        private List<KhachHang> danhSachKH = new List<KhachHang>();
        private int maTuDong = 1;
        private string duongDanFile = "test.txt";

        public event Action DuLieuDaThayDoi;

        public QuanLyKhachHang() { }

        public List<KhachHang> LayDanhSach()
        {
            return new List<KhachHang>(danhSachKH);
        }

        public bool Them(KhachHang kh, out string loi)
        {
            loi = "";
            if (!kh.HopLe(out loi)) 
                return false;

            if (danhSachKH.Any(x => x.SoDienThoai == kh.SoDienThoai))
            {
                loi = "Số điện thoại đã tồn tại";
                return false;
            }

            kh.MaKH = maTuDong++;
            danhSachKH.Add(kh);
            XuatRaFile(duongDanFile, out loi);
            DuLieuDaThayDoi?.Invoke();
            return true;
        }

        public bool CapNhat(KhachHang khMoi, out string loi)
        {
            loi = "";
            if (!khMoi.HopLe(out loi)) return false;

            var khCu = danhSachKH.FirstOrDefault(x => x.MaKH == khMoi.MaKH);
            if (khCu == null)
            {
                loi = "Không tìm thấy khách hàng";
                return false;
            }

            if (danhSachKH.Any(x => x.SoDienThoai == khMoi.SoDienThoai && x.MaKH != khMoi.MaKH))
            {
                loi = "Số điện thoại đã được dùng bởi khách hàng khác";
                return false;
            }

            khCu.HoTen = khMoi.HoTen;
            khCu.SoDienThoai = khMoi.SoDienThoai;
            khCu.Email = khMoi.Email;
            XuatRaFile(duongDanFile, out loi);
            DuLieuDaThayDoi?.Invoke();
            return true;
        }

        public bool Xoa(int maKH, out string loi)
        {
            loi = "";
            var kh = danhSachKH.FirstOrDefault(x => x.MaKH == maKH);
            if (kh == null)
            {
                loi = "Không tìm thấy khách hàng";
                return false;
            }
            danhSachKH.Remove(kh);
            XuatRaFile(duongDanFile, out loi);

            DuLieuDaThayDoi?.Invoke();
            return true;
        }
        public List<KhachHang> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return LayDanhSach();

            tuKhoa = tuKhoa.ToLower().Trim();
            return danhSachKH.Where(x =>
                x.HoTen.ToLower().Contains(tuKhoa) ||
                x.SoDienThoai.Contains(tuKhoa) ||
                x.Email.ToLower().Contains(tuKhoa)
            ).ToList();
        }

        public KhachHang LayTheoMa(int maKH)
        {
            return danhSachKH.FirstOrDefault(x => x.MaKH == maKH);
        }

        public bool CongDiem(int maKH, int diem, out string loi)
        {
            loi = "";
            var kh = LayTheoMa(maKH);
            if (kh == null)
            {
                loi = "Không tìm thấy khách hàng";
                return false;
            }
            kh.CongDiem(diem);
            XuatRaFile(duongDanFile, out loi);

            DuLieuDaThayDoi?.Invoke();
            return true;
        }
        public bool DoiQua(int maKH, int diem, out string loi)
        {
            loi = "";
            var kh = LayTheoMa(maKH);
            if (kh == null)
            {
                loi = "Không tìm thấy khách hàng";
                return false;
            }
            if (!kh.TruDiem(diem))
            {
                loi = "Điểm không đủ để đổi quà";
                return false;
            }
            XuatRaFile(duongDanFile, out loi);

            DuLieuDaThayDoi?.Invoke();
            return true;
        }

        public bool NhapTuFile(string duongDan, out string loi, out int soLuong)
        {
            loi = "";
            soLuong = 0;

            if (!File.Exists(duongDan))
            {
                loi = "File không tồn tại: " + duongDan;
                return false;
            }

            try
            {
                int dem = 0;
                using (StreamReader sr = new StreamReader(duongDan))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var kh = KhachHang.TuChuoi(line);
                        if (kh != null)
                        {
                            if (!danhSachKH.Any(x => x.MaKH == kh.MaKH || x.SoDienThoai == kh.SoDienThoai))
                            {
                                danhSachKH.Add(kh);
                                if (kh.MaKH >= maTuDong) maTuDong = kh.MaKH + 1;
                                dem++;
                            }
                        }
                    }
                }
                soLuong = dem;
                DuLieuDaThayDoi?.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lỗi đọc file: " + ex.Message;
                return false;
            }
        }

        public bool XuatRaFile(string duongDan, out string loi)
        {
            loi = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(duongDan, false))
                {
                    foreach (var kh in danhSachKH)
                    {
                        sw.WriteLine(kh.ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lỗi ghi file: " + ex.Message;
                return false;
            }
        }

        public (int tongKH, int tongDiem, int caoNhat, int thapNhat) ThongKe()
        {
            if (danhSachKH.Count == 0) return (0, 0, 0, 0);

            return (
                danhSachKH.Count,
                danhSachKH.Sum(x => x.DiemTichLuy),
                danhSachKH.Max(x => x.DiemTichLuy),
                danhSachKH.Min(x => x.DiemTichLuy)
            );
        }
        public Dictionary<string, int> ThongKeTheoCapBac()
        {
            return danhSachKH.GroupBy(x => x.CapBac)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}