CREATE TABLE [dbo].[Productos]
(  
    IdProducto INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Producto PRIMARY KEY CLUSTERED(IdProducto)
  , IdCategoria INT NOT NULL CONSTRAINT FK_Productos_Categoria FOREIGN KEY(IdCategoria) REFERENCES dbo.Categoria(IdCategoria)
  , Nombre VARCHAR(250) NOT NULL
  , Cantidad INT NOT NULL
  , Caracteristicas VARCHAR(500) NULL
  , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO

/*CREATE UNIQUE NONCLUSTERED INDEX IDX_Persona_Cedula
ON dbo.Persona(Cedula)
WITH (DATA_COMPRESSION=PAGE)
GO*/
