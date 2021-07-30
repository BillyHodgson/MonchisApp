CREATE TABLE [dbo].[Pedido]
(  
    IdPedido INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Pedido PRIMARY KEY CLUSTERED(IdPedido)
  , IdCliente INT NOT NULL CONSTRAINT FK_Pedido_Cliente FOREIGN KEY(IdCliente) REFERENCES dbo.Cliente(IdCliente)
  , FechaPedido DATE NOT NULL
  , IdProducto INT NOT NULL CONSTRAINT FK_Pedido_Producto FOREIGN KEY(IdProducto) REFERENCES dbo.Productos(IdProducto)
  , Cantidad INT NOT NULL /*Debe validar si esta disponible la cantidad*/
  , SubTotal INT NOT NULL
  , Envio INT NOT NULL
  , IVA INT NOT NULL 
  , Total INT NOT NULL 
  
)
WITH (DATA_COMPRESSION=PAGE)
GO

/*CREATE UNIQUE NONCLUSTERED INDEX IDX_Persona_Cedula
ON dbo.Persona(Cedula)
WITH (DATA_COMPRESSION=PAGE)
GO*/
