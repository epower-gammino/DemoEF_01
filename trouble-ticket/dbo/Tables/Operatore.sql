CREATE TABLE [dbo].[Operatore] (
    [OperID]  INT           NOT NULL,
    [Nome]    NVARCHAR (50) NOT NULL,
    [Cognome] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Operatore] PRIMARY KEY CLUSTERED ([OperID] ASC)
);

