-- create table cust (id int ,name varchar(30),age int ,city varchar(30), country varchar(30),salary float);

-- insert into cust values(1,'ram',25,'Nagpur','INDIA',40000);
-- insert into cust values(2,'shyam',20,'Goa','Australia',50000);
--select * from ghi;


--select id ,name FROM ghi;
--select * FROM ghi;
--SELECT name,city FROM ghi;

--SELECT ghiName ,City FROM ghi;

--SELECT DISTINCT id,name FROM ghi;
--SELECT city FROM ghi;
--SELECT COUNT(DISTINCT city )FROM ghi;
--SELECT count(*) AS Distinctcity FROM (SELECT DISTINCT city FROM ghi)
--SELECT id,name FROM ghi WHERE city='Nagpur';
--SELECT * FROM ghi WHERE id=1;

--SELECT id,name FROM ghi;

--SELECT * FROM cust WHERE city='Nagpur' AND city ='Goa';
-- select * from cust where country='India' OR country='Spain';

--select --* from cust where NOT country='India';

--select * from cust where not country='India' and not country='Australia';

--select * from cust order by country;

--select * from cust order by country desc;

--select * from cust order by country ,name;

--select * --from cust order by country asc,name desc;

--insert into cust (id,name,city,country)
--values(3,'Tom B.Erichsen','Skagen','Stavanger');

--insert into cust(name,city,country)
--values('Cardinal','Stavanger','Norway');

--select id,name,city from cust where id is null;

--select name,city,id from cust  where id is not null;

--update cust set name='Alfred Schmidt',city='Frankfurt' where  id=1;

--update cust set name='Juan' where city='Frankfurt';

--delete from cust where name='juan';

--select top 3* from cust;

-- update cust 

-- select top 50 percent * from cust;

--select * from cust fetch first 50 percent rows only;
--select top 3 * from cust where country='Norway';



select * from cust;
