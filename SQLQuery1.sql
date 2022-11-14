CREATE TABLE Member(
	MemberId int not null PRIMARY KEY IDENTITY(1, 1),
	Email varchar(100) not null,
	CompanyName varchar(40) not null,
	City varchar(15) not null,
	Country varchar(15) not null,
	Password varchar(30) not null,
	Fullname varchar(40) not null
)

CREATE TABLE [Order](
	OrderId int not null PRIMARY KEY,
	MemberId int not null,
	OrderDate datetime not null,
	RequiredDate datetime,
	ShippedDate datetime,
	Freight money,
	FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
)

CREATE TABLE Category(
	CategoryId int not null PRIMARY KEY,
	CategoryName varchar(50) not null
)


CREATE TABLE Product(
	ProductId int not null PRIMARY KEY,
	CategoryId int not null,
	ProductName varchar(40) not null,
	Weight varchar(20) not null,
	UnitPrice money not null,
	UnitsInStock  int not null,
	FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
	
)

CREATE TABLE OrderDetail(
	OrderId int not null,
	ProductId int not null,
	UnitPrice money not null,
	Quantity int not null,
	Discount float not null,
	FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
	FOREIGN KEY (OrderId) REFERENCES [Order](OrderId)
)

