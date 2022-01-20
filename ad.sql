create database ADEVERTISEMENT

use ADEVERTISEMENT

Create table Customer
(
CustomerID  int Primary key,
CustomerName varchar(20),
PhoneNo int,
City varchar(10),
Email varchar(50),
[Password] varchar(20)
)

Create table Advertisement
(
Ad_Id varchar(10),
CustomerID int,
Ad_Title varchar(50),
Ad_Type varchar(50),
Ad_Date Date,
BookingDate Date,
constraint fk_Advertisement_ foreign key(CustomerID) references Customer(CustomerID)
)

Create table Payments
(
payment_id varchar(10),
CustomerID int,
payment_date Date,
Amount decimal(5,2),
constraint fk_Payments_ foreign key(CustomerID) references Customer(CustomerID)
)

select * from Customer
select * from Advertisement
select * from Payments