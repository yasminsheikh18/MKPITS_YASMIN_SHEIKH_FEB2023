create table orders (order_no int primary key,order_date varchar(20),custid int)

create table order_details(orderno int , product_id int, rate int , quantity int,
constraint c1 foreign key (orderno) references orders (order_no))

insert into orders values(1,'12/12/2022',212)
insert into order_details values (1,123,200,2)
insert into order_details values (1,124,500,1)

insert into orders values(2,'12/1/2023',213)
insert into order_details values (2,123,200,1)
insert into order_details values (2,125,600,2)

insert into orders values (3,'12/2/2023',214)
insert into order_details values(3,125,600,1)

select * from orders
select * from order_details