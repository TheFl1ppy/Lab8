create table Users(
Id int,
Name varchar(100),
PhoneNumber varchar(255),
Role varchar(50),
Password varchar(50),
Email varchar(100),
Card varchar(50),
IsDeleted bit
)
create table TypeDelivery(
Id int,
Name varchar(50),
Cost int,
IsDeleted bit)
create table OrderUser
(Id int,
TypeDelivery int,
Address varchar(100),
IdUsers int,
IsDeleted bit,
status varchar(50))
create table Cart(
IdOrder int,
IdProduct int,
Amount int,
TotalCost int,
IsDeleted bit)
create table Product(
Id int,
Name varchar(100),
Cost int,
Discount int,
Categories int,
IsDeleted bit)
create table CategoriseProduct(
Id int,
Name varchar(100),
IsDeleted bit)
create table Filter
(Id int,
Name varchar(50),
Categorise int,
IsDeleted bit)

