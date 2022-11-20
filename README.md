# CrudYuGiOh

--Script:
CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] INT           IDENTITY (1, 1) NOT NULL,
    [Login]     VARCHAR (255) NOT NULL,
    [Senha]     VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

CREATE TABLE [dbo].[LogUsuario] (
    [IdLog]       INT      IDENTITY (1, 1) NOT NULL,
    [DataEntrada] DATETIME NOT NULL,
    [DataSaida]   DATETIME NULL,
    [IdUsuario]   INT      NULL,
    PRIMARY KEY CLUSTERED ([IdLog] ASC),
    CONSTRAINT [FK_LogUsuario_ToTable] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuario] ([IdUsuario])
);

