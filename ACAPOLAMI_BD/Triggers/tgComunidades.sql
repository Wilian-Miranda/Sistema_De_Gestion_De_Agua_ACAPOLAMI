--============================================================================================
-- Triggers de la tabla Comunidades --
--============================================================================================

--Trigger para Insertar Comunidad
 
CREATE TRIGGER tg_InsertarComunidad
    ON Comunidades
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @comunidad VARCHAR(50);

	SELECT @id = i.idComunidad,
	@comunidad = i.nombreComunidad
	FROM inserted i;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Comunidades', 'Se ha Insertado el registro con Id: ' +@id+ 
	' Nombre de comunidad : ' + @comunidad);
END
GO

--Trigger para Actualizar Comunidad
 
CREATE TRIGGER tg_ActualizarComunidad
    ON Comunidades
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @comunidad VARCHAR(50);

	SELECT @id = i.idComunidad,
	@comunidad = i.nombreComunidad
	FROM inserted i;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Comunidades', 'Se ha Actualizado el registro con Id: ' +@id+ 
	' Nombre de comunidad : ' + @comunidad);
END
GO
 
--Trigger para Eliminar Comunidad
 
CREATE TRIGGER tg_EliminarComunidad
    ON Comunidades
    AFTER Delete
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @comunidad VARCHAR(50);

	SELECT @id = i.idComunidad,
	@comunidad = i.nombreComunidad
	FROM deleted i;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Comunidades', 'Se ha Eliminado el registro con Id: ' +@id+ 
	' Nombre de comunidad : ' + @comunidad);
END