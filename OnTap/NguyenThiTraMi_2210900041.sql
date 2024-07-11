USE [NguyenThiTraMi_2210900041]
GO
/****** Object:  Table [dbo].[NTTM_SACH]    Script Date: 7/11/2024 8:27:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTTM_SACH](
	[Nttm_MaSach] [nchar](10) NOT NULL,
	[Nttm_TenSach] [nvarchar](250) NULL,
	[Nttm_SoTrang] [int] NULL,
	[Nttm_NamXB] [int] NULL,
	[Nttm_MaTG] [nchar](10) NULL,
	[Nttm_TrangThai] [bit] NULL,
 CONSTRAINT [PK_NTTM_SACH] PRIMARY KEY CLUSTERED 
(
	[Nttm_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NTTM_TACGIA]    Script Date: 7/11/2024 8:27:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTTM_TACGIA](
	[Nttm_MaTG] [nchar](10) NOT NULL,
	[Nttm_TenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_NTTM_TacGia] PRIMARY KEY CLUSTERED 
(
	[Nttm_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NTTM_SACH] ([Nttm_MaSach], [Nttm_TenSach], [Nttm_SoTrang], [Nttm_NamXB], [Nttm_MaTG], [Nttm_TrangThai]) VALUES (N'00001     ', N'Nguyễn Thị Trà Mi', 100, 2004, N'TG001     ', 1)
INSERT [dbo].[NTTM_SACH] ([Nttm_MaSach], [Nttm_TenSach], [Nttm_SoTrang], [Nttm_NamXB], [Nttm_MaTG], [Nttm_TrangThai]) VALUES (N'00002     ', N'Net MVC', 1000, 2019, N'TG001     ', 0)
GO
INSERT [dbo].[NTTM_TACGIA] ([Nttm_MaTG], [Nttm_TenTacGia]) VALUES (N'TG001     ', N'Nguyễn Thị Trà Mi')
INSERT [dbo].[NTTM_TACGIA] ([Nttm_MaTG], [Nttm_TenTacGia]) VALUES (N'TG002     ', N'Ngô Tất Tố')
INSERT [dbo].[NTTM_TACGIA] ([Nttm_MaTG], [Nttm_TenTacGia]) VALUES (N'TG003     ', N'Nguyễn Du')
GO
ALTER TABLE [dbo].[NTTM_SACH]  WITH CHECK ADD  CONSTRAINT [FK_NTTM_SACH_NTTM_TACGIA] FOREIGN KEY([Nttm_MaTG])
REFERENCES [dbo].[NTTM_TACGIA] ([Nttm_MaTG])
GO
ALTER TABLE [dbo].[NTTM_SACH] CHECK CONSTRAINT [FK_NTTM_SACH_NTTM_TACGIA]
GO
