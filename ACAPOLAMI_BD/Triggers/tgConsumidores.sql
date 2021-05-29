--============================================================================================
-- Triggers para la tabla Consumidores --
--============================================================================================

--Trigger para Insertar Consumidor
 
CREATE TRIGGER tg_InsertarConsumidor
    ON Consumidores
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @nombres VARCHAR(50), @apellidos varchar(50), @dui VARCHAR(20), @tel varchar(20), @correo varchar(30), @comunidad VARCHAR(50);

	SELECT @id = i.idConsumidor, 
	@nombres = i.nombresConsumidor, 
	@apellidos = i.apellidosConsumidor,
	@dui = i.numeroDocumento, 
	@tel = i.telefono,
	@correo = i.correo,
	@comunidad = b.nombreComunidad 
	FROM inserted i inner join Comunidades b
	on i.idComunidad_FK = b.idComunidad;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Consumidores', 'Se ha Insertado el registro con Id: ' +@id+ 
	', Nombres: ' + @nombres + 
	', Apellidos: ' +@apellidos+
	', DUI: '+@dui+
	', Telefono: '+@tel+
	', Correo: '+@correo+
	' y Comunidad: '+@comunidad);
END
GO

--Trigger para Actualizar Consumidor
 
CREATE TRIGGER tg_ActualizarConsumidor
    ON Consumidores
    for UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @nombres VARCHAR(50), @apellidos varchar(50), @dui VARCHAR(20), @tel varchar(20), @correo varchar(30), @comunidad VARCHAR(50);

	SELECT @id = i.idConsumidor, 
	@nombres = i.nombresConsumidor, 
	@apellidos = i.apellidosConsumidor,
	@dui = i.numeroDocumento, 
	@tel = i.telefono,
	@correo = i.correo,
	@comunidad = b.nombreComunidad 
	FROM inserted i inner join Comunidades b
	on i.idComunidad_FK = b.idComunidad;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Consumidores', 'Se ha Actualizado el registro con Id: ' +@id+ 
	', Nombres: ' + @nombres+
	', Apellidos: ' +@apellidos+
	', DUI: '+@dui+
	', Telefono: '+@tel+
	', Correo: '+@correo+
	' y Comunidad: '+@comunidad);
END
GO
 
--Trigger para Eliminar Consumidor
 
CREATE TRIGGER tg_EliminarConsumidor
    ON Consumidores
    AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @nombres VARCHAR(50), @apellidos varchar(50), @dui VARCHAR(20), @tel varchar(20), @correo varchar(30), @comunidad VARCHAR(50);

	SELECT @id = i.idConsumidor, 
	@nombres = i.nombresConsumidor, 
	@apellidos = i.apellidosConsumidor,
	@dui = i.numeroDocumento, 
	@tel = i.telefono,
	@correo = i.correo,
	@comunidad = b.nombreComunidad 
	FROM deleted i inner join Comunidades b
	on i.idComunidad_FK = b.idComunidad;

	INSERT INTO Sucesos VALUES((SELECT CONVERT(VARCHAR(10), GETDATE(), 3)), 'Consumidores', 'Se ha Eliminado el registro con Id: ' +@id+ 
	', Nombres: ' + @nombres+
	', Apellidos: ' +@apellidos+
	', DUI: '+@dui+
	', Telefono: '+@tel+
	', Correo: '+@correo+
	' y Comunidad: '+@comunidad);
END