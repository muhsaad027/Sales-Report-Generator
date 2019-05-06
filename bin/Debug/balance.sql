CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [b_cusId] INT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [PaidAmount] INT NULL, 
    [BalanceAmount] INT NULL
)
