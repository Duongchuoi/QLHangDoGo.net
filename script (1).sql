USE [master]
GO
/****** Object:  Database [QLDG]    Script Date: 11/27/2023 3:47:11 PM ******/
CREATE DATABASE [QLDG]
 CONTAINMENT = NONE
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDG] SET  MULTI_USER 
GO
ALTER DATABASE [QLDG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDG] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLDG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLDG]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MaNV] [int] NOT NULL,
	[Thang] [date] NULL,
	[SoCong] [int] NULL,
	[Thuong] [int] NULL,
	[TongLuong] [int] NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPX] [int] NOT NULL,
	[MaMH] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaMH] [int] NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DVT] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMH] [int] NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[MaNCC] [int] NULL,
	[SoLuong] [int] NULL,
	[DVT] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaCV] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [int] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [int] NOT NULL,
	[NgayXuat] [date] NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/27/2023 3:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](150) NULL,
	[MaNV] [int] NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (2, CAST(N'2023-05-12' AS Date), 24, 500000, 4000000)
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (3, CAST(N'2023-11-10' AS Date), 24, 600000, 15000000)
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (4, CAST(N'2023-12-15' AS Date), 21, 400000, 900000)
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (12, CAST(N'2022-12-12' AS Date), 12, 200000, 400000)
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (44, CAST(N'2023-12-12' AS Date), 23, 500000, 883233)
INSERT [dbo].[BangLuong] ([MaNV], [Thang], [SoCong], [Thuong], [TongLuong]) VALUES (123, CAST(N'2023-12-24' AS Date), 13, 400000, 9000000)
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (1, N'nhân viên')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (2, N'lễ tân')
GO
INSERT [dbo].[CTPhieuNhap] ([MaPX], [MaMH], [SoLuong], [DonGia], [ThanhTien]) VALUES (1, 1, 12, 100000, 12000000)
INSERT [dbo].[CTPhieuNhap] ([MaPX], [MaMH], [SoLuong], [DonGia], [ThanhTien]) VALUES (2, 2, 20, 2000000, 1010000)
GO
INSERT [dbo].[GioHang] ([MaMH], [TenMH], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (1, N'Tủ', 5, N'Chiếc', N'Gỗ Hương', 12000000)
INSERT [dbo].[GioHang] ([MaMH], [TenMH], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (3, N'Bàn', 17, N'Bộ', N'Lim', 5000000)
INSERT [dbo].[GioHang] ([MaMH], [TenMH], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (4, N'Giường', 11, N'Bộ', N'Lim', 10000000)
INSERT [dbo].[GioHang] ([MaMH], [TenMH], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (6, N'Phản', 12, N'Bộ', N'Hương Đá', 20000000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT]) VALUES (1, N'hoàng', 1981)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT]) VALUES (2, N'hậu', 81231)
GO
INSERT [dbo].[MatHang] ([MaMH], [TenMH], [MaNCC], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (1, N'Giường', 1, 6, N'bộ', N'gỗ hương', 13000000)
INSERT [dbo].[MatHang] ([MaMH], [TenMH], [MaNCC], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (2, N'Tủ', 2, 3, N'chiếc', N'Lim', 7000000)
INSERT [dbo].[MatHang] ([MaMH], [TenMH], [MaNCC], [SoLuong], [DVT], [Loai], [DonGia]) VALUES (3, N'Bàn Thờ', 3, 5, N'bộ', N'Sồi', 5000000)
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (1, N'a', N'thanh hoa', N'09122')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (2, N'HuongHue', N'HauLoc', N'0367953090')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (3, N'Thành', N'Nam Định', N'01283')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (2, N'hướng', 1, N'Hà Nội', N'0367953090', CAST(N'2003-06-25' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (3, N'linh', 2, N'hà tĩnh', N'1243', CAST(N'2023-11-07' AS Date), N'nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (4, N'dương', 2, N'Yên Bái', N'02393', CAST(N'2003-03-20' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (12, N'hoi', 2, N'thanh hoá', N'0922', CAST(N'2022-12-12' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (44, N'an', 1, N'nam dinh', N'33244', CAST(N'2003-12-16' AS Date), N'nam')
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNCC]) VALUES (1, CAST(N'2022-12-13' AS Date), 1)
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNCC]) VALUES (2, CAST(N'2023-11-11' AS Date), 2)
GO
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaKH], [MaNV]) VALUES (1, CAST(N'2012-12-12' AS Date), 1, 12)
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaKH], [MaNV]) VALUES (2, CAST(N'2023-11-11' AS Date), 2, 4)
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV], [Email]) VALUES (N'huong1', N'$2a$11$CsGN2Mn7mrKlOQ1UPzujeOualqv4SCog6vh2xZeJ/UGahjIZxGeqy', 12, N'huonghue@gmail.com')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV], [Email]) VALUES (N'manh1', N'$2a$11$bJOGthKiaa7jwyeBgPKlIe4KU3ADByAftoNlaMo4HnFIR5UB1/7AC', 2, N'vuthemanh@hehe.com')
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_MatHang]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_NhaCungCap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BangLuong] FOREIGN KEY([MaNV])
REFERENCES [dbo].[BangLuong] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BangLuong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_CTPhieuNhap] FOREIGN KEY([MaPX])
REFERENCES [dbo].[CTPhieuNhap] ([MaPX])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_CTPhieuNhap]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLDG] SET  READ_WRITE 
GO
