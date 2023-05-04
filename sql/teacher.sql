create table teachers (teacher_id int primary key , age int)

create table subject(teacher_id int , subject varchar(20) ,
constraint t1 foreign key(teacher_id) references teachers (teacher_id)  )

insert into teachers values(1,30)
insert into subject values(1,'chemistry')
insert into subject values(1,'biology')

insert into teachers values(2,26)
insert into subject values(2,'english')
insert into subject values(2,'maths')

insert into teachers values(3,25)
insert into subject values(3,'computer')

select * from teachers
select * from subject