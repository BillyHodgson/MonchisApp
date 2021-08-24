CREATE PROCEDURE [dbo].[ProductosInsertar]
	@IdCategoria INT,
	@Nombre VARCHAR(250),
	@Precio DECIMAL(18,2),
	@Cantidad INT,
	@Caracteristicas VARCHAR(250),
	@Estado BIT
AS

 BEGIN
	SET NOCOUNT ON
	BEGIN TRANSACTION TRASA

	BEGIN TRY

	INSERT INTO Productos (IdCategoria,Nombre,Precio,Cantidad,Caracteristicas,Estado)

	VALUES (@IdCategoria,@Nombre,@Precio,@Cantidad,@Caracteristicas,@Estado)

	COMMIT TRANSACTION TRASA

	SELECT 0 AS CodeError, '' AS MsgError

	END TRY

	BEGIN CATCH

	SELECT 
			 ERROR_NUMBER() AS CodeError
			,ERROR_MESSAGE() AS MsgError

		ROLLBACK TRANSACTION TRASA
	END CATCH
 

END