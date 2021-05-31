-- Procedimiento para mostrar los ultimos 5 Consumidores
use ACAPOLAMI;
CREATE PROC sp_UltimosConsumidores
AS
BEGIN
	SELECT top 5 CONCAT_WS(' ', a.nombresConsumidor, a.apellidosConsumidor) AS 'Nombre Completo', 
	a.numeroDocumento AS 'DUI', b.nombreComunidad as 'Comunidad'
	FROM Consumidores AS a
	inner join Comunidades b ON a.idComunidad_FK = b.idComunidad
	ORDER BY idConsumidor DESC;
END
Go
EXEC sp_UltimosConsumidores
GO

-- Procedimiento para mostrar los ultimos 5 Pagos
CREATE PROC sp_UltimosPagos
AS
BEGIN
	SELECT top 5 a.monto AS 'Monto', a.montoCancelado AS 'Monto a Cancelado', 
	a.impuesto AS 'Impuesto', a.montoTotal AS 'Total Deuda', a.fechaPago AS 'Fecha', 
	CONCAT_WS(' ', b.nombresConsumidor, b.apellidosConsumidor) AS 'Nombre Completo',
	c.nombreEstado
	from Pagos a
	inner join Consumidores b ON b.idConsumidor = a.idConsumidor_FK
	inner join Estados c ON c.idEstado = a.idEstado_FK
	ORDER BY idConsumidor DESC;
END
GO
EXEC sp_UltimosPagos