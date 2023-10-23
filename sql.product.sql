use Supermarker

create table Product
(
Product_Id int identity (100000, 1) primary key,
Product_Name nvarchar (50) not null,
Product_Observation nvarchar (50) not null,
Product_Price int not null,
);

go 

insert into Product values ('Salchicha zenu', 'Salchichas rancheras', 5)
insert into Product values ('Coca cola', 'Pepsi', 3)