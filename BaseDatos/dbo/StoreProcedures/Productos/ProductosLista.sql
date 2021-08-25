CREATE PROCEDURE [dbo].[ProductosLista]
AS
	BEGIN
	SET NOCOUNT ON

	SELECT
	 IdProducto
	FROM Productos
	WHERE Estado=1

	END