CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [MacAddress] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(100) NULL
);