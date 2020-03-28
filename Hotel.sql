create database Hotel
go
use Hotel
go
--creacion de tablas
create table Tipo_habitacion(
	cod_tipo integer primary key,
	nom_tipo varchar(25) not null,
	precio money not null
);

create table Habitacion(
	no_habitacion integer primary key,
	cod_tipo integer foreign key references tipo_habitacion(cod_tipo),
	descr varchar(60),
	cap integer not null,
	stat varchar(15)
);

alter table Habitacion
add constraint [CK_VAL_hab_stat] check(stat in('OCUPADA', 'RESERVADA', 'DISPONIBLE'));

create table Cliente(
	Id_cliente integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	correo varchar(25),
	estado varchar(50)
);

create table Empleado(
	Id_empleado integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	correo varchar(25)
);

create table Reserva(
	Id_reserva integer primary key identity(1,1),
	Id_cliente integer foreign key references cliente(id_cliente),
	Id_empleado integer foreign key references empleado(id_empleado),
	fecha_reserva date not null,
	forma_pago varchar(15),
	divisa varchar(3), 
	stat varchar(15)
);

alter table Reserva
add constraint [CK_VAL_res_stat] check(stat in('PAGADO', 'RESERVADO', 'CANCELADO', 'PENALIZADO'));
alter table reserva
add constraint [CK_VAL_res_formapago] check(forma_pago in('CREDITO', 'CONTADO', 'CHEQUE'));

create table Habitacion_Reserva(
	Id_hab_reserva integer primary key identity(1,1),
	no_habitacion integer foreign key references habitacion(no_habitacion),
	id_reserva integer foreign key references reserva(id_reserva),
	fecha_entrada date not null,
	fecha_salida date not null, 
	precio money
);

create table Huesped(
	Id_huesped integer primary key identity(1,1),
	p_nom varchar(15),
	s_nom varchar(15),
	p_apell varchar(15),
	s_apell varchar(15),
	direccion varchar(70),
	tel varchar(10),
	nacionalidad varchar(25),
	correo varchar(25)
);

create table Huesped_hab_reserva(
	Id_huesped int foreign key references huesped(id_huesped) not null,
	Id_hab_reserva int foreign key references habitacion_reserva(id_hab_reserva) not null
);

alter table Huesped_hab_reserva
add primary key(Id_huesped, Id_hab_reserva);

create table Servicio(
	Id_servicio integer primary key identity(1,1),
	descr varchar(60),
	precio money
);

create table Cargos_servicios(
	Id_servicio int foreign key references servicio(id_servicio) not null,
	Id_hab_reserva int foreign key references habitacion_reserva(id_hab_reserva) not null,
	precio money
);
alter table Cargos_servicios
add primary key(Id_servicio, Id_hab_reserva);


insert into Cliente values('Juan', 'Jose', 'Lopez', 'Mendoza', '12565 Reghan St.', '0051414899', 'juanlopez@aol.com','HABILITADO');
insert into Cliente values('Maria', 'Alejandra', 'Jerez', 'Mendez', '564 Union Av.', '0088947476', 'marjerez@hotmail.com','HABILITADO');
insert into Cliente values('Pepito', 'Jaime', 'Perez', 'Garcia', '7848 Longhorn & Vista Rd.', '7894514899', 'peperez@aol.com','HABILITADO');
insert into Cliente values('Vanessa', 'Lucia', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893', 'lucia_mejia15@yahoo.com','HABILITADO');
insert into Cliente values('Ana', 'Conda', 'Juarez', 'Soza', '141 Union Rd.', '7894514799', 'anaconda@yahoo.com','HABILITADO');

insert into Empleado values('Mario', 'Alberto', 'Roa', 'Carrion', '12569 Reghan St.', '0051488772', 'maalroca@gmail.com');
insert into Empleado values('Maria', 'Alejandra', 'Garcia', 'Jiron', '12560 Vinerod St.', '0052218772', 'maalegaji@gmail.com');
insert into Empleado values('Carlos', 'Jesus', 'Joya', 'Lola', '4474 Fines Av.', '0051278457', 'quejoyonpapa@gmail.com');

insert into Tipo_habitacion values(10, 'Basica', 150);
insert into Tipo_habitacion values(11, 'Ejecutiva', 200);
insert into Tipo_habitacion values(12, 'Presidencial', 500);

insert into Habitacion values(1, 10, 'Ninguna descripcion', 2, 'DISPONIBLE');
insert into Habitacion values(2, 11, 'Ninguna descripcion', 4, 'OCUPADA');
insert into Habitacion values(3, 10, 'Ninguna descripcion', 2, 'RESERVADA');
insert into Habitacion values(4, 12, 'Ninguna descripcion', 4, 'OCUPADA');
insert into Habitacion values(5, 10, 'Ninguna descripcion', 2, 'OCUPADA');
insert into Habitacion values(6, 11, 'Ninguna descripcion', 4, 'RESERVADA');
insert into Habitacion values(7, 11, 'Ninguna descripcion', 4, 'DISPONIBLE');
insert into Habitacion values(8, 12, 'Ninguna descripcion', 4, 'RESERVADA');
insert into Habitacion values(9, 10, 'Ninguna descripcion', 2, 'RESERVADA');
insert into Habitacion values(10, 12, 'Ninguna descripcion', 4, 'RESERVADA');

insert into Reserva values(1, 1, '20190215', 'CONTADO', 'NIO', 'PAGADO');
insert into Reserva values(2, 1, '20190228', 'CREDITO', 'USD', 'RESERVADO');
insert into Reserva values(3, 2, '20190201', 'CHEQUE', 'USD', 'PENALIZADO');
insert into Reserva values(4, 3, '20190302', 'CONTADO', 'EUR', 'CANCELADO');
insert into Reserva values(5, 2, '20190311', 'CREDITO', 'USD', 'RESERVADO');
insert into Reserva values(1, 3, '20190317', 'CONTADO', 'NIO', 'RESERVADO');

insert into Habitacion_Reserva values(4,1,'20190312', '20190318', 500);
insert into Habitacion_Reserva values(2,1,'20190312', '20190318', 200);
insert into Habitacion_Reserva values(3,2,'20190318', '20190320', 100);
insert into Habitacion_Reserva values(5,3,'20190310', '20190318',100);
insert into Habitacion_Reserva values(6,4,'20190320', '20190325',200);
insert into Habitacion_Reserva values(8,4,'20190320', '20190325',500);
insert into Habitacion_Reserva values(9,5,'20190319', '20190323',100);
insert into Habitacion_Reserva values(10,6,'20190318', '20190321',500);

insert into Servicio values('Desayuno al cuarto', 60);
insert into Servicio values('Almuerzo al cuarto', 70);
insert into Servicio values('Lavado de ropa', 40);
insert into Servicio values('Bebidas alcoholicas', 50);
insert into Servicio values('Internet dedicado', 30);

insert into Huesped values('Juan', 'Jose', 'Lopez', 'Mendoza', '12565 Reghan St.', '0051414899','Nicaraguense', 'juanlopez@aol.com');
insert into Huesped values('Maria', 'Alejandra', 'Jerez', 'Mendez', '564 Union Av.', '0088947476','Mexicano', 'marjerez@hotmail.com');
insert into Huesped values('Pepito', 'Jaime', 'Perez', 'Garcia', '7848 Longhorn & Vista Rd.', '7894514899','Hondureño', 'peperez@aol.com');
insert into Huesped values('Vanessa', 'Lucia', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893','Español', 'lucia_mejia15@yahoo.com');
insert into Huesped values('Ana', 'Conda', 'Juarez', 'Soza', '141 Union Rd.', '7894514799','Costarricense', 'anaconda@yahoo.com');
insert into Huesped values('Juan', 'Alberto', 'Lopez', 'Gasca', '12565 Reghan St.', '0051414899','Nicaraguense', 'juancho@aol.com');
insert into Huesped values('Guadalupe', 'Sofia', 'Gutierrez', 'Mendez', '564 Union Av.', '0088947476','Nicaraguense', 'exempl@gmail.com');
insert into Huesped values('Jose', 'Roberto', 'Norori', 'Guillen', '7848 Longhorn & Vista Rd.', '7894514899','Nicaraguense', 'joseguillen@hotmail.com');
insert into Huesped values('Hellen', 'del Carmen', 'Mejia', 'Avendaño', '5567 Calle 8.', '1526047893','Español', 'carmelaxd@live.com');
insert into Huesped values('Julia', 'del Socorro', 'Juarez', 'Soza', '141 Union Rd.', '7894514799','Americano', 'julitasalvame@outlook.com');



insert into Cargos_servicios values(1,1,60);
insert into Cargos_servicios values(3,1,40);
insert into Cargos_servicios values(5,2,30);


alter table Cliente
add constraint [CK_VAL_clie_estado] check(estado in('HABILITADO','DESHABILITADO'));
go

create procedure habilitado
@habilitar varchar(50),
@idCliente int 
as
update Cliente set estado=@habilitar where Id_cliente=@idCliente
go

select * from cliente
