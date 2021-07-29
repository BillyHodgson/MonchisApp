﻿CREATE TABLE [dbo].[Conductor]
(  
    IdConductor INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Conductor PRIMARY KEY CLUSTERED(IdConductor)
  , Nombre VARCHAR(250) NOT NULL
  , Apellido VARCHAR(250) NOT NULL
  , Cedula VARCHAR(250) NOT NULL
  , Telefono INT NOT NULL
  , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO

/*CREATE UNIQUE NONCLUSTERED INDEX IDX_Persona_Cedula
ON dbo.Persona(Cedula)
WITH (DATA_COMPRESSION=PAGE)
GO*/