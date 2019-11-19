USE [Cars]
GO

/****** Object:  Table [dbo].[CarsSALES]    Script Date: 5/19/2018 12:25:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarsSALES](
	[VIN] [nchar](10) NOT NULL,
	[CustomerID] [varchar](15) NOT NULL,
	[DateOfPurchase] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[VIN] ASC,
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CarsSALES]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CustomerRegister] ([CustomerID])
GO

ALTER TABLE [dbo].[CarsSALES]  WITH CHECK ADD FOREIGN KEY([VIN])
REFERENCES [dbo].[VehicleRegistration] ([VIN])
GO

