CREATE PROCEDURE [dbo].[CamionObtener]
	@IdCamion INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.IdCamion
		,   V.Caracteristicas
		,   V.Estado
		,   MV.IdConductor
		,	MV.Nombre
		,   MV.Apellido
	
				

	FROM dbo.Camion V
	 INNER JOIN dbo.Conductor MV
         ON V.IdConductor = MV.IdConductor
	WHERE
	     (@IdCamion IS NULL OR IdCamion=@IdCamion)

END