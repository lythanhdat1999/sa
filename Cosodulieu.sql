use quanlybanhang

create table HangHoa(
	MaHH varchar(10) primary key,
	TenHang nvarchar(30),
	DonGia int,
	XuatXu nvarchar(20),
	SoLuong int
)
create table KhachHang(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50),
	DiaChi nvarchar(50),
	SoDT varchar(20)
)
create table HoaDon(
	MaHD varchar(10) primary key,
	NgayLap date,
	KhachHang varchar(10),
	constraint fk_MaKH foreign key (KhachHang) references KhachHang(MaKH)
)

create table ChiTiet(
	MaHD varchar(10),
	MaHH varchar(10),
	SoLuong int,
	DonGia int,
	constraint fk_MaHD foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_MaHH foreign key (MaHH) references HangHoa(MaHH),
	constraint pk_ChiTiet PRIMARY KEY(MaHD,MaHH)
)
create table Account(
	MaDN varchar(10) primary key,
	MK varchar(30)
)