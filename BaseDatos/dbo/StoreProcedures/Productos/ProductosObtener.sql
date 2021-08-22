CREATE PROCEDURE [dbo].[ProductosObtener]
	@IdProducto INT= NULL
AS
	BEGIN

	SET NOCOUNT ON
	
	SELECT
	
	P.IdProducto
	,P.Nombre
	,P.Cantidad
	,P.Caracteristicas
	,P.Estado
	,C.IdCategoria
	,C.Descripcion

	FROM dbo.Productos P
	 INNER JOIN dbo.Categoria C
			ON (C.IdCategoria=P.IdCategoria)
	WHERE
	     (@IdProducto IS NULL OR IdProducto=@IdProducto)

	END