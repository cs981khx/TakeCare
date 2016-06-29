CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Id_Device] INT NULL, 
    [Steps] INT NULL, 
    [TimeStamp] DATETIME NULL, 
    [Intensity] INT NULL, 
    [Category] INT NULL, 
    [HeartRate] INT NULL, 
    --CONSTRAINT [FK_Activities_To_Device] FOREIGN KEY ([Id_Device]) REFERENCES [Devices]([Id])
);