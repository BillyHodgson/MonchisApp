CREATE PROCEDURE [dbo].[PedidoActualizar]
	@IdPedido INT,
	@IdCliente INT,
	@FechaPedido DATE,
	@IdProducto INT, 
	@Cantidad INT, 
	@SubTotal INT,
	@Envio INT, 
	@IVA INT, 
	@Total INT

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Pedido SET
	IdCliente=@IdCliente,
	FechaPedido=@FechaPedido,
	IdProducto=@IdProducto, 
	Cantidad=@Cantidad, 
	Subtotal=@SubTotal,
	Envio=@Envio, 
	IVA=@IVA, 
	Total=@Total

	WHERE IdPedido=@IdPedido

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
