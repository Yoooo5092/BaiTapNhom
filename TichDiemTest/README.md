# 📋 Ứng Quản Lý Tích Điểm Khách Hàng - Lab C# Windows Forms

## 🎯 Mục tiêu bài lab
Xây dựng ứng dụng quản lý khách hàng tích điểm với đầy đủ chức năng CRUD, nhập/xuất file, thống kê.

## 🏗️ Cấu trúc dự án (5 class đơn giản)

| File | Chức năng |
|------|-----------|
| `KhachHang.cs` | **Model** - Đại diện 1 khách hàng (mã, tên, SĐT, email, điểm, cấp bậc...) |
| `QuanLyKhachHang.cs` | **Business Logic** - Quản lý danh sách, tìm kiếm, nhập/xuất file, thống kê |
| `Form1.cs` | **Main Form** - Giao diện chính: DataGridView, toolbar, tìm kiếm, context menu |
| `FormKhachHang.cs` | **Dialog Form** - Thêm/Sửa khách hàng (tái sử dụng cho 2 trường hợp) |
| `FormDiem.cs` | **Dialog Form** - Cộng điểm / Đổi quà (trừ điểm) |
| `FormThongKe.cs` | **Report Form** - Biểu đồ tròn phân bố cấp bậc + Top 10 khách hàng |

## 🚀 Cách chạy

### Yêu cầu
- Visual Studio 2019/2022 (có workload **.NET Desktop Development**)
- .NET Framework 4.7.2 (có sẵn khi cài VS)

### Các bước
1. Mở **TichDiemTest.sln** bằng Visual Studio
2. Nhấn **F5** hoặc **Ctrl+F5** để chạy
3. Ứng dụng sẽ tự tạo dữ liệu mẫu (8 khách hàng) khi chạy lần đầu

## 📦 Chức năng chính

### 1. Quản lý khách hàng (CRUD)
- **Thêm** (Ctrl+N): Mở form nhập thông tin, tự gán mã, kiểm tra trùng SĐT
- **Sửa** (F2 / Double-click / Right-click > Cập nhật): Cập nhật tên, SĐT, email
- **Xóa** (Delete): Xác nhận trước khi xóa
- **Tìm kiếm**: Lọc real-time theo tên, SĐT, email

### 2. Hệ thống điểm
- **Cộng điểm** (F3): Thêm điểm cho khách, tự cập nhật cấp bậc
- **Đổi quà** (F4): Trừ điểm, kiểm tra đủ điểm mới cho đổi
- **Cấp bậc tự động**:
  - Đồng: < 1.000 điểm
  - Bạc: 1.000 - 4.999 điểm
  - Vàng: 5.000 - 9.999 điểm
  - Kim cương: ≥ 10.000 điểm

### 3. Nhập/Xuất file (format CSV với dấu `|`)
```
Mã|Họ tên|SĐT|Email|Điểm|Ngày ĐK|Cấp bậc
```
- **Nhập file** (Ctrl+I): Đọc từ `test.txt` (tự tìm ở thư mục chạy) hoặc chọn file
- **Xuất file** (Ctrl+E): Lưu danh sách hiện tại ra file text

### 4. Thống kê (F5)
- Tổng quan: Tổng KH, tổng điểm, điểm cao/thấp nhất
- Biểu đồ tròn: Phân bố theo cấp bậc
- Bảng Top 10: Khách hàng điểm cao nhất

### 5. Giao diện thân thiện
- Toolbar có tooltip phím tắt
- DataGridView: Màu xen kẽ, canh lề hợp lý, không bị cắt xén
- Context menu (chuột phải): Cập nhật, Cộng điểm, Đổi quà, Xóa
- Status bar hiển thị trạng thái thao tác
- Responsive: Resize form không bị lỗi layout

## ⌨️ Phím tắt nhanh

| Phím | Chức năng |
|------|-----------|
| `Ctrl+N` | Thêm khách hàng |
| `F2` | Sửa khách hàng đang chọn |
| `Delete` | Xóa khách hàng |
| `F3` | Cộng điểm |
| `F4` | Đổi quà |
| `F5` | Mở thống kê |
| `F6` | Tải lại dữ liệu mẫu |
| `Ctrl+I` | Nhập từ file |
| `Ctrl+E` | Xuất ra file |
| `Esc` | Thoát ứng dụng |

## 📁 File test.txt mẫu
Đã kèm sẵn trong thư mục dự án với 10 khách hàng:
```
1|Nguyễn Văn An|0901234567|an.nguyen@email.com|1250|2024-01-15|Bạc
2|Trần Thị Bình|0912345678|binh.tran@email.com|3200|2024-02-20|Vàng
...
```

## 💡 Điểm học tập (cho sinh viên)
1. **Tách class**: Model (KhachHang) tách biệt Logic (QuanLyKhachHang) tách biệt UI (Forms)
2. **Event-driven**: QuanLyKhachHang dùng event `DuLieuDaThayDoi` để báo UI cập nhật
3. **Validation**: Kiểm tra rỗng, trùng SĐT, định dạng email, điểm đủ...
4. **File I/O**: Đọc/ghi file text đơn giản, parse an toàn với try-catch
5. **DataGridView binding**: Bind List<T> trực tiếp, format column dễ đọc
6. **ContextMenuStrip**: Chuột phải trên grid để thao tác nhanh
7. **Form tái sử dụng**: FormKhachHang dùng cho cả Thêm và Sửa
8. **Chart cơ bản**: System.Windows.Forms.DataVisualization.Charting

## 🐛 Xử lý lỗi thường gặp
| Lỗi | Nguyên nhân | Khắc phục |
|-----|-------------|-----------|
| Build fail "GenerateResource" | Thiếu .NET Framework 4.7.2 targeting pack | Cài Visual Studio với workload .NET Desktop |
| Chart không hiện | Thiếu reference | Đã thêm `System.Windows.Forms.DataVisualization` trong csproj |
| File test.txt không đọc được | Sai đường dẫn | Đặt file cạnh .exe (bin\Debug) hoặc dùng nút Nhập file để chọn |

## 📝 Mở rộng gợi ý
- Thêm lịch sử giao dịch (điểm +/−)
- In báo cáo / Xuất Excel
- Đăng nhập phân quyền (Admin/Staff)
- Kết nối SQL Server thay vì file text
- Gửi email/SMS chúc mừng sinh nhật, thông báo điểm

---
*Dự án lab mẫu - C# Windows Forms .NET Framework 4.7.2*