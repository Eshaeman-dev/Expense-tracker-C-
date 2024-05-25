CREATE TABLE income(
id Int PRIMARY KEY IDENTITY(1,1),
category varchar(max) NULL,
item varchar(max) NULL,
income float NULL,
description text null,
date_income date null,
date_insert date null
);