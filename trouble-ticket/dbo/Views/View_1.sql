﻿CREATE VIEW dbo.View_1
AS
SELECT dbo.Operatore.OperID, dbo.Operatore.Nome AS NomeOperatore, dbo.Operatore.Cognome AS CognomeOperatore, dbo.Utente.UtentiID, dbo.Utente.Nome AS NomeUtente, dbo.Utente.Cognome AS CognomeUtente, dbo.Ticket.ticketID, dbo.Ticket.dataApertura, dbo.Ticket.Status, 
             dbo.Ticket.Richiesta, dbo.Note.noteID, dbo.Note.dataNote, dbo.Note.StatoNota, dbo.Note.TestoNota
FROM   dbo.Operatore INNER JOIN
             dbo.OperatoreUtenti ON dbo.Operatore.OperID = dbo.OperatoreUtenti.fk_operID INNER JOIN
             dbo.Utente ON dbo.OperatoreUtenti.fk_utentiID = dbo.Utente.UtentiID INNER JOIN
             dbo.Ticket ON dbo.Utente.UtentiID = dbo.Ticket.fk_utentiID INNER JOIN
             dbo.Note ON dbo.Operatore.OperID = dbo.Note.fk_operID AND dbo.Ticket.ticketID = dbo.Note.fk_ticketID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[22] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Operatore"
            Begin Extent = 
               Top = 20
               Left = 131
               Bottom = 190
               Right = 353
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OperatoreUtenti"
            Begin Extent = 
               Top = 29
               Left = 496
               Bottom = 199
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Utente"
            Begin Extent = 
               Top = 82
               Left = 860
               Bottom = 252
               Right = 1082
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ticket"
            Begin Extent = 
               Top = 201
               Left = 497
               Bottom = 398
               Right = 719
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Note"
            Begin Extent = 
               Top = 183
               Left = 188
               Bottom = 380
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'View_1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'View_1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'View_1';

