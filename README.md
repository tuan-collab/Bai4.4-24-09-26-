# Nguyễn Duy Tuấn - 24810310492
## Quản Lý Gọi Món – ListBox, Tổng Tiền Động

Bài tập Windows Forms (C#): quản lý danh sách món ăn bằng hai `ListBox`, chuyển món qua lại và tự động tính tổng tiền.

## Đề bài

Quản lý danh sách món ăn với ListBox, tính toán tổng tiền động và chuyển món sang danh sách đã chọn.

## Yêu cầu và cách đáp ứng

| Yêu cầu | Cách thực hiện |
|---|---|
| `lstMenu`: danh sách món sẵn có (Hamburger 50k, Pizza 120k, Gà Rán 35k, Pepsi 15k) | `LoadMenu()` nạp danh sách `MenuItem` (có override `ToString()`) vào `lstMenu` |
| Nút `>`: chuyển món đang chọn sang `lstSelected` | `btnAdd_Click` lấy `lstMenu.SelectedItem` thêm vào `lstSelected` |
| Nút `<`: xóa món khỏi `lstSelected` | `btnRemove_Click` xóa `lstSelected.SelectedItem` |
| `lblTotal`: tự động cập nhật tổng tiền các món trong `lstSelected` | `UpdateTotal()` duyệt `lstSelected.Items`, cộng dồn giá, gọi lại sau mỗi lần thêm/xóa |

## Công nghệ

- C# / .NET Windows Forms

## Cấu trúc project

```
MenuApp/
├── Form1.cs              # Class MenuItem + logic: nạp menu, thêm/xóa món, tính tổng tiền
├── Form1.Designer.cs     # Khai báo lstMenu, lstSelected, btnAdd, btnRemove, lblTotal
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Cách chạy

1. Mở Visual Studio → **File > New Project** → chọn **Windows Forms App (.NET)**.
2. Đặt tên project là `MenuApp` (trùng namespace trong code).
3. Thay nội dung 3 file `Form1.cs`, `Form1.Designer.cs`, `Program.cs` bằng code trong repo.
4. Nhấn **F5** để chạy.

## Kết quả

- Chọn món trong `lstMenu`, bấm `>` → món được thêm vào `lstSelected`, `lblTotal` tự cập nhật.
- Chọn món trong `lstSelected`, bấm `<` → món bị xóa, `lblTotal` tự cập nhật lại.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="1358" height="587" alt="Screenshot 2026-09-24 154133" src="https://github.com/user-attachments/assets/76ce71cd-a079-40ae-b1e0-1c9a34f7ba2e" />
