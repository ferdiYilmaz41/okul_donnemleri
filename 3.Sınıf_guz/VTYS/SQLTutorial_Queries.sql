-- CRUD ???

use Northwind
select * from Products

select ProductId,ProductName,UnitPrice,UnitsInStock 
from Products

select 'Dicle' as Adi,'Keser' Soyadi, 4 'Yasi'
UNION
select 'Uzay' as Adi,'Keser' Soyadi, 1 'Yasi'
UNION
select 'Uzay' as Adi,'Keser' Soyadi, 1 'Yasi'

select 'Dicle' as Adi,'Keser' Soyadi, 4 'Yasi'
UNION
select 'Uzay' as Adi,'Keser' Soyadi, 1 'Yasi'
UNION ALL
select 'Uzay' as Adi,'Keser' Soyadi, 1 'Yasi'

select 5+6 as 'Toplam'
select 5+'6' as 'Toplam'

select convert(varchar,5)+' Dicle' as 'Toplam'

select cast(5 as varchar)+' Dicle' as 'Toplam'

select CategoryID  [Kategori No], 
CategoryName  'Kategori Adı'
from Categories

select FirstName+' '+LastName as FullName, City, Country 
from Employees

select upper(ProductName) as ProductName,
UnitPrice,UnitsInStock 
from Products

select ProductName,UnitPrice,UnitsInStock 
from Products
order by UnitPrice asc

select ProductName,UnitPrice,UnitsInStock from Products
order by UnitPrice desc

select ProductName,UnitPrice,UnitsInStock from Products
order by UnitPrice desc,UnitsInStock asc

select CustomerID,CompanyName,ContactName, City 
from Customers
where City='Madrid' OR City='London'
order by CompanyName

select ProductName,UnitPrice,UnitsInStock 
from Products
where UnitPrice<=10
order by UnitPrice DESC

select FirstName+' '+LastName FullName, HireDate 
from Employees
where HireDate>1993

select FirstName+' '+LastName FullName, HireDate 
from Employees
where HireDate>'1993'

select FirstName+' '+LastName FullName, HireDate 
from Employees
where HireDate>'1993-12-31'

select * from Products
where ProductName Like '_c%'

select CategoryName,[Description] from Categories
where [Description] like '%sweet%'

select FirstName,LastName from Employees
where FirstName like 'S%' or LastName like 'S%'

select * from Customers where [Address] like '%57%'

select * from Customers where PostalCode like '%09'

select * from Employees
where HireDate >= '1993-01-01' and HireDate<='1993-12-31'

select * from Employees
where HireDate Between '1993-01-01' and '1993-12-31'

select * from Products 
where UnitPrice between 80 and 100 
order by UnitPrice

select * from Categories

select * from Products 
where CategoryID <> 1 and CategoryID <> 4 and CategoryID <> 8
order by CategoryID ASC

select * from Products where CategoryID Not IN(1,4,8)
order by CategoryID ASC



use AdventureWorks2017
select FirstName, LastName, MiddleName
from Person.Person
where MiddleName = NULL

select FirstName, LastName, MiddleName
from Person.Person
where MiddleName IS NULL

select FirstName, LastName, MiddleName
from Person.Person
where MiddleName <> NULL

select FirstName, LastName, MiddleName
from Person.Person
where MiddleName IS NOT NULL

use Northwind
select FirstName,LastName,HireDate 
from Employees
order by 3

select FirstName,LastName,HireDate from Employees
order by 2 asc

select FirstName,LastName,HireDate from Employees
order by 2 desc

select CategoryName from Categories 
order by CategoryName

select CategoryName from Categories
order by case CategoryName 
when 'Other' then 1 else 0 end

select ProductName,UnitPrice from Products
order by UnitPrice

select ProductName,UnitPrice from Products
order by UnitPrice,ProductName

select Country from Employees

select distinct Country from Employees
order by Country

select Country,City from Customers
order by Country

select distinct Country,City from Customers
order by Country

select CustomerID, OrderDate from Orders
where Year(OrderDate)=1997 and 
month(OrderDate)=7
and day(OrderDate)=4

select distinct CustomerID from Orders
where Year(OrderDate)=1997 and month(OrderDate)=6

select FirstName+' '+LastName as FullName,
HomePhone as Phone from Employees
union 
select ContactName,Phone from Customers
order by FullName


use Northwind
select * from Orders where year(OrderDate)=1997

select top 10 CustomerID from Orders 
where year(OrderDate)=1997 --ilk 10 veri

select * from Products

select top 20 percent * from Products

select * from Products order by UnitPrice


select ProductName as [Ürün Adı],UnitPrice as [Fiyat], 
UnitsInStock as Stok
from Products
where UnitPrice>50

select ProductName as [Ürün Adı],UnitPrice as [Fiyat],
UnitsInStock,
	case UnitsInStock when 0 then 'Stokta yok'
	else cast(UnitsInStock as varchar) end as [Stok]
from Products
where UnitPrice>50

select FirstName,LastName,TitleOfCourtesy 
from Employees

select FirstName,LastName,
	case TitleOfCourtesy when 'Ms.' then 'Female'
	when 'Mrs.' then 'Female'
	when 'Mr.' then 'Male'
	when 'Dr.' then 'Male'
	else '-' end as [Gender]
from Employees

select GETDATE(),SYSDATETIME(),SYSUTCDATETIME()

declare @tarih datetime
set @tarih='2022-12-15 09:50:00:000'
select @tarih

declare @tarih1 varchar(30)
set @tarih1='2022-32-15 12:15:00:00'
select @tarih1
select convert(datetime,@tarih1)

declare @tarih datetime
set @tarih='2022-12-15 12:15:00:00'
select DATEADD(day,1,@tarih)

declare @tarih datetime
set @tarih='2022-12-15 12:15:00:00'
select DATEADD(MONTH,1,@tarih)

declare @tarih datetime
set @tarih='2022-12-15 12:15:00:00'
select DATEADD(year,1,@tarih)

declare @tarih datetime
set @tarih='2022-12-15 12:15:00:00'
select DATEADD(minute,1,@tarih)

declare @tarih1 datetime
set @tarih1='2022-11-15 12:15:00:00'
declare @tarih2 datetime
set @tarih2='2022-11-15 09:15:00:00'
select datediff(day,@tarih1,@tarih2)

declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
declare @tarih2 datetime
set @tarih2='2022-11-15 12:15:00:00'
select datediff(month,@tarih1,@tarih2)

declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
declare @tarih2 datetime
set @tarih2='2022-12-14 12:15:00:00'
select datediff(year,@tarih1,@tarih2)

declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
declare @tarih2 datetime
set @tarih2='2022-12-15 12:15:00:00'
select datediff(MINUTE,@tarih1,@tarih2)

declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
declare @tarih2 datetime
set @tarih2='2022-12-15 12:15:00:00'
select datediff(hour,@tarih1,@tarih2)


declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
select year(@tarih1)
select datepart(year,@tarih1)
select datepart(day,@tarih1)
select datepart(hour,@tarih1)
select datepart(minute,@tarih1)

declare @zaman time
set @zaman='2022-12-15 12:15:00:00'
select @zaman

declare @sadeceTarih date
set @sadeceTarih='2022-12-15 12:15:00:00'
select @sadeceTarih


declare @tarih1 datetime
set @tarih1='2022-12-15'
select YEAR(@tarih1) 'Yıl', MONTH(@tarih1) 'Ay', 
DAY(@tarih1) as 'Gün'


declare @tarih1 datetime
set @tarih1='2022-12-15 12:15:00:00'
select convert(varchar,@tarih1)
select convert(varchar,@tarih1,103) as 'Tarih'  --Türkçe'ye en yakın tarih formatı


select FirstName,LastName,
convert(varchar,BirthDate,104) as 'BDate' 
from Employees

select FirstName,LastName,
convert(varchar,DATEADD(year,50,BirthDate),104) as 'BDate' 
from Employees


select FirstName,LastName,
DATEDIFF(year,HireDate,GETDATE()) as 'WDate1',
year(getdate())-year(HireDate) as 'WDate2'
from Employees

select OrderID, CustomerID, 
YEAR(OrderDate) as year, MONTH(OrderDate) as month,
DATEPART(DAY, OrderDate) as day from Orders

select OrderId, CustomerId, 
DATEDIFF(year, OrderDate, GETDATE()) as GecenYil 
from Orders

select DATEDIFF(day, getdate(), EOMONTH(Getdate()))

select ISDATE('12/33/2022')

declare @text varchar(50)
set @text='   Veritabanı Yönetim Sistemleri    '

select len(ltrim(@text))
select ltrim(@text)
select ltrim(rtrim(@text))

declare @text varchar(50)
set @text='Veritabanı Yönetim Sistemleri'

select left(@text,10)

select right(@text,10)

declare @text varchar(50)
set @text='Veritabanı Yönetim Sistemleri'
select CHARINDEX('yönetim', @text,1)

declare @text varchar(50)
set @text='Veritabanı Yönetim Sistemleri'
select PATINDEX('%yönetim%',@text)

declare @text varchar(50)
set @text='Verıtabanı Yönetım Sıstemlerı'
select replace(@text,'ı','i')

select str(5,8)

select str(12,10)

select SPACE(10)

declare @sayi int
set @sayi=12
select REPLACE(str(@sayi,10), space(1),'0')  --10 karakterli sayi oluşturup 1 karakterlik boşlukları 0 ile yer değiştir

select ProductName + ' '+
convert(varchar, ceiling(UnitPrice))+' liradır.' as UrunFiyatları
from Products

select ProductName + ' '+convert(varchar, floor(UnitPrice))+' liradır.' as UrunFiyatları
from Products

select ProductName + ' '+cast(UnitPrice as varchar)+' liradır.' as UrunFiyatları
from Products

select FirstName, LastName, Region, City, Country 
from Employees

select FirstName, LastName, 
coalesce (Region, City, Country) as Region 
from Employees

select * from Products P
left join Suppliers S on P.SupplierID=S.SupplierID
order by P.ProductID DESC


select * from Products P
right join Suppliers S on P.SupplierID=S.SupplierID
order by P.ProductID DESC

select * from Products P
full join Suppliers S on P.SupplierID=S.SupplierID
order by P.ProductID DESC

select * from Suppliers

select * from Products
cross join Suppliers


select * from Employees
select M.FirstName,M.LastName,E.ReportsTo,
len(M.FirstName+' '+M.LastName) as AD 
from Employees E
left join Employees M on E.ReportsTo=M.EmployeeID

select C.CategoryName, count(0) as [Count] 
from Products P
inner join Categories C on P.CategoryID=C.CategoryID
where P.UnitsInStock=0
group by C.CategoryName
order by [Count] desc


use AdventureWorks2017
select P.Name, sum(P.ListPrice*I.Quantity) as [Summary]
from Production.Product P
inner join Production.ProductInventory I on 
P.ProductID=I.ProductID
where P.ListPrice>0
group by P.Name
having sum(P.ListPrice*I.Quantity)>1000 --where koşuluna aggregate func yazılmaz
order by [Summary]


use Northwind
select o.OrderID, o.CustomerID, 
convert(varchar(50), o.OrderDate,104) as [OrderDate],
sum (od.UnitPrice*od.Quantity) as [Summary]
from Orders O
inner join [Order Details] od on o.OrderID=od.OrderID
group by o.OrderID, o.CustomerID, convert(varchar(50), 
o.OrderDate,104)
having sum (od.UnitPrice*od.Quantity) >10000
order by [Summary]




select o.OrderID, o.CustomerID, 
convert(varchar(50), o.OrderDate,104) as [OrderDate],
sum (od.UnitPrice*od.Quantity) as [Summary]
from Orders O
inner join [Order Details] od on o.OrderID=od.OrderID
group by o.OrderID, o.CustomerID, o.OrderDate
having sum (od.UnitPrice*od.Quantity) >10000
order by [Summary]


use AdventureWorks2017
select pc.Name,psc.Name,p.Name,sum(soh.TotalDue) as Total 
from Sales.SalesOrderHeader soh
inner join Sales.SalesOrderDetail sod on soh.SalesOrderID=sod.SalesOrderID
inner join Production.Product p on p.ProductID=sod.ProductID
inner join Production.ProductSubcategory psc on 
p.ProductSubcategoryID=psc.ProductSubcategoryID
inner join Production.ProductCategory pc on 
psc.ProductCategoryID=pc.ProductCategoryID
group by pc.Name,psc.Name,p.Name
with rollup
order by pc.Name,psc.Name,p.Name



select c.CompanyName,CONVERT(varchar,o.OrderDate) as OrderDate,
p.ProductName,od.UnitPrice,od.Quantity
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID
inner join Products p on p.ProductID=od.ProductID
order by o.OrderID
offset 0 rows fetch next 10 rows only


select c.CompanyName,CONVERT(varchar,o.OrderDate),p.ProductName,od.UnitPrice,od.Quantity
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID
inner join Products p on p.ProductID=od.ProductID
order by o.OrderID
offset 10 rows fetch next 10 rows only

select c.CompanyName,CONVERT(varchar,o.OrderDate),p.ProductName,od.UnitPrice,od.Quantity
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID
inner join Products p on p.ProductID=od.ProductID
order by o.OrderID
offset 2150 rows fetch next 10 rows only


declare @page int
declare @rowcount int
set @rowcount=10
set @page=1*@rowcount --1. sayfa
select c.CompanyName,CONVERT(varchar,o.OrderDate),p.ProductName,od.UnitPrice,od.Quantity
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID
inner join Products p on p.ProductID=od.ProductID
order by o.OrderID
offset @page rows fetch next @rowcount rows only


select ROW_NUMBER() over (order by o.orderDate),
p.ProductName,(od.UnitPrice*od.Quantity) as Summary,o.OrderDate
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where datepart(year,o.OrderDate)=1996

select ROW_NUMBER() over (order by p.ProductName),
p.ProductName,(od.UnitPrice*od.Quantity) as Summary,o.OrderDate
from Orders o
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where datepart(year,o.OrderDate)=1996



select distinct p.ProductName,sum(od.UnitPrice*od.Quantity) 
over (partition by p.ProductName) as Summary
from [Order Details] od 
inner join Products p on p.ProductID=od.ProductID


;WITH BitenUrunler(UrunKodu, UrunAdi) as 
(
	select ProductID as UrunKodu, ProductName as UrunAdi 
	from Products
	where UnitsInStock=0
)

select bu.UrunAdi,sum(od.Quantity*od.UnitPrice) as Summary 
from [Order Details] as od
inner join BitenUrunler bu on bu.UrunKodu=od.ProductID
group by bu.UrunAdi
order by Summary desc


select * from (
	select o.EmployeeID,o.CustomerID,count(*) as Summary 
	from Orders o
	group by o.EmployeeID,o.CustomerID) as t
PIVOT (sum(summary) for EmployeeID in ([1],[2],[3],[4],[5],[6],[7],[8],[9])) as p


use AdventureWorks2017

;with Customerwth(CustomerID) as(
	select CustomerID from Sales.Customer
	except
	select CustomerID from Sales.SalesOrderHeader
)
select c.* from Sales.Customer c
inner join Customerwth s on s.CustomerID=c.CustomerID

;with Customerwth(CustomerID) as(
	select CustomerID from Sales.Customer 
	intersect
	select CustomerID from Sales.SalesOrderHeader
)
select c.* from Sales.Customer c
inner join Customerwth s on s.CustomerID=c.CustomerID


select Name,ListPrice,
	ROW_NUMBER() over(order by ListPrice desc) as 'Row Number',
	RANK() over(order by ListPrice desc) as 'Rank',
	DENSE_RANK() over(order by ListPrice desc) as 'Dense Rank',
	NTILE(8) over(order by ListPrice desc) as 'Ntile'
from Production.Product
where ProductSubcategoryID=1


select * from Orders
where OrderID=10248


create index IX_Orders_CustomerID on Orders(CustomerID)
select OrderDate from Orders
where CustomerID='Vinet'


begin tran
update Products set UnitsInStock=100 where ProductID=1
select * from Products
rollback tran

select * from Employees
TRUNCATE Table Employees
delete from Employees where EmployeeID=10



insert into ContactInfo(FullName, HomePhone)
output inserted.*
values('Uzay Keser', '0544 444 44 44')
