--create table orders(orderid int, customerid int,orderdate int);
--select * from orders;

--create table customers (customerid int, customername varchar(30),contactname varchar(30),country varchar(30));

--select * from customers;

--insert into orders values(10308,2,1996-09-18);
--insert into orders values (10309,37,1996-09-19);
--insert into orders values (10310,77,1996-09-20);





--select * from orders;

--insert into customers values(1,'Alfred Futterkiste','Maria Anders','Germany');
--insert into customers values(2,'Ana Trujillo helados','Ana Trujillo','Mexico');
--insert into customers values (3,'Antonio Moreno Taqueria','Antonio Moreno','Mexico');


--select * from customers;

--select orders.orderid,customers.customername,orders.orderdate from orders
--inner join customers on orders.customerid=customers.Customerid;

--order ka customer id and customer ka customer id match hona chaie wahi records display honge;


--left join
--select customers.customerName,orders.orderid from customers
--left join orders on customers.customerid=orders.customerid order by customers.customername;

--right join
--select * from orders right join customers on orders.customerid=customers.customerid;

select orderid from orders full outer join 