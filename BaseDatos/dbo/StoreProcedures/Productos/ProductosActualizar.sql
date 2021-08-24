CREATE PROCEDURE [dbo].[ProductosActualizar]
	@IdProducto INT ,
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
	--METODO

	UPDATE Productos
	SET
	IdCategoria=@IdCategoria,
	Nombre=@Nombre,
	Precio=@Precio,
	Cantidad=@Cantidad,
	Caracteristicas=@Caracteristicas,
	Estado=@Estado

	WHERE 

		IdProducto=@IdProducto
	

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
