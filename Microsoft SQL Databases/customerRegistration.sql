USE [Cars]
GO

/****** Object:  Table [dbo].[CustomerRegister]    Script Date: 5/19/2018 12:26:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerRegister](
	[CustomerID] [varchar](15) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[ZipCode] [varchar](15) NULL,
	[ProductID] [varchar](15) NULL,
	[CustomerAddress] [varchar](300) NULL,
	[PhoneNumber] [varchar](30) NULL,
	[PICTURE] [varbinary](max) NULL,
	[DateofReg] [varchar](40) NULL,
	[CustomerType] [varchar](40) NULL,
	[Country] [varchar](25) NULL,
 CONSTRAINT [PK_CustomerRegister] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

