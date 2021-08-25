CREATE PROCEDURE [dbo].[CamionLista]
AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdCamion,
		Caracteristicas

		FROM	
			dbo.Camion

			WHERE
					Estado=1

	END