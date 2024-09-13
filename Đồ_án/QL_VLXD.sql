-- Tạo Database
CREATE DATABASE QL_VLXD;
GO
drop database QL_VLXD
-- Sử dụng Database
USE QL_VLXD;
GO

-- Tạo bảng VaiTro
CREATE TABLE VaiTro (
    VaiTroID char(5) PRIMARY KEY ,
    TenVaiTro VARCHAR(50) NOT NULL
);

-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    NguoiDungID char(5) PRIMARY KEY ,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    VaiTroID char(5)  NOT NULL,
    CONSTRAINT fk_VaiTroID FOREIGN KEY (VaiTroID) REFERENCES VaiTro(VaiTroID)
);

-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    NhaCungCapID char(5) PRIMARY KEY ,
    TenNhaCungCap VARCHAR(255) NOT NULL,
    DiaChi VARCHAR(255),
    SoDienThoai VARCHAR(20)
);

-- Tạo bảng HangHoa
CREATE TABLE HangHoa (
    MaHangHoa char(5) PRIMARY KEY ,
    TenHangHoa VARCHAR(255) NOT NULL,
    DonViTinh VARCHAR(50) NOT NULL,
    GiaNhap DECIMAL(18, 2) NOT NULL,
    GiaBan DECIMAL(18, 2) NOT NULL,
    SoLuongTon INT NOT NULL,
    NhaCungCapID char(5),
    CONSTRAINT fk_NhaCungCapID FOREIGN KEY (NhaCungCapID) REFERENCES NhaCungCap(NhaCungCapID)
);

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang char(5) PRIMARY KEY ,
    TenKhachHang VARCHAR(255) NOT NULL,
    DiaChi VARCHAR(255),
    SoDienThoai VARCHAR(20)
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien char(5) PRIMARY KEY ,
    TenNhanVien VARCHAR(255) NOT NULL,
    DiaChi VARCHAR(255),
    SoDienThoai VARCHAR(20),
    NgayBatDauLamViec DATETIME
);

-- Tạo bảng PhieuNhapKho
CREATE TABLE PhieuNhapKho (
    MaPhieuNhapKho char(5) PRIMARY KEY ,
    NgayNhap DATE NOT NULL,
    NhaCungCapID char(5),
    CONSTRAINT fk_NhaCungCapID_PNK FOREIGN KEY (NhaCungCapID) REFERENCES NhaCungCap(NhaCungCapID)
);

-- Tạo bảng PhieuXuatKho
CREATE TABLE PhieuXuatKho (
    MaPhieuXuatKho char(5) PRIMARY KEY ,
    NgayXuat DATE NOT NULL,
    KhachHangID char(5),
    CONSTRAINT fk_KhachHangID_PXK FOREIGN KEY (KhachHangID) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng ChiTietPhieuNhap
CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhapKho char(5),
    MaHangHoa char(5),
    SoLuongNhap INT NOT NULL,
    GiaNhap DECIMAL(18, 2) NOT NULL,
    CONSTRAINT pk_ChiTietPhieuNhap PRIMARY KEY (MaPhieuNhapKho, MaHangHoa),
    CONSTRAINT fk_MaPhieuNhapKho_CTPN FOREIGN KEY (MaPhieuNhapKho) REFERENCES PhieuNhapKho(MaPhieuNhapKho),
    CONSTRAINT fk_MaHangHoa_CTPN FOREIGN KEY (MaHangHoa) REFERENCES HangHoa(MaHangHoa)
);

-- Tạo bảng ChiTietPhieuXuat
CREATE TABLE ChiTietPhieuXuat (
    MaPhieuXuatKho char(5),
    MaHangHoa char(5),
    SoLuongXuat INT NOT NULL,
    GiaBan DECIMAL(18, 2) NOT NULL,
    CONSTRAINT pk_ChiTietPhieuXuat PRIMARY KEY (MaPhieuXuatKho, MaHangHoa),
    CONSTRAINT fk_MaPhieuXuatKho_CTPX FOREIGN KEY (MaPhieuXuatKho) REFERENCES PhieuXuatKho(MaPhieuXuatKho),
    CONSTRAINT fk_MaHangHoa_CTPX FOREIGN KEY (MaHangHoa) REFERENCES HangHoa(MaHangHoa)
);

-- Tạo bảng PhieuThu
CREATE TABLE PhieuThu (
    MaPhieuThu char(5) PRIMARY KEY ,
    NgayThu DATE NOT NULL,
    KhachHangID char(5),
    SoTienThu DECIMAL(18, 2) NOT NULL,
    CONSTRAINT fk_KhachHangID_PT FOREIGN KEY (KhachHangID) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng PhieuChi
CREATE TABLE PhieuChi (
    MaPhieuChi char(5) PRIMARY KEY ,
    NgayChi DATE NOT NULL,
    NhaCungCapID char(5),
    SoTienChi DECIMAL(18, 2) NOT NULL,
    CONSTRAINT fk_NhaCungCapID_PCHI FOREIGN KEY (NhaCungCapID) REFERENCES NhaCungCap(NhaCungCapID)
);
Go
-- Tạo View BaoCaoCongNoKhachHang
CREATE VIEW BaoCaoCongNoKhachHang AS
SELECT
    KhachHang.MaKhachHang,
    KhachHang.TenKhachHang,
    ISNULL(SUM(PhieuThu.SoTienThu), 0) AS TongThu,
    ISNULL(SUM(ChiTietPhieuXuat.GiaBan), 0) AS TongXuat,
    ISNULL(SUM(PhieuThu.SoTienThu), 0) - ISNULL(SUM(ChiTietPhieuXuat.GiaBan), 0) AS CongNo
FROM
    KhachHang
LEFT JOIN PhieuThu ON KhachHang.MaKhachHang = PhieuThu.KhachHangID
LEFT JOIN PhieuXuatKho ON KhachHang.MaKhachHang = PhieuXuatKho.KhachHangID
LEFT JOIN ChiTietPhieuXuat ON PhieuXuatKho.MaPhieuXuatKho = ChiTietPhieuXuat.MaPhieuXuatKho
GROUP BY
    KhachHang.MaKhachHang, KhachHang.TenKhachHang;

Go
-- Tạo View BaoCaoCongNoNhaCungCap
CREATE VIEW BaoCaoCongNoNhaCungCap AS
SELECT
    NhaCungCap.NhaCungCapID,
    NhaCungCap.TenNhaCungCap,
    ISNULL(SUM(PhieuChi.SoTienChi), 0) AS TongChi,
    ISNULL(SUM(ChiTietPhieuNhap.GiaNhap), 0) AS TongNhap,
    ISNULL(SUM(ChiTietPhieuNhap.GiaNhap), 0) - ISNULL(SUM(PhieuChi.SoTienChi), 0) AS CongNo
FROM
    NhaCungCap
LEFT JOIN PhieuChi ON NhaCungCap.NhaCungCapID = PhieuChi.NhaCungCapID
LEFT JOIN PhieuNhapKho ON NhaCungCap.NhaCungCapID = PhieuNhapKho.NhaCungCapID
LEFT JOIN ChiTietPhieuNhap ON PhieuNhapKho.MaPhieuNhapKho = ChiTietPhieuNhap.MaPhieuNhapKho
GROUP BY
    NhaCungCap.NhaCungCapID, NhaCungCap.TenNhaCungCap;
Go
-- Tạo View BaoCaoNhapKho
CREATE VIEW BaoCaoNhapKho AS
SELECT
    PhieuNhapKho.MaPhieuNhapKho,
    PhieuNhapKho.NgayNhap,
    NhaCungCap.TenNhaCungCap,
    HangHoa.TenHangHoa,
    ChiTietPhieuNhap.SoLuongNhap,
    ChiTietPhieuNhap.GiaNhap
FROM
    PhieuNhapKho
JOIN ChiTietPhieuNhap ON PhieuNhapKho.MaPhieuNhapKho = ChiTietPhieuNhap.MaPhieuNhapKho
JOIN HangHoa ON ChiTietPhieuNhap.MaHangHoa = HangHoa.MaHangHoa
JOIN NhaCungCap ON PhieuNhapKho.NhaCungCapID = NhaCungCap.NhaCungCapID;
Go
-- Tạo View BaoCaoXuatKho
CREATE VIEW BaoCaoXuatKho AS
SELECT
    PhieuXuatKho.MaPhieuXuatKho,
    PhieuXuatKho.NgayXuat,
    KhachHang.TenKhachHang,
    HangHoa.TenHangHoa,
    ChiTietPhieuXuat.SoLuongXuat,
    ChiTietPhieuXuat.GiaBan
FROM
    PhieuXuatKho
JOIN ChiTietPhieuXuat ON PhieuXuatKho.MaPhieuXuatKho = ChiTietPhieuXuat.MaPhieuXuatKho
JOIN HangHoa ON ChiTietPhieuXuat.MaHangHoa = HangHoa.MaHangHoa
JOIN KhachHang ON PhieuXuatKho.KhachHangID = KhachHang.MaKhachHang;

-- Tạo View BaoCaoTonKho
Go
CREATE VIEW BaoCaoTonKho AS
SELECT
    HangHoa.MaHangHoa,
    HangHoa.TenHangHoa,
    HangHoa.SoLuongTon,
    NhaCungCap.TenNhaCungCap
FROM
    HangHoa
JOIN NhaCungCap ON HangHoa.NhaCungCapID = NhaCungCap.NhaCungCapID;
Go
-- Thêm dữ liệu mẫu
-- Thêm dữ liệu vào bảng VaiTro
INSERT INTO VaiTro(VaiTroID, TenVaiTro) 
VALUES
('VT001','Admin'),
('VT002',N'Nhân viên');

-- Thêm dữ liệu vào bảng NguoiDung
INSERT INTO NguoiDung(NguoiDungID,Username, Password, VaiTroID) VALUES 
('NG001','admin123', 'supersecret', 'VT001'),
('NG002','nhanvienquen1', 'tooweak', 'VT002'),
('NG003','anhhangxom', 'ntr', 'VT002');

-- Thêm dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (NhaCungCapID, TenNhaCungCap, DiaChi, SoDienThoai) VALUES 
('NCC01',N'Công ty A', N'123 Đường ABC, Quận 12', '0123456789'),
('NCC02',N'Nhà phân phối B', N'456 Đường DEF, Quận Gò Vấp', '0987654321'),
('NCC03',N'Doanh nghiệp C', N'789 Đường GHI, Quận 9', '0345678901');


-- Thêm dữ liệu vào bảng HangHoa
INSERT INTO HangHoa (MaHangHoa, TenHangHoa, DonViTinh, GiaNhap, GiaBan, SoLuongTon, NhaCungCapID) VALUES 
('HH001',N'Gạch Ceramic A', N'Chiếc', 1.5, 2.2, 500, 'NCC01'),
('HH002',N'Gạch Ceramic B', N'Chiếc', 1.6, 2.3, 480, 'NCC02');

Insert INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) VALUES 
('KH001',N'Nguyễn Văn A', N'11 Nguyễn Du, Quận 1, TP.HCM', '0123456789'),
('KH002',N'Trần Thị B', N'22 Lê Lợi, Quận 2, TP.HCM', '0987654321'),
('KH003',N'Lê Quang C', N'33 Trần Hưng Đạo, Quận 3, TP.HCM', '0345678901');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, NgayBatDauLamViec) VALUES 
('NV001',N'Nguyễn Thị Nhân', N'44 Bạch Đằng, Quận 4, TP.HCM', '0765432109', '2022-01-15'),
('NV002',N'Trần Văn Thuận', N'55 Hải Phòng, Quận 5, TP.HCM', '0999888777', '2021-08-20'),
('NV003',N'Lê Hoàng Dương', N'66 Võ Văn Tần, Quận 6, TP.HCM', '0333222111', '2023-03-10');

-- Thêm dữ liệu vào bảng PhieuNhapKho
INSERT INTO PhieuNhapKho (MaPhieuNhapKho,NgayNhap, NhaCungCapID) 
VALUES 
('PN001','2023-01-20', 'NCC01'),
('PN002','2023-02-15', 'NCC03'),
('PN003','2023-03-25', 'NCC02');

-- Thêm dữ liệu vào bảng PhieuXuatKho
INSERT INTO PhieuXuatKho (MaPhieuXuatKho,NgayXuat, KhachHangID) 
VALUES 
('PX001','2023-04-10', 'KH001'),
('PX002','2023-05-05', 'KH002'),
('PX003','2023-06-15', 'KH001');

-- Thêm dữ liệu vào bảng ChiTietPhieuNhap
INSERT INTO ChiTietPhieuNhap (MaPhieuNhapKho, MaHangHoa, SoLuongNhap, GiaNhap) 
VALUES 
('PN001', 'HH001', 50, 1500),
('PN002', 'HH002', 80, 300000),
('PN003', 'HH001', 60, 5000000);

-- Thêm dữ liệu vào bảng ChiTietPhieuXuat
INSERT INTO ChiTietPhieuXuat (MaPhieuXuatKho, MaHangHoa, SoLuongXuat, GiaBan) VALUES 
('PX001', 'HH001', 30, 2500),
('PX002', 'HH002', 50, 450000),
('PX003', 'HH002', 40, 7000000);

-- Thêm dữ liệu vào bảng PhieuThu
INSERT INTO PhieuThu (MaPhieuThu, NgayThu, KhachHangID, SoTienThu) VALUES 
('PT001','2023-04-20', 'KH002', 300000),
('PT002','2023-05-15', 'KH003', 500000),
('PT003','2023-06-25', 'KH001', 400000);

-- Thêm dữ liệu vào bảng PhieuChi
INSERT INTO PhieuChi (MaPhieuChi, NgayChi, NhaCungCapID, SoTienChi) VALUES 
('PC001','2023-01-25', 'NCC03', 200000),
('PC002','2023-02-20', 'NCC01', 350000),
('PC003','2023-03-30', 'NCC02', 280000);

GO

