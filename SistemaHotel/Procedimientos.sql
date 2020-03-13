

use hotel;
create table Usuario
(
  IdUsuario int primary key identity(1,1),
  login varchar(50),
  password varchar(50),
  rol varchar(50),
  IdEmpleado int foreign key references Empleado(Id_empleado)
)
GO


Create procedure [dbo].[Buscar_Empleado]
	 @dato varchar(20)
	 as
	 Select
 c.Id_empleado as Id_Empleado,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 tel as Teléfono
 from Empleado c
 where c.p_nom like @dato + '%' 
 or  c.s_nom like @dato + '%' 
 or  c.p_apell like @dato + '%' 
 or c.s_apell like @dato+'%'

 go
 --


Create procedure [dbo].[Buscar_Registro]
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

go
--


Create procedure [dbo].[Disponibilidad_Habitación] 
@IdHabitación int, @Fechaentrada date, @Fechasalida date
as

Create table #TFecha 
(IdTFecha int primary key identity(1,1),
 Fecha date,
 Estado varchar(60))

  Declare @Contador int, @Fecha date, @Días int
 Set @Contador = 1
 set @Fecha = @Fechaentrada
 Set @Días = datediff(day,@Fechaentrada, @Fechasalida)
 while (@Contador <= (datediff(day,@Fechaentrada, @Fechasalida)+1))
 begin
 insert into #TFecha (Fecha) values (@Fecha)
 set @Fecha = dateadd(day,1, @Fecha )
 Set @Contador = @Contador +1 
 end

 Set @Contador = 1

while(@Contador <= ((Select count(*) from #TFecha)) )
begin
set @Fecha = (Select Fecha from #TFecha where IdTFecha = @Contador)
if not exists(Select * from Habitacion_Reserva hr
              where @Fecha >= hr.fecha_entrada and @Fecha < hr.fecha_salida
			  and hr.no_habitacion = @IdHabitación
			   )
			   begin
	          update #TFecha set Estado = 'Disponible' 
	          where IdTFecha = @Contador
	          end
			  else
			  begin
			  update #TFecha set Estado = 'Reservado' 
	          where IdTFecha = @Contador
			  end

			 
			  if(@Contador = (Select count(*) from #TFecha))
			    begin
			  update #TFecha set Estado = 'Salida' 
	          where IdTFecha = @Contador
			  end
			   Set @Contador = @Contador +1
			  

end

Select * from #TFecha
Drop table #TFecha

go


-----------------------------------

Create procedure [dbo].[Editar_Cliente]
	 @idcliente int,
	 @primernombre varchar(50),
     @segundonombre varchar(50),
     @primerapellido varchar(50),
     @segundoapellido varchar(50),
	 @direccion varchar(100),
	 @telefono varchar(20),
	 @correo varchar(100),
	 @Estado varchar(50)
	 as
	 update Cliente set 
	 p_nom =  @primernombre,
	 s_nom = @segundonombre,
	 p_apell = @primerapellido,
	 s_apell =  @segundoapellido,
	 direccion = @direccion,
	 tel = @telefono,
	 correo = @correo,
	 estado= @Estado
	 where Id_cliente = @idcliente
go

------------------------------------

Create procedure [dbo].[Editar_Empleado]
	 @idempleado int,
	 @primernombre varchar(15),
     @segundonombre varchar(15),
     @primerapellido varchar(15),
     @segundoapellido varchar(15),
	 @direccion varchar(90),
	 @correo varchar(40),
	 @telefono varchar(20)
as
	 update Empleado set 
	 p_nom =  @primernombre,
	 s_nom = @segundonombre,
	 p_apell = @primerapellido,
	 s_apell =  @segundoapellido,
	 direccion = @direccion,
	 correo = @correo,
	 tel = @telefono
	 where Id_empleado = @idempleado
go
--------------------------------------

Create procedure [dbo].[Estado_Habitacion] @fechaentrada date, @fechasalida date
as
Select 
   h.no_habitacion,
   th.nom_tipo, 
   dbo.Determina_Estado(h.no_habitacion,@fechaentrada, @fechasalida) as Estado 
   from Habitacion h inner join tipo_habitacion th on th.cod_tipo=h.cod_tipo
go
---------------------------------------------


Create procedure [dbo].[get_idCliente]
as
select top(1) Id_cliente from cliente order by id_cliente desc
go

--------------------------------------------------

Create procedure [dbo].[get_idReserva]
as
select top(1) id_reserva from reserva order by id_reserva desc
go

-----------------------------------------------

Create procedure [dbo].[habilitado]
@idCliente int
as
declare @estado varchar(50)
set @estado=(select estado from cliente where id_cliente=@idCliente)
if(@estado='HABILITADO')
  update cliente set estado='DESHABILITADO' where id_cliente=@idCliente
else
   update cliente set estado='HABILITADO' where id_cliente=@idCliente
select * from cliente

go
-----------------------------------------------

 Create procedure [dbo].[Habilitar]
 @IdCliente int,
 @Estado varchar(50)
 as
update cliente set estado=@Estado where id_cliente=@IdCliente

go

---------------------------------------------------------------

 Create procedure [dbo].[Insertar_Cliente]
 @primernombre varchar(15),
 @segundonombre varchar(15),
 @primerapellido varchar(15),
 @segundoapellido varchar(15),
 @direccion varchar(90),
 @correo varchar(40),
 @telefono varchar(20)
	as
 insert into Cliente values (@primernombre,@segundonombre,@primerapellido, @segundoapellido,@direccion, @telefono, @correo,'HABILITADO')
 Select * from Cliente

 go

 ----------------------------------------------------------

 Create procedure [dbo].[Insertar_Empleado]
 @primernombre varchar(15),
 @segundonombre varchar(15),
 @primerapellido varchar(15),
 @segundoapellido varchar(15),
 @direccion varchar(90),
 @correo varchar(40),
 @telefono varchar(20)
	as
 insert into empleado values (@primernombre,@segundonombre,@primerapellido, @segundoapellido,@direccion,@correo,@telefono)
 Select * from empleado

 go

 ------------------------------------------------------------

Create procedure [dbo].[Insertar_habitaciónReserva]
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
-------------------------
Create procedure Insertar_Huesped
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

----------------------------------------------------------

Create procedure [dbo].[Insertar_Reserva]
  @id_cliente int,
  @id_empleado int,
  @forma_pago varchar(15),
  @divisa varchar(8),
  @estado varchar(15)
   as
insert into reserva values (@id_cliente,@id_empleado,GETDATE(),@forma_pago,@divisa,@estado)

go

---------------------------------------------------------

Create procedure [dbo].[Insertar_Usuario]
@login varchar(50),
@password varchar(50),
@rol varchar(50)
 as
insert into Usuario values(@login,EncryptbyPassPhrase(@password,@password),@rol)


go

------------------------------------------------------------

Create procedure [dbo].[Mostrar_Clientes]
as
Select
 c.Id_cliente as Id_Cliente,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 tel as Teléfono,
 estado as Estado
 from Cliente c

 go

 ------------------------------------------------------------



Create procedure [dbo].[Mostrar_Empleado]
as
select * from empleado

go 

------------------------------------------------------------


Create procedure [dbo].[Mostrar_Habitación]
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

  go

  ----------------------------------------------------------

  Create procedure [dbo].[Mostrar_Habitaciones]
as
select 
  h.no_habitacion,
  th.cod_tipo,
  h.descr,h.cap,h.stat,th.nom_tipo,
  th.precio 
  from habitacion h
  inner join tipo_habitacion th on th.cod_tipo=h.cod_tipo

  go

  ----------------------------------------------------------

  Create procedure [dbo].[Mostrar_Huespedes]
  as
select * from huesped

go
--------------------------------------------------

Create procedure Mostrar_Huesped_Reservado
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
------------------------------------------------

Create procedure [dbo].[Mostrar_Reserva]
  as
select * from reserva
go

------------------------------------------------------

Create procedure [dbo].[Rol_Usuario]
@login varchar(50),
@password varchar(100)
   as
if exists(select login,password from Usuario where password=@password and login=@login)
   begin 
	 select rol from Usuario where password=@password and login=@login
   end
else
   begin
   select 'Usuario no existe' as rol
   end
go

---------------------------------------------------------


Create procedure [dbo].[Validar_Acceso]
@login nvarchar(50),
@password nvarchar(100)
   as
select IdEmplado from Usuario where password=@password and login=@login
go

--Create procedure [dbo].[Validar_Acceso]
--@login nvarchar(50),
--@password nvarchar(100)
--   as
--select IdEmplado from Usuario where cast(DECRYPTBYPASSPHRASE(@password,password) as varchar(50))=@password and login=@login
--go

CREATE PROCEDURE CONSULTAR_LISTA_HR_SERVICIO
AS
SELECT HR.id_hab_reserva,p_nom+SPACE(1)+C.p_apell,HR.no_habitacion,HR.fecha_entrada,HR.fecha_salida
FROM habitacion_reserva HR
INNER JOIN reserva R
ON R.id_reserva = HR.id_reserva
INNER JOIN cliente C
ON C.id_cliente = R.id_cliente
GROUP BY HR.id_hab_reserva,p_nom+SPACE(1)+C.p_apell,HR.no_habitacion,HR.fecha_entrada,HR.fecha_salida
go
---------------------------------

EXEC CONSULTAR_LISTA_HR_SERVICIO
----------------------------------
GO
Create PROCEDURE LISTAR_SERVICIOS
AS
SELECT s.id_servicio FROM servicio s
----------------------------------

EXEC LISTAR_SERVICIOS

---------------------------------
GO
CREATE PROCEDURE INSERTAR_CONSUMO_SERVICIO
@IDHR INT,
@IDS INT,
@PRECIO MONEY
AS
INSERT INTO cargos_servicios VALUES(@IDS,@IDHR,@PRECIO)

select * from cargos_servicios
go

create procedure ListaServicio
as
select descr from servicio
go

execute dbo.Mostrar_Huesped_Reservado 2

select * from cargos_servicios
select * from cliente
select * from empleado
select * from habitacion
select * from habitacion_reserva

select * from Empleado
select * from Usuario

insert into Usuario values('Luis','1234','Admin',1)

update Usuario set rol = 'Administrador' where IdUsuario = 1