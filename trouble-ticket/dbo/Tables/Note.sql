CREATE TABLE [dbo].[Note] (
    [fk_ticketID] INT            NOT NULL,
    [noteID]      INT            NOT NULL,
    [dataNote]    DATETIME       NOT NULL,
    [fk_operID]   INT            NULL,
    [TipoNota]    NCHAR (2)      NOT NULL,
    [StatoNota]   NCHAR (2)      NOT NULL,
    [TestoNota]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED ([noteID] ASC),
    CONSTRAINT [FK_Note_Operatore] FOREIGN KEY ([fk_operID]) REFERENCES [dbo].[Operatore] ([OperID]),
    CONSTRAINT [FK_Note_Ticket] FOREIGN KEY ([fk_ticketID]) REFERENCES [dbo].[Ticket] ([ticketID])
);

