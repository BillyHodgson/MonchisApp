﻿CREATE PROCEDURE [dbo].[CategoriaLista]
AS
	BEGIN
		SET NOCOUNT ON

		SELECT 
		IdCategoria,
		Descripcion

		FROM	
			dbo.Categoria
	END
