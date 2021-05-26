-- Procedimiento para Mostrar Consumidores por Comunidad

Create PROC sp_ConsumidoresPorComunidad
AS
BEGIN
	SET NOCOUNT ON;
	SELECT b.nombreComunidad as 'Comunidad',  Count(a.idConsumidor) as 'Total Consumidores' FROM Consumidores a
	inner join Comunidades b
	on a.idComunidad_FK = b.idComunidad
	group by b.nombreComunidad;
END
go

Exec sp_ConsumidoresPorComunidad