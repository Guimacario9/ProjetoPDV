CREATE TABLE [dbo].[DetalheVenda]
(
	[codDetalheVenda] INT NOT NULL PRIMARY KEY, 
    [codVenda] INT NULL, 
    [codProduto] INT NULL, 
    [quantidadeVenda] FLOAT NULL, 
    [precoDetalhe] FLOAT NULL, 
    CONSTRAINT [FK_DetalheVenda_ToVenda] FOREIGN KEY ([codVenda]) REFERENCES [Venda]([codVenda]), 
    CONSTRAINT [FK_DetalheVenda_ToProduto] FOREIGN KEY ([codProduto]) REFERENCES [Produto]([codProduto])
)
