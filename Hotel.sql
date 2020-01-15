use master
drop database Hotel
go

create database Hotel
go
use Hotel
go
--creacion de tablas
create table tipo_habitacion(
	cod_tipo integer primary key,
	nom_tipo varchar(25) not null,
	precio money not null
);

create table habitacion(
	no_habitacion integer primary key,
	cod_tipo integer foreign key references tipo_habitacion(cod_tipo),
	descr varchar(60),
	cap integer not null,
	stat varchar(15)
);

alter table habitacion
add constraint [CK_VAL_hab_stat] check(stat in('OCUPADA', 'RESERVADA', 'DISPONIBLE'));

create table cliente(
	id_cliente integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	correo varchar(25)
);

create table empleado(
	id_empleado integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	correo varchar(25)
);

create table reserva(
	id_reserva integer primary key identity(1,1),
	id_cliente integer foreign key references cliente(id_cliente),
	id_empleado integer foreign key references empleado(id_empleado),
	fecha_reserva date not null,
	forma_pago varchar(15),
	divisa varchar(3), 
	stat varchar(15)
);

alter table reserva
add constraint [CK_VAL_res_stat] check(stat in('PAGADO', 'RESERVADO', 'CANCELADO', 'PENALIZADO'));
alter table reserva
add constraint [CK_VAL_res_formapago] check(forma_pago in('CREDITO', 'CONTADO', 'CHEQUE'));

create table habitacion_reserva(
	id_hab_reserva integer primary key identity(1,1),
	no_habitacion integer foreign key references habitacion(no_habitacion),
	id_reserva integer foreign key references reserva(id_reserva),
	fecha_entrada date not null,
	fecha_salida date not null, 
	precio money
);

create table huesped(
	id_huesped integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	nacionalidad varchar(25),
	correo varchar(25)
);

create table huesped_hab_reserva(
	id_huesped int foreign key references huesped(id_huesped) not null,
	id_hab_reserva int foreign key references habitacion_reserva(id_hab_reserva) not null
);

alter table huesped_hab_reserva
add primary key(id_huesped, id_hab_reserva);

create table servicio(
	id_servicio integer primary key identity(1,1),
	descr varchar(60),
	precio money
);

create table cargos_servicios(
	id_servicio int foreign key references servicio(id_servicio) not null,
	id_hab_reserva int foreign key references habitacion_reserva(id_hab_reserva) not null,
	precio money
);
alter table cargos_servicios
add primary key(id_servicio, id_hab_reserva);


insert into cliente values('Juan', 'Jose', 'Lopez', 'Mendoza', '12565 Reghan St.', '0051414899', 'juanlopez@aol.com');
insert into cliente values('Maria', 'Alejandra', 'Jerez', 'Mendez', '564 Union Av.', '0088947476', 'marjerez@hotmail.com');
insert into cliente values('Pepito', 'Jaime', 'Perez', 'Garcia', '7848 Longhorn & Vista Rd.', '7894514899', 'peperez@aol.com');
insert into cliente values('Vanessa', 'Lucia', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893', 'lucia_mejia15@yahoo.com');
insert into cliente values('Ana', 'Conda', 'Juarez', 'Soza', '141 Union Rd.', '7894514799', 'anaconda@yahoo.com');

insert into empleado values('Mario', 'Alberto', 'Roa', 'Carrion', '12569 Reghan St.', '0051488772', 'maalroca@gmail.com');
insert into empleado values('Maria', 'Alejandra', 'Garcia', 'Jiron', '12560 Vinerod St.', '0052218772', 'maalegaji@gmail.com');
insert into empleado values('Carlos', 'Jesus', 'Joya', 'Lola', '4474 Fines Av.', '0051278457', 'quejoyonpapa@gmail.com');

insert into tipo_habitacion values(10, 'Basica', 150);
insert into tipo_habitacion values(11, 'Ejecutiva', 200);
insert into tipo_habitacion values(12, 'Presidencial', 500);

insert into habitacion values(1, 10, 'Ninguna descripcion', 2, 'DISPONIBLE');
insert into habitacion values(2, 11, 'Ninguna descripcion', 4, 'OCUPADA');
insert into habitacion values(3, 10, 'Ninguna descripcion', 2, 'RESERVADA');
insert into habitacion values(4, 12, 'Ninguna descripcion', 4, 'OCUPADA');
insert into habitacion values(5, 10, 'Ninguna descripcion', 2, 'OCUPADA');
insert into habitacion values(6, 11, 'Ninguna descripcion', 4, 'RESERVADA');
insert into habitacion values(7, 11, 'Ninguna descripcion', 4, 'DISPONIBLE');
insert into habitacion values(8, 12, 'Ninguna descripcion', 4, 'RESERVADA');
insert into habitacion values(9, 10, 'Ninguna descripcion', 2, 'RESERVADA');
insert into habitacion values(10, 12, 'Ninguna descripcion', 4, 'RESERVADA');

insert into reserva values(1, 1, '20190215', 'CONTADO', 'NIO', 'PAGADO');
insert into reserva values(2, 1, '20190228', 'CREDITO', 'USD', 'RESERVADO');
insert into reserva values(3, 2, '20190201', 'CHEQUE', 'USD', 'PENALIZADO');
insert into reserva values(4, 3, '20190302', 'CONTADO', 'EUR', 'CANCELADO');
insert into reserva values(5, 2, '20190311', 'CREDITO', 'USD', 'RESERVADO');
insert into reserva values(1, 3, '20190317', 'CONTADO', 'NIO', 'RESERVADO');

insert into habitacion_reserva values(4,1,'20190312', '20190318', 500);
insert into habitacion_reserva values(2,1,'20190312', '20190318', 200);
insert into habitacion_reserva values(3,2,'20190318', '20190320', 100);
insert into habitacion_reserva values(5,3,'20190310', '20190318',100);
insert into habitacion_reserva values(6,4,'20190320', '20190325',200);
insert into habitacion_reserva values(8,4,'20190320', '20190325',500);
insert into habitacion_reserva values(9,5,'20190319', '20190323',100);
insert into habitacion_reserva values(10,6,'20190318', '20190321',500);

insert into servicio values('Desayuno al cuarto', 60);
insert into servicio values('Almuerzo al cuarto', 70);
insert into servicio values('Lavado de ropa', 40);
insert into servicio values('Bebidas alcoholicas', 50);
insert into servicio values('Internet dedicado', 30);

insert into huesped values('Juan', 'Jose', 'Lopez', 'Mendoza', '12565 Reghan St.', '0051414899','Nicaraguense', 'juanlopez@aol.com');
insert into huesped values('Maria', 'Alejandra', 'Jerez', 'Mendez', '564 Union Av.', '0088947476','Mexicano', 'marjerez@hotmail.com');
insert into huesped values('Pepito', 'Jaime', 'Perez', 'Garcia', '7848 Longhorn & Vista Rd.', '7894514899','Hondureño', 'peperez@aol.com');
insert into huesped values('Vanessa', 'Lucia', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893','Español', 'lucia_mejia15@yahoo.com');
insert into huesped values('Ana', 'Conda', 'Juarez', 'Soza', '141 Union Rd.', '7894514799','Costarricense', 'anaconda@yahoo.com');
insert into huesped values('Juan', 'Alberto', 'Lopez', 'Gasca', '12565 Reghan St.', '0051414899','Nicaraguense', 'juancho@aol.com');
insert into huesped values('Guadalupe', 'Sofia', 'Gutierrez', 'Mendez', '564 Union Av.', '0088947476','Nicaraguense', 'exempl@gmail.com');
insert into huesped values('Jose', 'Roberto', 'Norori', 'Guillen', '7848 Longhorn & Vista Rd.', '7894514899','Nicaraguense', 'joseguillen@hotmail.com');
insert into huesped values('Hellen', 'del Carmen', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893','Español', 'carmelaxd@live.com');
insert into huesped values('Julia', 'del Socorro', 'Juarez', 'Soza', '141 Union Rd.', '7894514799','Americano', 'julitasalvame@outlook.com');

select * from habitacion_reserva;
select * from servicio;
insert into cargos_servicios values(1,1,60);
insert into cargos_servicios values(3,1,40);
insert into cargos_servicios values(5,2,30);


alter table cliente
add constraint [CK_VAL_clie_estado] check(estado in('HABILITADO','DESHABILITADO'));


alter login sa with password='grupo2M2'

create procedure habilitado
@habilitar varchar(50),
@idCliente int 
as
update cliente set estado=@habilitar where id_cliente=@idCliente
go

select * from cliente


create procedure Disponibilidad_Habitacion
@idHabitacion int,
@FechaEntrada date,
@FechaSalida date
  as
select 
   h.no_habitacion,descr,cap,stat,
   fecha_entrada,
   fecha_salida,precio
    from habitacion h inner join habitacion_reserva hr on hr.no_habitacion=h.no_habitacion
	where h.no_habitacion=@idHabitacion and fecha_entrada>=@FechaEntrada and fecha_salida<=@FechaSalida

execute Disponibilidad_Habitacion 1,'2019-03-18','2019-03-20'

create procedure mostrar_idHabitacion
as
select no_habitacion from habitacion

mostrar_idHabitacion
/*
  Agregar una ventana llamada disponibilidad de habitacionses

  numeros de habitacion,la fecha de entrada,fecha de salida

  agregar reservas y ejercicio 2 y 3
*/

use Hotel;

create login AccesoSistema with password = 'sistemasuni'

sp_adduser AccesoSistema,acceso
grant execute on Validar_Contraseña to acceso

