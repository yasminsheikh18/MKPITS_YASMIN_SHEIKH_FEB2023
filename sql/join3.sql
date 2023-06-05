create table customer(
custId int ,
custName varchar (20) not null,
telno int)

insert into customer values(123,'sana',45678)
insert into customer values(124,'yashu',45456)
insert into customer values(125,'yasmin',67890)
insert into customer values(126,'simran',33455)
insert into customer values(127,'sabiya',12345)

create table orders(
orderID int ,
orderDate varchar(20),
custID int,
prodName varchar(20) not null,
rate int,
qty int)

insert into orders values(1,'1/04/2023',123,'Laptop',30000,1)
insert into orders values(2,'2/04/2023',127,'computer',20000,4)
insert into orders values(3,'3/04/2023',125,'mobile',50000,2)
insert into orders values(4,'4/04/2023',128,'tv',20000,3)

select * from customer
select * from orders

------------------------inner join-----

select customer.custName,customer.custId,orders.prodName,orders.orderID,orders.rate
from customer
inner join orders
 on customer.custId=orders.custID


 select customer.custName,orders.orderID
 from customer
 inner join orders
 on customer.custId=orders.custID

 ------------------------


 -------------cross join-----
 select customer.custName,customer.custId,orders.prodName,orders.orderID,orders.rate,orders.orderDate
 from customer
 cross join orders

 select customer.custName,customer.custId,orders.prodName,orders.orderID
 from customer
 cross join orders
 where customer.custId=orders.custID

 -----------left outer join- all the record from  left table and matching record from right table-----------------
 select customer.custName,customer.custId,orders.prodName,orders.orderID,orders.rate,orders.orderDate
 from customer
 left outer join orders
 on customer.custId=orders.custID

 -------------right outer join--all the record from  right table and matching record from left table----------------
 select customer.custName,customer.custId,orders.prodName,orders.orderID,orders.rate,orders.orderDate
 from customer
 right outer join orders
 on customer.custId=orders.custID

 --------------full outer join-- includes all rows from both tables------
  select customer.custName,customer.custId,orders.prodName,orders.orderID,orders.rate,orders.orderDate
 from customer
 full outer join orders
 on customer.custId=orders.custID

