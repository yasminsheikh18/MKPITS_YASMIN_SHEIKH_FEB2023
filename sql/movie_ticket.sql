create table Movie_Ticket (Movie_Name varchar(20), Theater_Name varchar(20), Movie_Time varchar(20), No_of_seats int, Ticket_price int)
insert into Movie_Ticket values('KGF 1','PVR','9:00 AM', 2 , 450)
insert into Movie_Ticket values('KGF 2','Inox','9:00 pM', 1 , 200)
insert into Movie_Ticket values('Ved','Sangam','3:00 AM', 4 , 300)
insert into Movie_Ticket values('Pathan','PVR','12:00 AM', 2 , 400)
insert into Movie_Ticket values('KBKJ','Inox','6:00 pm', 1 , 450)
insert into Movie_Ticket values('DDLJ','Smurti','3:00 AM', 2 , 250)
insert into Movie_Ticket values('Wanted','Alankar','9:00 pm', 3 , 150)
insert into Movie_Ticket values('Pushpa','PVR','6:00 PM', 1, 450)
insert into Movie_Ticket values('Ruposh','PVR','12:00 AM', 2 , 500)
insert into Movie_Ticket values('Dear Zindagi','Sangam','9:00 PM', 5 , 600)

select * from Movie_Ticket
select * from Movie_Ticket where  Theater_Name = 'PVR'

select * from Movie_Ticket where No_of_seats = 1 and No_of_seats < 5
select * from Movie_Ticket where Movie_Name='Ruposh' order by Movie_Name desc
select Movie_Name from Movie_Ticket  order by  Movie_Name desc
select * from Movie_Ticket order by Theater_Name desc

select Theater_Name,count(*) from Movie_Ticket where Ticket_price='450' group by Theater_Name
select top 2 Movie_Name,Ticket_price from Movie_Ticket
select top 2 Movie_Name,Ticket_price from Movie_Ticket order by  Ticket_price desc
 select top 70 percent Movie_Name,Ticket_price from Movie_Ticket order by  Movie_Name desc
 select top 4 with Ties  Movie_Name,Ticket_price from Movie_Ticket order by  Movie_Name desc

 select distinct Movie_Name from Movie_Ticket
 select * from Movie_Ticket where No_of_seats in(1, 4)
 select * from Movie_Ticket where No_of_seats not in(1, 4)