CREATE TABLE [dbo].[Cares]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [IdPerson] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Cares_ToPerson] FOREIGN KEY ([IdPerson]) REFERENCES [Person]([Id])
)
