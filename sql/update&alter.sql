create table product1(productID int, productName varchar(20), price int,qty int)

insert into product1 values(1,'mouse',220,2)
insert into product1 values(2,'keyboard',500,5)
insert into product1 values(3,'monitor',2000,4)
insert into product1 values(4,'mouse',250,3)
insert into product1 values(5,'cpu',5000,2)

select * from product1

EXEC sp_rename 'product1.qty', 'quantity','COLUMN'

update product set price='10000'
where productName='monitor'

update product set price='300'
where productName='mouse' and price=220

delete from product
where productName='cpu'


create table sample(id int identity primary key,
name varchar(20))

insert into sample values('mouse')
insert into sample values('keyboard')
select * from sample

delete from sample
insert into sample values('mouse')
insert into sample values('keyboard')
delete from sample

--truncate will delete the record and when you
--insert new records it will start from one

truncate table sample
select * from sample
insert into sample values('mouse')
insert into sample values('keyboard')
select * from sample

--adding one more column to existing table
alter table sample
add price int



--query to change datatype of column
alter table sample
alter column price dec(10,2)

--query to drop column
alter table sample
drop column price


create table sample1(id int identity primary key,
name varchar(20))

insert into sample1 values('mouse')
insert into sample1 values('keyboard')
select * from sample1

sp_rename 'sample1', 'sample2'
sp_help sample2


