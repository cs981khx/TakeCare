CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MacAddress] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(100) NULL
);