--**********************************************************
-- Trigger para hacer calculos

Create TRIGGER tg_CalculoPagos
   ON  Pagos
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @estado varchar(4), @id int, @consumidor int, 
	@pendiente money, @monto money, @cancelado money;

	select @id=i.idPago,
	@monto=i.monto,
	@consumidor = i.idConsumidor_FK,
	@estado = i.idEstado_FK,
	@cancelado = i.montoCancelado 
	from inserted i;

	if @estado = 2
	BEGIN
		Declare @deuda money;

		With TotalDeuda as 
		(
		SELECT montoTotal, idPago,  
		ROW_NUMBER() OVER (ORDER BY idPago
		desc
		) AS fila FROM Pagos) 
		
		Select @deuda = montoTotal From TotalDeuda where fila = 2;
		Select @pendiente = 0;

		SET @pendiente = @pendiente + @deuda;

		EXEC sp_CalcularPagos @id, @monto, @pendiente, @cancelado
	END

	else
	BEGIN
		Select @pendiente = 0;
		EXEC sp_CalcularPagos @id, @monto, @pendiente, @cancelado
	END
END
GO

--*******************************************

CREATE Proc sp_CalcularPagos
@id int,
@monto money,
@pendiente money,
@cancelado money
as
begin 
	SET NOCOUNT ON;
	Declare @impuesto money;
	Declare @total money;

	Select @impuesto = dbo.fn_CalcularImpuesto(@pendiente);
	Select @total = dbo.fn_CalcularMontoTotal(@monto, @pendiente, @impuesto, @cancelado);
	
	Update Pagos set impuesto = @impuesto, 
	montoPendiente =  @pendiente, 
	montoTotal = @total

	where idPago = @id
end

Exec sp_CalcularPago 31, 2, 2, 0
--*********************************

--------------------------------------------------------------------------------------------

-- Funcion para calcular Impuesto

CREATE FUNCTION fn_CalcularImpuesto
(
@pendiente money
)
RETURNS money
AS
BEGIN
DECLARE @impuesto money

SELECT @impuesto = cast((@pendiente)*0.10 as money)

RETURN @impuesto
END

select dbo.fn_CalcularImpuesto(4)

--------------------------------------------------------------------------------------------

-- Funcion para calcular montoTotal
CREATE FUNCTION fn_CalcularMontoTotal
(
@monto money,
@pendiente money,
@impuesto money,
@cancelado money
)
RETURNS money
AS
BEGIN
DECLARE @total money

SELECT @total = cast(@monto + @pendiente + @impuesto - @cancelado as money)

RETURN @total
END

select dbo.fn_CalcularMontoTotal(2, 2, 0)