CREATE DATABASE ExpenseTracker

Use ExpenseTracker
CREATE TABLE users(
id int PRIMARY KEY IDENTITY (1,1),
username varchar(max) NULL,
password varchar(max) NULL,
date_create Date NULL
);
select * from users
CREATE TABLE income(
id Int PRIMARY KEY IDENTITY(1,1),
category varchar(max) NULL,
item varchar(max) NULL,
income float NULL,
description text null,
date_income date null,
date_insert date null
);
select * from income

CREATE TABLE expenses(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
item VARCHAR(MAX) NULL,
cost FLOAT NULL,
description VARCHAR(MAX) NULL,
date_expense DATE NULL,
date_insert DATE NULL
);

SELECT * FROM expenses

