create table product(Id int primary key,
Region varchar(20),
Product varchar(20),
Year int, 
Quantity int, 
Price int)

insert into product values(1,'East','Computer',2020,130,50000)
insert into product values(2,'sount','Computer',2020,450,35000)
insert into product values(3,'North','Computer',2020,250,40000)
insert into product values(4,'East','Hard Disk',2020,190,5500)
insert into product values(5,'West','Computer',2021,250,45000)
insert into product values(6,'South','Hard Disk',2021,550,4400)
insert into product values(7,'West','Hard Disk',2021,650,7500)
insert into product values(8,'East','Pen Drive',2021,120,800)
insert into product values(9,'North','Mouse',2019,160,1500)
insert into product values(10,'South','Pen Drive',2019,270,750)
insert into product values(11,'East','Mouse',2019,2000,1200)
insert into product values(12,'West','Pen Drive',2019,190,650)

select * from product

SELECT MIN(Quantity) AS "Minimum Quantity" FROM product; 
SELECT MIN(Price) AS "Minimum Quantity" FROM product; 
SELECT MIN(Region) AS "Minimum Quantity" FROM product; 

---------------where----------------
    SELECT Product, Quantity, Price  
    FROM product  
    WHERE Quantity = (  
    SELECT MIN(Quantity) AS "Minimum Quantity"   
    FROM product);  

	SELECT Product, Quantity, Price  
    FROM product  
    WHERE Quantity = (  
    SELECT MIN(Price) AS "Minimum Quantity"   
    FROM product);  
	 --------- group by--------

	 SELECT product, MIN(Year) AS "Minimum Quantity"   
    FROM Product  
    GROUP BY Product;  

	 SELECT Region, MIN(Quantity) AS "Minimum Quantity"   
    FROM Product  
    GROUP BY Region;  

	SELECT Product, MIN(Quantity) AS "Minimum Quantity"   
    FROM Product 
    GROUP BY Product  
    HAVING MIN(Quantity)>100;  

	---------------maximum-------------------

	    SELECT MAX(Quantity) AS "Maximum Quantity" FROM Product; 

		------------where clause------------
	SELECT Product, Quantity, Price  
    FROM Product  
    WHERE Quantity = (  
    SELECT MAX(Quantity) AS "Maximum Quantity"   
    FROM Product);   

	SELECT Region, Quantity, Price  
    FROM Product  
    WHERE Quantity = (  
    SELECT MAX(Quantity) AS "Maximum Quantity"   
    FROM Product);   

	----------group clause-----------
	SELECT Region, MAX(Quantity) AS "Maximum Quantity"   
    FROM Product 
    GROUP BY Region 
    ORDER BY Region;  

	---------------AVERAGE------

	SELECT AVG(Quantity) AS "Average Quantity"   
    FROM product;   

	----------where-----------
	SELECT AVG(price) AS "Average price"   
    FROM product  
    WHERE Product = 'Mouse';   

	-------------group--------------
	SELECT product, AVG(Quantity) AS "Average Price"   
    FROM product 
    GROUP BY product;    

	-----------sum----------------
	SELECT SUM(Price) AS "Total Price" FROM product;  

	-----------distinct-----------
	SELECT SUM( DISTINCT Quantity) AS "Total Quantity"   
    FROM product;  

	------ sum with where clause--------------
	SELECT SUM(Quantity) AS "Total quantity"  
    FROM product   
    WHERE Quantity> 500;  

	------------sum with group clause---------
	SELECT Region, SUM(Quantity) AS "Total quantity"  
    FROM product
	group by Region

	-----------count------------
	select * from product
select count(Price) as 'total' from product

select count(price) as 'total' from product 
where product ='Computer'

select product,count(price) as 'total' from product
group by product
select*from product


CREATE TABLE Geeks (
ID int NOT NULL,
Name varchar(255),
Age int,
Location varchar(255) DEFAULT 'Noida');

INSERT INTO Geeks VALUES (4, 'Mira', 23, 'Delhi')
INSERT INTO Geeks VALUES (8, 'Komal', 24, 'Delhi');
INSERT INTO Geeks(Id,Name,Age) VALUES (9, 'Payal', 26);

INSERT INTO Geeks(Id,Name,Age) VALUES(5, 'Hema', 27);

select * from Geeks

CREATE TABLE Geeks1 (
ID int NOT NULL,
Name varchar(255),
Age int,
Location varchar(255)constraint c1 DEFAULT 'Noida');
INSERT INTO Geeks1 VALUES (4, 'Mira', 23, 'Delhi')
	

alter table Geeks1
drop constraint c1
INSERT INTO Geeks1 (ID,Name,Age)VALUES (5, 'Mira', 26)		
select * from Geeks1

CREATE TABLE Students
(
ID int NOT NULL,
NAME varchar(10) NOT NULL,
AGE int DEFAULT 18
);

insert into students(ID,NAME) values(1,'yashu')
select * from Students


----------------update------------------------------------

CREATE TABLE vendor_groups2 (
    group_id INT  PRIMARY KEY,
    group_name VARCHAR (100) NOT NULL
); 

CREATE TABLE vendors (
        vendor_id INT  PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT default 100,
        constraint f  foreign key(group_id)
        references vendor_groups2(group_id)
        on update set default
        
        )

insert into vendor_groups2 values(1,'tcs1')
insert into vendors values(111,'mkpits',1)



insert into vendor_groups2 values(2,'tcs2')
  insert into vendors values(112,'mkpits1',2)

 update vendor_groups2 set group_id=22 where group_name='tcs1'
        
        select * from vendors
		select * from vendor_groups2

