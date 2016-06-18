CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Id_Device] INT NOT NULL, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] NCHAR(10) NULL, 
    CONSTRAINT [FK_Person_To_Device] FOREIGN KEY ([Id_Device]) REFERENCES [Devices]([Id]),
)
