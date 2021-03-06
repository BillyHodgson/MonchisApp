CREATE PROCEDURE [dbo].[PedidoInsertar]
	@IdCliente INT,
	@FechaPedido Date,
	@IdProducto INT,
	@Cantidad INT,
	@SubTotal DECIMAL (18,2),
	@Envio DECIMAL (18,2),
	@Impuesto DECIMAL (18,2),
	@Total DECIMAL (18,2),
	@Estado BIT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Pedido 
		(
	      IdCliente
	    , FechaPedido 
	    , IdProducto
		, Cantidad
		, Envio
		, SubTotal
		, Impuesto
		, Total
		, Estado
		)
		VALUES
		(
		  @IdCliente
	    , @FechaPedido 
	    , @IdProducto
		, @Cantidad
		, @Envio
		, @SubTotal
		, @Impuesto
		, @Total
		, @Estado
		)

		Update Productos set Cantidad=Cantidad - @Cantidad where IdProducto=@IdProducto


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