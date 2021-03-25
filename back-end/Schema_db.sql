create database green_leavas_db

use green_leavas_db
go

create table usuarios(
id int not null primary key identity(1,1),
nombre varchar(50) not null,
email varchar(50) not null,
telefono varchar(50) not null,
fecha date not null,
ciudad varchar(100) not null
);
go
