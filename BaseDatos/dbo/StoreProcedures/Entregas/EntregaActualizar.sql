CREATE PROCEDURE [dbo].[EntregaActualizar]
	@IdEntrega INT,
	@FechaEntrega DATE,
    @IdCatalogoProvincia INT,
	@IdCatalogoCanton INT,
	@IdCatalogoDistrito INT,
	@IdPedido INT,
	@IdCamion INT, 
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Entrega SET
	FechaEntrega=@FechaEntrega,
    IdCatalogoProvincia=@IdCatalogoProvincia,
	IdCatalogoCanton=@IdCatalogoCanton,
	IdCatalogoDistrito=@IdCatalogoDistrito,
	IdPedido=@IdPedido,
	IdCamion=@IdCamion, 
	Estado=@Estado

	WHERE IdEntrega=@IdEntrega

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END