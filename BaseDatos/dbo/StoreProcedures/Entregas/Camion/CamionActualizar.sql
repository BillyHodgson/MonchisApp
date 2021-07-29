﻿CREATE PROCEDURE [dbo].[CamionActualizar]
	@IdCamion INT,
	@IdConductor INT,
    @Caracteristicas VARCHAR(250),
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Camion SET
	 IdConductor=@IdConductor,
	 Caracteristicas=@Caracteristicas,
	 Estado=@Estado

	WHERE IdCamion=@IdCamion

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
