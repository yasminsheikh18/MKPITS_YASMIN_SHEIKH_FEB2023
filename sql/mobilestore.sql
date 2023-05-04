create table mobilestore(
store_id int primary key,
store_name varchar(20),
phone int,
email varchar(20),
street varchar(20),
city varchar(20),
state varchar(20),
zip_cpde int
)

insert into mobilestore values(100,'Alpha mobile',1234,'alpha@gmail','Bardi','Nagpur','Maharashtra',440031)
insert into mobilestore values(101,'Star mobile',5678,'star@gmail','sadar','Mumbai','Maharashtra',440032)
insert into mobilestore values(102,'Mobile planet',1984,'mobil@gmail','itprak','Pune','Maharashtra',440209)

create table categories(
category_id int primary key,
category_name varchar(20),
)

insert into categories values(200,'Smartphone')
insert into categories values(201,'Telephone')
insert into categories values(202,'Androidphone')

create table brands(
brand_id int primary key,
brand_name varchar(20)
) 

insert into brands values (300,'Iphone')
insert into brands values (301,'Oneplus')
insert into brands values (302,'Vivo')

create table  products(
product_id int primary key,
product_name varchar(20),
brd_id int ,constraint p1 foreign key(brd_id) references brands(brand_id),
cat_id int ,constraint p2 foreign key(cat_id) references categories(category_id),
model_year int,
list_price int
)

insert into products values(400,'Iphone11',300,200,2019,60000)
insert into products values(401,'Oneplus9',301,201,2020,30000)
insert into products values(402,'Vivov23',302,202,2023,20000)

create table stock(
str_id int,constraint sx1 foreign key(str_id) references mobilestore(store_id),
pro_id int ,constraint sx2 foreign key(pro_id) references products(product_id),
quantity int
)

insert into stock values(100,400,3)
insert into stock values(101,401,6)
insert into stock values(102,402,5)

create table customers(
customer_id int primary key, 
first_name varchar(20),
last_name varchar(20),
phone int , 
email varchar(20),
street varchar(20), 
city varchar(20), 
state varchar(20),
zip_code int
)

insert into customers values(500,'yasmin','sheikh',80800,'y@gmail.com','main road','chandrapur','maharashtra',442701)
insert into customers values(501,'yashu','sheikh',83445,'yas@gmail.com','sadar','nagpur','maharashtra',442001)

create table staffs(
staff_id int primary key,
first_name varchar(20),
last_name varchar(20),
email varchar(20),
phno int,
active varchar(20),
strr_id int,constraint ss1 foreign key(strr_id) references mobilestore(store_id),
manager_id int
)

insert into staffs values(600,'simran','khan','s@gmail.com',1234,'yes',100,01)
insert into staffs values(601,'nida','khan','n@gmail.com',1235,'no',101,00)

create table orders(
order_id int primary key,
cust_id int , constraint o1 foreign key(cust_id) references customers(customer_id),
order_status varchar(20),
order_date varchar(20),
required_date varchar(20), 
shipped_date varchar(20),
strt_id int , constraint o2 foreign key(strt_id) references mobilestore(store_id),
stf_id int,constraint  o3 foreign key(stf_id) references staffs(staff_id)
)

insert into orders values(700,500,'complete','12/06/2019', '13/06/2019','15/06/2019',100,600)
insert into orders values(701,501,'pending','1/04/2023', '2/04/2023','3/06/2023',101,601)

create table order_details(
ord_id int ,constraint y11 foreign key(ord_id) references orders(order_id),
item_id int, 
pr_id int ,constraint y12 foreign key(pr_id) references products(product_id),
quan int, 
list_price int,
discount int
)

insert into order_details values(700,20,400,35,70000,2)
insert into order_details values(701,25,401,56,60000,2)

select * from mobilestore
select * from categories
select *  from brands
select * from products
select * from stock
select *  from customers
select * from staffs
select * from orders
select * from order_details