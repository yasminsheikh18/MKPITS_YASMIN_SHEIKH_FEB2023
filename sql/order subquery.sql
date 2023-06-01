create table customer(
custId int primary key, 
firstName varchar(20),
lastName varchar(20),
phone int,
email varchar(20),
street varchar(20),
city varchar(20),
state varchar (20),
zipCode int)

insert into customer values(1,'Yasmin','Sheikh',12345,'y@gmail.com','main road','chandrapur','maharashtra',442701)
insert into customer values(2,'tanmay','patil',34567,'t@gmail.com','manish nagar','Nagpur','maharashtra',440031)
insert into customer values(3,'mayuri','pal',567890,'m@gmail.com','bardi','nagpur','maharashtra',440021)
insert into customer values(4,'simran','khan',67890,'s@gmail.com','sadar','bhopal','MP',45678)
insert into customer values(5,'NIDA','khan',66000,'N@gmail.com','manevada','bhopal','MP',45898)

select * from customer

create table order_details(
orderid int  , customerId int  , constraint c2 foreign key(customerId) references customer(custId), orderdate date,
productname varchar(20),qty int)

insert into order_details values(1,1,'2022-2-2','mouse',5)
insert into order_details values(2,1,'2022-2-2','keyboard',5)
insert into order_details values(3,2,'2022-2-2','desktop',5)
insert into order_details values(4,2,'2022-2-2','ram',5)
insert into order_details values(5,3,'2022-2-2','laptop',5)
insert into order_details values(6,3,'2022-1-2','mouse',5)
insert into order_details values(7,4,'2022-2-2','mouse',5)
insert into order_details values(8,4,'2022-2-2','ram',5)
insert into order_details values(9,5,'2022-2-2','desktop',5)
insert into order_details values(10,5,'2022-2-2','ram',5)
select * from order_details

select * from customer
select custid,firstName,lastName from customer where city='nagpur'


select * from order_details
-------------sub query-------------
select orderid,customerId,orderdate,productname,qty 
from order_details
where customerId in 
(select custid from customer where city='nagpur')

select orderid,customerId,orderdate,productname,qty 
from order_details
where customerId in 
(select custid from customer where state='mp')

select orderid,customerId,orderdate,productname,qty 
from order_details
where customerId in 
(select custid from customer where city='bhopal')
order by orderdate desc

SELECT custId,firstName,lastName FROM customer WHERE
    city = 'chandrapur'


