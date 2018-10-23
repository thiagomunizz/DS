use master
drop database dbEmpresa
create database dbEmpresa
use dbEmpresa

create table Empresa(
	
	IdEmpresa int primary key identity(1,1),
	fk_IdEstados int,
	NmUsuario varchar(30),
	CnpjEmpresa varchar(30),
	DsEndereco varchar(255),
	NmEmpresa varchar(255),
	FoneEmpresa varchar(25),
	Razao varchar(50)
	
)

create table tbEstados(
	IdEstados int primary key identity(1,1),
	Estado varchar(30)
)



ALTER TABLE Empresa

ADD CONSTRAINT fk_IdEstados

FOREIGN KEY(fk_IdEstados)

REFERENCES tbEstados(IdEstados)



insert into tbEstados(Estado)
values('Acre')

insert into tbEstados(Estado)
values('Alagoas')

insert into tbEstados(Estado)
values('Amap�')

insert into tbEstados(Estado)
values('Amazonas')

insert into tbEstados(Estado)
values('Bahia')

insert into tbEstados(Estado)
values('Cear�')

insert into tbEstados(Estado)
values('Distrito Federal ')

insert into tbEstados(Estado)
values('Esp�rito Santo ')

insert into tbEstados(Estado)
values('Goi�s ')

insert into tbEstados(Estado)
values('Maranh�o ')

insert into tbEstados(Estado)
values('Mato Grosso ')

insert into tbEstados(Estado)
values('Mato Grosso do Sul ')

insert into tbEstados(Estado)
values('Minas Gerais ')

insert into tbEstados(Estado)
values('Par�  ')

insert into tbEstados(Estado)
values('Para�ba ')

insert into tbEstados(Estado)
values('Paran� ')

insert into tbEstados(Estado)
values('Pernambuco ')

insert into tbEstados(Estado)
values('Piau�')

insert into tbEstados(Estado)
values('Rio de Janeiro')

insert into tbEstados(Estado)
values('Rio Grande do Norte')

insert into tbEstados(Estado)
values('Rio Grande do Sul ')

insert into tbEstados(Estado)
values('Rond�nia')

insert into tbEstados(Estado)
values('Roraima ')

insert into tbEstados(Estado)
values('Santa Catarina')

insert into tbEstados(Estado)
values('S�o Paulo')

insert into tbEstados(Estado)
values('Sergipe')

insert into tbEstados(Estado)
values('Tocantins')





create PROCEDURE sp_RetornarEmpresa
@NmEmpresa varchar(255) = null
as
SELECT b.Estado 'Estado',a.IdEmpresa 'C�digo Empresa', a.NmEmpresa 'Nome', a.NmUsuario 'Nome de Usu�rio', a.DsEndereco 'Endere�o', a.CnpjEmpresa 'CNPJ', a.foneEmpresa 'Telefone', a.Razao 'Raz�o Social' FROM Empresa as a 
inner join tbEstados b
on b.IdEstados = a.fk_IdEstados
where @NmEmpresa is null or NmEmpresa like '%' + @NmEmpresa + '%'

insert into Empresa values (2,'EmpresaUser','111.111.111-11','Rua da Empresa Exemplo','Empresa Exemplo','(11)2577-8899','Empresa ltda')
insert into Empresa values (1,'EmpresaUsuario','222.222.222-22','Rua Exemplo','Empresa Exemplo2','(11)2177-8892','Empresa2 ltda')

select*from Empresa

select*from tbEstados


sp_RetornarEmpresa 'empresa exemplo'

