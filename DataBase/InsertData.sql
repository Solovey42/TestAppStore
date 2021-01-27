INSERT INTO clients (Name, Phone) VALUES ('Соловьев В.Д', '+79992345566');
INSERT INTO clients (Name, Phone) VALUES ('Иванов А.А', '+72345557777');
INSERT INTO clients (Name, Phone) VALUES ('Петров Г.У', '+79234445555');
INSERT INTO clients (Name, Phone) VALUES ('Степанова Е.А', '+79992345566');

INSERT INTO products (Type, Cost, Info) VALUES ('Телефон', 19999, 'Камера: 8mp, Встроенная память: 16гб');
INSERT INTO products (Type, Cost, Info) VALUES ('Телевизор', 32500.50, 'Диагональ: 40 дюймов');
INSERT INTO products (Type, Cost, Info) VALUES ('Компьютер', 29999.99, 'Ядер процессора: 8, Оперативная память: 16');
INSERT INTO products (Type, Cost, Info) VALUES ('Домашний кинотеатр', 41000, '6 колонок, 1 сабвуфер');

INSERT INTO orders (ClientID, ProductID, "Date") VALUES (13, 5, '2021-01-23');
INSERT INTO orders (ClientID, ProductID, "Date") VALUES (14, 6, '2020-12-30');
INSERT INTO orders (ClientID, ProductID, "Date") VALUES (15, 5, '2021-01-09');
INSERT INTO orders (ClientID, ProductID, "Date") VALUES (15, 6, '2021-01-11');
INSERT INTO orders (ClientID, ProductID, "Date") VALUES (16, 7, '2021-01-12');

