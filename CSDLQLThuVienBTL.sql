create database QuanLyTV
go
use QuanLyTV
go
create table DOCGIA
(
	MaDocGia	char(50) primary key,	
	HoTen		nvarchar(50),
	NgaySinh	date,	
	DiaChi		nvarchar(50),	
	NgayLapThe	date,	
		
)
create table THUTHU
(
	MaThuThu	char(50) primary key,	
	HoTen	nvarchar(50),
	DiaChi	nvarchar(50),	
	TenDangNhap	nvarchar(50),
	MatKhau	char(10),	
	QuyenHan	char(20)
)
create table PHANLOAI
(
	MaLoai	char(40) primary key,	
	TenLoai	nvarchar(50)	
		
)
create table SACH
(
	MaSach	char(50),
	TenSach	nvarchar(50),	
	SoTrang	int,
	SoLuong	int	,
	NamXB	date,	
	LanXB	int,
	MaLoai	char(40),
	NXB	nvarchar(50),
	TacGia	nvarchar(50),
	NgayNhap	date,
	constraint 	KC1_FK primary key(MaSach),
	constraint KN2_FK foreign key (MaLoai) references PHANLOAI(MaLoai)
)
create table PHIEUMUON 
(
	MaDocGia	char(50),
	NgayMuon	date,
	MaSach	char(50),
	MaThuThu	char(50),
	SoLuong	int,
	TrangThai	nvarchar(30),
	NgayTra	date,
	constraint KC_FK primary key (MaDocGia,NgayMuon,MaSach),
	constraint KN0_FK foreign key (MaDocGia) references DOCGIA(MaDocGia),
	constraint KN1_FK foreign key (MaThuThu) references THUTHU(MaThuThu)
)
alter table PHIEUMUON
add constraint KN3_FK foreign key (MaSach) references SACH(MaSach)
