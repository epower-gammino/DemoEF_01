CREATE TABLE [dbo].[OperatoreUtenti] (
    [OperatoriUtentiID] INT NOT NULL,
    [fk_utentiID]       INT NOT NULL,
    [fk_operID]         INT NOT NULL,
    CONSTRAINT [PK_OperatoreUtenti] PRIMARY KEY CLUSTERED ([OperatoriUtentiID] ASC),
    CONSTRAINT [FK_OperatoreUtenti_Operatore] FOREIGN KEY ([fk_operID]) REFERENCES [dbo].[Operatore] ([OperID]),
    CONSTRAINT [FK_OperatoreUtenti_Utente] FOREIGN KEY ([fk_utentiID]) REFERENCES [dbo].[Utente] ([UtentiID])
);

