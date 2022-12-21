--select pname
--from products
--where sid=ALL(select sid from suppliers where city='Nag');

--select * from suppliers
--where city='Nag' And name='mickey';

--select * from products
--where price >Any (select price from products where price>8);

--select * from products
--where price BETWEEN 8 AND 20;

--select name 
--from suppliers
--where EXISTS(select pname from products where products.sid =suppliers.sid and price<20);

--select* from suppliers
--where city IN ('Nag','mum');

--select * from suppliers
--where city like 'n%';

--select * from suppliers
--where city not like 'n%';

--select * from customers1
--where city='berlin' OR country='japan';


--create table Reena(id int,name varchar(30),city varchar(30),price int);
--insert into Reena values(1,'Amit','Lucknow',50);
--insert into Reena values (2,'Sumit','Mumbai',60);
--insert into Reena values(3,'Rishi','Delhi',40);
--(Doubt)
--select * from Reena
--where price >some(select price from Reena where price>40);

--select * from products1 
--where Unit_Price>some(select price from products where price >10);

