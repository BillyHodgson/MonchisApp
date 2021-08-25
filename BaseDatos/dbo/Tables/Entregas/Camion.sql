CREATE TABLE [dbo].[Camion]
(  
    IdCamion INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Camion PRIMARY KEY CLUSTERED(IdCamion)
  , IdConductor INT NOT NULL CONSTRAINT FK_Camion_Conductor FOREIGN KEY(IdConductor)
   REFERENCES dbo.Conductor(IdConductor)
  , Caracteristicas VARCHAR(250) NOT NULL
  , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO
