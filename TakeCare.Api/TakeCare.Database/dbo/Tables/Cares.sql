CREATE TABLE [dbo].[Cares] (
    [Id]        INT        NOT NULL,
    [FirstName] NCHAR (10) NULL,
    [LastName]  NCHAR (10) NULL,
    [IdPerson]  INT        NULL,
    CONSTRAINT [PK_Cares] PRIMARY KEY CLUSTERED ([Id] ASC)
);

