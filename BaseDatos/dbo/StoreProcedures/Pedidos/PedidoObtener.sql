﻿CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedido INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdPedido
		,   V.FechaPedido
		,   V.Cantidad
		,   V.PrecioUnitario
		,   V.SubTotal
		,   V.Envio
		,   V.Impuesto
		,   V.Total
		,   MV.IdCliente
		,   MV.NombreCompleto
		,	MA.IdProducto
		,   MA.Nombre
	
	FROM dbo.Pedido V
	 INNER JOIN dbo.Cliente MV
         ON V.IdCliente = MV.IdCliente
	INNER JOIN dbo.Productos MA
         ON V.IdProducto = MA.IdProducto
	WHERE
	     (@IdPedido IS NULL OR IdPedido=@IdPedido)

END
