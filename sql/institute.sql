create table nation(nationid int primary key,nationname varchar(30))
insert into nation values(1,'India');
insert into nation values(2,'united nation');
insert into nation values(3,'Nepal');
insert into nation values(4,'srilanka');

select * from nation
create table state(stateid int primary key,statename varchar(30),nationid int,constraint c1 foreign key(nationid) references
nation(nationid))
insert into state values(101,'Arunachal pradesh',1)
insert into state values(102,'punjab',1)
insert into state values(103,'califoniya',2)
insert into state values(104,'florida',2)
insert into state values(105,'koshi',3)
insert into state values(106,'bagmati',3)
insert into state values(107,'colomabo',4)
insert into state values(108,'ratnapura',4)

select s.stateid,s.statename from state s inner join nation n on
s.nationid=n.nationid
where nationname='India'

create table city(cityid int primary key,cityname varchar(20),stateid int ,constraint d1 foreign key(stateid) references state(stateid));
insert into city values(1001,'vishakhapatnam',101)
insert into city values(1002,'vijaywada',101)
insert into city values(1003,'guntu',101)
insert into city values(1004,'amritsir',102)
insert into city values(1005,'jalandhar',102)
insert into city values(1006,'chnadigahr',102)
insert into city values(1007,'los angeles',103)
insert into city values(1008,'san joes',103)
insert into city values(1009,'san diegi',103)
insert into city values(1010,'jacksonvill',104)
insert into city values(1011,'miami',104)
insert into city values(1012,'tampa',104)
insert into city values(1013,'damka',105)
insert into city values(1014,'dharan',105)
insert into city values(1015,'biratnagara',105)
insert into city values(1016,'banepa',106)
insert into city values(1017,'bharatpur',106)
insert into city values(1018,'hetauda',106)
insert into city values(1019,'grandpass',107)
insert into city values(1020,'borella',107)
insert into city values(1021,'pettah',107)
insert into city values(1022,'balangoda',108)
insert into city values(1023,'kalana',108)


create table courseid(courseregid int primary key identity,categoryid int,fullname varchar(20),gender int)
insert into courseid values(1,'mk',1)
insert into courseid values(2,'mk1',2)
insert into courseid values(1,'ravi',1)
insert into courseid values(1,'anand',1)
insert into courseid values(1,'gopal',1)
insert into courseid values(1,'girva',2)
insert into courseid values(11,'pranjali',1)
insert into courseid values(11,'gurav',1)
insert into courseid values(1,'dhanjay',1)
insert into courseid values(1,'anjali',1)
insert into courseid values(2,'mona',1)
insert into courseid values(1,'tanu',1)
insert into courseid values(2,'anaa',2)
select * from courseid

create table addres(regaddid int identity,courseregid int constraint e11 foreign key(courseregid) references courseid(courseregid),nationid int
constraint e21 foreign key(nationid) references nation(nationid),stateid int constraint e31 foreign key(stateid) references state(stateid),
 cityid int,constraint e41 foreign key(cityid) references city(cityid));
 insert into addres values(1,4,4,102,1003)
 insert into addres values(2,4,4,104,1009)
 insert into addres values(3,4,4,102,1003)
 insert into addres values(4,4,4,104,1012)
 insert into addres values(5,4,2,104,1009)
 insert into addres values(6,4,2,104,1009)
 insert into addres values(7,4,2,103,1009)
 insert into addres values(8,4,2,103,1007)
 insert into addres values(9,12,1,102,1006)
 insert into addres values(10,13,1,101,1001)
 insert into addres values(11,14,4,107,1021)
 insert into addres values(12,15,2,104,1012)
 insert into addres values(13,16,1,101,1002)


 
 
create table fee(feeid int primary key identity,courseregid int constraint f1 foreign key(courseregid) references courseid,totalamount decimal,
 minper decimal,paidamount decimal,balaneamount decimal,paiddate datetime)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(4,3000,0,20,2980,2023-04-04)
 insert into fee values(4,1000,0,200,800,2023-04-10)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(4,1000,0,500,500,2023-04-10)
 insert into fee values(12,1000,0,600,400,2023-04-10)
 insert into fee values(13,1000,600,600,400,2023-04-10)
 insert into fee values(14,3000,2400,2400,600,2023-04-10)
 insert into fee values(15,1000,500,500,500,2023-04-10)
 insert into fee values(16,3000,2400,2500,500,2023-04-10)


 select * from fee
 select s.cityid,s.cityname from city s inner join state n on s.stateid = n.stateid where statename ='punjab'
 select * from addres
 select * from fee
 select * from courseid