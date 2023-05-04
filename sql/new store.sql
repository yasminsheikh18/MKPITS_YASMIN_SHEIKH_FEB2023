create table  store(store_id int primary key,store_name varchar(20),phno int , 
email varchar(30),street varchar(20),city varchar(20),state varchar(20),zip_code int)
insert into store values(1,'haldiram',12345,'haldiram@gmail.com','bardi','nagpur','mah',440021)

create table categroies(categroy_id int primary key , categroy_name varchar(20))
insert into categroies values(10,'softy')

create table brand(brand_id int primary key, brand_name varchar(20))
insert into  brand values(12,'vanila')

create table product(product_id int primary key ,product_name varchar(20), brandid int ,constraint c3 foreign key(brandid)
references brand(brand_id),
cat_id int,constraint c1 foreign key(cat_id)
references categroies(categroy_id),list_price int)
insert into product values (100,'chocolate',12,10,20)

create table stock(stock_id int primary key, pro_id int  , constraint c2 foreign key (pro_id)
references product(product_id),quantity int)
insert into stock values(1000,100,3)

create table customer(cust_id int primary key, first_name varchar(20),last_name varchar(20),phone int , 
email varchar(20),street varchar(20), city varchar(20), state varchar(20),zip_code int)
insert  into customer values(1804,'yasmin','sheikh',1234567890,'y@gmail','main road','chandrapur','maharashtra',442701)

create table staffs(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),phno int,
active varchar(20),str_id int,constraint s1 foreign key(str_id) references store(store_id),manager_id int )
insert into staffs values(1998,'simran','khan','s@gmail',000000,'on',1,21)

create table orders(order_id int primary key,customer_id int , constraint o1 foreign key(customer_id) 
references customer(cust_id),order_status varchar(20),order_date varchar(20),required_date varchar(20), shipped_date varchar(20),
strid int , constraint o2 foreign key(strid) references store(store_id),
stfid int,constraint  o3 foreign key(stfid) references staffs(staff_id))
insert into orders values(04,1804,'pending','03/04/2023','04/04/2023','05/04/2023',1,1998)

create table order_items(ordid int ,constraint y1 foreign key(ordid) references orders(order_id),item_id int, 
prid int ,constraint y2 foreign key(prid) references product(product_id),quantity int, list_price int,discount int)
insert into order_items values(04,90,100,5,50,40)

select * from store
select * from categroies
select *  from brand
select * from product
select * from stock
select *  from customer
select * from staffs
select * from orders
select * from order_items