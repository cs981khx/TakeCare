CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_Device] INT NOT NULL, 
    [Steps] INT NULL, 
    [TimeStamp] DATETIME NULL, 
    [Intensity] INT NULL, 
    [Category] NCHAR(10) NULL, 
    [HeartRate] NCHAR(10) NULL, 
    CONSTRAINT [FK_Activities_To_Device] FOREIGN KEY ([Id_Device]) REFERENCES [Devices]([Id])
)
