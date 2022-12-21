--create table products(id int,pname varchar(30),price int,qty int,sid varchar(30));
--insert into products values(1,'pencil',10,100,'s001');
--insert into products values(2,'pen',8,40,'s001');
--insert into products values(3,'eraser',5,80,'s002');
--insert into products values(4,'register',20,200,'s005');

--select * from products;

--create table suppliers(sid varchar(30),name varchar(30),city varchar(30));
--insert into suppliers values('s001','mickey','Nag');
--insert into suppliers values('s002','Rahul','Pune');
--insert into suppliers values ('s003','Rickey','Mum');
--insert into suppliers values('s004','Amir','Delhi');



--select * from suppliers;

--(cross join)

--select * from products,suppliers;

--(inner join)

--select * from products inner join suppliers on products.sid=suppliers.sid;

-- (left join)
--select * from products left join suppliers on products.sid=suppliers.sid;

--(right join)
--select * from products right join suppliers on products.sid=suppliers.sid;

--(full join)
--select * from products full join suppliers on products.sid=suppliers.sid;

--(self join)
--select * from products self join products on products.sid=products.sid;

--(union)
--select sid from products union select sid from suppliers;

--(union all)
--select sid from products union all select sid from suppliers;

--(union with where)
--select sid from products where sid='s001' union select sid from suppliers where sid='s002' order by sid;

--(union all with where)
--select sid from products where sid='s001' union all select sid from suppliers where sid='s002' order by sid;

--(another union example)

--select sid As Supplier_id , pname AS Product_Name from products 
--union 
--select sid, city  from suppliers;

-- select price  from products where max(price) group by price, order by price;

-- select count(id),price from products group by price;
-- select count(id), Sid from products group by Sid;
--select count (price) ,pname from products group by pname order by count (price)desc;

--select products.pname,count(suppliers.city)as Numberofsuppliers from suppliers
-- left join products on suppliers.productssid=products.productssid group by pname;