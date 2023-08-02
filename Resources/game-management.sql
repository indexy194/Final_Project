USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'ShopAccountDB')
	DROP DATABASE GameManagement
GO

CREATE DATABASE GameManagement
GO

use GameManagement


GO

-- create tables
CREATE TABLE Users (
  users_id INT IDENTITY (1, 1) PRIMARY KEY,
  username VARCHAR (255) NOT NULL unique,
  passwords VARCHAR(40) NOT NULL,
  status VARCHAR(20),
  role int,
);
GO
CREATE TABLE Game (
  game_id INT IDENTITY (1, 1) PRIMARY KEY,
  game_name NVARCHAR (50) NOT NULL,
);
GO

CREATE TABLE Score (
	score_id INT IDENTITY (1,1) PRIMARY KEY,
	users_id INT NOT NULL,
	game_id INT NOT NULL,
	total_score BIGINT,
	FOREIGN KEY(users_id) REFERENCES Users(users_id),
	FOREIGN KEY(game_id) REFERENCES Game(game_id)
);
GO

--INSERT INTO USERS TABLE
INSERT INTO Users (username, passwords, role) VALUES ('admin','123', 1)
INSERT INTO Users (username, passwords, role) VALUES ('admin2','123', 1)
INSERT INTO Users (username, passwords,status, role) VALUES ('indexy','123','active', 2)
INSERT INTO Users (username, passwords,status, role) VALUES ('indexy2012','123','active', 2)

INSERT INTO Users (username, passwords,status, role) VALUES ('indexy1','123','active', 2)

INSERT INTO Users (username, passwords,status, role) VALUES ('indexy194','123','block', 2)
GO

--INSERT INTO GAME TABLE
INSERT INTO Game (game_name) VALUES ('Car Game')
INSERT INTO Game (game_name) VALUES ('T Rex Game')
INSERT INTO Game (game_name) VALUES ('Flappy Bird')
GO

--INSERT INTO SCORE TABLE
INSERT INTO Score (users_id, game_id, total_score) VALUES (3,1, 100)
INSERT INTO Score (users_id, game_id, total_score) VALUES (3,2, 120)
INSERT INTO Score (users_id, game_id, total_score) VALUES (3,3, 10)
INSERT INTO Score (users_id, game_id, total_score) VALUES (4,3, 12)
INSERT INTO Score (users_id, game_id, total_score) VALUES (4,3, 10)

INSERT INTO Score (users_id, game_id, total_score) VALUES (4,1, 100)



select * from Users;

select * from Game;

select sum(total_score) from Score where users_id = 3;

select * from Score;
go
select top(10) a.total_score, a.users_id, c.game_name, b.username from Score as a 
	join Users as b on a.users_id = b.users_id 
	join Game as c on a.game_id = c.game_id
	where a.game_id = 1
	group by c.game_name, a.users_id, b.username, a.total_score 
	order by a.total_score desc


select * from Users where username = 'indexy' and passwords = '123';

select top(10) a.score_id, a.total_score, c.users_id, c.username, b.game_name from Score as a 
	join Game as b on a.game_id = b.game_id 
	join Users as c on a.users_id = c.users_id 
	where a.game_id = 1
	group by a.score_id, a.total_score, c.users_id, c.username, b.game_name 
	order by a.total_score desc


update Users set passwords = '1234' where username = 'indexy1' and passwords = '12';

INSERT INTO Users (username, passwords,status, role) VALUES ('indexy2','123','block', 2)

select count(*) from users where username = 'indexy111';