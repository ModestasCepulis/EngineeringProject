CREATE TABLE Orders
(
Order_ID numeric (5) NOT NULL,
Order_Type char (10) NOT NULL,
Value numeric (15) NOT NULL,
Amount numeric (8) NOT NULL,
Delivery_Address char (20) NOT NULL UNIQUE,
Delivery_Date char (10) NOT NULL,
Status char (1) NOT NULL,
Customer_ID numeric (5) NOT NULL,
CONSTRAINT pk_Orders PRIMARY KEY (Order_ID),
FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID)
);