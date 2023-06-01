create table student(
rno int unique ,
name varchar(20),
email varchar(30),
city varchar(20),
courseid int primary key,
)

insert into student values (1,'yashu','y@gmail.com','Nagpur',101)
insert into student values (2,'yasmin','ya@gmail.com','Mimbai',102)
insert into student values (3,'Simran','s@gmail.com','Nagpur',103)
insert into student values (4,'shifa','shifa@gmail.com','Delhi',104)
insert into student values (5,'ziya','z@gmail.com','Delhi',105)

create table fees(
feesID int,
rno int,
feesDate varchar(20),
amount int,
courseID int, constraint cc foreign key (courseID) references student(courseid),)

insert into fees values(01,1,'01/05/2023',20000,101)
insert into fees values(02,2,'02/05/2023',30000,101)
insert into fees values(03,3,'03/05/2023',15000,102)
insert into fees values(04,4,'04/05/2023',80000,103)
insert into fees values(05,5,'01/05/2023',20000,104)
insert into fees values(06,6,'08/05/2023',10000,105)

select  * from student
select * from fees

select feesID,rno,feesDate,feesID,courseID
from fees
where courseID in 
(select courseid from student where city='nagpur')

select rno,name,city
from student
where courseID in 
(select courseid from student where city='nagpur')

select rno,name,city
from student
where courseID in 
(select courseid from student where city='Delhi')

select feesID,rno,feesDate,feesID,courseID
from fees
where courseID in 
(select courseid from student where amount='10000')

select * from student where name='yasmin'