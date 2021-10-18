create database StockManager
use StockManager

create table login
(
adminname varchar(50) primary key,
adminpassword int
)

insert into login values('admin',123456789)

create table customers
(
IDC int primary key,
Name varchar(50),
Email varchar(50),
Tel int
)

insert into customers values(1,'cost1','cost1@gmail.com',+332456789)

create table Product
(
Pname varchar(50) primary key,
CatName varchar(50),
Pstock int,
Pprice int
)

insert into Product values('PC','IT',54,400)


create Table Category
(ID int primary key,
CategoryName varchar(50))

insert into Category values(1,'IT')
insert into Category values(2,'EK')

create Table Sales
(
RefSales int primary key,
CustID int foreign key references customers(IDC),
ProductName varchar(50) foreign key references Product(Pname) ,
Price int,
productStock int,
SalesDate date,
)


create table Stock
(
IDStock int primary key,
Category varchar(50),
PName varchar(50),
PStock int,
)

select * from login
select * from customers
select * from Product






