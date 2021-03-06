USE [hidra]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cli] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [varchar](50) NULL,
	[Tel_cli] [varchar](14) NULL,
	[Dir_cli] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 3/3/2021 8:32:02 p. m. ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NOT NULL,
	[uname] [nvarchar](50) NULL,
	[pass] [nvarchar](16) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_cliente]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizar_cliente]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Telefono VARCHAR(14),
    @Direccion VARCHAR(100),
    @id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Cliente set Nom_cli= @Nombre,Tel_cli= @Telefono,Dir_cli= @Direccion WHERE id_cli=@id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_cliente]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertar_cliente]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Telefono VARCHAR(14),
    @Direccion VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into Cliente (Nom_cli,Tel_cli,Dir_cli) VALUES (@Nombre,@Telefono,@Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Login]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Clave VARCHAR(16)

AS
BEGIN
	SELECT top 1 COUNT(*) FROM [login] 
    WHERE login.uname = @Nombre AND login.pass= @Clave
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_cliente]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_mostrar_cliente]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Cliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectfor]    Script Date: 3/3/2021 8:32:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectfor]
	-- Add the parameters for the stored procedure here
	@Param1 varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Cliente where Nom_cli like '%'+@Param1+'%'
END
GO
