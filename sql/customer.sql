create table customer (custid int primary key,custname varchar(20),custaddress varchar(20),custage int,)
insert into customer values(1,'yashu','chandrapur',23)
insert into customer values(2,'yasmin','Ballarpur',22)
insert into customer values(3,'nisha','nagpur',24)
insert into customer values(4,'simran','nagpur',25)
insert into customer values(6,'nida','Ballarpur',20)

select * from customer

select * from customer order by custage
select * from customer order by custage  desc

select * from customer where custname = 'yashu'


select * from customer where custaddress = 'Ballarpur'

select * from customer where custid>2 

select * from customer where custid>=1 and custid<6
select * from customer where custaddress = 'nagpur' order by custname

select * from customer where custaddress = 'chandrapur' order by custname desc

select custid , COUNT(*) from customer
where custaddress='nagpur'
group by custid

select custname , COUNT(*) from customer
where custaddress='nagpur'
group by custname order by custname

select custid, COUNT(*) from customer
where custaddress='Ballarpur' group by custid 

DELETE FROM Customer WHERE custname='nida';
insert into customer values(5,'nida','Ballarpur',20)
 
 select * from students
 select * from students where first_name  like'm%'
 select first_name from students  order by LEN(first_name) DESC
 select distinct first_name from students
 select * from students where first_name='yasmin'
 select * from students where city in ('chandrapur','amravati')
 select top 4 first_name, last_name from students order by last_name desc
 select top 60 percent first_name, last_name from students order by last_name desc
