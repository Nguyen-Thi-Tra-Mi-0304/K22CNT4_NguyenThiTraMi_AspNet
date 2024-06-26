USE [NttmK22CNT4QLSinhVien]
GO
/****** Object:  Table [dbo].[NttmKetQua]    Script Date: 6/26/2024 2:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NttmKetQua](
	[NttmMaSV] [nchar](10) NULL,
	[NttmMaMH] [nchar](10) NULL,
	[NttmDiem] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NttmKhoa]    Script Date: 6/26/2024 2:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NttmKhoa](
	[NttmMaKH] [nchar](10) NOT NULL,
	[NttmTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_NttmKhoa] PRIMARY KEY CLUSTERED 
(
	[NttmMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NttmMonHoc]    Script Date: 6/26/2024 2:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NttmMonHoc](
	[NttmMaMH] [nchar](10) NOT NULL,
	[NttmTenMH] [nvarchar](50) NULL,
	[NttmSoTiet] [decimal](18, 0) NULL,
 CONSTRAINT [PK_NttmMonHoc] PRIMARY KEY CLUSTERED 
(
	[NttmMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NttmSinhVien]    Script Date: 6/26/2024 2:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NttmSinhVien](
	[NttmMaSV] [nchar](10) NOT NULL,
	[NttmHoSV] [nvarchar](50) NULL,
	[NttmTenSV] [nvarchar](50) NULL,
	[NttmPhai] [bit] NULL,
	[NttmNgaySinh] [date] NULL,
	[NttmNoiSinh] [nvarchar](50) NULL,
	[NttmMaKH] [nchar](10) NULL,
	[NttmHocBong] [decimal](18, 0) NULL,
	[NttmDiemTrungBinh] [decimal](18, 0) NULL,
 CONSTRAINT [PK_NttmSinhVien] PRIMARY KEY CLUSTERED 
(
	[NttmMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NttmKetQua]  WITH CHECK ADD  CONSTRAINT [FK_NttmKetQua_NttmMonHoc] FOREIGN KEY([NttmMaMH])
REFERENCES [dbo].[NttmMonHoc] ([NttmMaMH])
GO
ALTER TABLE [dbo].[NttmKetQua] CHECK CONSTRAINT [FK_NttmKetQua_NttmMonHoc]
GO
ALTER TABLE [dbo].[NttmKetQua]  WITH CHECK ADD  CONSTRAINT [FK_NttmKetQua_NttmSinhVien] FOREIGN KEY([NttmMaSV])
REFERENCES [dbo].[NttmSinhVien] ([NttmMaSV])
GO
ALTER TABLE [dbo].[NttmKetQua] CHECK CONSTRAINT [FK_NttmKetQua_NttmSinhVien]
GO
ALTER TABLE [dbo].[NttmSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_NttmSinhVien_NttmKhoa] FOREIGN KEY([NttmMaKH])
REFERENCES [dbo].[NttmKhoa] ([NttmMaKH])
GO
ALTER TABLE [dbo].[NttmSinhVien] CHECK CONSTRAINT [FK_NttmSinhVien_NttmKhoa]
GO
