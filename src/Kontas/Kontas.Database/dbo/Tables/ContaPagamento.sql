CREATE TABLE [dbo].[ContaPagamento] (
    [Id]      INT             IDENTITY (1, 1) NOT NULL,
    [ContaId] INT             NOT NULL,
    [Valor]   DECIMAL (18, 2) NOT NULL,
    [Data]    DATE            NOT NULL,
    CONSTRAINT [PK_ContaPagamento] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContaPagamento_Conta] FOREIGN KEY ([ContaId]) REFERENCES [dbo].[Conta] ([Id])
);

