USE [master]
GO
/****** Object:  Database [ajandaDB]    Script Date: 29.04.2023 20:14:12 ******/
CREATE DATABASE [ajandaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ajandaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ajandaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ajandaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ajandaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ajandaDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ajandaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ajandaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ajandaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ajandaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ajandaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ajandaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ajandaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ajandaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ajandaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ajandaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ajandaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ajandaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ajandaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ajandaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ajandaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ajandaDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ajandaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ajandaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ajandaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ajandaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ajandaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ajandaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ajandaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ajandaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ajandaDB] SET  MULTI_USER 
GO
ALTER DATABASE [ajandaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ajandaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ajandaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ajandaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ajandaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ajandaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ajandaDB', N'ON'
GO
ALTER DATABASE [ajandaDB] SET QUERY_STORE = OFF
GO
USE [ajandaDB]
GO
/****** Object:  Table [dbo].[Aktivite]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktivite](
	[aktiviteID] [int] IDENTITY(1,1) NOT NULL,
	[aktiviteAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Aktivite] PRIMARY KEY CLUSTERED 
(
	[aktiviteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aktiviteler]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktiviteler](
	[aktivitelerID] [int] IDENTITY(1,1) NOT NULL,
	[aktiviteID] [int] NULL,
	[aktivitelerAdi] [nvarchar](50) NULL,
	[aktivitelerTarih] [datetime] NULL,
	[ogrenciID] [int] NULL,
	[personelID] [int] NULL,
	[arastirmaciID] [int] NULL,
 CONSTRAINT [PK_Aktiviteler] PRIMARY KEY CLUSTERED 
(
	[aktivitelerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arastirmaci]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arastirmaci](
	[arastirmaciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[telefon] [nvarchar](15) NULL,
	[meslek] [nvarchar](50) NULL,
 CONSTRAINT [PK_Arastirmaci] PRIMARY KEY CLUSTERED 
(
	[arastirmaciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[ogrenciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[telefon] [nvarchar](15) NULL,
	[meslek] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[ogrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[personelID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[telefon] [nvarchar](15) NULL,
	[meslek] [nvarchar](50) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[personelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 29.04.2023 20:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[yoneticiID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Yonetici] PRIMARY KEY CLUSTERED 
(
	[yoneticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aktivite] ON 

INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (1, N'Kitap Okuma')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (2, N'Yürüyüş')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (3, N'Diksiyon')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (4, N'Yüzme')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (5, N'Ders Çalışma')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (6, N'Araştırma')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (7, N'Toplantı')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (8, N'Yemek Yeme')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (9, N'Dinlenme')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (10, N'Yazı Yazma')
INSERT [dbo].[Aktivite] ([aktiviteID], [aktiviteAdi]) VALUES (11, N'Sosyal Medya')
SET IDENTITY_INSERT [dbo].[Aktivite] OFF
GO
SET IDENTITY_INSERT [dbo].[Aktiviteler] ON 

INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (1, NULL, N'Ders Çalışma', CAST(N'2023-04-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (2, NULL, N'Ders Çalışma', CAST(N'2023-04-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (3, NULL, N'Araştırma', CAST(N'2023-04-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (4, NULL, N'Yüzme', CAST(N'2023-04-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (5, NULL, N'', CAST(N'2023-04-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (10, NULL, N'Araştırma', CAST(N'2023-04-29T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (11, NULL, N'Araştırma', CAST(N'2023-04-29T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (12, NULL, N'Yüzme', CAST(N'2023-04-29T10:52:42.897' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (13, NULL, N'Toplantı', CAST(N'2023-04-29T10:53:05.730' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (14, NULL, N'Ders Çalışma', CAST(N'2023-04-29T10:54:06.307' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (15, NULL, N'Diksiyon', CAST(N'2023-04-29T10:55:21.403' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (16, NULL, N'Yemek Yeme', CAST(N'2023-04-29T10:55:37.500' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (17, NULL, N'Yüzme', CAST(N'2023-04-29T10:55:46.657' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (18, NULL, N'Araştırma', CAST(N'2023-04-29T10:56:41.187' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (19, NULL, N'Yemek Yeme', CAST(N'2023-04-29T10:57:11.047' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (20, NULL, N'Ders Çalışma', CAST(N'2023-04-29T10:58:18.893' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (21, NULL, N'Ders Çalışma', CAST(N'2023-04-29T10:58:24.400' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (22, NULL, N'Ders Çalışma', CAST(N'2023-04-29T10:58:44.133' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (23, NULL, N'Ders Çalışma', CAST(N'2023-04-29T10:58:54.870' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (24, NULL, N'Toplantı', CAST(N'2023-04-29T11:22:51.800' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (25, NULL, N'Toplantı', CAST(N'2023-04-29T11:23:00.923' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (26, NULL, N'Diksiyon', CAST(N'2023-04-29T11:23:07.570' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (27, NULL, N'Yüzme', CAST(N'2023-04-29T11:23:17.867' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (28, NULL, N'Yüzme', CAST(N'2023-04-29T11:23:33.190' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (29, NULL, N'Yüzme', CAST(N'2023-04-29T12:07:15.103' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (30, NULL, N'Ders Çalışma', CAST(N'2023-04-29T12:07:58.467' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (31, NULL, N'Yüzme', CAST(N'2023-04-29T12:08:28.340' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (32, NULL, N'Ders Çalışma', CAST(N'2023-04-29T14:26:00.543' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Aktiviteler] ([aktivitelerID], [aktiviteID], [aktivitelerAdi], [aktivitelerTarih], [ogrenciID], [personelID], [arastirmaciID]) VALUES (33, NULL, N'Araştırma', CAST(N'2023-04-29T15:13:58.633' AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Aktiviteler] OFF
GO
SET IDENTITY_INSERT [dbo].[Arastirmaci] ON 

INSERT [dbo].[Arastirmaci] ([arastirmaciID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (1, N'Recep Can', N'Hastürk', N'rcan@gmail.com', N'654321', N'(553) 656-3478', N'araştırmacı')
INSERT [dbo].[Arastirmaci] ([arastirmaciID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (2, N'Ufuk Yasin', N'Başar', N'uyasin@gmail.com', N'987123', N'(553) 656-4419', N'Araştırmacı')
SET IDENTITY_INSERT [dbo].[Arastirmaci] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([ogrenciID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (1, N'Muhammet Ali', N'Karakaya', N'mali@gmail.com', N'123456', N'(553) 656-1924', N'öğrenci')
INSERT [dbo].[Ogrenci] ([ogrenciID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (2, N'Eray', N'Çelik', N'eray@gmail.com', N'654789', N'(556) 626-0619', N'Öğrenci')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([personelID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (1, N'Berat ', N'Özşahin', N'berat@gmail.com', N'987456', N'(553) 656-4161', N'personel')
INSERT [dbo].[Personel] ([personelID], [ad], [soyad], [kullaniciAdi], [sifre], [telefon], [meslek]) VALUES (2, N'Yakup', N'Özdemircan', N'yakup@gmail.com', N'987326', N'(554) 420-1906', N'Personel')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Yonetici] ON 

INSERT [dbo].[Yonetici] ([yoneticiID], [ad], [soyad], [kullaniciAdi], [sifre]) VALUES (1, N'Ömer Faruk', N'Çetinkaya', N'omerf@gmail.com', N'032165')
SET IDENTITY_INSERT [dbo].[Yonetici] OFF
GO
ALTER TABLE [dbo].[Aktiviteler]  WITH CHECK ADD  CONSTRAINT [FK_Aktiviteler_Aktivite] FOREIGN KEY([aktiviteID])
REFERENCES [dbo].[Aktivite] ([aktiviteID])
GO
ALTER TABLE [dbo].[Aktiviteler] CHECK CONSTRAINT [FK_Aktiviteler_Aktivite]
GO
ALTER TABLE [dbo].[Aktiviteler]  WITH CHECK ADD  CONSTRAINT [FK_Aktiviteler_Arastirmaci] FOREIGN KEY([arastirmaciID])
REFERENCES [dbo].[Arastirmaci] ([arastirmaciID])
GO
ALTER TABLE [dbo].[Aktiviteler] CHECK CONSTRAINT [FK_Aktiviteler_Arastirmaci]
GO
ALTER TABLE [dbo].[Aktiviteler]  WITH CHECK ADD  CONSTRAINT [FK_Aktiviteler_Ogrenci] FOREIGN KEY([ogrenciID])
REFERENCES [dbo].[Ogrenci] ([ogrenciID])
GO
ALTER TABLE [dbo].[Aktiviteler] CHECK CONSTRAINT [FK_Aktiviteler_Ogrenci]
GO
ALTER TABLE [dbo].[Aktiviteler]  WITH CHECK ADD  CONSTRAINT [FK_Aktiviteler_Personel] FOREIGN KEY([personelID])
REFERENCES [dbo].[Personel] ([personelID])
GO
ALTER TABLE [dbo].[Aktiviteler] CHECK CONSTRAINT [FK_Aktiviteler_Personel]
GO
USE [master]
GO
ALTER DATABASE [ajandaDB] SET  READ_WRITE 
GO
