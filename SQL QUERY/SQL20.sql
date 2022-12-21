--select * from cust where city like'pun%';

--select * from cust where city like 'p_n_';

--select * from cust where city like '[bps]%';

--select * from cust where city like'[!bps]%';

--select * from cust where city like '[a-c]%';

--select * from cust where country in('India','japan','Australia');
--select * from cust where country not in ('India','Japan','Australia');
--select * from cust where country in (select country from India);
--select * from cust where age between 20 and 30;
--select id as id,name as name from cust;

--select name as Cname,country as Mycountry from cust;

--select name, city+',  '+country from cust;

--select city,concat(name,',',country,',') from cust;

-- select cust.name, cust.age, ghi.name, ghi.city, ghi.salary from cust, ghi;
--select c.name, c.age, g.name, g.city, g.salary from cust AS c, ghi AS g;



--select * from cust;