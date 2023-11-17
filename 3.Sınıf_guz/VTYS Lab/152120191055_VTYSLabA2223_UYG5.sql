use BikeStores

--soru1
SELECT first_name, last_name, store_name
FROM sales.customers  sc
INNER JOIN sales.orders  so on sc.customer_id = so.customer_id
INNER JOIN sales.stores  ss on so.store_id = ss.store_id

--soru2
SELECT S1.staff_id , S1.first_name, S1.last_name, COUNT(S1.staff_id)  calisan_sayisi
FROM sales.staffs  S1
INNER JOIN sales.staffs  S2 ON S1.staff_id = S2.manager_id
GROUP BY S1.staff_id, S1.first_name, S1.last_name;

--soru3
SELECT staffs.staff_id, first_name, last_name, COUNT(orders.order_id) 
FROM sales.staffs
INNER JOIN sales.orders ON staffs.staff_id = orders.staff_id
WHERE last_name LIKE '%l'
GROUP BY staffs.staff_id, first_name, last_name
HAVING COUNT(orders.order_id) <100;

--soru4
SELECT products.product_id, product_name, model_year, list_price
FROM production.products
WHERE EXISTS(SELECT stocks.product_id FROM production.stocks
WHERE products.product_id=stocks.product_id AND quantity>5)

--soru5
SELECT products.product_id, product_name, model_year, list_price
FROM production.products
WHERE product_id = ANY (SELECT stocks.product_id 
FROM production.stocks WHERE products.product_id=stocks.product_id AND quantity<5)

--soru6
SELECT products.product_id, product_name, model_year, list_price
FROM production.products
WHERE product_id = ALL (SELECT stocks.product_id 
FROM production.stocks WHERE products.product_id=stocks.product_id AND quantity>5)
