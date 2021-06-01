--============================================================================================
-- Triggers para la tabla Pagos --
--============================================================================================
use ACAPOLAMI;
--Trigger para Insertar Pago
 
CREATE TRIGGER tg_InsertarPago
    ON Pagos
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @monto money, @cancelado money, 
	@pendiente money, @impuesto money,@total money, @estado varchar(20), @consumidor varchar(20);

	SELECT @id = i.idPago, 
	@monto = i.monto, 
	@cancelado = i.montoCancelado,
	@pendiente = i.montoPendiente,
	@impuesto = i.impuesto,
	@total = i.montoTotal,
	@estado = c.nombreEstado,
	@consumidor = b.nombresConsumidor 
	FROM inserted i 
	inner join Consumidores b
	on i.idConsumidor_FK = b.idConsumidor
	inner join Estados c
	on i.idEstado_FK = c.idEstado;

	INSERT INTO Sucesos VALUES(GETDATE(), 'Pagos', 'Se ha Insertado el registro con Id: ' +@id+ 
	', Monto: ' + cast(@monto as varchar)+ 
	', Monto cancelado: ' +cast(@cancelado as varchar)+
	', Monto pendiente: ' +cast(@pendiente as varchar)+
	', Impuesto: '+cast(@monto as varchar)+
	', Total deuda: ' +cast(@Total as varchar)+
	', Estado: '+@estado+
	' y Consumidor: '+@consumidor);
END
GO

--Trigger para Actualizar Pagos
 
Create TRIGGER tg_ActualizarPago
    ON Pagos
    FOR UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @monto money, @cancelado money, 
	@pendiente money, @impuesto money,@total money, @estado varchar(20), @consumidor varchar(20);

	SELECT @id = i.idPago, 
	@monto = i.monto, 
	@cancelado = i.montoCancelado,
	@pendiente = i.montoPendiente,
	@impuesto = i.impuesto,
	@total = i.montoTotal,
	@estado = c.nombreEstado,
	@consumidor = b.nombresConsumidor 
	FROM inserted i 
	inner join Consumidores b
	on i.idConsumidor_FK = b.idConsumidor
	inner join Estados c
	on i.idEstado_FK = c.idEstado;

	INSERT INTO Sucesos VALUES(GETDATE(), 'Pagos', 'Se ha Actualizado el registro con Id: ' +@id+ 
	', Monto: ' + cast(@monto as varchar)+ 
	', Monto cancelado: ' +cast(@cancelado as varchar)+
	', Monto pendiente: ' +cast(@pendiente as varchar)+
	', Impuesto: '+cast(@monto as varchar)+
	', Total deuda: ' +cast(@Total as varchar)+
	', Estado: '+@estado+
	' y Consumidor: '+@consumidor);
END
GO
 
--Trigger para Eliminar Pago
 
Create TRIGGER tg_EliminarPago
    ON Pagos
    FOR DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id VARCHAR(4), @monto money, @cancelado money, 
	@pendiente money, @impuesto money,@total money, @estado varchar(20), @consumidor varchar(20);

	SELECT @id = i.idPago, 
	@monto = i.monto, 
	@cancelado = i.montoCancelado,
	@pendiente = i.montoPendiente,
	@impuesto = i.impuesto,
	@total = i.montoTotal,
	@estado = c.nombreEstado,
	@consumidor = b.nombresConsumidor 
	FROM deleted i 
	inner join Consumidores b
	on i.idConsumidor_FK = b.idConsumidor
	inner join Estados c
	on i.idEstado_FK = c.idEstado;

	INSERT INTO Sucesos VALUES(GETDATE(), 'Pagos', 'Se ha Eliminado el registro con Id: ' +@id+ 
	', Monto: ' + cast(@monto as varchar)+ 
	', Monto cancelado: ' +cast(@cancelado as varchar)+
	', Monto pendiente: ' +cast(@pendiente as varchar)+
	', Impuesto: '+cast(@monto as varchar)+
	', Total deuda: ' +cast(@Total as varchar)+
	', Estado: '+@estado+
	' y Consumidor: '+@consumidor);
END
GO