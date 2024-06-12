USE [NttmK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[nttmKhoa]    Script Date: 6/12/2024 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nttmKhoa](
	[nttmMaKH] [nchar](10) NOT NULL,
	[nttmTenKH] [nvarchar](50) NULL,
	[nttmTrangThai] [bit] NULL,
 CONSTRAINT [PK_nttmKhoa] PRIMARY KEY CLUSTERED 
(
	[nttmMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nttmSinhVien]    Script Date: 6/12/2024 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nttmSinhVien](
	[NttmMaSV] [nchar](10) NOT NULL,
	[NttmHoSV] [nvarchar](50) NULL,
	[NttmTenSV] [nvarchar](50) NULL,
	[NttmPhai] [bit] NULL,
	[NttmEmail] [nvarchar](50) NULL,
	[NttmPhone] [nvarchar](50) NULL,
	[NttmMaKH] [nchar](10) NULL,
	[NttmTrangThai] [bit] NULL,
 CONSTRAINT [PK_nttmSinhVien] PRIMARY KEY CLUSTERED 
(
	[NttmMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[nttmSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_nttmSinhVien_nttmKhoa] FOREIGN KEY([NttmMaKH])
REFERENCES [dbo].[nttmKhoa] ([nttmMaKH])
GO
ALTER TABLE [dbo].[nttmSinhVien] CHECK CONSTRAINT [FK_nttmSinhVien_nttmKhoa]
GO
