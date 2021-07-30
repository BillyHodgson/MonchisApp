CREATE PROCEDURE [dbo].[PedidoInsertar]
	@IdCliente INT,
	@FechaPedido Date,
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
		
		INSERT INTO dbo.Pedido 
		(
	      IdCliente
	    , FechaPedido 
	    , IdProducto
		, Cantidad
		, SubTotal
		, Envio
		, IVA
		, Total
		)
		VALUES
		(
		  @IdCliente
	    , @FechaPedido 
	    , @IdProducto
		, @Cantidad
		, @SubTotal
		, @Envio
		, @IVA
		, @Total
		)


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