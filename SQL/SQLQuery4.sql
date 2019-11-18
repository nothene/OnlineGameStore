--Select * from Library

--select * from Account
--select * from Friend

--insert into Account (username, password, balance, picture, display_name, creation_date, total_hours) values 
--	('patch', 'password', 1000, null, 'patch', convert(datetime, '11/23/2005'), 150);

--select * from Account

--insert into Games (title, studio, publisher, price, discount, genre) values 
--	('Ourcraft', 'Majang', 'Macrosoft', 29, null, 'action'),
--	('White Souls', 'Grom Software', 'Witvision', 29, null, 'action'),
--	('World of Planes', 'Fukk Studios', 'Maicrosoft', 15, null, 'simulation');

--select * from Account

--select * from Games

insert into Library (user_id, game_id) values
	(1, 1),
	(2, 2),
	(1, 3),
	(2, 1),
	(4, 2),
	(8, 2),
	(3, 1),
	(9, 1),
	(4, 3),
	(3, 3),
	(2, 3),
	(6, 3);

--select * from library

--Drop Table Purchase

--Create Table Purchase (
--	purchase_id int not null identity(1,1) primary key,
--	user_id int not null foreign key references Account(user_id),
--	game_id int not null foreign key references Games(game_id),
--	purchase_date datetime
--);

insert into Purchase (user_id, game_id, purchase_date) values
	(1, 1, convert(datetime, '11/23/2015')),
	(2, 2, convert(datetime, '12/12/2010')),
	(1, 3, convert(datetime, '11/22/2017')),
	(2, 1, convert(datetime, '11/24/2017')),
	(4, 2, convert(datetime, '1/5/2018')),
	(8, 2, convert(datetime, '11/3/2014')),
	(3, 1, convert(datetime, '12/23/2011')),
	(9, 1, convert(datetime, '6/23/2018')),
	(4, 3, convert(datetime, '1/23/2016')),
	(3, 3, convert(datetime, '7/3/2013')),
	(2, 3, convert(datetime, '10/3/2016')),
	(6, 3, convert(datetime, '11/4/2012'));

--  exec sp_columns Purchase;

--select * from Account;

--insert into Friend values 
--	(1, 3),
--	(1, 8),
--	(1, 12),
--	(4, 6),
--	(3, 8),
--	(6, 10),
--	(6, 12),
--	(1, 12),
--	(12, 4);

--select * from Friend;

--select Account.username, Games.title, Purchase.purchase_date, Games.price from((Purchase inner join Games on Purchase.game_id = Games.game_id) inner join Account on Account.user_id = Purchase.user_id)

--select * from Purchase

--select Games.title, Purchase.purchase_date, Games.price from (Purchase inner join Games on Purchase.game_id = Games.game_id)
