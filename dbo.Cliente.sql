CREATE TABLE [dbo].[Cliente]
(
	[codCliente] INT NOT NULL PRIMARY KEY, 
    [CPF] VARCHAR(20) NULL, 
    [nomeCliente] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [renda] FLOAT NULL,
	[fone] VARCHAR(12) NULL,
	[endereco] VARCHAR(50) NULL,
	[cidade] VARCHAR(20) NULL,
	[estado] VARCHAR(2) NULL
)
