CREATE TABLE [dbo].[Usuario]
(
	[codUsuario] INT NOT NULL PRIMARY KEY, 
    [nomeUsuario] VARCHAR(50) NULL, 
    [senhaUsuario] VARCHAR(50) NULL, 
    [md5Senha] VARCHAR(50) NULL
)


Abordagem baseada em FaaS aplicada ao Monitoramento Remoto  de Pacientes