create table salesman (
salesman_ID int primary key,
name varchar(20),
city varchar  (20),
comission DEC(10,2),
)

insert into  salesman values (5001,'James Hoog','NewYork',0.15)
insert into  salesman values (5002,'Nail Knites','Paris',0.13)
insert into  salesman values (5005,'Pit Alex','London',0.11)
insert into  salesman values (5006,'Mc Lyon','Paris',0.14)
insert into  salesman values (5007,'Paul Adam','Rome',0.13)
insert into  salesman values (5008,'Lausen Hen','San Jose',0.12)

select * from salesman
select name, comission from salesman

create table salesorder1(
ord_no int,
purch_amt dec(10,2),
ord_date varchar(20),
customerID int,
saleId int  constraint cs foreign key(saleId)references salesman(salesman_Id),
primary key(ord_no,customerId)
)

insert into salesorder1 values(70001,150.5,'2012-10-05',3005,5002)
insert into salesorder1 values(70009,270.65,'2012-09-10',3001,5005)
insert into salesorder1 values(70002,65.26,'2012-10-05',3002,5001)
insert into salesorder1 values(70004,110.5,'2012-08-17',3009,5008)
insert into salesorder1 values(70007,948.5,'2012-09-10',3005,5002)
insert into salesorder1 values(70005,2400.6,'2012-07-27',3007,5001)

select * from salesorder1
