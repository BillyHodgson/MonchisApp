CREATE PROCEDURE [dbo].[ConductorObtener]
		@IdConductor INT= NULL

AS
	BEGIN 
	SET NOCOUNT ON

	SELECT 
	    IdConductor
	  , NombreCompleto
	  , Cedula
	  , Telefono
	  , Estado
	FROM Conductor
	WHERE (@IdConductor IS NULL OR IdConductor=@IdConductor)

	END
