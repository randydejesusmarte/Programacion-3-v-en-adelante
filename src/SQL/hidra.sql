USE [hidra]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/2/2021 12:25:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cli] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [nchar](10) NULL,
	[Dir_cli] [nchar](10) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 17/2/2021 12:25:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_fac] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [varchar](50) NULL,
	[Dir_cli] [varchar](max) NULL,
	[Mar_veh] [nchar](10) NULL,
	[Mod_veh] [nchar](10) NULL,
	[Año_veh] [nchar](10) NULL,
	[Fec_ent] [nchar](10) NULL,
	[Fec_sal] [nchar](10) NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_fac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 17/2/2021 12:25:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](max) NULL,
	[uid] [nvarchar](50) NULL,
	[pass] [nvarchar](18) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
