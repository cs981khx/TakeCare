CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdMacAddress] INT NOT NULL, 
    [Steps] NCHAR(10) NULL, 
    [GettingDateFrom] DATETIME NULL, 
    [GettingDateUntil] DATETIME NULL, 
    [Intensity] NCHAR(10) NULL, 
    [Category] NCHAR(10) NULL, 
    [HeartRate] NCHAR(10) NULL, 
    CONSTRAINT [FK_Activities_ToDevice] FOREIGN KEY ([IdMacAddress]) REFERENCES [Device]([IdMacAddress])
)
