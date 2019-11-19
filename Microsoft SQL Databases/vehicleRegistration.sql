USE [Cars]
GO

/****** Object:  Table [dbo].[VehicleRegistration]    Script Date: 5/19/2018 12:27:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VehicleRegistration](
	[VIN] [nchar](10) NOT NULL,
	[Manufacturer] [varchar](50) NOT NULL,
	[Model] [varchar](30) NOT NULL,
	[Version] [varchar](30) NOT NULL,
	[Colour] [varchar](15) NOT NULL,
	[Transmission_Type] [bit] NOT NULL,
	[Number_Of_Door] [int] NOT NULL,
	[Fuel_Type] [char](15) NOT NULL,
	[Selling_Price] [varchar](30) NOT NULL,
	[Date_Of_Registration] [varchar](40) NOT NULL,
	[Vehicle_Interior_Image] [varbinary](max) NOT NULL,
	[Vehicle_Exterior_Image] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_VehicleRegistration] PRIMARY KEY CLUSTERED 
(
	[VIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

