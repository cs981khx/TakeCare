CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] NCHAR(10) NULL, 
    [IdMacAddress] INT NOT NULL, 
    CONSTRAINT [FK_Person_ToDevice] FOREIGN KEY (IdMacAddress) REFERENCES [Device](IdMacAddress) 
)
