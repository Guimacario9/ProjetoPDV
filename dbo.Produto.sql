USE [SistemaPDV]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 12/04/2022 10:17:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[codProduto] [int] NOT NULL,
	[descricao] [varchar](50) NULL,
	[valorUnitario] [float] NULL,
	[estoqueMinimo] [float] NULL,
	[quantidadeEstoque] [float] NULL,
	[codBarra] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
