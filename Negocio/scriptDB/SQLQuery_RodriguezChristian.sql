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
codigo varchar(50) not null ,
nombre varchar(50) not null,
descripcion varchar(50),
linkurl varchar(700),
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
insert into Articulos(codigo,nombre,descripcion,linkurl,idMarca,idCategoria,precio) values (5,'Notebook i3','Lenta','https://http2.mlstatic.com/notebook-hp-240-g6-intel-dual-core-4gb-500gb-14-gtia-mexx-D_NQ_NP_983423-MLA25627143558_052017-Q.jpg',1,1,1000)
go
insert into Articulos(codigo,nombre,descripcion,linkurl,idMarca,idCategoria,precio) values (70,'Desktop i7','Rapida','https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/desktops/inspiron_desktops/inspiron_3670/mt/pdp/desktop-inspiron-3670mt-gambit-pdp-design-01.jpg?fmt=png-alpha&wid=570&hei=400',2,1,10000)
go
insert into Articulos(codigo,nombre,descripcion,linkurl,idMarca,idCategoria,precio) values (80,'Stanley i7','Eficiente','https://www.doiteargentina.com.ar/wp-content/uploads/2017/03/stanley-termo-classic-1l-con-caja-46712-01.jpg',4,3,100)
