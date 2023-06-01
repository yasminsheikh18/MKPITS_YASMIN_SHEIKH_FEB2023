create table result(rno int primary key,
marks int check(marks > 0))
--insert into result values(1,0)// error
insert into result values(1,99)

select * from result