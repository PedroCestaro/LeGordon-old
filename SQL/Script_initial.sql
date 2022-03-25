Create Database LeGordon;

use LeGordon;

Create Table Customers(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	Name varchar(250),
	Document varchar(25),
	BirthDate Datetime2,
	Email varchar(100),
	Login varchar(50),
	Password varbinary(200) 
);

Create Table CustomersAdresses(
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	CustomerId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Customer(Id),
	Address varchar(300),
	Number varchar(20),
	Reference varchar(250),
	ZipCode int(8),
	CityId int
);

Create Table Cities(
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	Name varchar(200),
	StateId int not null
);


Create Table CustomersPhones(
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	CustomerId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Customer(Id),
	PhoneNumber varchar(50)
);

Create Table Users(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	Name varchar(250),
	Document varchar(25),
	BirthDate Datetime2,
	Email varchar(100),
	Username varchar(50),
	Password varbinary(200),
	Address varchar(300),
	Number varchar(20),
	Reference varchar(250),
	ZipCode int(8),
);

Create Table UsersRoles(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	UserId UNIQUEIDENTIFIER not null References Users(Id),
	RoleId int not null FOREIGN key REFERENCES Roles(Id)
)

Create Table Roles(
	Id int not null PRIMARY KEY identity(1,1),
	Section varchar(50),
	Values mediumtext,
)

Create Table UsersPhones(
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	UserId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Users(Id),
	PhoneNumber varchar(50)
);

Create Table Orders(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	CustomerId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Customer(Id),
	Date Datetime2,
	Value numeric(10,2),
	CouponId int FOREIGN KEY References Coupons(Id),
	IsForDelivery bit NOT NULL DEFAULT 1,
	ClientAddressId FOREIGN KEY References CustomersAdresses(Id),
	StatusId int Not null DEFAULT 0,

);

Create Table OrdersPaymentType(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	OrderId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Orders(Id),
	PaymentTypeId int not null FOREIGN KEY References PaymentTypes(Id),
	Date Datetime2 not null DEFAULT GETDATE();
	ShippingTypeId int not null foreign key REFERENCES ShippingTypes(Id)
);

Create TABLE ShippingTypes(
	Id int not NULL identity(1,1) PRIMARY KEY,
	Description varchar(50),
	ShippingTypeId int not null foreign key REFERENCES ShippingTypes(Id),
	StatusId int not null foreign key REFERENCES ShippingStatus(Id)
);

Create TABLE ShippingStatus(
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	Description varchar(50)
)

Create Table OrderDeliveries(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	OrderId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Orders(Id),
)

Create Table OrderItems(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	OrderId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Orders(Id),
	ProductId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Products(Id),
);

Create Table Products(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	Name varchar(100),
	SKU VARCHAR(50),
	Description mediumtext, 
	IsActive bit not null DEFAULT 1,
	Value numeric(10,2),
	CategoryId int not null FOREIGN KEY References Categories(Id)
);

CREATE TABLE ProductsImages(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	ProductId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Products(Id),
	ImageUrl VARCHAR(500)
)

Create Table Categories(
 	Id int identity(1,1) NOT NULL PRIMARY KEY,
 	Name varchar(100),
 	IsActive bit DEFAULT 1,
 );

 Create Table Coupons(
 	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
 	Code varchar(10),
 	Discount numeric(3,2)
);

Create Table Basket(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	CustomerId int not null FOREIGN KEY References Customers(Id),
	Date Datetime2,
	IsFinished bit not null DEFAULT 0
);

Create Table BasketItems(
	 Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	 BasketId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Basket(Id),
	 ProductId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Products(Id)
);


Create Table PaymentTypes( --cards, cash, etc
	Id int not null identity(1,1) PRIMARY KEY,
	Description varchar(100)
);

Create TABLE CashPayments (
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	CustomerId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Customer(Id),
	OrderId UNIQUEIDENTIFIER NOT NULL Foreign KEY REFERENCES Orders(Id),
	Value NUMERIC (10,2),
	DATE DATETIME2 not null DEFAULT DATETIME(),
	Status int foreing key REFERENCES PaymentStatus(id)
);

CREATE TABLE CardsPayments(
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	CustomerId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY References Customer(Id),
	OrderId UNIQUEIDENTIFIER NOT NULL Foreign KEY REFERENCES Orders(Id),
	Value NUMERIC (10,2),
	DATE DATETIME2 not null DEFAULT DATETIME(),
	BrandId INT Not null foreign KEY REFERENCES CardsBrands(Id),
	CardType int,
	Status int foreing key REFERENCES PaymentStatus(id)
);

Create Table CardsBrands( 
	Id int not null identity(1,1) PRIMARY KEY,
	Name varchar(50)
);