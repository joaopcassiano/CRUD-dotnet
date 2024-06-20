USE [master]
GO
/****** Object:  Database [Banco2024]    Script Date: 19/06/2024 20:25:28 ******/
CREATE DATABASE [Banco2024]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'banco2024', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\banco2024.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'banco2024_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\banco2024_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Banco2024] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Banco2024].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Banco2024] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Banco2024] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Banco2024] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Banco2024] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Banco2024] SET ARITHABORT OFF 
GO
ALTER DATABASE [Banco2024] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Banco2024] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Banco2024] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Banco2024] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Banco2024] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Banco2024] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Banco2024] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Banco2024] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Banco2024] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Banco2024] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Banco2024] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Banco2024] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Banco2024] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Banco2024] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Banco2024] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Banco2024] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Banco2024] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Banco2024] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Banco2024] SET  MULTI_USER 
GO
ALTER DATABASE [Banco2024] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Banco2024] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Banco2024] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Banco2024] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Banco2024] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Banco2024] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Banco2024] SET QUERY_STORE = ON
GO
ALTER DATABASE [Banco2024] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Banco2024]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 19/06/2024 20:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Codigo_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Categoria] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Codigo_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 19/06/2024 20:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Codigo_Produto] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Produto] [varchar](50) NOT NULL,
	[Valor_Produto] [float] NULL,
	[Codigo_Categoria] [int] NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Codigo_Produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Banco2024] SET  READ_WRITE 
GO
