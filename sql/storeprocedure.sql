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

--query to create store procedure
create procedure prod1
as 
begin
select * from Movie_Ticket
end;

exec prod1

CREATE PROCEDURE uspProductList
AS
BEGIN
    SELECT Movie_Name,Theater_Name
    FROM 
    Movie_Ticket
    ORDER BY 
    Movie_Name desc;
END;
exec uspProductList

--query for store procedure with parameter
create procedure pro (@tp as int)
as
begin
select * from Movie_Ticket
end
exec pro @tp=250

---query to insert values into procedure
create procedure prod
as
begin
insert into Movie_Ticket values('fast & furious','Sangam','12:00 PM', 5 , 700)
end;
exec prod
select * from Movie_Ticket



