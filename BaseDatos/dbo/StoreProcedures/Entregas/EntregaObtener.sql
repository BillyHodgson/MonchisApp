CREATE PROCEDURE [dbo].[EntregaObtener]
	@IdEntrega INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdEntrega
		,	V.FechaEntrega
		,	V.Destino
		,   V.Estado
		,   V.Estado
		,   MV.IdPedido

	
				

	FROM dbo.Entrega V
	 INNER JOIN dbo.Pedido MV
         ON V.IdPedido = MV.IdPedido
	WHERE
	     (@IdEntrega IS NULL OR IdEntrega=@IdEntrega)

END