USE [master]
GO
/****** Object:  Database [LoanWise]    Script Date: 11/21/2024 8:00:22 AM ******/
CREATE DATABASE [LoanWise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoanWise', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LoanWise.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoanWise_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LoanWise_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LoanWise] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoanWise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoanWise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoanWise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoanWise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoanWise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoanWise] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoanWise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoanWise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoanWise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoanWise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoanWise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoanWise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoanWise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoanWise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoanWise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoanWise] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoanWise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoanWise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoanWise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoanWise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoanWise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoanWise] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoanWise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoanWise] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LoanWise] SET  MULTI_USER 
GO
ALTER DATABASE [LoanWise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoanWise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoanWise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoanWise] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoanWise] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LoanWise] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LoanWise] SET QUERY_STORE = ON
GO
ALTER DATABASE [LoanWise] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LoanWise]
GO
/****** Object:  Table [dbo].[newapplication]    Script Date: 11/21/2024 8:00:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[newapplication](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[middlename] [varchar](50) NULL,
	[dob] [date] NULL,
	[gender] [varchar](6) NULL,
	[martialstatus] [varchar](25) NULL,
	[idtype] [varchar](25) NULL,
	[idnumber] [int] NULL,
	[phonenumber] [varchar](15) NULL,
	[email] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[employername] [varchar](25) NULL,
	[employmentstatus] [varchar](25) NULL,
	[position] [varchar](25) NULL,
	[annualincome] [int] NULL,
	[yearsemployment] [varchar](10) NULL,
	[employercontact] [varchar](25) NULL,
	[incomeproof] [int] NULL,
	[identtityproof] [int] NULL,
	[collateraldocument] [int] NULL,
	[loantype] [varchar](25) NULL,
	[amount] [int] NULL,
	[loanpurpose] [varchar](25) NULL,
	[repaymentterm] [varchar](25) NULL,
	[collateraltype] [varchar](25) NULL,
	[estimatedvalue] [int] NULL,
	[collateraldescription] [text] NULL,
	[monthlyincome] [int] NULL,
	[expenses] [int] NULL,
	[applicationdate] [date] NULL,
	[status] [varchar](50) NULL,
	[assignedofficer] [varchar](50) NULL,
 CONSTRAINT [PK_newapplication] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users_tbl]    Script Date: 11/21/2024 8:00:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users_tbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[usertype] [varchar](50) NULL,
	[date_created] [date] NULL,
	[contact] [int] NULL,
	[homeaddress] [varchar](50) NULL,
	[emergencycontact] [int] NULL,
	[dob] [date] NULL,
 CONSTRAINT [PK_users_tbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[newapplication] ADD  CONSTRAINT [DF_newapplication_status]  DEFAULT ('Pending') FOR [status]
GO
USE [master]
GO
ALTER DATABASE [LoanWise] SET  READ_WRITE 
GO
