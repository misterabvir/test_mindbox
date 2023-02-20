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

INSERT INTO Products (ProductId, ProductName) VALUES
(1, 'Product 1'),
(2, 'Product 2'),
(3, 'Product 3');
(4, 'Product 4');

INSERT INTO Categories (CategoryId, CategoryName) VALUES
(1, 'Category 1'),
(2, 'Category 2'),
(3, 'Category 3');

INSERT INTO ProductCategory (ProductId, CategoryId) VALUES
(1, 1),
(1, 2),
(2, 2),
(2, 3),
(3, 1);

SELECT ProductName, CategoryName
FROM 
Products LEFT JOIN ProductCategory 
ON Products.ProductId= ProductCategory.ProductId 
	LEFT JOIN Categories 
	ON ProductCategory.CategoryId = Categories.CategoryId;