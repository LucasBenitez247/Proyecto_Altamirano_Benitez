USE [master]
GO
/****** Object:  Database [BD_SISTEMA_VENTA_]    Script Date: 08/10/2025 10:45:01 a. m. ******/
CREATE DATABASE [BD_SISTEMA_VENTA_]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_SISTEMA_VENTA_', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BD_SISTEMA_VENTA_.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_SISTEMA_VENTA__log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BD_SISTEMA_VENTA__log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_SISTEMA_VENTA_].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET  MULTI_USER 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_SISTEMA_VENTA_', N'ON'
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET QUERY_STORE = ON
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BD_SISTEMA_VENTA_]
GO
/****** Object:  Table [dbo].[Categoria_producto]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_producto](
	[Id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_categoria] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_cliente] [varchar](100) NOT NULL,
	[Apellido_cliente] [varchar](100) NOT NULL,
	[Dni_cliente] [varchar](20) NOT NULL,
	[Genero_cliente] [varchar](20) NULL,
	[Correo_cliente] [varchar](100) NULL,
	[Telefono_cliente] [varchar](20) NULL,
	[Direccion_cliente] [varchar](150) NULL,
	[Ciudad_cliente] [varchar](100) NULL,
	[Provincia_cliente] [varchar](100) NULL,
	[Cod_postal_cliente] [int] NULL,
	[Estado_cliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_producto]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_producto](
	[Id_estado_producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_estado_producto] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_estado_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre_perfil] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id_producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_producto] [varchar](100) NOT NULL,
	[Descripcion_producto] [varchar](255) NULL,
	[Precio_producto] [decimal](10, 2) NOT NULL,
	[Id_estado_producto] [int] NOT NULL,
	[Stock_producto] [int] NOT NULL,
	[Id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 08/10/2025 10:45:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[correo] [varchar](100) NOT NULL,
	[contrasenia] [varchar](200) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[estado_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria_producto] ON 

INSERT [dbo].[Categoria_producto] ([Id_categoria], [Descripcion_categoria]) VALUES (1, N'Gorras')
INSERT [dbo].[Categoria_producto] ([Id_categoria], [Descripcion_categoria]) VALUES (2, N'Buzos')
INSERT [dbo].[Categoria_producto] ([Id_categoria], [Descripcion_categoria]) VALUES (3, N'Remeras')
INSERT [dbo].[Categoria_producto] ([Id_categoria], [Descripcion_categoria]) VALUES (4, N'Autitos coleccionables')
SET IDENTITY_INSERT [dbo].[Categoria_producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Dni_cliente], [Genero_cliente], [Correo_cliente], [Telefono_cliente], [Direccion_cliente], [Ciudad_cliente], [Provincia_cliente], [Cod_postal_cliente], [Estado_cliente]) VALUES (1, N'María', N'Gómez', N'38222444', N'Femenino', N'maria.gomez@example.com', N'1133344455', N'Calle Falsa 456', N'Córdoba', N'Córdoba', 5000, NULL)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Dni_cliente], [Genero_cliente], [Correo_cliente], [Telefono_cliente], [Direccion_cliente], [Ciudad_cliente], [Provincia_cliente], [Cod_postal_cliente], [Estado_cliente]) VALUES (2, N'Juan', N'Pérez', N'40999888', N'Masculino', N'juan.perez@example.com', N'1145678901', N'Mitre 789', N'Rosario', N'Santa Fe', 2000, NULL)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Dni_cliente], [Genero_cliente], [Correo_cliente], [Telefono_cliente], [Direccion_cliente], [Ciudad_cliente], [Provincia_cliente], [Cod_postal_cliente], [Estado_cliente]) VALUES (3, N'Carla', N'Rodríguez', N'37222111', N'Femenino', N'carla.rodriguez@example.com', N'1155566677', N'San Martín 654', N'La Plata', N'Buenos Aires', 1900, NULL)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado_producto] ON 

INSERT [dbo].[Estado_producto] ([Id_estado_producto], [Descripcion_estado_producto]) VALUES (1, N'Activo')
INSERT [dbo].[Estado_producto] ([Id_estado_producto], [Descripcion_estado_producto]) VALUES (2, N'Inactivo')
SET IDENTITY_INSERT [dbo].[Estado_producto] OFF
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id_perfil], [nombre_perfil]) VALUES (1, N'Administrador')
INSERT [dbo].[perfil] ([id_perfil], [nombre_perfil]) VALUES (2, N'Vendedor')
INSERT [dbo].[perfil] ([id_perfil], [nombre_perfil]) VALUES (3, N'Dueño de negocio')
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [nombre], [apellido], [correo], [contrasenia], [id_perfil], [estado_usuario]) VALUES (2, N'Julián', N'Rodríguez', N'Julian_Rodriguez11@gmail.com', N'j123456', 2, 1)
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [apellido], [correo], [contrasenia], [id_perfil], [estado_usuario]) VALUES (3, N'Carlos', N'Castillo', N'carlos_castillo@gmail.com', N'c123456', 3, 1)
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [apellido], [correo], [contrasenia], [id_perfil], [estado_usuario]) VALUES (7, N'Gabriel', N'Zanchez', N'gabriel_sanchez88@gmail.com', N'g123456', 1, 1)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clientes__538EA93B39799856]    Script Date: 08/10/2025 10:45:03 a. m. ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[Dni_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__usuarios__2A586E0BBF2ECB5A]    Script Date: 08/10/2025 10:45:03 a. m. ******/
ALTER TABLE [dbo].[usuarios] ADD UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ((1)) FOR [estado_usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([Id_categoria])
REFERENCES [dbo].[Categoria_producto] ([Id_categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Estado] FOREIGN KEY([Id_estado_producto])
REFERENCES [dbo].[Estado_producto] ([Id_estado_producto])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Estado]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_perfil]
GO
USE [master]
GO
ALTER DATABASE [BD_SISTEMA_VENTA_] SET  READ_WRITE 
GO
