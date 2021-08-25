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
         ON MV.IdPedido = V.IdPedido
     INNER JOIN dbo.Camion A
         ON A.IdCamion = V.IdCamion
	WHERE
	     (@IdEntrega IS NULL OR IdEntrega=@IdEntrega)

END