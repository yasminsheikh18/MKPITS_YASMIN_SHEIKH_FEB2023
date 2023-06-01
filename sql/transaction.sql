CREATE TABLE Product (  
     Product_id INT PRIMARY KEY,   
     Product_name VARCHAR(40),   
     Price INT,  
     Quantity INT  
    )  

	insert into Product values(111, 'Mobile', 10000, 10)
	insert into Product values(112, 'Laptop', 20000, 15)
	insert into Product values(113, 'Mouse', 300, 20)
	insert into Product values(114, 'Hard Disk', 4000, 25)
	insert into Product values(115, 'Speaker', 3000, 20)

	select * from Product

	-- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
     INSERT INTO Product VALUES(116, 'Headphone', 2000, 30)  
     UPDATE Product SET Price = 450 WHERE Product_id = 113  
     -- Commit changes   
    COMMIT TRANSACTION  

	select * from Product

	-------------------------------------------------------------

	-- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE Product_id = 114  
    DELETE FROM Product WHERE Product_id = 116  

	select * from Product

	-------------------------------------------------------------

	set implicit_transactions on 

    -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 6000 WHERE Product_id = 114  
    DELETE FROM Product WHERE Product_id = 116  
    --Undo Changes  
    COMMIT TRANSACTION  

	select * from Product

	---------------------------
	set implicit_transactions on 

    -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE Product_id = 114  
    DELETE FROM Product WHERE Product_id = 116  
    --Undo Changes  
    ROLLBACK TRANSACTION  

	SELECT * FROM Product
----------------------



DECLARE 
    @product_name2 VARCHAR(MAX), 
    @list_price2   DECIMAL;

DECLARE cursor_product2 CURSOR
FOR SELECT 
        product_name, 
        price
    FROM 
        product;

OPEN cursor_product2;

FETCH NEXT FROM cursor_product2 INTO 
    @product_name2, 
    @list_price2;
PRINT @product_name2 + CAST(@list_price2 AS varchar);
WHILE @@FETCH_STATUS = 0
    BEGIN
       
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name2, 
            @list_price2;
            
          PRINT @product_name2 + CAST(@list_price2 AS varchar);
    END;

CLOSE cursor_product2;

DEALLOCATE cursor_product2;



---------------------------------------------------------
DECLARE 
    @product_name3 VARCHAR(MAX), 
    @qnty   DECIMAL;

DECLARE cursor_product2 CURSOR
FOR SELECT 
        product_name, 
        Quantity
    FROM 
        product;

OPEN cursor_product2;

FETCH NEXT FROM cursor_product2 INTO 
    @product_name3, 
    @qnty;
PRINT @product_name3 + CAST(@qnty AS varchar);
WHILE @@FETCH_STATUS = 0
    BEGIN
       
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name3, 
            @qnty;
            
          PRINT @product_name3 + CAST(@qnty AS varchar);
    END;

CLOSE cursor_product2;

DEALLOCATE cursor_product2;
