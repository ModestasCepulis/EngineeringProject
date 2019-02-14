DROP TABLE Customers;
DROP TABLE Stock;
DROP TABLE Orders;
DROP TABLE Orders_Items;



CREATE TABLE Customers
(
Customer_ID numeric(5) NOT NULL,
First_Name char(15) NOT NULL,
Last_Name char(15) NOT NULL,
Address char(20) NOT NULL UNIQUE,
Date_Of_Birth char(10) NOT NULL,
Phone_Number char(13) NOT NULL UNIQUE,
Email_Address char(25) NOT NULL,
Status char(1) NOT NULL,
Username char (15) NOT NULL UNIQUE,
Password char (15) NOT NULL UNIQUE,
CONSTRAINT pk_Customers PRIMARY KEY (Customer_ID)
);

CREATE TABLE Stock
(
Stock_ID numeric (3) NOT NULL,
Stock_type char (7) NOT NULL,
Stock_Amount numeric (8) NOT NULL,
Stock_Date char (10) NOT NULL,
CONSTRAINT pk_Stock PRIMARY KEY (Stock_ID)
);

CREATE TABLE Orders
(
Order_ID numeric (5) NOT NULL,
Order_Type char (10) NOT NULL,
Value numeric (15) NOT NULL,
Amount numeric (8) NOT NULL,
Delivery_Address numeric (20) NOT NULL UNIQUE,
Delivery_Date char (10) NOT NULL,
Status char (1) NOT NULL,
Customer_ID numeric (5) NOT NULL,
CONSTRAINT pk_Orders PRIMARY KEY (Order_ID),
FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID)
);

CREATE TABLE Orders_Items
(
Amount numeric (8) NOT NULL,
Item_Type char (7) NOT NULL,
Order_ID numeric (5) NOT NULL,
FOREIGN KEY (Order_ID) REFERENCES Orders(Order_ID)
);

