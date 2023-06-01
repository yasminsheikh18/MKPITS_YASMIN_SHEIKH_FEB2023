create table employee (
empid int primary key,
empname varchar(20))

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)
-------- trigger inserted----
create trigger empt
on employee
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted; 

insert into employee values(11,'amit')
select * from employee
select * from emplog

insert into employee values(12,'amita')
insert into employee values (13, 'shifa')
select * from employee
select * from emplog

------------trigger update-----
create trigger empu
on employee
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'update',GETDATE() from deleted

select * from employee
update employee set empname='amitabh' where empid=11

select * from employee
select * from EmpLog
----------------------------------------------------------------
create trigger empuu
on employee
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted

select * from employee
update employee set empname='rani' where empid=12

select * from employee
select * from EmpLog

-----------------------------------------
create trigger empd
on employee
after delete
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted

delete from employee where empid=12
select * from employee

select * from Emplog