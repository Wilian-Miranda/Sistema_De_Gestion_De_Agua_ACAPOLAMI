USE master 
GO
DROP database IF exists ACAPOLAMI
GO
CREATE database ACAPOLAMI
GO
USE ACAPOLAMI

--=========================================================
-- Tablas

--=========================================================
GO
CREATE TABLE Comunidades(
	idComunidad int not null IDENTITY PRIMARY KEY,
	nombreComunidad varchar(50) not null,
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Consumidores(
	idConsumidor int not null IDENTITY PRIMARY KEY,
	nombresConsumidor varchar(50) not null,
	apellidosConsumidor varchar(50) not null,
	numeroDocumento varchar(20) not null,
	telefono varchar(20),
	correo varchar(50),
	idComunidad_FK int REFERENCES Comunidades(idComunidad)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Estados(
	idEstado int not null IDENTITY PRIMARY KEY,
	nombreEstado varchar(50)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Pagos(
	idPago int not null IDENTITY PRIMARY KEY,
	monto money not null,
	fechaPago date not null,
	impuesto money,
	idEstado_FK int REFERENCES Estados(idEstado),
	idConsumidor_FK int REFERENCES Consumidores(idConsumidor)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Sucesos(
	idSuceso int not null IDENTITY PRIMARY KEY,
	tipoSuceso int,
	descripcion varchar(100),
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Usuarios(
	idComunidad int not null IDENTITY PRIMARY KEY,
	nombre varchar(50) not null,
	clave varchar(100) not null,
	rol varchar(20)
);
GO
--======================================================================================
-- Registros
--======================================================================================
go
--Comunidades
INSERT INTO Comunidades VALUES('Las Lomas'), ('Las minas'), ('Agua Zarca');
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Consumidores 
VALUES('Manuel', 'Perlera', '312432-4324-32', '71368341', 'manuenitoo@gmail.com', 1),
		('Wilian', 'Leiva', '454235-4324-32', '4524545', 'willianfrifayer@gmail.com', 2),
		('Francisco', 'Miranda', '54523-4324-3243', '74354345', 'Carlosidfgj@gmail.com', 3);
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Estados VALUES('Cancelado'), ('Retrasado');
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Pagos 
VALUES(2, getdate(), 0, 1, 1), (2, getdate(), 0, 2, 2), (2, getdate(), 0, 2, 3);
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Usuarios VALUES ('Manuel', 'frifayer12', 'admin');
go
--SELECTs
go
SELECT * FROM Comunidades
SELECT * FROM Consumidores
SELECT * FROM Estados
SELECT * FROM Pagos
SELECT * FROM Usuarios
go

--======================================================================================
-- Procedimientos almacenados para Consumidores
--======================================================================================
go
-- Procedimiento para mostrar los consumidores
Create PROC sp_MostrarConsumidores
AS
SELECT a.idConsumidor 'Id', a.nombresConsumidor AS 'Nombres', a.apellidosConsumidor AS 'Apellidos', 
a.numeroDocumento AS 'DUI', a.correo AS 'Correo electrónico', a.telefono AS 'Teléfono', 
b.nombreComunidad AS 'Comunidad'

FROM Consumidores AS a
inner join Comunidades AS b
ON b.idComunidad = a.idComunidad_FK;
go
------------------------------------------------------------------------------------------------
go
--Prueba
EXEC sp_MostrarConsumidores
go
-------------------------------------------------------------------------------------------------
go
-- Procedimiento para mostrar los consumidores filtrados por comunidad
CREATE PROC sp_MostrarClientesId
@idComunidad int 
AS
SELECT a.idConsumidor 'Id',a.nombresConsumidor AS 'Nombres', a.apellidosConsumidor AS 'Apellidos', 
a.numeroDocumento AS 'DUI', a.correo AS 'Correo electrónico', a.telefono AS 'Teléfono', 
b.nombreComunidad AS 'Comunidad'

FROM Consumidores AS a
inner join Comunidades AS b
ON b.idComunidad = a.idComunidad_FK
WHERE b.idComunidad = @idComunidad
go
-------------------------------------------------------------------------------------------------
go
--Prueba
EXEC sp_MostrarClientesId 3;
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento para insertar los consumidores y la comunidad
CREATE PROC sp_InsertarConsumidores
@nombres varchar(50),
@apellidos varchar(50),
@dui varchar(20),
@telefono varchar(20),
@correo varchar(50),
@idComunidad int
AS
BEGIN
	INSERT INTO Consumidores
	VALUES(@nombres, @apellidos, @dui, @telefono, @correo, @idComunidad)
END
go
-------------------------------------------------------------------------------------------------
go
--Prueba
EXEC sp_InsertarConsumidores 'Manuel', 'Perlera', '12123-12321-32', '77388082', 'manuenitoo@gmail.com', 1;
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento para eliminar un registro de un consumidor
CREATE PROC sp_EliminarConsumidor
@id int
AS
DELETE FROM Consumidores WHERE idConsumidor = @id
go
-------------------------------------------------------------------------------------------------
go
--Prueba
EXEC sp_EliminarConsumidor 4
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento de Actualizar los Consumidores
CREATE PROC sp_ActualizarConsumidor
@id int,
@nombres varchar(50),
@apellidos varchar(50),
@dui varchar(20),
@telefono varchar(20),
@idComunidad int,
@correo varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Consumidores
	SET 
	nombresConsumidor = @nombres,
	apellidosConsumidor = @apellidos,
	numeroDocumento = @dui,
	telefono = @telefono,
	correo = @correo,
	idComunidad_FK = @idComunidad
	WHERE idConsumidor = @id
END
go
-------------------------------------------------------------------------------------------------
go
--Prueba
EXEC sp_ActualizarConsumidor 7, 'Jose', 'tejada', '452435243-435', '8834129412',3,'manu@gmail.com';
go
-------------------------------------------------------------------------------------------------

--Procedimiento para mostrar comunidad 
