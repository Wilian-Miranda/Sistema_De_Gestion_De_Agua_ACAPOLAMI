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
VALUES(2, 0, 0, getdate(), 0, 1, 1), (2, 0, 0, getdate(), 0, 2, 2), (2, 0, 0, getdate(), 0, 2, 3);
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Usuarios VALUES ('Manuel', 'frifayer12', 'admin');
go
--SELECTs
go
--SELECT * FROM Comunidades
--SELECT * FROM Consumidores
--SELECT * FROM Estados
--SELECT * FROM Pagos
--SELECT * FROM Usuarios