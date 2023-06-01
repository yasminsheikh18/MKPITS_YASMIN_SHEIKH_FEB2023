create table salesman1 (
salesman_ID int primary key,
name varchar(20),
city varchar  (20),
comission DEC(10,2),
)

insert into  salesman1 values (5001,'James Hoog','NewYork',0.15)
insert into  salesman1 values (5002,'Nail Knites','Paris',0.13)
insert into  salesman1 values (5005,'Pit Alex','London',0.11)
insert into  salesman1 values (5006,'Mc Lyon','Paris',0.14)
insert into  salesman1 values (5007,'Paul Adam','Rome',0.13)
insert into  salesman1 values (5003,'Lausen Hen','San Jose',0.12)

select * from salesman1
select name, comission from salesman1

create table order1(
ord_no int,
purch_amt dec(10,2),
ord_date varchar(20),
customerID int,
saleId int  constraint aa foreign key(saleId)references salesman1(salesman_ID),
primary key(ord_no,customerId)
)

insert into order1 values(70001,150.5,'2012-10-05',3005,5002)
insert into order1 values(70009,270.65,'2012-09-10',3001,5005)
insert into order1 values(70002,65.26,'2012-10-05',3002,5001)
insert into order1 values(70004,110.5,'2012-08-17',3009,5003)
insert into order1 values(70007,948.5,'2012-09-10',3005,5002)
insert into order1 values(70005,2400.6,'2012-07-27',3007,5001)
insert into order1 values(70008,5760,'2012-09-10',3002,5001)

select * from order1
select ord_date,saleId,ord_no,purch_amt from order1
------------4 query---------
SELECT DISTINCT saleId
FROM order1;

-----------5 query--------
SELECT name,city from salesman1 WHERE city='paris'
(select city from salesman1)
    
------------6 QUERY--------------
create table customer1(
customer_Id int  primary key,
cust_name varchar(20),
city varchar(20),
grade int,
salesman_Id int  constraint y1 foreign key(salesman_Id)references salesman1(salesman_ID))


insert into customer1 values(3002,'nick rimando','new york',100,5001)
insert into customer1 values(3007,'brad davis','new york',200,5001)

insert into customer1 values(3005,'graham zusi','california',200,5002)
insert into customer1 values(3008,'julian green','london',300,5002)

insert into customer1 values(3004,'fabian johnson','paris',300,5006)
insert into customer1 values(3009,'geoff cameron','berlin',100,5003)
insert into customer1 values(3003,'jozy altidor','moscow',200,5007)
select * from customer1


SELECT * FROM customer1 WHERE grade =200 
select customer_Id, cust_name, city, grade, salesman_id from customer1
where grade=200;


------------7 QUERY-------
--select * from order1
select  ord_no,ord_date,purch_amt from order1
WHERE saleId=5001

------------8 QUERY-------
create table winner1(year int,
subject varchar(20),
winner varchar(50),
country varchar(20),
category varchar(20))
insert into winner1 values(1970,'physics','hannes alfven','swedan','scientist')
insert into winner1 values(1970,'physics','louis neel','france','scientist')
insert into winner1 values(1972,'chemistry','luis federico leloir','france','scientist')
insert into winner1 values(1970,'physiology','ulf von euler','swedan','scientist')
insert into winner1 values(1973,'physiology','bernard katz','germany','scientist')
insert into winner1 values(1970,'literature','aleksandr Solzhenitsyn ','russia','linguist')
insert into winner1 values(1970,'economics','paul samuelson','usa','null')
select * from winner1

select year, subject, winner from winner1
where year=1970


-----------9 query---------

select winner from winner1
where subject='literature'and year=1970

-----------10 query------------
select year, subject from winner1
where winner='bernard katz'



