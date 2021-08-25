CREATE PROCEDURE [dbo].[ConductorLista]
AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdConductor,
		NombreCompleto
		FROM	
			dbo.Conductor

			WHERE
					Estado=1






	END