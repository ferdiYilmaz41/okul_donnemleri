--select*from sales.customers where first_name like 'a%' and last_name like 'b%' --soru1

--select count(product_name) from production.products -- soru2

--SELECT SC.customer_id, SC.first_name, SC.last_name, SC.phone, SC.order_date, order_status,
--product_name FROM sales.orders SO ,production.products PP,sales.order_items OI , sales.customers SC
--WHERE SO.order_id=OI.item_id  AND OI.item_id = 13 and   --soru3

--select * from production.products where model_year like '[2016,2018]%' and brand_id =1 and category_id=1; --soru 4  










--update sales.customers set phone = 0123456789 where phone is NULL; --soru5



