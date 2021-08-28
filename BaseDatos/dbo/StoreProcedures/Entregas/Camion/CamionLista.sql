CREATE PROCEDURE [dbo].[CamionLista]
	@FechaEntrega DATE,
	@IdCamion INT = NULL

AS BEGIN
		SET NOCOUNT ON

		IF (@IdCamion is NULL)
	SELECT
			C.IdCamion,
			C.Caracteristicas
			FROM	
				dbo.Camion C
			WHERE
				C.Estado=1

			EXCEPT

			SELECT
			C.IdCamion,
			C.Caracteristicas
			FROM
				dbo.Entrega E
				INNER JOIN dbo.Camion C
					 ON E.IdCamion = C.IdCamion
				WHERE E.FechaEntrega = @FechaEntrega
ELSE
	SELECT
			C.IdCamion,
			C.Caracteristicas
			FROM	
				dbo.Camion C
			WHERE
				C.Estado=1

			EXCEPT

			SELECT
			C.IdCamion,
			C.Caracteristicas
			FROM
				dbo.Entrega E
				INNER JOIN dbo.Camion C
					 ON E.IdCamion = C.IdCamion
				WHERE E.FechaEntrega = @FechaEntrega AND E.IdCamion != @IdCamion



	END



	




