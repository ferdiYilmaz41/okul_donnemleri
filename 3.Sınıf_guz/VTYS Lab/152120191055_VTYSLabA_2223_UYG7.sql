use BikeStores

CREATE PROCEDURE soru1
	@FirstName VARCHAR (255),@LastName VARCHAR(255)
AS
BEGIN
	SELECT first_name, last_name
	FROM sales.staffs
	WHERE first_name LIKE @FirstName + '%' AND last_name LIKE @LastName+'%'  
END



exec soru1 @FirstName='f',@LastName='j'
exec soru1 @FirstName='b',@LastName='h'


CREATE PROCEDURE soru2_1
	@OrderStatu VARCHAR (255),
	@StoreId VARCHAR (255)
AS
BEGIN
	SELECT b.customer_id, p.first_name, p.last_name, c.product_id, email, b.order_status, b.store_id
	FROM sales.orders b , sales.customers p, sales.order_items c
	WHERE b.customer_id=p.customer_id and c.order_id=b.order_id  and b.order_status = @OrderStatu AND b.store_id = @StoreId
	ORDER BY p.first_name
END

exec soru2_1 @OrderStatu='2', @StoreId='1';
exec soru2_1 @OrderStatu='2', @StoreId='2';


CREATE PROCEDURE soru3
	@BrandName VARCHAR (255),
	@CategoryName VARCHAR (255),
	@MinModel DECIMAL (10, 2),
	@MaxModel DECIMAL (10, 2)
AS
BEGIN
	SELECT brand_name,category_name, product_name,list_price
	FROM production.products p
	INNER JOIN production.brands b ON p.brand_id = b.brand_id
	INNER JOIN production.categories c ON p.category_id = c.category_id
	WHERE b.brand_name = @BrandName AND c.category_name = @CategoryName
		AND p.model_year BETWEEN @MinModel AND @MaxModel
	ORDER BY p.model_year
END

EXEC soru3 @BrandName='Electra' , @CategoryName='Children Bicycles', @MinModel=2017,@MaxModel=2018;
EXEC soru3 @BrandName='Heller' , @CategoryName='Mountain Bikes', @MinModel=2017,@MaxModel=2018;