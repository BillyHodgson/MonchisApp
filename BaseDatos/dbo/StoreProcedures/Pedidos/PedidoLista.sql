CREATE PROCEDURE [dbo].[PedidoLista]
	AS
	BEGIN
	SET NOCOUNT ON

	SELECT
	 IdPedido
	FROM Pedido
	WHERE Estado=1

	END