create table auctions(auction_id int primary key , division_name varchar(20),auction_date int)

create table auction_details(auctionid int , depot_name varchar(20),product_name varchar(20),
constraint a1 foreign key (auctionid) references auctions(auction_id));

insert into auctions values(101,'nagpur',04-5-2023)
insert into auction_details values(101,'umred','timber')
insert into auction_details values(101,'sindewahi','teak')

insert into auctions values(102,'chandrapur',05-5-2023)
insert into auction_details values(102,'umred','timber')
insert into auction_details values(102,'paoni','teak')

insert into auctions values(103,'yavatmal',06-5-2023)
insert into auction_details values (103,'washim','teak')

select * from auctions
select * from auction_details
