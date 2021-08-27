CREATE PROCEDURE [dbo].[PedidoActualizar]
	@IdPedido INT,
	@IdCliente INT,
	@FechaPedido DATE,
	@IdProducto INT, 
	@Cantidad INT,
	@Envio DECIMAL (18,2),
	@SubTotal DECIMAL (18,2),
	@Impuesto DECIMAL (18,2),
	@Total DECIMAL (18,2),
	@Estado BIT

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
	Envio=@Envio,
	Subtotal=@SubTotal,
	Impuesto=@Impuesto, 
	Total=@Total,
	Estado=@Estado

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
