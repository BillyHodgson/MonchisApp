CREATE PROCEDURE [dbo].[ClienteActualizar]
	@IdCliente INT,
	@Cedula VARCHAR(500),
	@NombreCompleto VARCHAR(500),
	@FechaNacimiento DATE,
	@Telefono varchar(250),
    @Estado BIT
	
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
		update dbo.Cliente set     
		  Cedula=@Cedula,
	      NombreCompleto=@NombreCompleto,		 
		  FechaNacimiento=@FechaNacimiento,
		  Telefono=@Telefono,
		  Estado=@Estado
		where IdCliente=@IdCliente


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
