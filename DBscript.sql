USE [DMRT]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 14-Dec-20 4:25:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_details]    Script Date: 14-Dec-20 4:25:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](max) NULL,
	[last_name] [nvarchar](max) NULL,
	[mobile] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[date] [nvarchar](max) NULL,
	[nationality] [nvarchar](max) NULL,
	[gender] [nvarchar](max) NULL,
	[seat] [nvarchar](max) NULL,
	[seatfare] [nvarchar](max) NULL,
	[bording] [nvarchar](max) NULL,
	[dropping] [nvarchar](max) NULL,
	[type] [nvarchar](max) NULL,
 CONSTRAINT [PK_user_details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
