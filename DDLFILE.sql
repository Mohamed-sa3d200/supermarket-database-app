
INSERT INTO Customer (Name, Email, Password, Address, Phone) VALUES
('Alice Smith', 'alice@example.com', 'password123', '123 Maple Street', '555-1234'),
('Bob Johnson', 'bob@example.com', 'securepass', '456 Oak Avenue', '555-5678'),
('Carol White', 'carol@example.com', 'letmein', '789 Pine Road', '555-9012');


INSERT INTO Admin (Name, Email, Password, Phone) VALUES
('Admin John', 'adminjohn@example.com', 'adminpass', '555-1111'),
('Admin Jane', 'adminjane@example.com', 'admin123', '555-2222');

INSERT INTO Supplier (S_Name, Address, Phone) VALUES
('Fresh Farms', '101 Farm Lane', '555-3333'),
('Grocery Goods Co.', '202 Market St', '555-4444');


INSERT INTO Category (Category_name, Description) VALUES
('Beverages', 'Drinks of all kinds'),
('Snacks', 'Chips, biscuits, and munchies'),
('Dairy', 'Milk, cheese, yogurt, etc.');


INSERT INTO Product (P_Name, Description, Price, Quantity, StockQuantity, MinStockThreshold, Category_id, Supplier_id) VALUES
('Orange Juice', 'Freshly squeezed orange juice', 3.99, 100, 80, 20, 1, 1),
('Potato Chips', 'Salted potato chips', 1.49, 200, 150, 30, 2, 2),
('Milk 1L', 'Whole milk', 0.99, 150, 120, 25, 3, 1);


INSERT INTO [Order] (Customer_id, Admin_id, Order_Date, Total_Amount, Status) VALUES
(1, 1, GETDATE(), 5.48, 'Completed'),
(2, 2, GETDATE(), 3.99, 'Pending');


INSERT INTO OrderItem (Order_id, Product_id, U_Price, Quantity) VALUES
(1, 1, 3.99, 1),
(1, 2, 1.49, 1),
(2, 1, 3.99, 1);


INSERT INTO Payment (Order_id, Total_Paid, Payment_Date, Payment_Method) VALUES
(1, 5.48, GETDATE(), 'Credit Card'),
(2, 3.99, GETDATE(), 'Cash');


INSERT INTO Voucher (CustomerId, VoucherCode, Amount, ExpiryDate, Status) VALUES
(1, 'WELCOME10', 10.00, '2025-12-31', 'Active'),
(2, 'SAVE5', 5.00, '2025-06-30', 'Used');
