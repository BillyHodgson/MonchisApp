CREATE PROCEDURE [dbo].[EntregaObtener]
	@IdEntrega INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdEntrega
		,	V.FechaEntrega
		,	V.Destino
		,   V.Estado
		,   MV.IdPedido
		,   A.IdCamion


	
				

	FROM dbo.Entrega V
	 INNER JOIN dbo.Pedido MV
         ON V.IdPedido = MV.IdPedido
     INNER JOIN dbo.Camion A
         ON A.IdCamion = A.IdCamion
	WHERE
	     (@IdEntrega IS NULL OR IdEntrega=@IdEntrega)

END