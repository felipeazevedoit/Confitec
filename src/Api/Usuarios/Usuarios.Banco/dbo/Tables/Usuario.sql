CREATE TABLE [dbo].[Usuario] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (100) NOT NULL,
    [Sobrenome]      VARCHAR (200) NULL,
    [Email]          VARCHAR (300) NOT NULL,
    [DataNascimento] DATE          NULL,
    [Escolaridade]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

