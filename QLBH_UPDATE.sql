-- ho ten , email viết theo ví dụ

CREATE DATABASE QLBH

USE QLBH

CREATE TABLE KhachHang 
(
	MaKH NVARCHAR(10) PRIMARY KEY,
	TenKH NVARCHAR(30),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	SDT NVARCHAR(11),
	Email NVARCHAR(30),
	DiaChi NVARCHAR(50)
)

CREATE TABLE NhanVien
(
	MaNV NVARCHAR(10) PRIMARY KEY,
	TenNV NVARCHAR(30),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	SDT NVARCHAR(11),
	Email NVARCHAR(30),
	DiaChi NVARCHAR(50)
)

CREATE TABLE SanPham 
(
	MaSP NVARCHAR(10) PRIMARY KEY,
	TenSP NVARCHAR(30),
	Gia INT,
	DanhMuc NVARCHAR(20),
	SOLUONG INT,
	NgayNhap DATE
)

CREATE TABLE HoaDon 
(
	MaHD NVARCHAR(10) PRIMARY KEY,
	NgayLap DATE,
	NguoiLap NVARCHAR(10) CONSTRAINT FK_NguoiLap_HD FOREIGN KEY (NguoiLap) REFERENCES NhanVien(MaNV),
	KhachHang NVARCHAR(10) CONSTRAINT FK_KhachHang_HD FOREIGN KEY (KhachHang) REFERENCES KhachHang(MaKH)
)

CREATE TABLE CTHoaDon
(
	MaHD NVARCHAR(10) CONSTRAINT FK_MaHD_CTHD FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
	MaSP NVARCHAR(10) CONSTRAINT FK_MaSP_CTHD FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP),
	SoLuong INT
)

CREATE TABLE Account 
(
	AccUser NVARCHAR(20) PRIMARY KEY,
	AccPass NVARCHAR(20)
)

CREATE TABLE AccNV
(
	MaNV NVARCHAR(10) CONSTRAINT PK_AccNV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
	AccUser NVARCHAR(20),
	AccPass NVARCHAR(20),
	PRIMARY KEY (MaNV)
)

CREATE TABLE TTAdmin
(
	AccAdmin NVARCHAR(20) CONSTRAINT FK_AccAdmin_AD FOREIGN KEY REFERENCES Account(AccUser),
	TenAD NVARCHAR(30),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	SDT NVARCHAR(11),
	Email NVARCHAR(30),
	DiaChi NVARCHAR(50)
)


INSERT INTO Account VALUES  -- tài khoản người quản lí
(N'trunghau' , N'12345678'),
(N'hieutrung' , N'12345678'),
(N'anbinh' , N'12345678'),
(N'phuongvy' , N'12345678')

INSERT INTO TTAdmin VALUES
(N'trunghau' , N'Võ Trung Hậu', N'Nam' , '12-12-2001', '0345670981' ,  N'trunghau@gmail.com' , N'206, Lê Lợi, Q1, Tp HCM'),
(N'hieutrung' , N'Võ Hiếu Trung', N'Nam' , '07-06-2001', '0973789534' , 'hieutrung@gmail.com' ,N'89, Nguyễn Thị Minh Khai, Q2, Tp HCM'),
(N'anbinh' , N'An Bình', N'Nữ' , '04-08-2001', '0973789534' , 'anbinh@gmail.com' ,N'89, Nguyễn Thị Minh Khai, Q2, Tp HCM'),
(N'phuongvy' , N'Phương Vy', N'Nữ' , '05-01-2001', '0973789534' , 'phuongvy@gmail.com' ,N'89, Nguyễn Thị Minh Khai, Q2, Tp HCM')



INSERT INTO KhachHang VALUES
(N'KH001' , N'NGUYỄN VĂN TÈO', N'Nam' , '04-05-2000', '0345670981' ,  N'TNTEO000@GMAIL.COM' , N'206, Lê Lợi, Q1, Tp HCM'), --địa chỉ email vd:trunghau@gmail.com  họ tên vd; Võ Trung Hậu
(N'KH002' , N'LÂM ÁNH NGỌC', N'Nữ' , '07-06-2001', '0973789534' , ' NGOC123@GMAIL.COM' ,N'89, Nguyễn Thị Minh Khai, Q2, Tp HCM'),
(N'KH003' , N'CAO VĂN TRÍ', N'Nam' ,  '02-04-2000', '0327865122', 'TTRI111GMAIL.COM' , N'20, Bùi Đình Túy, Q5, Tp HCM'),
(N'KH004' , N'TRỊNH THẢO', N'Nữ', '09-03-2001', '0632578283', 'THAO283@GMAIL.COM', N'58, An Dương Vương, Q5, Tp HCM'),
(N'KH005' , N'NGUYỄN THỊ KIM CHI', N'Nữ', '01-03-2001', '0582569832', 'CHIKIM31GMAIL.COM', N'100, Lạc Long Quân, Q11, Tp HCM'),
(N'KH006' , N'LÊ TRỌNG TẤN', N'Nam', '02-09-2001', '0836257694', 'TANNAM@GMAIL.COM', N'280, Lý Thái Tổ, Q10, Tp HCM'),
(N'KH007' , N'NGUYỄN THANH HUYỀN', N'Nữ', '06-08-2001', '0567486923', 'HUYENNU@GMAIL.COM', N'65, Nguyễn Trãi, Q5, Tp HCM'),
(N'KH008' , N'NGUYỄN THÀNH NAM', N'Nam', '08-05-2001', '0432674698', 'NAM0508@GMAIL.COM', N'216, Phạm Ngũ Lão, Q1, Tp HCM'),
(N'KH009' , N'CAO LÂM ANH', N'Nữ', '01-07-2001', '0423564517', 'ANH517GMAIL.COM', N'213, Lê Văn Sĩ, Q3, Tp HCM'),
(N'KH010' , N'HUỲNH TUẤN LINH', N'Nam', '07-01-2001', '0564726198', 'HTL0701@GMAIL.COM', N'321, Trần Đình Trọng, Q5, Tp HCM'),
(N'KH011' , N'ĐINH VĂN TOÀN', N'Nam', '06-04-2001', '0457328565', 'TOAN@GMAIL.COM', N'41, Bến Nghé, Q1, Tp HCM'),
(N'KH012' , N'HUỲNH THIÊN KIM', N'Nữ', '04-06-2001', '0675289326', 'THIENKIM0406@GMAIL.COM', N'235, Tạ Quang Bửu, Q8, Tp HCM'),
(N'KH013' , N'BÙI NGUYỆT MINH', N'Nữ', '09-09-2001', '0342676987', 'NGUYETMINH987@GMAIL.COM', N'41, Hải Thượng Lãn Ông, Q11, Tp HCM'),
(N'KH014' , N'TRẦN THÀNH NHÂN', N'Nam', '04-02-2001', '0413987608', 'NHAN0204GMAIL.COM', N'43, Hùng Vương, Q5, Tp HCM'),
(N'KH015' , N'VÕ NGỌC MINH THƯ', N'Nữ', '02-04-2001', '0362546798', 'THU016GMAIL.COM', N'235, Nguyễn Văn Linh, Q7, Tp HCM'),
(N'KH016' , N'LÊ HOÀI BẢO', N'Nam', '06-06-2001', '0253614239', 'BAOLE06@GMAIL.COM', N'132, Dương Đình Hội, Q9, Tp HCM'),
(N'KH017' , N'NGUYỄN GIA HÂN', N'Nữ', '03-03-2001', '0568213790', 'HAN790@GMAIL.COM', N'142, Âu Cơ, Q11, Tp HCM'),
(N'KH018' , N'LƯƠNG VĂN PHÚ', N'Nam', '07-05-2001', '0921438671', 'PHULUONGVAN@GMAIL.COM', N'89, Cách Mạng Tháng Tám, Q10, Tp HCM'),
(N'KH019' , N'TRẦN LÊ ANH THƯ', N'Nữ', '05-07-2001', '0956146154', 'THU050701@GMAIL.COM', N'52, Bắc Hải, Q10, Tp HCM'),
(N'KH020' , N'VÕ THANH HÙNG', N'Nam', '09-03-2001', '0632578283', 'HUNG283@GMAIL.COM', N'58, An Dương Vương, Q5, Tp HCM')

INSERT INTO NhanVien VALUES
(N'NV001', N'ĐẶNG VĂN TÈO', N'Nam', '06-02-1990', '0382881555', N'TNTEO000@GMAIL.COM' , N'TP Vũng Tàu'),
(N'NV002', N'NV Trung Hậu', N'Nam', '07-05-1991', '0783265908' , ' nvtrunghau@gmail.com' , N'TP Nha Trang'),
(N'NV003', N'LÊ THỊ AN BÌNH', N'Nữ', '05-11-1992', '0895833764', 'TTRI111GMAIL.COM' , N'TPHCM'),
(N'NV004', N'NV Phương Vy', N'Nữ', '01-09-1993', '0983767143', 'nvphuongvy@GMAIL.COM', N'TPHCM'),
(N'NV005', N'NGUYỄN VÕ HIẾU TRUNG', N'Nam', '04-08-1994', '0754618790', 'THAOdf283@GMAIL.COM', N'TP Cần Thơ'),
(N'NV006', N'PHẠM CHÍ BẢO', N'Nam', '08-01-1994', '0874869701', 'THAderO283@GMAIL.COM', N'TP Kiên Giang'),
(N'NV007', N'NGUYỄN THÚY KIỀU', N'Nữ', '07-09-1993', '0671438916', 'THAO2df83@GMAIL.COM', N'TP Long An'),
(N'NV008', N'LÊ KIỀU DIỄM TRINH', N'Nữ', '04-09-1995', '0138746879', 'THAdfO283@GMAIL.COM', N'TP Bạc Liêu'),
(N'NV009', N'TRẦN BẢO LÂM', N'Nam', '03-07-1995', '0465218749','dfTHAO283@GMAIL.COM', N'TP Sóc Trăng'),
(N'NV010', N'LƯƠNG NGỌC VY', N'Nữ', '01-05-1995', '0419187879', 'TdfHAO283@GMAIL.COM', N'TP Hậu Giang'),
(N'NV011', N'LƯƠNG ANH QUÂN', N'Nam', '03-08-1996', '0162469878','TfdfHAfO283@GMAIL.COM',  N'TP Vĩnh Long'),
(N'NV012', N'LÊ ĐINH ANH THƯ', N'Nữ', '05-04-1996', '0612578419', 'TdfHAO283@GMAIL.COM', N'TPHCM'),
(N'NV013', N'VÕ HOÀI LINH', N'Nam', '09-07-1996', '0891786531', 'THAOfds283@GMAIL.COM', N'TPHCM'),
(N'NV014', N'TRẦN HUYỀN MY', N'Nữ', '06-03-1997', '0456351478', 'THAO283@GMAIL.COM', N'TP Đồng Tháp'),
(N'NV015', N'TRẦN TRUNG BÌNH', N'Nam', '08-01-1997', '0674678608', 'TsHAO283@GMAIL.COM', N'TPHCM'),
(N'NV016', N'MAI VĂN CHƯƠNG', N'Nam', '03-09-1997', '0432775891', 'THAxvO283@GMAIL.COM', N'TPHCM'),
(N'NV017', N'MAI THỊ DIỄM LỆ', N'Nữ', '02-06-1998', '0453257849', 'THAOdfsd283@GMAIL.COM', N'TP Đồng Nai'),
(N'NV018', N'NGUYỄN THỊ XUÂN', N'Nữ', '04-08-1998', '0237678970', 'THAxsdfcO283@GMAIL.COM', N'TP Bình Dương'),
(N'NV019', N'TRƯƠNG BẢO QUỐC', N'Nam', '03-01-1998', '0372589627', 'THAssO283@GMAIL.COM', N'TPHCM'),
(N'NV020', N'HUỲNH THỊ MỸ', N'Nữ', '06-01-1998', '0483427276', 'THAO28sf3@GMAIL.COM', N'TPHCM')

INSERT INTO AccNV VALUES    -- tài khoản nhân viên
(N'NV002', N'trunghaunv', N'12345678'),  --cái này thêm cho đủ 20 cái luôn
(N'NV004', N'phuongvynv', N'12345678')


INSERT INTO HoaDon VALUES
(N'HD001', '04-05-2020', N'NV015', N'KH012'),
(N'HD002', '01-02-2019', N'NV016', N'KH004'),
(N'HD003', '02-03-2020', N'NV014', N'KH001'),
(N'HD004', '03-04-2019', N'NV012', N'KH015'),
(N'HD005', '05-06-2020', N'NV009', N'KH007'),
(N'HD006', '06-07-2019', N'NV001', N'KH016'),
(N'HD007', '07-08-2020', N'NV010', N'KH019'),
(N'HD008', '08-09-2019', N'NV011', N'KH003'),
(N'HD009', '09-01-2020', N'NV007', N'KH001'),
(N'HD010', '08-02-2019', N'NV004', N'KH006'),
(N'HD011', '07-03-2020', N'NV003', N'KH002'),
(N'HD012', '06-04-2019', N'NV001', N'KH005'),
(N'HD013', '05-05-2020', N'NV002', N'KH018'),
(N'HD014', '04-04-2019', N'NV020', N'KH008'),
(N'HD015', '06-06-2020', N'NV011', N'KH019'),
(N'HD016', '07-07-2019', N'NV006', N'KH011'),
(N'HD017', '08-08-2020', N'NV010', N'KH012'),
(N'HD018', '09-09-2019', N'NV005', N'KH009'),
(N'HD019', '01-01-2020', N'NV013', N'KH017'),
(N'HD020', '02-02-2019', N'NV018', N'KH003')

INSERT INTO SanPham VALUES
(N'SP001', N'iphone 12 Pro Max', '35000000', N'Điện Thoại', '5', '04-05-2020'),
(N'SP002', N'Samsung Galaxy S20', '24000000', N'Điện Thoại', '5', '02-01-2020'),
(N'SP003', N'Sony Xperia XZ3', '5890000', N'Điện Thoại', '4', '08-06-2020'),
(N'SP004', N'Huawei P30 Lite', '5490000', N'Điện Thoại', '3', '07-09-2020'),
(N'SP005', N'Oppo Reno4 Pro', '11990000', N'Điện Thoại', '7', '05-03-2020'),
(N'SP006', N'Dell Inspiron 7490-N4I5106W', '18890000', N'Laptop', '3', '06-04-2020'),
(N'SP007', N'ASUS ROG STRIX G15 G512L', '36990000', N'Laptop', '2', '03-08-2020'),
(N'SP008', N'Laptop HP Pavilion', '14890000', N'Laptop', '3', '02-08-2020'),
(N'SP009', N'Laptop Acer Gaming Nitro 5', '19990000', N'Laptop', '2', '01-05-2020'),
(N'SP010', N'Laptop LG gram 2020 15ZD90N', '27400000', N'Laptop', '3', '01-09-2020'),
(N'SP011', N'Tai Nghe AKG S8/S9/P', '119000', N'Phụ Kiện Điện Thoại', '5', '04-03-2020'),
(N'SP012', N'Tai Nghe Bluetooth', '2312000', N'Phụ Kiện Điện Thoại', '3', '02-09-2020'),
(N'SP013', N'Sạc Dự Phòng Polymer 10000mAh', '382000', N'Phụ Kiện Điện Thoại', '5', '02-05-2020'),
(N'SP014', N'Sạc Dự Phòng 7500mAh AVA', '255000', N'Phụ Kiện Điện Thoại', '2', '04-09-2020'),
(N'SP015', N'Sạc Dự Phòng 10000mAh Anker', '600000', N'Phụ Kiện Điện Thoại', '3', '08-04-2020'),
(N'SP016', N'Bàn phím Laptop Dell XPS', '2800000', N'Phụ Kiện Laptop', '2', '03-05-2020'),
(N'SP017', N'Chuột không dây Logitech', '270000', N'Phụ Kiện Laptop', '3', '04-06-2020'),
(N'SP018', N'Tai nghe choàng đầu có micro', '1200000', N'Phụ Kiện Laptop', '3', '04-02-2020'),
(N'SP019', N'Loa Laptop ASUS U35J', '320000', N'Phụ Kiện Điện Thoại', '2', '05-06-2020'),
(N'SP020', N'Chuột không dây Anitech', '490000', N'Phụ Kiện Laptop', '3', '04-06-2020')

INSERT INTO CTHoaDon VALUES
('HD001', 'SP001', '2'),
('HD001', 'SP002', '2'),
('HD011', 'SP015', '1'),
('HD012', 'SP004', '1'),
('HD005', 'SP009', '3'),
('HD006', 'SP011', '1'),
('HD020', 'SP005', '3'),
('HD017', 'SP006', '1'),
('HD003', 'SP017', '2'),
('HD003', 'SP016', '1'),
('HD008', 'SP006', '2'),
('HD010', 'SP002', '1'),
('HD013', 'SP019', '2'),
('HD014', 'SP011', '3'),
('HD019', 'SP013', '3'),
('HD012', 'SP012', '1'),
('HD018', 'SP017', '1'),
('HD006', 'SP013', '3'),
('HD007', 'SP009', '3'),
('HD008', 'SP007', '3')
