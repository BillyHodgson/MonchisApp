CREATE PROCEDURE [dbo].[ConductorInsertar]
	@Nombre VARCHAR(250),
	@Apellido VARCHAR(250),
	@Cedula VARCHAR(250),
	@Telefono INT,
	@Estado BIT
AS
 BEGIN
   SET NOCOUNT ON
   BEGIN TRANSACTION TRASA

   BEGIN TRY 

   INSERT INTO Conductor 
   (
    Nombre,
	Apellido,
	Cedula,
	Telefono,
	Estado)
   VALUES
   (
     @Nombre
	,@Apellido
	,@Cedula
	,@Telefono
	,@Estado
   )

   COMMIT TRANSACTION TRASA

     SELECT 0 AS CodeError, '' AS MsgError

   END TRY

   BEGIN CATCH
     SELECT 
	     ERROR_NUMBER() AS CodeError
	   , ERROR_MESSAGE() AS MsgError

	   ROLLBACK TRANSACTION TRASA
   END CATCH

 END
