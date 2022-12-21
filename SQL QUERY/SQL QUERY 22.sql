 -- select customers.customername,orders.orderid from customers
-- full outer join orders on customers.customerid=orders.customerid order by customers.customername;

-- select * from customers, orders where 
-- customers.customerid = orders.customerid;

--select  a.customername as customername1,b.customername as customername2 ,a.customerid
--from customers a,customers b where a.customerid<>b.customerid and a.customerid=b.customerid order by a.customerid;
--select * from customers;
--select * from orders;