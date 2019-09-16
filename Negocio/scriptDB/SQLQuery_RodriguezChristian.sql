create database Articulos_DB_RodriguezChristian
go
use Articulos_DB_RodriguezChristian
go
create table Marcas (
id int primary key identity,
descripcion varchar(50) not null
)
go
create table Categorias (
id int primary key identity,
descripcion varchar(50) not null
)
go
create table Articulos (
id int primary key identity,
codigo int not null ,
nombre varchar(50) not null,
descripcion varchar(50),
idMarca int foreign key references Marcas(id),
idCategoria int foreign key references Categorias(id),
precio money
)
go
insert into Marcas(descripcion) values ('HP')
go
insert into Marcas(descripcion) values ('DELL')
go
insert into Marcas(descripcion) values ('Samsung')
go
insert into Marcas(descripcion) values ('Stanley')
go
insert into Categorias(descripcion) values ('Computadoras')
go
insert into Categorias(descripcion) values ('Televisores')
go
insert into Categorias(descripcion) values ('Termos')
go
insert into Articulos(codigo,nombre,descripcion,idMarca,idCategoria,precio) values (5,'Notebook i3','Lenta',1,1,1000)
go
insert into Articulos(codigo,nombre,descripcion,idMarca,idCategoria,precio) values (70,'Desktop i7','Rapida',2,1,10000)
go
insert into Articulos(codigo,nombre,descripcion,idMarca,idCategoria,precio) values (80,'Stanley i7','Eficiente',4,3,100)
