CREATE PROCEDURE [dbo].[ClienteInsertar]
	@Cedula VARCHAR(250),
	@NombreCompleto VARCHAR(250),
	@FechaNacimiento DATE,
	@Telefono varchar(250),
    @Estado BIT
	
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
		INSERT INTO dbo.Cliente
		(	       
	      Cedula,
	      NombreCompleto,		 
		  FechaNacimiento,
		  Telefono,
		  Estado
		)
		VALUES
		(		
	      @Cedula,
	      @NombreCompleto,		 
		  @FechaNacimiento,
		  @Telefono,
		  @Estado
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
