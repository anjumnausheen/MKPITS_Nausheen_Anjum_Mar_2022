--create DATABASE Nausheen_One
--DROP DATABASE Nausheen_One

	

	/*BACKUP DATABASE abcd
	TO DISK ='D:\abcd.bak';
	-- */
    
	/*BACKUP DATABASE abcd
	TO DISK='C:\backups\Nausheen_Anjum.bak'
	WITH DIFFERENTIAL;*/
	
	
	--DROP TABLE dbo.exmpl;

	

	/*create table Maharaja(
	ID int NOT NULL UNIQUE,
	LASTNAME varchar(255)NOT NULL,
	FIRSTNAME varchar(255),
	Age int);*/

	--select * from Maharaja

	
	/*ALTER TABLE mum
	ADD  UNIQUE (SID);

	--select * from mum*/

	--ALTER TABLE Mihan
	--ADD CONSTRAINT UC_Mihan UNIQUE (OrderID,OrderNO);

	
--create table maharaja2(PersonID int not null PRIMARY KEY,LastName varchar(255),FirstName varchar(255),Age int );
--insert into  maharaja2 values(1,'Sinha','Ashok',30);
--insert into  maharaja2 values(2,'Shivam','Satyam',30);
--insert into  maharaja2 values(3,'Geet','Mala',30);

--select * from maharaja2
--create table Volvo(Orderid int not null PRIMARY KEY,ordernumber int not null,PersonID int FOREIGN KEY REFERENCES maharaja2(PersonID));
--insert into Volvo values (1,'77895',3);
--insert into Volvo values (2,'44678',3);
--insert into Volvo values (3,'22456',2);
--insert into Volvo values (4,'24562',1);

  --(Will not Execute because pk should be match with the volvo table fk)
--insert into Volvo values (5,'24562',4);


--select * from Volvo

--CREATE PROCEDURE SelectAllCustomers
--AS
--SELECT * FROM customers1
--GO;

--EXEC SelectAllCustomers;


-- CREATE PROCEDURE SelectAllCustomers9 @City nvarchar(30) 
-- AS
-- SELECT * FROM customers1 where city = @City
-- GO

 --EXEC SelectAllCustomers9 @City = 'London';

-- CREATE PROCEDURE SelectAllCustomers5 @City nvarchar(30), @Id int 
-- AS
-- SELECT * FROM customers1 where city = @City AND id = @Id
-- GO
-- EXEC SelectAllCustomers5 @City = 'London', @Id = 3;

 /*CREATE PROCEDURE SelectAllCustomers6 @City nvarchar(30), @Id int 
 AS
 SELECT * FROM customers1 where city = @City AND id = @Id
GO
 EXEC SelectAllCustomers5 @City = 'berlin', @Id = 1;*/
