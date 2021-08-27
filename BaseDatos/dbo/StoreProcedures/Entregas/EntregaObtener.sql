CREATE PROCEDURE [dbo].[EntregaObtener]
	@IdEntrega INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdEntrega
		,	V.FechaEntrega
		,   V.Estado
		
		,   CP.IdCatalogoProvincia
		,	CP.NombreCatalogoProvincia

		,   CC.IdCatalogoCanton
		,	CC.NombreCatalogoCanton

		,   CD.IdCatalogoDistrito
		,	CD.NombreCatalogoDistrito

		,   MV.IdPedido
		,   A.IdCamion
		,   A.Caracteristicas

	FROM dbo.Entrega V
	INNER JOIN dbo.CatalogoProvincia CP
         ON V.IdCatalogoProvincia = CP.IdCatalogoProvincia
     INNER JOIN dbo.CatalogoCanton CC
         ON V.IdCatalogoCanton = CC.IdCatalogoCanton
	 INNER JOIN dbo.CatalogoDistrito CD
         ON V.IdCatalogoDistrito = CD.IdCatalogoDistrito
	 INNER JOIN dbo.Pedido MV
         ON MV.IdPedido = V.IdPedido
     INNER JOIN dbo.Camion A
         ON A.IdCamion = V.IdCamion
	WHERE
	     (@IdEntrega IS NULL OR IdEntrega=@IdEntrega)

END