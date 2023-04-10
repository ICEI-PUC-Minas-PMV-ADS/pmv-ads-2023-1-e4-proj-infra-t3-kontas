CREATE TABLE [dbo].[Conta] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Descricao]     VARCHAR (50)    NOT NULL,
    [Vencimento]    DATE            NOT NULL,
    [Valor]         DECIMAL (18, 2) NOT NULL,
    [StatusContaId] INT             NOT NULL,
    [APagar]        BIT             NOT NULL,
    CONSTRAINT [PK_Conta] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Conta_StatusConta] FOREIGN KEY ([StatusContaId]) REFERENCES [dbo].[StatusConta] ([Id])
);

