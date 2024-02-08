if db_id('Student') IS NULL 
    CREATE DATABASE Student
go

use Student

create table UserLogin (
	id int primary key identity,
    username varchar(10) unique not null,
    [password] varchar (12) not null
);

create table Registration (
	regNo int primary key,
    firstName varchar(50),
    lastName varchar (50),
	dateOfBirth dateTime,
	gender varchar(50),
	[address] varchar(50),
	email varchar(50),
	mobilePhone int,
	homePhone int,
	parentName varchar(50),
	nic varchar(50),
	contactNo int
);

INSERT INTO UserLogin (username, [password])
VALUES ('Admin', 'Skills@123');