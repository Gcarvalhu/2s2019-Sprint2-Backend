create database T_Ekips;

create table Permissoes(IdPermissao Int primary key,TipoPermissao varchar(250) );

create table Cargos (IdCargo int primary key identity, NomeCargo varchar(250),Disponibilidade varchar(250) not null);

CREATE TABLE Departamentos (IdDepartamento Int Primary key identity , NomeDepartamento varchar (250));

create table Usuarios(IdUsuario int primary key identity, Email varchar(250) , Senha varchar(250) , Permissao varchar (250)
create table Funcionarios(IdFuncionario int primary key, Nome varchar(250), CPF int not null, DataNascimento date, Salario int not null, IdDepartamento int foreign key references Departamentos, IdCargo int foreign key references Cargos, IdUsuario int foreign key references Usuarios)

insert into Permissoes (IdPermissao,TipoPermissao) VALUES (1,'ADMINISTRADOR');
insert into Permissoes (IdPermissao,TipoPermissao) VALUES (2,'COMUM');

insert into Usuarios(Email,Senha,IdPermissao) values ('a@.com',123456,1)

drop table Permissoes
drop table Funcionarios
drop table Usuarios 
														  

select * from Funcionarios

select * from Permissoes

select * from Departamentos

select * from Cargos

select * from Usuarios