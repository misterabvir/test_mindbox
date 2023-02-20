/*
	связь многие ко многим предполагает наличие к таплицам Products и Categories 
	наличие третьей таблицы ProductCategory
	
	CREATE TABLE Products (
	   ProductId INT PRIMARY KEY,
	   ProductName VARCHAR(30)
	);

	CREATE TABLE Categories (
	   CategoryId INT PRIMARY KEY,
	   CategoryName VARCHAR(30)
	);

	CREATE TABLE ProductCategory (
	   ProductId INT,
	   CategoryId INT,
	   FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
	   FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
	);
	
	запрос должен включать в себя LEFT JOIN для таблиц Products и CategoryOfProduct с Categories,
	он выберет все записи включая те которые не имеют соответствующих записей в таблице Categories
*/

SELECT ProductName, CategoryName
FROM 
Products LEFT JOIN ProductCategory 
ON Products.ProductId= ProductCategory.ProductId 
	LEFT JOIN Categories 
	ON ProductCategory.CategoryId = Categories.CategoryId;