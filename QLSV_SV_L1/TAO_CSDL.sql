﻿-- Create Database
create database QLSV_SV_L1
on primary
(   name = QLSV_SV_L1_data,
    filename = 'D:\DATA\QLSV_SV_L1_data.mdf',
    size = 3MB,maxsize = 5MB,filegrowth = 1MB)
log on
(   name = QLSV_SV_L1_log,
    filename = 'D:\DATA\QLSV_SV_L1_log.ldf',
    size = 3MB,maxsize = 5MB,filegrowth = 1MB)
go
use QLSV_SV_L1
go
use master
drop database QLSV_SV_L1
-- Tao bang KHOA
create table KHOA
(
    MaKH char(2),
    TenKH nvarchar(30),
    constraint Pri_KHOA primary key (MaKH)
)

-- Tao bang SINHVIEN
create table SINHVIEN
(
    MaSV char(3),
    HoSV nvarchar(38),
    TenSV nvarchar(10),
    Phai bit,
    Ngaysinh datetime,
    Noisinh nvarchar(50),
    MaKH char(2),
	HocBong real,
    constraint Pri_SINHVIEN primary key (MaSV),
    constraint For_KHOA_SINHVIEN foreign key (MaKH) references KHOA(MaKH)
)

-- Tao bang MONHOC
create table MONHOC
(
    MaMH char(2),
    TenMH nvarchar(45),
	SoTiet real,
	LoaiMH bit,
    constraint Pri_MONHOC primary key (MaMH)
)

-- Tao bang KETQUA
create table KETQUA
(
    MaSV char(3),
    MaMH char(2),
    Diem real,
    constraint Pri_KETQUA primary key (MaSV, MaMH),
    constraint For_SINHVIEN_KETQUA foreign key (MaSV) references SINHVIEN(MaSV),
    constraint For_MONHOC_KETQUA foreign key (MaMH) references MONHOC(MaMH)
)
-- Nhap lieu KHOA
insert into KHOA values ('AV', N'Anh Văn');
insert into KHOA values ('HH', N'Hóa Học');
insert into KHOA values ('KT', N'Kinh Tế Học');
insert into KHOA values ('SV', N'Sinh Vật Học');
insert into KHOA values ('TH', N'Tin Học');
insert into KHOA values ('VL', N'Vật Lý');
insert into KHOA values ('OT', N'Cơ khí');
select * from KHOA

-- Nhap lieu MONHOC
insert into MONHOC values ('01', N'Triết Học Đông Phương',30,1);
insert into MONHOC values ('02', N'Toán Cao Cấp 1',60,0);
insert into MONHOC values ('03', N'Toán Cao Cấp 2',60,0);
insert into MONHOC values ('04', N'Vật Lý Đại Cương',25,1);
insert into MONHOC values ('05', N'Cơ Sở Dữ Liệu',45,1);
insert into MONHOC values ('06', N'Lập Trình Hệ Thống',60,1);
insert into MONHOC values ('07', N'Tiếp Pháp',30,0);
insert into MONHOC values ('08', N'Tiếng Hoa',30,0);
insert into MONHOC values ('09', N'Phân Tích Hệ Thống',35,1);
insert into MONHOC values ('10', N'Tiếng Anh',30,0);
insert into MONHOC values ('11', N'Lập Trình Hướng Đối Tượng',35,1);
select * from MONHOC

-- Nhap lieu SINHVIEN
insert into SINHVIEN values ('A01',N'Nguyễn Ngoan',N'Cường',1,'05/06/1972',N'Hà Nội','AV',20000);
insert into SINHVIEN values ('A02',N'Lý Anh',N'Huy',1,'01/01/1975',N'TP.HCM','AV',50000);
insert into SINHVIEN values ('A03',N'Lê Khắc',N'Dung',0,'08/12/1974',N'Bình Định','TH',45000);
insert into SINHVIEN values ('A10',N'Đinh Hữu',N'Chính',1,'05/25/1977',N'Cà Mau','AV',50000);
insert into SINHVIEN values ('A11',N'Văn Thành',N'Nho',1,'07/05/1971',N'Cần Giờ','AV',50000);
insert into SINHVIEN values ('A12',N'Nguyễn Văn',N'Chính',1,'01/23/1974',N'Mỹ Tho','AV',45000);
insert into SINHVIEN values ('A13',N'Trần Thị Yến',N'Nhi',0,'11/23/1975',N'Cần Thơ','TH',50000);
insert into SINHVIEN values ('A14',N'Nguyễn Thành',N'Khiêm',1,'04/30/1975',N'TP.HCM','TH',30000);
insert into SINHVIEN values ('D09',N'Đoàn Kiều',N'Giang',0,'01/01/1975',N'Cần Thơ','SV',50000);
insert into SINHVIEN values ('H08',N'Bùi Quốc',N'Cường',1,'04/18/1976',N'Tiền Giang','HH',35000);
insert into SINHVIEN values ('K04',N'Tạ Văn',N'Minh',1,'12/26/1974',N'Hà Nội','KT',40000);
insert into SINHVIEN values ('S06',N'Đoàn Thanh',N'Mai',0,'09/25/1976',N'An Giang','SV',50000);
insert into SINHVIEN values ('T07',N'Lê Ngọc Diễm',N'Lệ',0,'01/26/1975',N'TP.HCM','TH',50000);
insert into SINHVIEN values ('V05',N'Nguyễn Khắc',N'Định',1,'04/12/1976',N'Tây Ninh','VL',50000);
insert into SINHVIEN values ('V09',N'Mai Văn',N'Dũng',1,'01/12/1977',N'Sa Đéc','VL',50000);
select * from SINHVIEN

-- Nhap lieu KETQUA
insert into KETQUA values ('A01','01',8);
insert into KETQUA values ('A01','02',7);
insert into KETQUA values ('A03','01',10);
insert into KETQUA values ('A03','02',4.5);
insert into KETQUA values ('A03','03',3);
insert into KETQUA values ('A10','10',8);
insert into KETQUA values ('A10','11',4.5);
insert into KETQUA values ('A12','07',9);
insert into KETQUA values ('A12','08',8.5);
insert into KETQUA values ('A13','03',6.5);
insert into KETQUA values ('A13','06',10);
insert into KETQUA values ('A14','05',8.5);
insert into KETQUA values ('A14','09',8);
insert into KETQUA values ('A14','11',10);
insert into KETQUA values ('D09','05',8);
insert into KETQUA values ('D09','01',4);
insert into KETQUA values ('D09','03',0);
insert into KETQUA values ('K04','01',5.5);
insert into KETQUA values ('K04','02',6);
insert into KETQUA values ('K04','03',7.5);
insert into KETQUA values ('S06','04',0);
insert into KETQUA values ('T07','05',3);
insert into KETQUA values ('T07','10',2);
insert into KETQUA values ('T07','11',5);
insert into KETQUA values ('V05','04',8);
insert into KETQUA values ('V05','01',0);
select * from KETQUA
