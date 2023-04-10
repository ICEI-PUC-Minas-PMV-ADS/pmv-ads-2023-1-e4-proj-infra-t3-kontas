CREATE TABLE [dbo].[StatusConta] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_StatusConta] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_StatusConta_Nome]
    ON [dbo].[StatusConta]([Nome] ASC);

