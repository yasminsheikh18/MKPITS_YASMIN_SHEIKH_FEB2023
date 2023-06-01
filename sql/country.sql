create table country(countryId int primary key,conuntryName varchar(20))

insert into country values(1,'India')
insert into country values(2,'Usa')

create table state(stateID int primary key,
stateName varchar(20),
cId int , constraint c1 foreign key(cId) references country(countryId))

insert into state values(1,'Maharashtra',1)
insert into state values(2,'Mp',1)
insert into state values(3,'Wahington',2)
insert into state values(4,'lowa',2)
insert into state values(5,'florida',2)

select * from country
select * from state

create table city(cityID int primary key,
cityName varchar (20),
stId  int , constraint c2 foreign key  (stId) references state(stateID))

insert into city values(1,'nagpur',1)
insert into city values(2,'munbai',1)
insert into city values(3,'bhopal',2)
insert into city values(4,'indore',2)
insert into city values(5,'LA',3)
insert into city values(6,'miami',4)

select * from city

----------to find country name state name using inner join on id-------------
select c1.countryID,c1.conuntryName,s1.stateID,s1.stateName
from country c1 inner join state s1
on c1.countryId=s1.cId
where c1.conuntryName='India'

select c1.countryID,c1.conuntryName,s1.stateID,s1.stateName
from country c1 inner join state s1
on c1.countryId=s1.cId
where c1.conuntryName='usa'


---------- to find only state----------
select s1.stateID,s1.stateName
from country c1 inner join state s1
on c1.countryId=s1.cId
where c1.conuntryName='India'

-----------to find city by using state id-------------
select ct.cityName
from city ct inner join state s1
on  ct.stId=s1.stateID
where s1.stateName='mp'

-----------to find state--------
select stateName from state
where cId =(select countryId from country where conuntryName='india');

select cityName from city
where stId =(select stateID from state where stateName='maharashtra');