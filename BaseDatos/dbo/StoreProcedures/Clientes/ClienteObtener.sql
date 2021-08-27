CREATE PROCEDURE [dbo].[ClienteObtener]
	@IdCliente INT= null
AS
	begin
	SET NOCOUNT ON


	 SELECT
	 IdCliente,
	 Cedula,
	 NombreCompleto,
	 FechaNacimiento,
	 Telefono,
	 Estado

	 FROM dbo.Cliente
	 WHERE

	 (@IdCliente IS NULL OR IdCliente=@IdCliente)
	end