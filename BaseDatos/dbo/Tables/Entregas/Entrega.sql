CREATE TABLE [dbo].[Entrega]
(  
    IdEntrega INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Entrega PRIMARY KEY CLUSTERED(IdEntrega)
  , FechaEntrega DATE NOT NULL 
   , IdCatalogoProvincia INT NOT NULL
	      CONSTRAINT FK_Agencia_Provincia FOREIGN KEY(IdCatalogoProvincia) REFERENCES dbo.CatalogoProvincia(IdCatalogoProvincia)
	, IdCatalogoCanton INT NOT NULL 
	       CONSTRAINT Fk_Agencia_Canton FOREIGN KEY(IdCatalogoCanton) REFERENCES dbo.CatalogoCanton(IdCatalogoCanton)
	, IdCatalogoDistrito INT NOT NULL
	       CONSTRAINT Fk_Agencia_Distrito FOREIGN KEY(IdCatalogoDistrito) REFERENCES dbo.CatalogoDistrito(IdCatalogoDistrito)
, IdPedido INT NOT NULL CONSTRAINT FK_Entrega_Pedido FOREIGN KEY(IdPedido) REFERENCES dbo.Pedido(IdPedido)
  , IdCamion INT NOT NULL CONSTRAINT FK_Entrega_Camion FOREIGN KEY(IdCamion) REFERENCES dbo.Camion(IdCamion)
  , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO
