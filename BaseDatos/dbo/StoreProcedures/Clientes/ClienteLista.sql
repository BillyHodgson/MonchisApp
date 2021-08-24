CREATE PROCEDURE [dbo].[ClienteLista]
	AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 IdCliente,
	 NombreCompleto
	FROM Cliente
	WHERE Estado=1


	END