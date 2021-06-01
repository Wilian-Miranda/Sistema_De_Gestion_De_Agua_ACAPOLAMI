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
	montoCancelado money,
	montoPendiente money,
	impuesto money,
	montoTotal money,
	fechaPago date not null,
	idEstado_FK int REFERENCES Estados(idEstado),
	idConsumidor_FK int REFERENCES Consumidores(idConsumidor)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Sucesos(
	idSuceso int not null IDENTITY PRIMARY KEY,
	fechaSuceso datetime,
	tipoSuceso varchar(20),
	descripcion varchar(300),
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Usuarios(
	idComunidad int not null IDENTITY PRIMARY KEY,
	nombre varchar(50) not null,
	clave varchar(100) not null,
	rol varchar(20)
);
GO