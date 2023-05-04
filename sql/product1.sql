create table product (product_id int, product_name varchar(20), price int , quaantity int) 
insert into  product values (1,'mouse' , 600 , 3 )
insert into  product values (2,'mouse' , 400 , 1 )
insert into  product values (3,'keyboard' , 550 , 3 )
insert into  product values (4,'cpu' , 400 , 2 )
insert into  product values (5,'keyboard' , 600 , 3 )
insert into  product values (6,'monitor' , 6000 , 1 )
insert into  product values (7,'cpu' , 650 , 6 )

select * from product

select Top 2 product_id from product order by product_name
select Top 2 product_id, product_name from product 
select Top 2 product_id,quaantity from product 

select Top 4 product_name from product order by product_name desc
SELECT TOP 2
    product_name, 
    price
FROM
    product
ORDER BY 
    price DESC;

	SELECT TOP 50 percent
    product_name, 
    price
FROM
    product
ORDER BY 
    price DESC;

	SELECT TOP 4 with Ties
    product_name, 
    price
FROM
    product
ORDER BY 
    price DESC;

	select distinct product_name from product
	select distinct quaantity from product

	select  product_name from product
	select distinct product_name from product

	select  product_name from product order by product_name
	select product_name from product order by product_name desc

	select product_name from product order by LEN (product_name) 
	select product_name from product order by LEN (product_name) DESC

	select product_name,price from product where price='400' order by product_name 

	select * from product where product_id>3 and  product_name='cpu'
	select * from product where product_id>4 or product_name='monitor'

	select * from product where price  between 500 and 650 order by price desc
	select * from product where price  between 500 and 650 

	select * from product where product_id in (3,7,5)
	select * from product where product_id  not in (3,7,5)

	select * from product where product_id in (3,7,5) order by product_name desc

	select * from product where product_name like'%ar%'
	select * from product where product_name like'm%'
	select * from product where product_name like'%mo%'
	select * from product where product_name like'm%e'
	select * from product where product_name like'k%'
	select * from product where product_name like'%u'
	select * from product where product_name like'%us%'

	select * from product where product_id=5 and price>400 order by price desc
    select * from product where product_id=5 and price>5000 and quaantity=3 

	SELECT  * FROM product WHERE product_id = 1 AND price > 500 and quaantity=3 ORDER BY price DESC;
	SELECT  * FROM product WHERE product_id = 1 or product_id =3 and quaantity=3 ORDER BY price DESC;
	SELECT  * FROM product WHERE (product_id = 1 or product_id =3) and quaantity=3 ORDER BY price DESC;
