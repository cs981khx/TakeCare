CREATE TABLE [dbo].[Device] (
    [Id]         NCHAR (10) NOT NULL,
    [MacAddress] NCHAR (10) NULL,
    CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED ([Id] ASC)
);

