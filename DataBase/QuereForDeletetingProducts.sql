UPDATE Products
SET cost = NULL,
	INFO = NULL
WHERE Type = 'Компьютер';

DELETE FROM Products where Type = 'Компьютер';