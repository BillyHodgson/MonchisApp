CREATE PROCEDURE [dbo].[CategoriaObtener]
 @IdCategoria INT= NULL

 AS
	BEGIN
	SET NOCOUNT ON

	SELECT
		IdCategoria
		,Descripcion

	FROM Categoria
	WHERE (@IdCategoria IS NULL OR IdCategoria=@IdCategoria)

	END