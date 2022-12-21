--(Exists Operator)
--select name 
--from suppliers
--where exists (select pname from products where
--products.sid=suppliers.sid and price <20);

--(Exist Operator)
--select name
--from suppliers
--where exists (select pname from products where 
--products.sid=suppliers.sid and price=5);

--select pname
--from products
--where sid=any (select sid from suppliers where qty=80);

--select pname
--from products
--where sid=any
--(select sid from suppliers where qty>39);




--select all pname
--from products
--where true;

--(Doubt)

--select pname
--from products
--where sid=all
--(select sid from suppliers where qty=80);