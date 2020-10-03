CREATE TABLE [dbo].[Utente] (
    [UtentiID] INT           NOT NULL,
    [Nome]     NVARCHAR (50) NOT NULL,
    [Cognome]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Utente] PRIMARY KEY CLUSTERED ([UtentiID] ASC)
);

