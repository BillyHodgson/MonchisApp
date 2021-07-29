CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedido INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdPedido
		,   V.FechaPedido
		,   V.Cantidad
		,   V.Cantidad
		,   V.SubTotal
		,   V.SubTotal
		,   V.Envio
		,   V.IVA
		,   V.Total
		,   MV.IdCliente
		,   MV.Nombre
		,   MV.Primer_Apellido
		,   MV.Segundo_Apellido
		,   MV.Cedula
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
