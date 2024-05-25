CREATE DATABASE ExpenseTracker

Use ExpenseTracker
CREATE TABLE users(
id int PRIMARY KEY IDENTITY (1,1),
username varchar(max) NULL,
password varchar(max) NULL,
date_create Date NULL
);