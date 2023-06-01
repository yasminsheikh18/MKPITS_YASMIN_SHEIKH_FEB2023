select * from TablelnvoiceDetails
select * from TableProductCategory
select * from TableProduct
select * from TableProductGSTDetails
select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on
a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name='mobile'
select p.Product_Name from TableProduct p inner join TableProductCategory c on c.Product_Category_ID=p.ProductTypelD 
where Product_Type_Name='computer'