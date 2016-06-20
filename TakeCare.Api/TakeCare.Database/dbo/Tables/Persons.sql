CREATE TABLE [dbo].[Persons] (
    [Id]           INT        NOT NULL,
    [FirstName]    NCHAR (10) NULL,
    [LastName]     NCHAR (10) NULL,
    [IdMacAddress] INT        NOT NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([Id] ASC)
);

