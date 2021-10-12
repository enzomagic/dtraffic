create database DBPTI
go

use DBPTI
go

create table usuarios
(
id varchar(5),
nombre varchar(20),
apellidos varchar(50),
departamento varchar(5),
patente varchar(10),
telefono int
);
go

create proc sp_listar_usuarios
as
select * from usuarios order by id
go

create proc sp_mantenimiento_usuarios
@id varchar(5),
@nombre varchar(20),
@apellidos varchar(50),
@departamento varchar(5),
@patente varchar(10),
@telefono int,
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @idnuevo varchar(5), @idmax varchar(5)
	set @idmax = (select max(id) from usuarios)
	set @idmax = isnull(@idmax,'A0001')
	set @idnuevo = 'A'+RIGHT(RIGHT(@idmax,4)+10001,4)
	insert into usuarios(id,nombre,apellidos,departamento,patente,telefono)
	values(@idnuevo,@nombre,@apellidos,@departamento,@patente,@telefono)
	set @accion= 'Se genero el id: ' +@idnuevo
end
else if (@accion='2')
begin
	update usuarios set nombre=@nombre, apellidos=@apellidos, departamento=@departamento, patente=@patente, telefono=@telefono where id=@id
	set @accion= 'Se modifico id: ' +@id
end
else if (@accion= '3')
begin
	delete from usuarios where id=@id
	set @accion= 'Se borro el id: ' +@id
end
go