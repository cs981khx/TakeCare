CREATE TABLE [dbo].[Activity] (
    [Id]              INT        NOT NULL,
    [IdMacAddress]    INT        NULL,
    [Steps]           NCHAR (10) NULL,
    [GettingDateFrom] DATETIME   NULL,
    [GettingDateTo]   DATETIME   NULL,
    [Intensity]       NCHAR (10) NULL,
    [Category]        NCHAR (10) NULL,
    [HeartRate]       NCHAR (10) NULL,
    CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED ([Id] ASC)
);

