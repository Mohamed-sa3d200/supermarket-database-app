
-- Create the database
CREATE DATABASE SupermarketDatabase;
GO

-- Use the database
USE SupermarketDatabase;
GO


-- Customer table
CREATE TABLE Customer (
    Customer_id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
	Address NVARCHAR(255),
	Phone NVARCHAR(20)
);

CREATE TABLE Admin (
    Admin_id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
	Phone NVARCHAR(20)
);


-- Supplier table
CREATE TABLE Supplier (
    Supplier_id INT PRIMARY KEY IDENTITY(1,1),
    S_Name NVARCHAR(100),
	Address NVARCHAR(255),
	Phone NVARCHAR(20)

);

-- Category table
CREATE TABLE Category (
    Category_id INT PRIMARY KEY IDENTITY(1,1),
    Category_name NVARCHAR(100),
    Description NVARCHAR(MAX)
);

-- Product table
CREATE TABLE Product (
    Product_id INT PRIMARY KEY IDENTITY(1,1),
    P_Name NVARCHAR(100),
    Description NVARCHAR(MAX),
    Price DECIMAL(10, 2),
    Quantity INT,
	StockQuantity INT NOT NULL CHECK (StockQuantity >= 0),
    MinStockThreshold INT NOT NULL CHECK (MinStockThreshold >= 0),
    Category_id INT,
    Supplier_id INT,
    FOREIGN KEY (Category_id) REFERENCES Category(Category_id),
    FOREIGN KEY (Supplier_id) REFERENCES Supplier(Supplier_id)
);

-- Order table (Use square brackets for reserved keyword "Order")
CREATE TABLE [Order] (
    Order_id INT PRIMARY KEY IDENTITY(1,1),
    Customer_id INT,
    Admin_id INT,
    Order_Date DATE  DEFAULT GETDATE(),
    Total_Amount DECIMAL(10, 2),
    Status NVARCHAR(50) DEFAULT 'Pending',
    FOREIGN KEY (Customer_id) REFERENCES Customer(Customer_id),
    FOREIGN KEY (Admin_id) REFERENCES Admin(Admin_id)
);

-- OrderItem table
CREATE TABLE OrderItem (
    Order_id INT,
    Product_id INT,
    U_Price DECIMAL(10, 2),
    Quantity INT,
    PRIMARY KEY (Order_id, Product_id),
    FOREIGN KEY (Order_id) REFERENCES [Order](Order_id),
    FOREIGN KEY (Product_id) REFERENCES Product(Product_id)
);

-- Payment table
CREATE TABLE Payment (
    Payment_id INT PRIMARY KEY IDENTITY(1,1),
    Order_id INT,
    Total_Paid DECIMAL(10, 2),
    Payment_Date DATE  DEFAULT GETDATE(),
    Payment_Method NVARCHAR(50),
    FOREIGN KEY (Order_id) REFERENCES [Order](Order_id)
);


-- Voucher Table
CREATE TABLE Voucher(
	VoucherId INT PRIMARY KEY IDENTITY(1,1), 
	CustomerId INT NOT NULL,
    VoucherCode NVARCHAR(50) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL CHECK (Amount >= 0),
    ExpiryDate DATE NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customer(Customer_id)
);



