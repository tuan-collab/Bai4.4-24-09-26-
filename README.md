# Nguyễn Duy Tuấn - 24810310492

Quản Lý Gọi Món – ListBox, Tổng Tiền Động
## Đề bài

Quản lý danh sách món ăn với ListBox, tính toán tổng tiền động và chuyển món sang danh sách đã chọn.

## Cấu trúc project

```
MenuApp/
├── Form1.cs              # Class MenuItem + logic: nạp menu, thêm/xóa món, tính tổng tiền
├── Form1.Designer.cs     # Khai báo lstMenu, lstSelected, btnAdd, btnRemove, lblTotal
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Kết quả

- Chọn món trong `lstMenu`, bấm `>` → món được thêm vào `lstSelected`, `lblTotal` tự cập nhật.
- Chọn món trong `lstSelected`, bấm `<` → món bị xóa, `lblTotal` tự cập nhật lại.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="1358" height="587" alt="Screenshot 2026-09-24 154133" src="https://github.com/user-attachments/assets/76ce71cd-a079-40ae-b1e0-1c9a34f7ba2e" />
