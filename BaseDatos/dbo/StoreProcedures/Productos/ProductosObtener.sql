CREATE PROCEDURE [dbo].[ProductosObtener]
	@IdProducto INT= NULL
AS
	BEGIN

	SET NOCOUNT ON
	
	SELECT
	
	 IdProducto
	,IdCategoria
	,Nombre
	,Cantidad
	,Caracteristicas
	,Estado

	FROM Productos
	WHERE
	     (@IdProducto IS NULL OR IdProducto=@IdProducto)

	END