create table course(courseId int primary key,
courseName varchar(20))

insert into course values(1,'Dotnet')
insert into course values (2,'Java')
insert into course values (3,'python')

create table student(rno int primary key,
studentName varchar(20),
cID int ,constraint ss foreign key(cID)references course(courseID))

insert into student values(101,'yasmin',1)
insert into student values(102,'Anjali',1)
insert into student values(103,'Tanmay',2)
insert into student values(104,'Sahil',2)
insert into student values(105,'jay',3)
insert into student values(106,'monali',3)

select * from student
select * from course

select a1.courseName,a1.courseID,a2.studentName,a2.rno
from course a1 inner join  student a2
on a1.courseId=a2.cID
WHERE a1.courseName='python'

select a1.courseID,a1.courseName,a2.rno,a2.studentName
from course a1 inner join  student a2
on a1.courseId=a2.cID
WHERE a1.courseName='Dotnet'

select a2.rno,a2.studentName
from course a1 inner join  student a2
on a1.courseId=a2.cID
WHERE a1.courseName='Dotnet'

select cr.courseName
from course cr inner join student s1
on  cr.courseId=s1.cID
where s1.studentName='jay'

select courseName from course
where courseId =(select cID from student where studentName='yasmin');

select * from course where courseName='java'

select y1.courseID,y1.courseName,y2.studentName
from course y1 inner join student y2
on y1.courseId=y2.cID
where y1.courseName='java'

