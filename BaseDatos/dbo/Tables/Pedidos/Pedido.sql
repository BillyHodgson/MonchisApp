CREATE TABLE [dbo].[Pedido]
(  
    IdPedido INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Pedido PRIMARY KEY CLUSTERED(IdPedido)
  , Cliente VARCHAR(250) NOT NULL /*Debe venir de Clientes*/
  , FechaPedido DATE NOT NULL
  , Producto VARCHAR(250) NOT NULL /*Debe venir de Productos*/
  , Cantidad INT NOT NULL /*Debe validar si esta disponible la cantidad*/
  , SubTotal INT NOT NULL 
  , SubEnvio INT NOT NULL
  , IVA INT NOT NULL 
  , Total INT NOT NULL 
  
)
WITH (DATA_COMPRESSION=PAGE)
GO

/*CREATE UNIQUE NONCLUSTERED INDEX IDX_Persona_Cedula
ON dbo.Persona(Cedula)
WITH (DATA_COMPRESSION=PAGE)
GO*/
