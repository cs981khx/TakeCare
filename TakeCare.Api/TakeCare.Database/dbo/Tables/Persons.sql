CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Id_Device] INT NOT NULL, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    --CONSTRAINT [FK_Person_To_Device] FOREIGN KEY ([Id_Device]) REFERENCES [Devices]([Id]),
);

