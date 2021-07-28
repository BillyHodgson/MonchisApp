CREATE PROCEDURE [dbo].[CategoriaInsertar]
	@IdCategoria INT,
	@Descripcion VARCHAR(250)

	AS
	BEGIN
   SET NOCOUNT ON
   BEGIN TRANSACTION TRASA

   BEGIN TRY 

   INSERT INTO Categoria
   (
	  IdCategoria
      ,Descripcion
	)
   VALUES
   (
      @IdCategoria
     ,@Descripcion
	
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