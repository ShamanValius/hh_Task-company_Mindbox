CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Яблоко'),
	(2, 'BMW'),
	(3, 'ASUS rog'),
	(4, 'Redmi');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Книги'),
	(2, 'Машины'),
	(3, 'Компьютеры'),
	(4, 'Телефоны');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(3, 3),
	(2, 2),
	(4, 4);

SELECT Products."Name" [Имя продукта], Categories."Name" [Имя категории]
FROM Products
LEFT JOIN ProductCategories
	ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
	ON ProductCategories.CategoryId = Categories.Id;