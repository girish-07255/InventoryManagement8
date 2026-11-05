-- Run this once in SSMS / Azure Data Studio / VS SQL Server Object Explorer
IF DB_ID('InventoryDB') IS NULL
    CREATE DATABASE InventoryDB;
GO

USE InventoryDB;
GO

IF OBJECT_ID('dbo.Products', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Products (
        ProductID   INT IDENTITY(1,1) PRIMARY KEY,
        ProductName VARCHAR(100) NOT NULL,
        Category    VARCHAR(50)  NOT NULL,
        Quantity    INT          NOT NULL CHECK (Quantity >= 0),
        Price       DECIMAL(10,2) NOT NULL CHECK (Price >= 0)
    );

    INSERT INTO dbo.Products (ProductName, Category, Quantity, Price)
    VALUES ('Laptop',   'Electronics', 10, 45000),
           ('Mouse',    'Accessories', 25, 500),
           ('Keyboard', 'Accessories', 15, 1000);
END
GO

SELECT * FROM dbo.Products;
