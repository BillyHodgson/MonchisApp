CREATE PROCEDURE [dbo].[CamionLista]
	@FechaEntrega DATE=NULL

AS BEGIN
		SET NOCOUNT ON

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

	END



	






--DECLARE @FechaEntrega DATE=NULL

--SELECT
--C.IdCamion,
--C.Caracteristicas
--FROM	
--	dbo.Camion C

--EXCEPT

--SELECT
--C.IdCamion,
--C.Caracteristicas
--FROM
--	dbo.Entrega E
--	INNER JOIN dbo.Camion C
--         ON E.IdCamion = C.IdCamion
--	WHERE E.FechaEntrega != @FechaEntrega
