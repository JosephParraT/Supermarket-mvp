use Supermarker

create table Provider 

(

Provider_Id int identity (100000, 1) primary key,
Provider_Name nvarchar (50) not null,
Provider_Observation nvarchar (50) not null,
)

go

insert into Provider values ('Aldor', 'Empresa Multinacional')
insert into Provider values ('Bavaria', 'Empresa de Refrescos') 