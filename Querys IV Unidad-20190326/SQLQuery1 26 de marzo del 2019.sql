

Alter login sa with password = 'grupo2M1'


create procedure Mostrar_Clientes
as
Select
 id_cliente as Id_Cliente,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 tel as Teléfono,
 c.estado as Estado
 from Cliente c

 exec Mostrar_Clientes

 Create procedure Insertar_Cliente
 @primernombre varchar(15),
 @segundonombre varchar(15),
 @primerapellido varchar(15),
 @segundoapellido varchar(15),
 @direccion varchar(90),
 @correo varchar(40),
 @telefono varchar(20),
 @Estado varchar(50)
	as
 insert into Cliente values (@primernombre,@segundonombre,@primerapellido, @segundoapellido,@direccion, @telefono, @correo,@Estado)
 Select * from Cliente

	 Create procedure Editar_Cliente
	 @idcliente int,
	 @primernombre varchar(15),
     @segundonombre varchar(15),
     @primerapellido varchar(15),
     @segundoapellido varchar(15),
	 @direccion varchar(90),
	 @correo varchar(40),
	 @telefono varchar(20),
	 @Estado varchar(50)
	 as
	 update Cliente set 
	 p_nom =  @primernombre,
	 s_nom = @segundonombre,
	 p_apell = @primerapellido,
	 s_apell =  @segundoapellido,
	 direccion = @direccion,
	 correo = @correo,
	 tel = @telefono,
	 estado= @Estado
	 where id_cliente = @idcliente

	 /*
	 buscar registro es buscar un cliente...
	 */
	 create procedure Buscar_Registro
	 @dato varchar(20)
	 as
	 Select
 id_cliente as Id_Cliente,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 tel as Teléfono
 from Cliente c
 where c.p_nom like @dato + '%' 
 or  c.s_nom like @dato + '%' 
 or  c.p_apell like @dato + '%' 
 or c.s_apell like @dato+'%'


 /*
   Agregar el campo estado a la tabla cliente por derfecto todos estaran habilitados
 */

 /*
    Traer el catalogo de habitacion y del huesped 
 */

 alter table cliente 
 add estado varchar(50)

 update cliente set estado='Habilitado'

 create procedure Habilitar
 @IdCliente int,
 @Estado varchar(50)
 as
update cliente set estado=@Estado where id_cliente=@IdCliente

select * from cliente

create procedure Mostrar_Habitaciones
as
select 
  h.no_habitacion,
  th.cod_tipo,
  h.descr,h.cap,h.stat,th.nom_tipo,
  th.precio 
  from habitacion h
  inner join tipo_habitacion th on th.cod_tipo=h.cod_tipo

create procedure Mostrar_Habitación
@IdTipoHabitación int
   as
select 
  h.no_habitacion,
  th.cod_tipo,
  h.descr,h.cap,h.stat,th.nom_tipo,
  th.precio 
  from habitacion h
  inner join tipo_habitacion th on th.cod_tipo=h.cod_tipo
  where th.cod_tipo=@IdTipoHabitación

Mostrar_Habitación 10


select * from habitacion_reserva

select * from huesped
select * from huesped_hab_reserva

select * from cliente

create procedure Mostrar_Huespedes
  as
select * from huesped


Mostrar_Huespedes

 ALTER procedure [dbo].[Habilitar]
 @IdCliente int,
 @Estado varchar(50)
 as
update cliente set estado=@Estado where id_cliente=@IdCliente

ALTER procedure [dbo].[habilitado]
@idCliente int
as
declare @estado varchar(50)
set @estado=(select estado from cliente where id_cliente=@idCliente)
if(@estado='HABILITADO')
  update cliente set estado='DESHABILITADO' where id_cliente=@idCliente
else
   update cliente set estado='HABILITADO' where id_cliente=@idCliente
select * from cliente

ALTER procedure [dbo].[Mostrar_Habitaciones]
as
select 
  h.no_habitacion,
  th.cod_tipo,
  h.descr,h.cap,h.stat,th.nom_tipo,
  th.precio 
  from habitacion h
  inner join tipo_habitacion th on th.cod_tipo=h.cod_tipo

 --========================================================================

create procedure Insertar_Usuario
@login varchar(50),
@password varchar(50),
@rol varchar(50)
 as
insert into dbo.Usuario values(@login,EncryptbyPassPhrase(@password,@password),@rol,1)
go


execute Insertar_Usuario 'ulises','1234','Administrador'
go

execute Rol_Usuario 'ulises','1234'

Create procedure Rol_Usuario
@login varchar(50),
@password varchar(100)
   as
if exists(select login,cast(DECRYPTBYPASSPHRASE(@password,password) as varchar(50)) from Usuario where cast(DECRYPTBYPASSPHRASE(@password,password) as varchar(50))=@password and login=@login)
   begin 
	 select rol from Usuario where cast(DECRYPTBYPASSPHRASE(@password,password) as varchar(50))=@password and login=@login
   end
else
   begin
   select 'Usuario no existe' as rol
   end
go

select * from empleado
select * from cliente

Execute Rol_Usuario 'Luis','1234'
Execute Rol_Usuario 'Kevin','kmcc'
go

create procedure Mostrar_Empleado
as
select * from empleado
go

Execute Mostrar_Empleado

--==========================================================================

select * from reserva

execute Mostrar_Habitaciones

select 
  u.id_Empleado 
  from Usuario u 
  inner join empleado e on u.id_empleado=e.id_empleado
  where u.login='Kevin' and u.password='kmcc'
go

create procedure Validar_Acceso
@login nvarchar(50),
@password nvarchar(100)
   as
select id_Empleado from Usuario where cast(DECRYPTBYPASSPHRASE(@password,password) as varchar(50))=@password and login=@login
go

validar_Acceso 'carlos','kmcc'

Execute Validar_Contraseña 'kevin','kmcc'

select * from reserva
go 

Create  procedure Insertar_Reserva
  @id_cliente int,
  @id_empleado int,
  @forma_pago varchar(15),
  @divisa varchar(8),
  @estado varchar(15)
   as
insert into reserva values (@id_cliente,@id_empleado,GETDATE(),@forma_pago,@divisa,@estado)
go

create procedure Insertar_habitaciónReserva
@no_habitación int,
@id_reserva int,
@fecha_entrada date,
@fecha_salida date
 as
declare @precio money= (select precio 
                    from tipo_habitacion th 
					inner join habitacion h on th.cod_tipo=h.cod_tipo
					where h.no_habitacion=@no_habitación)
Insert into habitacion_reserva values (@no_habitación,@id_reserva,@fecha_entrada,@fecha_entrada,@precio)
go
  

Create procedure Mostrar_Reserva
  as
select * from reserva
go

Mostrar_Reserva

update Usuario set id_Empleado=1 where IdUsuario=2

go 

create procedure get_idCliente
as
select top(1) id_cliente from cliente order by id_cliente desc
go

Execute get_idCliente

Mostrar_clientes

delete from cliente where id_cliente= 2018

go

Create procedure get_idReserva
as
select top(1) id_reserva from reserva order by id_reserva desc
go

Execute get_idReserva

select * from reserva
go
select * from habitacion_reserva

--use hotel;
--create table Usuario
--(
--  IdUsuario int primary key identity(1,1),
--  login varchar(50),
--  password varchar(50),
--  rol varchar(50),
--  idEmplado int foreign key references Empleado(id_empleado)
--)

---=========================================================================


select * from cliente
delete from cliente where id_cliente in(2028,2029,2030)

go

Execute Editar_Cliente 2025,'Luis','Gabriel','Gonzalez','Lopez','De la rocargo','8923892','lgabriel@gmail.com','HABILITADO'

get_idCliente

select * from reserva
delete from reserva where id_cliente in(2027,2028,2030)

get_idReserva

select * from habitacion_reserva
delete from habitacion_reserva where id_reserva=17

--=====

select * from huesped
go

create procedure Insertar_Huesped
@PrimerNombre varchar(50),
@SegundoNombre varchar(50),
@PrimerApellido varchar(50),
@SegundoApellido varchar(50),
@Dirección varchar(100),
@Teléfono varchar(20),
@Nacionalidad varchar(50),
@Correo varchar(100)
  as
Insert into huesped values (@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@Dirección,@Teléfono,@Nacionalidad,@Correo)
go



select h.p_nom+' '+h.s_nom+' '+h.p_apell+' '+h.s_apell from huesped h where 

select * from huesped_hab_reserva

--///////////////////////////////////////////////////


/*Procedimiento almacenado inserción*/



ALter procedure Insertar_Huesped
@PrimerNombre varchar(50),
@SegundoNombre varchar(50),
@PrimerApellido varchar(50),
@SegundoApellido varchar(50),
@Dirección varchar(100),
@telefono varchar(20),
@Nacionalidad varchar(50),
@Correo varchar(100)
  as
Insert into huesped values (@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@Dirección,@telefono,@Nacionalidad,@Correo)

declare @idHuesped int = (select top(1) id_huesped from huesped order by id_huesped desc)

declare @id_Reserva int = (select top(1) id_reserva from reserva order by id_reserva desc)

declare @id_hab_reserva int= (select top(1)id_hab_reserva from habitacion_reserva where id_reserva=@id_Reserva)

Insert into huesped_hab_reserva values(@idHuesped,@id_hab_reserva)
go

--Test--
select * from habitacion_reserva
select * from huesped_hab_reserva

select * from cliente
delete from cliente where id_cliente= 2037
select * from reserva
delete from reserva where id_cliente between 2032 and 2037
select * from habitacion_reserva 
delete from habitacion_reserva where id_reserva between 20 and 25
select * from huesped_hab_reserva 
delete from huesped_hab_reserva where id_huesped between 14 and 15
select * from huesped
delete from huesped where id_huesped between 13 and 18
go


select * from huesped

Insertar_Huesped 'Luis','Gabriel','Gonzalez','Lopez','De la rocargo','90909090','Nicaraguense','gabriel@gmail.com'

go

ALter procedure Mostrar_Huesped_Reservado
@IdReserva int
  as
select 
   h.p_nom+' '+
   h.s_nom+' '+
   h.p_apell+' '+
   h.s_apell as Nombre
   from huesped h 
   inner join huesped_hab_reserva hhr on hhr.id_huesped=h.id_huesped
   inner join habitacion_reserva hr on hr.id_reserva=@IdReserva
go

Exec Mostrar_Huesped_Reservado 6
Exec get_idReserva

select h.p_nom+' '+h.s_nom+' '+h.p_apell+' '+h.s_apell as Nombre from huesped h inner join huesped_hab_reserva hhr on hhr.id_huesped=h.id_huesped inner join habitacion_reserva hr on hr.id_reserva= 6@IdReserva