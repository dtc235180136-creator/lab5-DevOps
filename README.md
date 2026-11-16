# Student Manager — DevOps Lab 5

Ứng dụng quản lý sinh viên được xây dựng cho **Lab 5: Quản lý mã nguồn với Git Flow & Code Review trên GitHub**.

- Repository: https://github.com/dtc235180136-creator/lab5-DevOps
- Nền tảng: ASP.NET Core MVC trên .NET 10
- Phiên bản: 1.0.0

## Tính năng

- Hiển thị danh sách sinh viên mẫu.
- Tìm kiếm theo mã sinh viên, họ tên hoặc khóa học.
- Thêm sinh viên mới và kiểm tra trùng mã.
- Giao diện responsive dùng Bootstrap.
- Dữ liệu được lưu trong bộ nhớ để bài có thể chạy ngay, không cần cấu hình cơ sở dữ liệu.

## Cài đặt và chạy

Yêu cầu: .NET 10 SDK và Git.

```bash
git clone https://github.com/dtc235180136-creator/lab5-DevOps.git
cd lab5-DevOps/devops
dotnet restore
dotnet run
```

Mở địa chỉ HTTPS được hiển thị trong terminal, thường là `https://localhost:xxxx`.

> Lưu ý: nếu thư mục project được checkout với tên `devops`, dùng `cd devops`. Dòng lệnh trên chỉ minh họa cấu trúc project.

## Quy trình Git Flow đã áp dụng

- `main`: mã nguồn ổn định để nộp.
- `develop`: nhánh tích hợp.
- `feature/student-manager`: phát triển chức năng quản lý sinh viên.
- Commit message dùng Conventional Commits như `feat:`, `docs:` và `fix:`.

Các lệnh kiểm tra lịch sử:

```bash
git log --oneline --graph --all
git branch -a
git remote -v
```

## Cấu trúc chính

```text
devops/
├── Controllers/HomeController.cs
├── Models/Student.cs
├── Services/StudentStore.cs
├── Views/Home/Index.cshtml
└── wwwroot/css/site.css
```

## Kiểm tra chức năng

1. Chạy ứng dụng và kiểm tra 3 sinh viên mẫu.
2. Tìm kiếm `SV001` hoặc một phần tên.
3. Thêm `SV004`, nhập họ tên, tuổi và khóa.
4. Thử thêm lại `SV004` để kiểm tra validation trùng mã.
5. Chạy `dotnet build` để kiểm tra biên dịch.

## Minh chứng Lab cần cập nhật trên GitHub/LMS

- `git log --oneline --graph --all`.
- `git branch -a` với `main`, `develop` và các nhánh feature.
- Pull Request chức năng Student Manager.
- Code Review và trạng thái PR đã merge.
- Lịch sử giải quyết merge conflict README (nếu giảng viên yêu cầu thực hành).
- Ảnh giao diện danh sách, tìm kiếm và thêm sinh viên.

## Tác giả

- Sinh viên: **DTC235180136**
- Môn học: DevOps — Lab 5
