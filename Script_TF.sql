USE [master]
GO
/****** Object:  Database [Project_EM]    Script Date: 28/06/2022 23:51:50 ******/
CREATE DATABASE [Project_EM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Edna_Moda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Edna_Moda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Edna_Moda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Edna_Moda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Project_EM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_EM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_EM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_EM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_EM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_EM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_EM] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_EM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_EM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_EM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_EM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_EM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_EM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_EM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_EM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_EM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_EM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_EM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_EM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_EM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_EM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_EM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_EM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_EM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_EM] SET RECOVERY FULL 
GO
ALTER DATABASE [Project_EM] SET  MULTI_USER 
GO
ALTER DATABASE [Project_EM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_EM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_EM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_EM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_EM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_EM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project_EM', N'ON'
GO
ALTER DATABASE [Project_EM] SET QUERY_STORE = OFF
GO
USE [Project_EM]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Numero_Dni] [varchar](20) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Comprobante] [varchar](20) NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Compra](
	[Id_Detalle_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[Id_Compra] [int] NULL,
	[Cantidad] [int] NULL,
	[Marca] [varchar](25) NULL,
	[Talla] [varchar](20) NULL,
	[Fecha] [date] NULL,
	[Total] [decimal](18, 2) NULL,
	[Id_Proveedor] [int] NULL,
 CONSTRAINT [PK__Detalle___42234240E818100E] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[Id_Detalle_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Fecha] [date] NULL,
	[Id_Venta] [int] NULL,
 CONSTRAINT [PK__Detalle___B8F57402BA2EE993] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Stock_Inicial] [int] NULL,
	[Stock_Actual] [int] NULL,
	[Categoria] [varchar](50) NULL,
	[Codigo] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [varchar](20) NULL,
	[Distrito] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Number] [varchar](6) NULL,
	[Nombre] [varchar](20) NULL,
	[Clave] [varchar](15) NULL,
 CONSTRAINT [PK__Usuario__63C76BE29660EB37] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Tipo_Comprobante] [varchar](20) NULL,
	[Zona] [varchar](25) NULL,
 CONSTRAINT [PK__Comproba__B3C9EABDEE958A00] PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compra_Compra] FOREIGN KEY([Id_Compra])
REFERENCES [dbo].[Compra] ([Id_Compra])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_Detalle_Compra_Compra]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compra_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_Detalle_Compra_Producto]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compra_Proveedor] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[Proveedor] ([Id_Proveedor])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_Detalle_Compra_Proveedor]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Producto]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Venta] FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[Venta] ([Id_Venta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_v_cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_v_cliente]
GO
/****** Object:  StoredProcedure [dbo].[SP_Cant_Ventas_Zona]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Cant_Ventas_Zona]
	@Search varchar(25)
as
	select Venta.Id_Venta as 'Ventas', Producto.Nombre as 'Producto', Venta.Zona as 'Zona',Producto.Categoria, Producto.Codigo, Producto.Stock_Actual as 'Stock',
		Venta.Id_Cliente as 'ID Cliente', Venta.Tipo_Comprobante as 'Comprobante', Detalle_Venta.Fecha,  Detalle_Venta.Precio, Detalle_Venta.Total
from Detalle_Venta
INNER JOIN Venta ON Detalle_Venta.Id_Venta=Venta.Id_Venta
INNER JOIN Producto ON Detalle_Venta.Id_Producto=Producto.Id_Producto
	where Zona like @Search + '%' order by Venta.Id_Venta desc
GO
/****** Object:  StoredProcedure [dbo].[SP_Cliente_Verificar_Uso]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Cliente_Verificar_Uso]
@Id_Cliente INT
AS
SELECT TOP 1 Id_Cliente
FROM Venta
WHERE Id_Cliente=@Id_Cliente
GO
/****** Object:  StoredProcedure [dbo].[SP_Create_Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Create_Compra]
	@Tipo_Comprobante varchar(20)
as
begin
	insert into Compra(Tipo_Comprobante) values (@Tipo_Comprobante)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Create_Compra_DT]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_Create_Compra_DT]
@Tipo_Comprobante varchar(20)
as
insert into Compra (Tipo_Comprobante) values (@Tipo_Comprobante)
select MAX(Id_Compra) AS Id_Compra from Compra
GO
/****** Object:  StoredProcedure [dbo].[SP_Create_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Create_Venta]
	@Id_Cliente int,
	@Tipo_Comprobante varchar(20),
	@Zona varchar(25)
as
begin
	insert into Venta (Id_Cliente,Tipo_Comprobante,Zona) values (@Id_Cliente,@Tipo_Comprobante,@Zona)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Create_Venta_DT]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_Create_Venta_DT]
@Id_Cliente int,
@Tipo_Comprobante varchar(20),
@Zona varchar(25)
as
insert into Venta (Id_Cliente,Tipo_Comprobante,Zona) values (@Id_Cliente,@Tipo_Comprobante,@Zona)
select MAX(Id_Venta) AS Id_Venta from Venta
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Compra_DT]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_Delete_Compra_DT]
@Id_Compra int
as
delete from Detalle_Compra where Id_Compra=@Id_Compra
delete from Compra where Id_Compra=@Id_Compra
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Venta_DT]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Delete_Venta_DT]
@Id_Venta int
as
delete from Detalle_Venta where Id_Venta=@Id_Venta
delete from Venta where Id_Venta=@Id_Venta
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarProdMasVendidosConCategoria3]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ListarProdMasVendidosConCategoria3]
as
select
MONTH(getdate()) as Mes,
pro.Nombre, pro.Categoria,
Detalle_Venta.Id_Producto as 'ID Producto', SUM(Case when Month(Fecha)=MONTH(getdate()) then Cantidad end) as 'Venta Total'
from Detalle_Venta
left join Producto as pro
on Detalle_Venta.Id_Producto=pro.Id_Producto
group by Detalle_Venta.Id_Producto, pro.Nombre,pro.Categoria
order by MONTH(getdate()) asc,[Venta Total] desc


GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Clients]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Clients]
	@Id_Cliente int,
	@Nombre varchar(50),
	@Numero_Dni varchar(20),
	@Direccion varchar(50),
	@Telefono varchar(20),
	@accion varchar(1)
as
	 if(@accion = '1')
begin
	 insert into Cliente (Nombre,Numero_Dni,Direccion,Telefono)
	 values (@Nombre,@Numero_Dni,@Direccion,@Telefono);
end
else if(@accion = '2')
begin
	 update Cliente set
	 Nombre = @Nombre,
	 Numero_Dni = @Numero_Dni,
	 Direccion = @Direccion,
	 Telefono = @Telefono
	 where Id_Cliente = @Id_Cliente;
end
else if(@accion = '3')
begin
	 delete from Cliente where Id_Cliente = @Id_Cliente;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Compra]
	@Id_Producto int,
	@Id_Proveedor int,
	@Id_Compra int,
	@Cantidad int,
	@Marca varchar(25),
	@Talla varchar(20),
	@Total decimal(18,2),
	@Fecha date,
	@accion varchar(1)
as
	if(@accion = '1')
begin
	insert into Detalle_Compra (Id_Producto,Id_Proveedor,Id_Compra,Cantidad,Marca,Talla,Total,Fecha)
	values (@Id_Producto,@Id_Proveedor,@Id_Compra,@Cantidad,@Marca,@Talla,@Total,@Fecha)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Detalle_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Detalle_Venta]
	@Id_Producto int,
	@Cantidad int,
	@Precio decimal(18,2),
	@Total decimal(18,2),
	@Fecha date,
	@Id_Venta int,
	@accion varchar(1)
as
	if(@accion = '1')
begin
	insert into Detalle_Venta (Id_Producto,Cantidad,Precio,Total,Fecha,Id_Venta) 
	values (@Id_Producto,@Cantidad,@Precio,@Total,@Fecha,@Id_Venta)
	
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Products]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Products]
	@Id_Producto int,
	@Nombre varchar(50),
	@Stock_Inicial int,
	@Stock_Actual int,
	@Categoria varchar(50),
	@Codigo int,
	@accion varchar(1)
as
	 if(@accion = '1')
begin
	 insert into Producto (Nombre,Stock_Inicial,Stock_Actual,Categoria,Codigo)
	 values (@Nombre,@Stock_Inicial,@Stock_Actual,@Categoria,@Codigo)
end
else if(@accion = '2')
begin
	 update Producto set
	 Nombre = @Nombre,
	 Stock_Inicial = @Stock_Inicial,
	 Stock_Actual = @Stock_Actual,
	 Categoria = @Categoria,
	 Codigo = @Codigo
	 where Id_Producto = @Id_Producto
end
else if(@accion = '3')
begin
	 delete from Producto where Id_Producto = @Id_Producto
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Proveedor]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Proveedor]
	@Id_Proveedor int,
	@Nombre varchar(50),
	@Telefono varchar(20),
	@Distrito varchar(20),
	@accion varchar(1)
as
	 if(@accion = '1')
begin
	 insert into Proveedor (Nombre,Telefono,Distrito)
	 values (@Nombre,@Telefono,@Distrito);
end
else if(@accion = '2')
begin
	 update Proveedor set
	 Nombre = @Nombre,
	 Telefono = @Telefono,
	 Distrito = @Distrito
	 where Id_Proveedor = @Id_Proveedor;
end
else if(@accion = '3')
begin
	 delete from Proveedor where Id_Proveedor = @Id_Proveedor;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Search_Clients]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Mantenimiento_Search_Clients]
@buscar varchar(50)
as
begin
	select Id_Cliente as 'ID', Nombre, Numero_Dni, Direccion, Telefono 
	from Cliente where Nombre like @buscar + '%';
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Search_Products]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[SP_Mantenimiento_Search_Products]
@buscar varchar(50)
as
begin
	select Id_Producto as 'ID',Nombre,Stock_Actual as 'Stock', Categoria,Codigo
	from Producto where Nombre like @buscar + '%';
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Mantenimiento_Search_Proveedor]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Mantenimiento_Search_Proveedor]
	@buscar varchar(50)
as
begin
	select * from Proveedor where Nombre like @buscar + '%';
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Producto_Busqueda_Categoria]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Producto_Busqueda_Categoria]
@Categoria varchar(50)
as
select 
p.Id_Producto,
p.Nombre,
p.Stock_Actual
from Producto p
--where Categoria=@Categoria
--where Categoria like @Categoria + '%'
where Categoria like '%' + @Categoria + '%' --esto sirve para hacer una busqueda
order by Stock_Actual desc
GO
/****** Object:  StoredProcedure [dbo].[SP_Producto_Verificar_Uso]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Producto_Verificar_Uso]
@Id_Producto INT
AS
SELECT TOP 1 Id_Producto
FROM Detalle_Compra
WHERE Id_Producto=@Id_Producto

UNION 

SELECT TOP 1 Id_Producto
FROM Detalle_Venta
WHERE Id_Producto=@Id_Producto
GO
/****** Object:  StoredProcedure [dbo].[SP_Proveedor_Verificar_Uso]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Proveedor_Verificar_Uso]
@Id_Proveedor INT
AS
SELECT TOP 1 Id_Proveedor
FROM Detalle_Compra
WHERE Id_Proveedor=@Id_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[SP_Psw_Uid]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Psw_Uid]
	@Number varchar(6),
	@Nombre varchar(20),
	@Clave varchar(15)
as
	select * from Usuario where Number=@Number and Nombre=@Nombre or Clave=@Clave
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Clients]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Clients]
as
select Id_Cliente as 'ID', Nombre, Numero_Dni, Direccion, Telefono from Cliente order by Id_Cliente desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_Buy]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_Buy]
as
select * from Compra order by Id_Compra desc 
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_Client]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_Client]
as
select Id_Cliente,Nombre from Cliente order by Nombre asc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_ID_Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_ID_Compra]
as
select Id_Compra,Tipo_Comprobante from Compra order by Id_Compra desc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_ID_Product]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_ID_Product]
as
select Id_Producto,Nombre from Producto order by Id_Producto desc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_ID_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_ID_Venta]
as
select Id_Venta,Tipo_Comprobante from Venta order by Id_Venta desc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Column_Proveedor]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Column_Proveedor]
as
select Id_Proveedor,Nombre from Proveedor order by Nombre asc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Compra]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Compra]
as
select Compra.Id_Compra as 'ID', Producto.Codigo,Producto.Nombre as 'Producto',Detalle_Compra.Cantidad,Proveedor.Nombre as 'Proveedor',
		Detalle_Compra.Marca,Detalle_Compra.Talla,Detalle_Compra.Total,Detalle_Compra.Fecha
from Detalle_Compra
INNER JOIN Compra ON Detalle_Compra.Id_Compra=Compra.Id_Compra
INNER JOIN Producto ON Detalle_Compra.Id_Producto=Producto.Id_Producto
INNER JOIN Proveedor ON Detalle_Compra.Id_Proveedor=Proveedor.Id_Proveedor
order by Compra.Id_Compra desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Compra_N]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_ToList_Compra_N]
AS
SELECT
Id_Compra as ID,
Tipo_Comprobante AS 'Tipo Comprobante'
FROM Compra 
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Detalle_Compra_ID]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[SP_ToList_Detalle_Compra_ID]
@Id_Compra int
as
select 
DC.Id_Compra AS ID,
P.Nombre AS Producto,
PR.Nombre as Proveedor,
DC.Cantidad,
DC.Marca,
DC.Talla,
DC.Fecha,
DC.Total
from Detalle_Compra DC
INNER JOIN PRODUCTO P
ON DC.Id_Producto=P.Id_Producto 
INNER JOIN Proveedor PR
ON DC.Id_Proveedor=PR.Id_Proveedor
where Id_Compra=@Id_Compra
order by Id_Compra desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Detalle_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Detalle_Venta]
as
select Id_Venta as 'ID',Id_Producto as 'Producto',Cantidad,Precio,Total,Fecha from Detalle_Venta order by Id_Venta desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Detalle_Venta_ID]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[SP_ToList_Detalle_Venta_ID]
@Id_Venta int
as
select DV.Id_Venta as 'ID',P.Nombre as 'Producto',DV.Cantidad,DV.Precio,DV.Total,DV.Fecha 
from Detalle_Venta DV
INNER JOIN PRODUCTO P
ON DV.Id_Producto=P.Id_Producto 
where Id_Venta=@Id_Venta
order by Id_Venta desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_ID_Product]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_ID_Product]
as
select Id_Producto from Producto order by Id_Producto desc;
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Products]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Products]
as
select Id_Producto as 'ID',Nombre,Stock_Actual as 'Stock', Categoria,Codigo from Producto order by Id_Producto desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Proveedor]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Proveedor]
as
select Id_Proveedor as 'ID Proveedor', Nombre, Telefono, Distrito from Proveedor order by Id_Proveedor desc
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Venta]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[SP_ToList_Venta]
AS
SELECT
V.Id_Venta AS ID,
C.Numero_Dni AS DNI,
C.Nombre,
V.Tipo_Comprobante AS 'Tipo Comprobante',
V.Zona
FROM Venta V
INNER JOIN Cliente C
ON V.Id_Cliente=C.Id_Cliente
GO
/****** Object:  StoredProcedure [dbo].[SP_ToList_Venta_D]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ToList_Venta_D]
as
select Venta.Id_Venta as 'Ventas', Producto.Nombre as 'Producto', Venta.Zona as 'Zona',Producto.Categoria, Producto.Codigo, Producto.Stock_Actual as 'Stock',
		Venta.Id_Cliente as 'ID Cliente', Venta.Tipo_Comprobante as 'Comprobante', Detalle_Venta.Fecha,  Detalle_Venta.Precio, Detalle_Venta.Total
from Detalle_Venta
INNER JOIN Venta ON Detalle_Venta.Id_Venta=Venta.Id_Venta
INNER JOIN Producto ON Detalle_Venta.Id_Producto=Producto.Id_Producto
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Stock]    Script Date: 28/06/2022 23:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Update_Stock]
	@Nombre varchar(50),
	@Stock int
as
begin
	update Producto set
	Stock_Actual = Stock_Inicial - @Stock
	where Nombre= @Nombre
end
GO
USE [master]
GO
ALTER DATABASE [Project_EM] SET  READ_WRITE 
GO
