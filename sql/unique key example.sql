create table sample(
id int unique,
name varchar(20))

--insert into sample  values(1,'yashu')
--insert into sample values(11,'yasmin')
--insert into sample values(12,'yasmin')
insert into sample(name) values('yasmin')
insert into sample(name) values('yas')

--insert into sample values(1,12,9)

select * from sample

create table employee(empid int primary key,
empname varchar(20),
passportno int,drivinglicenceno int,
constraint e1 unique(passportno,drivinglicenceno))

insert into employee values(1,'jayesh',12345,98989)
insert into employee values(2,'jayesh',1235,98989)
--insert into employee values(3,'jayesh',22345,9899)

select * from employee

create table emp(empid int primary key,empname varchar(20),
pno int unique,dlno int unique)

insert into emp values(1,'anand',111,222)
insert into emp values(2,'anand',112,223)

select * from emp

create table customer1(custid int primary key identity,
custname varchar(50))

insert into customer1 values('raj')
insert into customer1 values('yashu')
insert into customer1 values('yashu')
select * from customer1

create table rslt(rno int primary key,
marks int check(marks > 0))
--insert into result values(1,0)// error
insert into rslt values(1,99)

select * from rslt

create table product1(product_id int primary key, product_name varchar(20) not null,
unit_price dec(10,2)check(unit_price > 0))

insert into product1 values(1,'mouse',120)
--insert into product1 values('mouse',0,0) // error

select * from product1

alter table product1
add mob_no varchar(20)
select * from product1

alter table product1
drop column mob_no

alter table emp 
add constraint C1 CHECK (empid>0)
select * from emp

alter table emp
drop constraint c1 
select * from emp

EXEC sp_help 'emp'

