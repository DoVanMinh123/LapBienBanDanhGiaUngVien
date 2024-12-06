CREATE DATABASE QuanLyNhanSu_KTPM
USE QuanLyNhanSu_KTPM

CREATE TABLE tbl_Nhanvien (
    PK_sMaNV VARCHAR(10) PRIMARY KEY,       -- Mã nhân viên, khóa chính
    sTenNV NVARCHAR(30) NOT NULL,          -- Tên nhân viên
    dNgaysinh DATETIME,                    -- Ngày sinh
    sGioitinh NVARCHAR(3),                 -- Giới tính
    sCCCD VARCHAR(12),                     -- Căn cước công dân
    sDiachi NVARCHAR(20),                  -- Địa chỉ
    sSDT VARCHAR(10),                      -- Số điện thoại
    sEmail VARCHAR(20),                    -- Email
    dNgayvaolam DATETIME,                  -- Ngày vào làm
    fLuongcb FLOAT,                        -- Lương cơ bản
    sTinhtrang NVARCHAR(20)                -- Tình trạng
);

CREATE TABLE tbl_Bienban (
    PK_sMabienban VARCHAR(10) PRIMARY KEY,   -- Mã biên bản đánh giá, khóa chính
    dNgaylap DATETIME NOT NULL,              -- Ngày lập biên bản
    FK_sMaNV VARCHAR(10) NOT NULL,           -- Mã nhân viên, khóa ngoại
    sNddanhgia NVARCHAR(500),                 -- Nội dung đánh giá
    CONSTRAINT FK_Bienban_Nhanvien FOREIGN KEY (FK_sMaNV) REFERENCES tbl_Nhanvien(PK_sMaNV)
);
DROP TABLE tbl_Bienban;
INSERT INTO tbl_Nhanvien (PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam, fLuongcb, sTinhtrang)
VALUES
('NV001', N'Nguyễn Văn A', '1990-05-10', 'Nam', '012345678901', 'Hà Nội', '0987654321', 'a.nguyen@example.com', '2020-01-15', 10000000, 'Đang làm việc'),
('NV002', N'Trần Thị B', '1995-08-20', 'Nữ', '098765432112', 'Hồ Chí Minh', '0912345678', 'b.tran@example.com', '2021-03-10', 12000000, 'Đang làm việc'),
('NV003', N'Lê Văn C', '1988-11-05', 'Nam', '087654321098', 'Đà Nẵng', '0934567890', 'c.le@example.com', '2019-07-01', 9000000, 'Nghỉ việc');
DELETE tbl_Nhanvien
Delete tbl_Bienban
INSERT INTO tbl_Bienban (PK_sMabienban, dNgaylap, FK_sMaNV, sNddanhgia)
VALUES
('BB001', '2023-06-15', 'NV001', N'Nhân viên đạt kết quả xuất sắc'),
('BB002', '2023-06-20', 'NV002', N'Hoàn thành công việc đúng thời hạn'),
('BB003', '2023-06-25', 'NV003', N'Nhân viên cần cải thiện kỹ năng giao tiếp');