CREATE PROCEDURE [dbo].[CamionLista]
AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdCamion,
		IdConductor,
		Caracteristicas,
		Estado

		FROM	
			dbo.Camion

			WHERE
					Estado=1






	END