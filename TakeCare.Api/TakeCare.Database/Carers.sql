CREATE TABLE [dbo].[Carers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Id_Person] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Carers_To_Person] FOREIGN KEY ([Id_Person]) REFERENCES [Person]([Id]), 

)
