--create table Persons(
--PersonID int,
--LastName varchar(255),
--FirstName varchar(255),
--Address varchar(255),
--City varchar(255)
--);
--select * from Persons


 --create table TestTable 
 --as select city,name 
--from suppliers;

--Drop table products;

--Drop table Persons;
--select * from persons

--Truncate Table customers1Backup2017;
--select * from customers1Backup2017;

--DROP TABLE customers1Backup2017;
--select * from customers1Backup2017;

--(ALTER TABLE)

--ALTER TABLE Persons
--ADD country varchar(30);

--ALTER TABLE Reena
--Add qty int;
--select * from Reena

--ALTER TABLE Reena
--ADD Email varchar(255);
--select * from Reena

--ALTER TABLE Reena
--DROP COLUMN Email;
--select * from Reena;

--ALTER TABLE Reena
--ALTER COLUMN price varchar(30);
--select * from Reena

--create table Rima(
--id int not null,
--LastName varchar(255)NOT NULL,
--FirstName varchar(255)NOT NULL,
--Age int
--);
--select * from Rima

--ALTER TABLE Rima
--ALTER COLUMN Age int NOT NULL
--select * from Rima

--(SQL UNIQUE CONSTRAINTS)
--ALTER TABLE Rima(
--id int not null unique,
--LastName varchar(255)NOT NULL,
--FirstName varchar(255),
--Age int
--);
--ALTER TABLE Rima
--ALTER COLUMN id int  UNIQUE(id)

--create table Paradise(
--ID int NOT NULL,
--LastName varchar(255)Not NULL,
--FirstName varchar(255),
--Age int,
--PRIMARY KEY(ID)
--);
--select * from Paradise

--create table Persons1(
--ID int NOT NULL PRIMARY KEY,
--LastName varchar(255) NOT NULL,
--FirstName varchar(255),
--Age int
--);
--select * from Persons1

--create table Persons2(

--ID int not null,
--Lastname varchar(255) not null,
--Firstname varchar(255) not null,
--Age int
--);
--select * from Persons2

--ALTER TABLE Persons2
--ADD PRIMARY KEY (ID);

--select * from Persons2

ALTER TABLE Persons1
ADD CONSTRAINTS PK_Persons1 PRIMARY KEY(Firstname,Lastname);
