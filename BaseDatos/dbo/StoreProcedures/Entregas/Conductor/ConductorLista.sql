CREATE PROCEDURE [dbo].[ConductorLista]
AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdConductor,
		Nombre,
		Apellido,
		Cedula,
		Telefono

		FROM	
			dbo.Conductor

			WHERE
					Estado=1






	END