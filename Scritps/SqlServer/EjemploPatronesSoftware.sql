USE [master]
GO
/****** Object:  Database [EjemploPatronesSoftware]    Script Date: 07/04/2017 11:21:58 ******/
CREATE DATABASE [EjemploPatronesSoftware] ON  PRIMARY 
( NAME = N'EjemploPatronesSoftware', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EjemploPatronesSoftware.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EjemploPatronesSoftware_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EjemploPatronesSoftware_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EjemploPatronesSoftware].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ANSI_NULLS OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ANSI_PADDING OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ARITHABORT OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [EjemploPatronesSoftware] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [EjemploPatronesSoftware] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [EjemploPatronesSoftware] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET  DISABLE_BROKER
GO
ALTER DATABASE [EjemploPatronesSoftware] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [EjemploPatronesSoftware] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [EjemploPatronesSoftware] SET  READ_WRITE
GO
ALTER DATABASE [EjemploPatronesSoftware] SET RECOVERY SIMPLE
GO
ALTER DATABASE [EjemploPatronesSoftware] SET  MULTI_USER
GO
ALTER DATABASE [EjemploPatronesSoftware] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [EjemploPatronesSoftware] SET DB_CHAINING OFF
GO
USE [EjemploPatronesSoftware]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 07/04/2017 11:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[empleado] ON
INSERT [dbo].[empleado] ([id], [nombre]) VALUES (1, N'Empleado UNO desde SQLServer')
INSERT [dbo].[empleado] ([id], [nombre]) VALUES (2, N'Empleado DOS desde SQLServer')
INSERT [dbo].[empleado] ([id], [nombre]) VALUES (3, N'Empleado TRES desde SQLServer')
SET IDENTITY_INSERT [dbo].[empleado] OFF
