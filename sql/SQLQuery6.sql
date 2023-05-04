create table students(first_name varchar(20),last_name varchar(20),course varchar(20), city varchar(20), state varchar(20))
insert into students values ('yasmin','sheikh','dotnet','chandrapur','mah')
insert into students values ('tanmay','patil','dotnet','nagpur','mah')
insert into students values ('jay','deshmukh','java','amrawati','mah')
insert into students values ('sahil','kalwe','dotnet','nagpur','mah')
insert into students values ('rani','deshmukh','java','amravati','mah')
insert into students values ('anjali','pathak','dotnet','nagpur','mah')
insert into students values ('aakansha','wahane','dotnet','nagpur','mah')
insert into students values ('tanushree','meshram','dotnet','nagpur','mah')
insert into students values ('mayuri','pal','dotnet','nagpur','mah')
insert into students values ('monali','mohatkar','dotnet','nagpur','mah')

select * from students

select first_name,last_name from students

select * from students order by first_name

select * from students order by first_name desc

--query to find records whose name is mayuri
select * from students where first_name = 'mayuri'

select * from students where state = 'mah'

select * from students where course = 'java'

select * from students where city = 'nagpur'

select * from students where course = 'dotnet'

--query to count no of student on course whose
--city is nagpur
select course,COUNT(*) from students
where city='nagpur'
group by course

--query to count no of student on course whose
--city is not nagpur
select course,COUNT(*) from students
where city <> 'nagpur'
group by course order by course

select city,COUNT(*) from students
where state = 'mah'
group by city
having COUNT(*) < 2

select first_name from students order by first_name