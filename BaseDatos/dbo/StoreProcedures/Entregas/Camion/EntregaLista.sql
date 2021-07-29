CREATE PROCEDURE [dbo].[EntregaLista]
AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdEntrega,
		FechaEntrega,
		IdPedido,
		Destino,
		IdCamion,
		Estado

		FROM	
			dbo.Entrega

			WHERE
					Estado=1






	END