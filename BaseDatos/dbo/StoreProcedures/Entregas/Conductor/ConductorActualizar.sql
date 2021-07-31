﻿CREATE PROCEDURE [dbo].[ConductorActualizar]
	@IdConductor INT,
    @Nombre VARCHAR(250),
	@Apellido VARCHAR(250),
	@Cedula VARCHAR(250),
	@Telefono INT,
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Conductor SET
    Nombre=@Nombre,
	Apellido=@Apellido,
	Cedula=@Cedula,
	Telefono=@Telefono,
	Estado=@Estado

	WHERE IdConductor=@IdConductor

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