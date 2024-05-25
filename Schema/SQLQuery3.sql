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