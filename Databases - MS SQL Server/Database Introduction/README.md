CREATE DATABASE [Minions]

USE [Minions]

CREATE TABLE [Minions] (
[Id] INT PRIMARY KEY NOT NULL
,[Name] NVARCHAR(50) NOT NULL
, [Age] INT
)

CREATE TABLE [Towns](
[Id] INT PRIMARY KEY NOT NULL,
[Name] NVARCHAR(50)
) 

ALTER TABLE [Minions]
ADD [TownId] INT 

ALTER TABLE [Minions]
ADD CONSTRAINT [FK_MinionsTownId] FOREIGN KEY (TownId) REFERENCES [Towns] ([Id])

INSERT INTO [Towns]([Id], [Name]) VALUES
(1, 'Sofia'),
(2, 'Ploviv'),
(3, 'Varna');

INSERT INTO [Minions]([Id], [Name], [Age], [TownId]) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Stewart', NULL, 2);

DROP TABLE [Minions]

CREATE TABLE [Minions] (
[Id] INT PRIMARY KEY NOT NULL
,[Name] NVARCHAR(50) NOT NULL
, [Age] INT
)

DROP TABLE [Towns]

TRUNCATE TABLE [Minions]
