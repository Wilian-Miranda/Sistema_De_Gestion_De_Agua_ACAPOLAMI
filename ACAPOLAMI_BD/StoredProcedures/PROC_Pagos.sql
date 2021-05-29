--======================================================================================
-- Procedimientos almacenados para Pagos
--======================================================================================
-- Procedimiento para Mostrar Pagos
CREATE PROC sp_MostrarPagos
AS

BEGIN
--Select para la tabla de pagos
	SELECT a.idPago Id, b.nombresConsumidor Nombres, b.apellidosConsumidor Apellidos, 
	a.monto as Monto, a.montoCancelado as Cancelado, a.montoPendiente as Pendiente, 
	a.impuesto as Impuesto, a.montoTotal as [Total deuda], c.nombreEstado as Estado, a.fechaPago as Fecha 

	FROM Pagos AS a

	INNER JOIN Consumidores AS b on a.idConsumidor_FK = b.idConsumidor
	INNER JOIN Estados AS c on a.idEstado_FK = c.idEstado;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarPagos
go
-------------------------------------------------------------------------------------------------

-- Procedimiento para Mostrar Pagos filtrados por Consumidor
CREATE PROC sp_MostrarPagosId
@idConsumidor int 

AS
BEGIN
	SET NOCOUNT ON;
	SELECT a.idPago Id, b.nombresConsumidor Nombres, b.apellidosConsumidor Apellidos, 
	a.monto as Monto, a.montoCancelado as Cancelado, a.montoPendiente as Pendiente, 
	a.impuesto as Impuesto, a.montoTotal as [Total a deuda], c.nombreEstado as Estado, a.fechaPago as Fecha 

	FROM Pagos AS a

	INNER JOIN Consumidores AS b on a.idConsumidor_FK = b.idConsumidor
	INNER JOIN Estados AS c on a.idEstado_FK = c.idEstado
	WHERE a.idConsumidor_FK = @idConsumidor
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarPagosId 3;
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento para Insertar Pagos
CREATE PROC sp_InsertarPago
@monto money,
@montoCancelado money,
@montoPendiente money,
@impuesto money,
@total money,
@fechaPago date,
@idEstado int,
@idConsumidor int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Pagos
	VALUES(@monto, @montoCancelado, @montoPendiente, @impuesto, @total, @fechaPago, @idEstado, @idConsumidor);
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarPago 2, 2, 0, 0, 0,'2021-05-03', 1, 3;
go
-------------------------------------------------------------------------------------------------

--Procedimiento para Eliminar Pagos
CREATE PROC sp_EliminarPago
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Pagos WHERE idPago = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarPago 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar Pagos
CREATE PROC sp_ActualizarPago
@id int,
@monto money,
@montoCancelado money,
@montoPendiente money,
@impuesto money,
@total money,
@fechaPago date,
@idEstado int,
@idConsumidor int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Pagos
	SET 
	monto = @monto,
	montoCancelado = @montoCancelado,
	montoPendiente = @montoPendiente,
	impuesto = @impuesto,
	montoTotal = @total,
	fechaPago = @fechaPago,
	idEstado_FK = @idEstado,
	idConsumidor_FK = @idConsumidor
	WHERE idPago = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarPago 4, 4, 2, 0, 0, 0,'2021-05-03', 1, 3;
go