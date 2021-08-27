CREATE PROCEDURE [dbo].[EntregaInsertar]
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
		
		INSERT INTO dbo.Entrega
		(
	     FechaEntrega 
		, IdCatalogoProvincia
		,  IdCatalogoCanton
		,  IdCatalogoDistrito
		, IdPedido
		, IdCamion
		, Estado
		)
		VALUES
		(
		  @FechaEntrega 
		, @IdCatalogoProvincia
		 , @IdCatalogoCanton
		 , @IdCatalogoDistrito
		, @IdPedido
		, @IdCamion
		, @Estado
		)


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