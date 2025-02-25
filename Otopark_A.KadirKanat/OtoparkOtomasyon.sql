USE [master]
GO
/****** Object:  Database [OtoparkOtomasyon]    Script Date: 22.12.2019 20:13:34 ******/
CREATE DATABASE [OtoparkOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtoparkOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OtoparkOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtoparkOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OtoparkOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OtoparkOtomasyon] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtoparkOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtoparkOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtoparkOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtoparkOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtoparkOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtoparkOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET RECOVERY FULL 
GO
ALTER DATABASE [OtoparkOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [OtoparkOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtoparkOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtoparkOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtoparkOtomasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtoparkOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OtoparkOtomasyon] SET QUERY_STORE = OFF
GO
USE [OtoparkOtomasyon]
GO
/****** Object:  Table [dbo].[Aboneler]    Script Date: 22.12.2019 20:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aboneler](
	[AboneID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [nvarchar](50) NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PlakaNo] [nvarchar](50) NULL,
	[AracTipiID] [int] NULL,
	[AbonelikDurumu] [bit] NULL,
 CONSTRAINT [PK_Aboneler] PRIMARY KEY CLUSTERED 
(
	[AboneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AracTipleri]    Script Date: 22.12.2019 20:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracTipleri](
	[AracTipiID] [int] IDENTITY(1,1) NOT NULL,
	[AracTipi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AracTipleri] PRIMARY KEY CLUSTERED 
(
	[AracTipiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanıcı]    Script Date: 22.12.2019 20:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcı](
	[KullanıcıID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıAdı] [nvarchar](50) NOT NULL,
	[KullanıcıSİfre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kullanıcı] PRIMARY KEY CLUSTERED 
(
	[KullanıcıID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParkYeri]    Script Date: 22.12.2019 20:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParkYeri](
	[ParkYeriID] [int] IDENTITY(1,1) NOT NULL,
	[ParkDurumu] [bit] NOT NULL,
	[AboneID] [int] NOT NULL,
	[TarihGiriş] [datetime] NULL,
	[TarihÇıkış] [datetime] NULL,
 CONSTRAINT [PK_ParkYeri] PRIMARY KEY CLUSTERED 
(
	[ParkYeriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aboneler] ON 

INSERT [dbo].[Aboneler] ([AboneID], [TC], [Ad], [Soyad], [Telefon], [Email], [PlakaNo], [AracTipiID], [AbonelikDurumu]) VALUES (1, N'BOŞ', N'BOŞ', N'BOŞ', N'BOŞ', N'BOŞ', N'BOŞ', 1, 0)
SET IDENTITY_INSERT [dbo].[Aboneler] OFF
SET IDENTITY_INSERT [dbo].[AracTipleri] ON 

INSERT [dbo].[AracTipleri] ([AracTipiID], [AracTipi]) VALUES (1, N'Kamyon')
INSERT [dbo].[AracTipleri] ([AracTipiID], [AracTipi]) VALUES (2, N'Otomobil')
INSERT [dbo].[AracTipleri] ([AracTipiID], [AracTipi]) VALUES (3, N'Motorsiklet')
SET IDENTITY_INSERT [dbo].[AracTipleri] OFF
SET IDENTITY_INSERT [dbo].[Kullanıcı] ON 

INSERT [dbo].[Kullanıcı] ([KullanıcıID], [KullanıcıAdı], [KullanıcıSİfre]) VALUES (1, N'Admin', N'4444')
SET IDENTITY_INSERT [dbo].[Kullanıcı] OFF
SET IDENTITY_INSERT [dbo].[ParkYeri] ON 

INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (1, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (2, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (3, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (4, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (5, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (6, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (7, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (8, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (9, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (10, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (11, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (12, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (13, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (14, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (15, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (16, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (17, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (18, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (19, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (20, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (21, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (22, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (23, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (24, 0, 1, NULL, NULL)
INSERT [dbo].[ParkYeri] ([ParkYeriID], [ParkDurumu], [AboneID], [TarihGiriş], [TarihÇıkış]) VALUES (25, 0, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ParkYeri] OFF
ALTER TABLE [dbo].[Aboneler]  WITH CHECK ADD  CONSTRAINT [FK_Aboneler_AracTipleri] FOREIGN KEY([AracTipiID])
REFERENCES [dbo].[AracTipleri] ([AracTipiID])
GO
ALTER TABLE [dbo].[Aboneler] CHECK CONSTRAINT [FK_Aboneler_AracTipleri]
GO
ALTER TABLE [dbo].[ParkYeri]  WITH CHECK ADD  CONSTRAINT [FK_ParkYeri_Aboneler] FOREIGN KEY([AboneID])
REFERENCES [dbo].[Aboneler] ([AboneID])
GO
ALTER TABLE [dbo].[ParkYeri] CHECK CONSTRAINT [FK_ParkYeri_Aboneler]
GO
USE [master]
GO
ALTER DATABASE [OtoparkOtomasyon] SET  READ_WRITE 
GO
