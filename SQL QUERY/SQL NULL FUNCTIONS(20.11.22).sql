--create table exmpl1(customername varchar (30),city varchar(30),country varchar (30));
--insert into exmpl1 values('Isha','Mumbai','India');
--insert into exmpl1 values('Monty',Null,'Australia');
--insert into exmpl1 values ('Mona',Null,'Russia');
--insert into exmpl1 values('Tom','Goa','India');
--select customername,city,country from exmpl1
--order by 
--(case 
--when city is null then country 
--else city
--end);





--select * from exmpl1;



--create table products1(P_Id int,Product_Name varchar(30),Unit_Price int,Units_In_Stock int,Units_On_Order int);
--insert into products1 values(1,'Jarls',10.45,16,15);
--insert into products1 values(2,'Mascar',32.56,23,Null);
--insert into products1 values(3,'Gorgon',15.67,9,20);
--select *from products1;
--(Doubt)
--select Product_Name,Unit_Price*(Units_In_Stock+Units_On_Order)
--from products1;

--(Doubts)
--select Product_Name,Unit_Price*(Units_In_Stock+IFNULL(Units_On_Order,0))
--from Products1;

--(Doubts)
--select Product_Name,Unit_Price*(Units_In_Stock+COALESCE(Units_On_Order,0))
--from products1;

--select Product_Name,Unit_Price*(Units_In_Stock+COALESCE(Units_On_Order,0))
--from products1;

--select Product_Name,Unit_Price*(Units_In_Stock+
--ISNULL(Units_On_order,0))
--from products1;







--select * from products1;

