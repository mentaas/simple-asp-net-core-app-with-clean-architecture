USE [master]
GO
/****** Object:  Database [aspnet-AbcTestApp]    Script Date: 12/31/2020 8:13:41 AM ******/
CREATE DATABASE [aspnet-AbcTestApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aspnet-AbcTestApp', FILENAME = N'C:\Users\m_shy\aspnet-AbcTestApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aspnet-AbcTestApp_log', FILENAME = N'C:\Users\m_shy\aspnet-AbcTestApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [aspnet-AbcTestApp] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aspnet-AbcTestApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET  MULTI_USER 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aspnet-AbcTestApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [aspnet-AbcTestApp] SET QUERY_STORE = OFF
GO
USE [aspnet-AbcTestApp]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [aspnet-AbcTestApp]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[UpdatedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[DeletedOn] [datetime2](7) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedBy] [nvarchar](150) NULL,
	[DeletedOn] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](150) NULL,
	[UpdatedOn] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 12/31/2020 8:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[CityId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedBy] [nvarchar](150) NULL,
	[DeletedOn] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](150) NULL,
	[UpdatedOn] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230031117_Initial', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230124907_SeedUser', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230125253_SeedRoleUser', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201231013905_AddCityAndLocationTable', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201231014730_SeedCityTable', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201231044528_addedLongitudeAndLatitudeToLocation', N'5.0.1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2301D884-221A-4E7D-B509-0113DCC043E1', N'Administrator', N'ADMINISTRATOR', N'ebb699f0-abe9-43ec-a761-73b719229e88')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7D9B7113-A8F8-4035-99A7-A20DD400F6A3', N'Moderator', N'MODERATOR', N'fea053e9-66fa-4593-9e16-38eac52f0a5d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6B6867B8-3173-4AA8-A4F0-07D2DD931825', N'2301D884-221A-4E7D-B509-0113DCC043E1')
INSERT [dbo].[AspNetUsers] ([Id], [Name], [LastName], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsDeleted], [DeletedBy], [DeletedOn], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6B6867B8-3173-4AA8-A4F0-07D2DD931825', N'Master', N'Admin', NULL, CAST(N'2020-12-31T05:45:27.5426703' AS DateTime2), NULL, NULL, 0, NULL, NULL, N'masteradmin', N'MASTERADMIN', N'Admin@Admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAEK+rUp2RawB2uaI6ZWjkONW5tDKO1yxx+qrqeCKp5A7lrmrxGXx5JCTVnG2itUG5GQ==', N'00000000-0000-0000-0000-000000000000', N'1a6cd3e5-0e4e-467d-a13d-71bd106f5929', N'XXXXXXXXXXXXX', 1, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [LastName], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsDeleted], [DeletedBy], [DeletedOn], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a732dab6-7f97-4039-b36a-8e1697f05cf5', N'Mentor', N'Shyti', NULL, CAST(N'2020-12-30T20:32:44.4545821' AS DateTime2), NULL, NULL, 0, NULL, NULL, N'mentor.shyti@gmail.com', N'MENTOR.SHYTI@GMAIL.COM', N'mentor.shyti@gmail.com', N'MENTOR.SHYTI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECrPyVykcTi8XXTpSZvf5G5YYWZG6/T6iCvK0//bawr/7/B3IAYDpZ8QajkJwCO9gQ==', N'XX6UKUEQP6CX2SOWNFG5T7IY2XRUEILL', N'f67a5b71-91cc-420b-b958-b0b17ff4c795', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (1, N'Berlin', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (2, N'Amsterdam', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (3, N'Ljubljana', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (4, N'Belgrade', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (5, N'Zagreb', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (6, N'Sarajevo', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (7, N'Prishtina', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (8, N'Rome', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (9, N'Paris', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (10, N'Madrid', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (11, N'Istanbul', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (12, N'Moscow', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [Name], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn]) VALUES (13, N'Stockholm', 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (1, N'My home', N'Rr. Vushtrria', 7, 1, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 0, 0)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (2, N'My Work', N'Rr. Tirana', 7, 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 41.6589654, 43.55555789)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (3, N'My Travel', N'Eiffel Tower', 9, 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 44.656842, 42.5987465)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (4, N'dsfsd', N'sdfsdf', 5, 1, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 44.656842, 43.55555789)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (5, N'My Home', N'Rr. Tirana', 7, 0, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 41.658645, 42.88456)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [CityId], [IsDeleted], [DeletedBy], [DeletedOn], [UpdatedBy], [UpdatedOn], [CreatedBy], [CreatedOn], [Latitude], [Longitude]) VALUES (6, N'dsfs', N'sdf', 5, 1, NULL, NULL, NULL, NULL, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 54.415, 8554.546)
SET IDENTITY_INSERT [dbo].[Locations] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Locations_CityId]    Script Date: 12/31/2020 8:13:42 AM ******/
CREATE NONCLUSTERED INDEX [IX_Locations_CityId] ON [dbo].[Locations]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Locations] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Latitude]
GO
ALTER TABLE [dbo].[Locations] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Longitude]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Locations]  WITH CHECK ADD  CONSTRAINT [FK_Locations_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Locations] CHECK CONSTRAINT [FK_Locations_Cities_CityId]
GO
USE [master]
GO
ALTER DATABASE [aspnet-AbcTestApp] SET  READ_WRITE 
GO
