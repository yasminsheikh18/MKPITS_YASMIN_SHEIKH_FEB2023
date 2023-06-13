create table Item_Master (
Item_Id int primary key identity,
Item_Name varchar(30),
Category varchar (30),
Balance_Quantity int,
)
alter table Item_Master
add rate int;

select * from Item_Master


create table Department_Master(
Department_Id int primary key identity,
Department_Name varchar(40), 
)


create table Vendor_Master(
Vendor_Id int primary key identity,
Vendor_Name varchar(40),
)

create table Transaction_Details(
Transaction_ID int primary key identity,
Item_Id int , constraint i1 foreign key(Item_Id) references Item_Master(Item_Id),
Transaction_Date Datetime,
Department_Id int,constraint i2 foreign key(Department_Id) references Department_Master(Department_Id),
Vendor_ID int,constraint i3 foreign key(Vendor_Id) references Vendor_Master(Vendor_Id),
Quantity int,
)

select * from Item_Master
select * from Department_Master
select * from Vendor_Master
select * from Transaction_Details