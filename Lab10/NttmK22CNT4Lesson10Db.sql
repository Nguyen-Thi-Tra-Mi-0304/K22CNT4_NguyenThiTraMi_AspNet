USE [NttmK22CT4Lesson10]
GO
/****** Object:  Table [dbo].[NttmAccount]    Script Date: 7/3/2024 2:02:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NttmAccount](
	[NttmID] [int] IDENTITY(1,1) NOT NULL,
	[NttmUserName] [nvarchar](50) NULL,
	[NttmPassWord] [nvarchar](50) NULL,
	[NttmFullName] [nvarchar](50) NULL,
	[NttmEmail] [nvarchar](50) NULL,
	[NttmPhone] [nvarchar](50) NULL,
	[NttmActive] [bit] NULL,
 CONSTRAINT [PK_NttmAccount] PRIMARY KEY CLUSTERED 
(
	[NttmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NttmAccount] ON 

INSERT [dbo].[NttmAccount] ([NttmID], [NttmUserName], [NttmPassWord], [NttmFullName], [NttmEmail], [NttmPhone], [NttmActive]) VALUES (1, N'Nguyễn Mi', N'123456a@', N'Nguyễn Thị Trà Mi', N'traminguyen0304@gmail.com', N'0963225045', 1)
SET IDENTITY_INSERT [dbo].[NttmAccount] OFF
GO
