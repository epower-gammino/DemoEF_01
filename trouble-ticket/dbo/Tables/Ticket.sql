CREATE TABLE [dbo].[Ticket] (
    [ticketID]     INT            NOT NULL,
    [dataApertura] DATETIME       NOT NULL,
    [fk_utentiID]  INT            NOT NULL,
    [Status]       NCHAR (2)      NOT NULL,
    [Richiesta]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([ticketID] ASC),
    CONSTRAINT [FK_Ticket_Utente] FOREIGN KEY ([fk_utentiID]) REFERENCES [dbo].[Utente] ([UtentiID])
);

