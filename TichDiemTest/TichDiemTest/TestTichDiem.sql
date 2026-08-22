CREATE DATABASE TestTichDiem;
GO

USE TestTichDiem;
GO

-- 2. Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(11) NOT NULL UNIQUE,
    Email NVARCHAR(100) NULL,
    DiemTichLuy INT DEFAULT 0,
    NgayDangKy DATETIME DEFAULT GETDATE()
);
GO

-- 3. Bảng Thuốc
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(20) NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL DEFAULT 0,
    SoLuongTon INT NOT NULL DEFAULT 0,
    NhaSanXuat NVARCHAR(100) NULL,
    HanSuDung DATE NULL,
    MoTa NVARCHAR(500) NULL,
    CONSTRAINT UQ_Thuoc_Ten_DVT UNIQUE (TenThuoc, DonViTinh)
);
GO

-- 4. Bảng Lịch sử giao dịch
CREATE TABLE LichSuGiaoDich (
    MaGiaoDich VARCHAR(8) PRIMARY KEY,
    MaKH INT NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    NgayGio DATETIME NOT NULL DEFAULT GETDATE(),
    LoaiGiaoDich NVARCHAR(20) NOT NULL, -- 'Bán thuốc', 'Cộng điểm', 'Đổi quà'
    SoDiemThayDoi INT NOT NULL,         -- Dương: cộng, Âm: trừ
    TongTien DECIMAL(18,0) DEFAULT 0,   -- Chỉ dùng cho 'Bán thuốc'
    ChiTietThuoc NVARCHAR(MAX) NULL     -- JSON hoặc format pipe-separated
);
GO

-- 5. Bảng Quà tặng
CREATE TABLE Qua (
    MaQua INT IDENTITY(1,1) PRIMARY KEY,
    TenQua NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(500) NULL,
    DiemCan INT NOT NULL DEFAULT 0,
    SoLuongTon INT NOT NULL DEFAULT 0,
    DonViTinh NVARCHAR(20) DEFAULT N'Cái',
    HinhAnh NVARCHAR(255) NULL,
    TrangThai BIT DEFAULT 1,            -- 1: Đang đổi, 0: Ngừng đổi
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- 6. Bảng Chi tiết đổi quà
CREATE TABLE ChiTietDoiQua (
    MaGiaoDich INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    MaQua INT NOT NULL FOREIGN KEY REFERENCES Qua(MaQua),
    TenQua NVARCHAR(100) NOT NULL,      -- Lưu tên quà tại thời điểm đổi
    SoLuong INT NOT NULL,
    DiemTru INT NOT NULL,               -- Tổng điểm trừ (DiemCan * SoLuong)
    NgayDoi DATETIME DEFAULT GETDATE()
);
GO

-- 7. Indexes để tối ưu hiệu năng
CREATE INDEX IX_LichSuGiaoDich_MaKH ON LichSuGiaoDich(MaKH);
CREATE INDEX IX_LichSuGiaoDich_NgayGio ON LichSuGiaoDich(NgayGio);
CREATE INDEX IX_LichSuGiaoDich_Loai ON LichSuGiaoDich(LoaiGiaoDich);
CREATE INDEX IX_ChiTietDoiQua_MaKH ON ChiTietDoiQua(MaKH);
CREATE INDEX IX_ChiTietDoiQua_NgayDoi ON ChiTietDoiQua(NgayDoi);
CREATE INDEX IX_Thuoc_Ten ON Thuoc(TenThuoc);
CREATE INDEX IX_Qua_TrangThai ON Qua(TrangThai);
GO

-- 8. Dữ liệu mẫu (Optional - để test nhanh)
-- Khách hàng mẫu
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiemTichLuy, NgayDangKy) VALUES
(N'Nguyễn Văn An', '0901234567', 'an.nguyen@email.com', 1500, '2024-01-15'),
(N'Trần Thị Bình', '0912345678', 'binh.tran@email.com', 3200, '2024-02-20'),
(N'Lê Văn Cường', '0923456789', 'cuong.le@email.com', 500, '2024-03-10'),
(N'Phạm Thị Dung', '0934567890', 'dung.pham@email.com', 8700, '2024-01-28'),
(N'Hoàng Văn Em', '0945678901', 'em.hoang@email.com', 2100, '2024-04-05'),
(N'Vũ Thị Phương', '0956789012', 'phuong.vu@email.com', 450, '2024-05-12'),
(N'Đặng Văn Giang', '0967890123', 'giang.dang@email.com', 6800, '2024-02-14'),
(N'Bùi Thị Hạnh', '0978901234', 'hanh.bui@email.com', 1200, '2024-06-01'),
(N'Ngô Văn Inh', '0989012345', 'inh.ngo@email.com', 9500, '2024-03-22'),
(N'Đỗ Thị Kiên', '0990123456', 'kien.do@email.com', 300, '2024-07-10');
GO

-- Thuốc mẫu
INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, NhaSanXuat, HanSuDung, MoTa) VALUES
(N'Paracetamol 500mg', N'Viên', 3500, 1000, N'Công ty Dược phẩm Hà Nội', '2026-12-31', N'Giảm đau, hạ sốt'),
(N'Amoxicillin 500mg', N'Viên', 8500, 500, N'Công ty Dược phẩm TW', '2026-10-15', N'Kháng sinh điều trị nhiễm khuẩn'),
(N'Vitamin C 100mg', N'Viên', 2200, 2000, N'Công ty Dược phẩm Sài Gòn', '2027-01-20', N'Bổ sung Vitamin C'),
(N'Omeprazole 20mg', N'Viên', 5500, 300, N'Công ty Dược phẩm Đà Nẵng', '2026-11-30', N'Điều trị viêm loét dạ dày'),
(N'Cetirizine 10mg', N'Viên', 4200, 800, N'Công ty Dược phẩm Huế', '2026-12-15', N'Kháng histamine trị dị ứng'),
(N'Ibuprofen 400mg', N'Viên', 6800, 600, N'Công ty Dược phẩm Cần Thơ', '2027-02-28', N'Giảm đau, chống viêm'),
(N'Metformin 500mg', N'Viên', 3800, 400, N'Công ty Dược phẩm Bình Dương', '2026-09-15', N'Điều trị đái tháo đường type 2'),
(N'Amlodipine 5mg', N'Viên', 4500, 350, N'Công ty Dược phẩm Vĩnh Long', '2026-12-01', N'Điều trị huyết áp cao'),
(N'Atorvastatin 20mg', N'Viên', 9200, 250, N'Công ty Dược phẩm Tây Ninh', '2026-11-10', N'Giảm cholesterol'),
(N'Losartan 50mg', N'Viên', 7800, 300, N'Công ty Dược phẩm Long An', '2027-01-15', N'Điều trị huyết áp cao'),
(N'Diclofenac 50mg', N'Viên', 3200, 700, N'Công ty Dược phẩm Bà Rịa', '2026-10-20', N'Giảm đau, chống viêm'),
(N'Loratadine 10mg', N'Viên', 2800, 900, N'Công ty Dược phẩm Bình Phước', '2026-12-25', N'Kháng histamine không gây buồn ngủ'),
(N'Cough Syrup 100ml', N'Chai', 45000, 150, N'Công ty Dược phẩm Đồng Nai', '2026-08-30', N'Xịt ho, long đờm'),
(N'Eye Drops 10ml', N'Chai', 35000, 200, N'Công ty Dược phẩm Bình Dương', '2027-03-15', N'Thuốc nhỏ mắt khô, mỏi'),
(N'Bandage 5cm x 5m', N'Cuộn', 15000, 500, N'Công ty Y tế Việt Nam', '2028-12-31', N'Băng gạc y tế');
GO

-- Quà tặng mẫu
INSERT INTO Qua (TenQua, MoTa, DiemCan, SoLuongTon, DonViTinh, HinhAnh, TrangThai, NgayTao) VALUES
(N'Khăn lạnh mini', N'Khăn lạnh tiện lợi, size nhỏ gọn', 500, 100, N'Cái', NULL, 1, GETDATE()),
(N'Nước suối 500ml', N'Nước suối tinh khiết, đóng chai 500ml', 800, 200, N'Chai', NULL, 1, GETDATE()),
(N'Mũ nón bảo hộ', N'Mũ nón chống nắng, chống mưa', 2000, 50, N'Cái', NULL, 1, GETDATE()),
(N'Túi xách vải', N'Túi xách vải bền đẹp, nhiều màu', 3000, 80, N'Cái', NULL, 1, GETDATE()),
(N'Ly giữ nhiệt 500ml', N'Ly inox giữ nhiệt/nóng 6-8h', 4000, 60, N'Cái', NULL, 1, GETDATE()),
(N'Đèn pin LED', N'Đèn pin siêu sáng, pin sạc', 2500, 70, N'Cái', NULL, 1, GETDATE()),
(N'Balo nhỏ', N'Balo mini đựng đồ cá nhân', 3500, 40, N'Cái', NULL, 1, GETDATE()),
(N'Khẩu trang y tế (hộp 50)', N'Khẩu trang 3 lớp, hộp 50 cái', 1500, 120, N'Hộp', NULL, 1, GETDATE()),
(N'Cây viết tên thương hiệu', N'Bút bi viết mượt, in logo', 1000, 300, N'Cây', NULL, 1, GETDATE()),
(N'Sổ ghi chú A5', N'Sổ ghi chú bìa cứng, giấy trắng', 1200, 150, N'Cuốn', NULL, 1, GETDATE());
GO
