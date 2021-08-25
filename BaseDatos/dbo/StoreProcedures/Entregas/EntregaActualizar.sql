CREATE PROCEDURE [dbo].[EntregaActualizar]
	@IdEntrega INT,
	@FechaEntrega DATE,
    @Destino VARCHAR(250),
	@IdCamion INT, 
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Entrega SET
	FechaEntrega=@FechaEntrega,
    Destino=@Destino,
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