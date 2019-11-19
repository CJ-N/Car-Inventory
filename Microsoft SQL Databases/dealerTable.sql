USE [InventoryDB]
GO

/****** Object:  Table [dbo].[Dealer]    Script Date: 5/19/2018 12:24:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dealer](
	[DealerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[DealerAddress1] [varchar](175) NOT NULL,
	[DealerAddress2] [varchar](100) NULL,
	[PhoneNumber] [varchar](70) NOT NULL,
	[DateIn] [date] NOT NULL,
	[Gender] [char](10) NOT NULL
) ON [PRIMARY]
GO

