CREATE TABLE [dbo].[Produto]
(
	[codProduto] INT NOT NULL PRIMARY KEY, 
    [descricao] VARCHAR(50) NULL, 
    [valorUnitario] FLOAT NULL, 
    [estoqueMinimo] FLOAT NULL, 
    [quantidadeEstoque] FLOAT NULL, 
    [codBarra] VARCHAR(50) NULL
)
