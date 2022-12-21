--create table customers1(id int,customername varchar(30),contactname varchar(30),address varchar(30),
--city varchar(30),postalcode int,country varchar(30));

--insert into customers1 values (1,'Alfreds' ,'Maria','obere','berlin',123,'Australia');
--insert into customers1 values(2,'Ana','Trujillo','Avda','Mexico',456,'South Africa');
--insert into customers1 values(3,'Antonio','Moreno','Mataderos','London',789,'Japan');
--insert into customers1 values(4,'Around','Thomas','Hanover','Madrid',1011,'China');
--insert into customers1 values(5,'Berglunds','Christina','Berguvsvagen','Lulea',1112,'Russia');
--insert into customers1 values(6,'Blauer ','Hanna','Forsterstr','Madrid',1213,'China');

--(group by)

--select count(id),country from customers1 group by country;


--(group by desc);

--select count(id),country
--from customers1
--group by country
--order by count(id)desc;

--select count(id),contactname
--from customers1
--group by contactname
--order by count(id)desc;


--select * from customers1

--select count(id),city
--from customers1
--group by city
--order by city desc;

--create table shippers (shipperid int,shippername varchar(30),phone int);

--insert into shippers values(4,'Speed by express', '123-9831');

--insert into shippers values(2,'United Package','(503)555-3199');

--insert into shippers values (3,'Federal Shipping','(503) 555-9931');

--insert into shippers values(5,'Sheeri','123456789');

--delete from shippers where shippername='Sheeri';

--select * from shippers


--create table orders5(orderID int,customerID int, employeeID int,orderDate varchar(50),shipperID int);

--insert into orders5 values(10248,90,5,'1996-07-04',3);
--insert into orders5 values(10249,81,6,'1996-07-05',1);
--insert into orders5 values(10250,34,4,'1996-07-08',2);
--insert into orders5 values(10251,84,3,'1996-07-08',1);

--select shippers.shippername,count(orders5.orderID) AS numberoforders from orders5
--left join shippers on orders5.shipperid=shippers.shipperid group by shippername;



--select * from orders5

--(SQL HAVING)

--select count(id),country
--from customers1
--group by country
--having count(id)>1;
--select* from customers1

select count(id),country
from customers1
group by country
having count(id)>1
order by count(id)desc;

