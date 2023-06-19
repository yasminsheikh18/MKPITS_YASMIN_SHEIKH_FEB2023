create table ItemMaster(
ItemID int primary key identity NOT NULL,
ItemDescr varchar(100) NULL,
BalQty int NULL,
CreatedOn Datetime
)

create table Transactions(
TransID int primary key identity NOT NULL,
ItemID int constraint c1 foreign key (ItemID) references ItemMaster (ItemID),
TransType char(1) NOT NULL ,
TransQty int,
TransDate datetime,
)

select * from ItemMaster
select * from Transactions