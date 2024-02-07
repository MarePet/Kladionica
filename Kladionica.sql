USE [master]
GO
/****** Object:  Database [Kladionica]    Script Date: 07.02.2024. 15:04:30 ******/
CREATE DATABASE [Kladionica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kladionica', FILENAME = N'C:\Users\Marko\Kladionica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kladionica_log', FILENAME = N'C:\Users\Marko\Kladionica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kladionica] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kladionica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kladionica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kladionica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kladionica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kladionica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kladionica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kladionica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kladionica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kladionica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kladionica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kladionica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kladionica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kladionica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kladionica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kladionica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kladionica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kladionica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kladionica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kladionica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kladionica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kladionica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kladionica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kladionica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kladionica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kladionica] SET  MULTI_USER 
GO
ALTER DATABASE [Kladionica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kladionica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kladionica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kladionica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kladionica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kladionica] SET QUERY_STORE = OFF
GO
USE [Kladionica]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Kladionica]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[Id] [int] NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grad]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grad](
	[GradID] [int] NOT NULL,
	[NazivGrada] [varchar](50) NOT NULL,
	[Ptt] [int] NOT NULL,
 CONSTRAINT [PK_Grad] PRIMARY KEY CLUSTERED 
(
	[GradID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klub]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klub](
	[KlubID] [int] NOT NULL,
	[NazivKluba] [varchar](50) NOT NULL,
	[GodinaOsnivanja] [int] NOT NULL,
	[Grad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Klub] PRIMARY KEY CLUSTERED 
(
	[KlubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Godine] [int] NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaTiketa]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaTiketa](
	[StavkaID] [int] NOT NULL,
	[Rezultat] [varchar](50) NOT NULL,
	[IzabranaKvota] [float] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[TiketID] [int] NOT NULL,
	[UtakmicaID] [int] NOT NULL,
 CONSTRAINT [PK_StavkaTiketa] PRIMARY KEY CLUSTERED 
(
	[StavkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tiket]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiket](
	[TiketID] [int] IDENTITY(1,1) NOT NULL,
	[Uplata] [float] NOT NULL,
	[PotencijalnaIsplata] [float] NOT NULL,
	[DatumUplate] [date] NOT NULL,
	[StatusTiketa] [varchar](50) NOT NULL,
	[KorisnikID] [int] NOT NULL,
 CONSTRAINT [PK_Tiket] PRIMARY KEY CLUSTERED 
(
	[TiketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utakmica]    Script Date: 07.02.2024. 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utakmica](
	[UtakmicaID] [int] IDENTITY(1,1) NOT NULL,
	[NazivDrzave] [varchar](50) NOT NULL,
	[VremePocetka] [datetime] NOT NULL,
	[VrstaUtakmice] [varchar](50) NOT NULL,
	[RezultatUtakmice] [varchar](50) NOT NULL,
	[Kvota1] [float] NOT NULL,
	[KvotaX] [float] NOT NULL,
	[Kvota2] [float] NOT NULL,
	[DomacinID] [int] NOT NULL,
	[GostID] [int] NOT NULL,
	[GradID] [int] NOT NULL,
 CONSTRAINT [PK_Utakmica] PRIMARY KEY CLUSTERED 
(
	[UtakmicaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrator] ([Id], [KorisnickoIme], [Lozinka]) VALUES (1, N'marko', N'marko1')
GO
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (1, N'Beograd', 11000)
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (2, N'London', 7)
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (3, N'Lester', 9)
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (4, N'Njukasl', 11)
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (5, N'Mancester', 13)
INSERT [dbo].[Grad] ([GradID], [NazivGrada], [Ptt]) VALUES (6, N'Liverpool', 15)
GO
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (1, N'Partizan', 1945, N'Beograd')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (2, N'Crvena zvezda', 1945, N'Beograd')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (3, N'Arsenal', 1931, N'London')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (4, N'Chelsea', 1930, N'London')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (5, N'Everton', 1920, N'Liverpool')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (6, N'Leicester City', 1920, N'Lester')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (7, N'Manchester City', 1920, N'Mancester')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (8, N'Manchester United', 1920, N'Mancester')
INSERT [dbo].[Klub] ([KlubID], [NazivKluba], [GodinaOsnivanja], [Grad]) VALUES (9, N'Liverpool', 1920, N'Liverpool')
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([KorisnikID], [Ime], [Prezime], [Godine], [KorisnickoIme], [Lozinka]) VALUES (1, N'Pera', N'Peric', 21, N'pera', N'pera')
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
INSERT [dbo].[StavkaTiketa] ([StavkaID], [Rezultat], [IzabranaKvota], [Status], [TiketID], [UtakmicaID]) VALUES (1, N'Tim 1 pobedjuje', 1.85, N'Gubitan', 7, 7)
GO
SET IDENTITY_INSERT [dbo].[Tiket] ON 

INSERT [dbo].[Tiket] ([TiketID], [Uplata], [PotencijalnaIsplata], [DatumUplate], [StatusTiketa], [KorisnikID]) VALUES (7, 1256, 2323.6, CAST(N'2024-02-07' AS Date), N'Gubitan', 1)
SET IDENTITY_INSERT [dbo].[Tiket] OFF
GO
SET IDENTITY_INSERT [dbo].[Utakmica] ON 

INSERT [dbo].[Utakmica] ([UtakmicaID], [NazivDrzave], [VremePocetka], [VrstaUtakmice], [RezultatUtakmice], [Kvota1], [KvotaX], [Kvota2], [DomacinID], [GostID], [GradID]) VALUES (7, N'Srbija', CAST(N'2024-02-07T21:00:00.000' AS DateTime), N'Takmicarska', N'Nerešeno', 1.85, 2, 2.25, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Utakmica] OFF
GO
USE [master]
GO
ALTER DATABASE [Kladionica] SET  READ_WRITE 
GO
