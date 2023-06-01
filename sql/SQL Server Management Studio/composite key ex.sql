create table order_details(
order_id  int,
product_id int,
quantity int,
primary key(order_id,product_id))

insert into order_details values(1,11,9)
insert into order_details values(2,11,9)
insert into order_details values(1,12,9)

select * from order_details

--order_Details table you cannot insert duplicate record of same order_id and product_id 
--either the order_id should be different or product_id should be different
