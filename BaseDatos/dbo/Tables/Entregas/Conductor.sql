﻿CREATE TABLE [dbo].[Conductor]
(  
    IdConductor INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Conductor PRIMARY KEY CLUSTERED(IdConductor)
  , NombreCompleto VARCHAR(250) NOT NULL
  , Cedula VARCHAR(250) NOT NULL
  , Telefono VARCHAR(250) NOT NULL
  , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO

