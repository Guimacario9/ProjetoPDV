CREATE TABLE [dbo].[Venda]
(
	[codVenda] INT NOT NULL PRIMARY KEY, 
    [dataVenda] Date NULL, 
    [codCliente] INT NULL, 
    [precoTotal] float NULL, 
    CONSTRAINT [FK_Venda_ToCliente] FOREIGN KEY ([codCliente]) REFERENCES [Cliente]([codCliente])
)

