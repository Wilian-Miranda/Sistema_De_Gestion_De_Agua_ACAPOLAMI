CREATE proc sp_obtenerMontoCanceladoMeses
@year as varchar(10)

AS
BEGIN
	SET NOCOUNT ON;
	SELECT DATENAME (MONTH, DATEADD(MONTH, MONTH(a.fechaPago) - 1, min(@year))) Mes, 
	SUM(a.montoCancelado) [Total cancelado]
	FROM dbo.Pagos a
	where fechaPago >= '2021' and year(fechaPago) = @year
	GROUP BY MONTH(fechaPago)
END

EXEC sp_obtenerMontoCanceladoMeses '2021'