--create index index_cust2
--on customers1(customername,contactname);
--select * from customers1


--select * from Reena
/*create unique index index_reeta
on Reena(id);*/
--select * from Reena

/*create index idx_mina
on Reena(name);*/

--Drop Index idx_mina on Reena;

/*Create table Persons_one(
Personid int IDENTITY(1,1)PRIMARY KEY,
LastName varchar(255)NOT NULL,
FirstName varchar(255),
Age int
);*/
--select * from Persons_one

--create table Ordes_date(OrderID int, ProductName varchar(255),OrderDate varchar(255));
--insert into Ordes_date values(1,'Ram',2008-11-11);
--insert into Ordes_date values(2,'Sohan','2008-11-09');

--select * from Ordes_date where OrderDate='2008-11-09'
--select * from Ordes_date

/*create view [Australia customers1]AS
select customername,contactname
from customers1
where country='Australia';*/
--select * from [Australia customers1];

