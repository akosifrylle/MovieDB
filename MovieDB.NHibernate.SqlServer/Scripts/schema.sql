USE [master]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'movie_db')
BEGIN
CREATE DATABASE movie_db
END

USE [movie_db]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Genre')
BEGIN
CREATE TABLE Genre(
	[Id] [BIGINT] IDENTITY (1,1) NOT NULL,
	[NAME] [NVARCHAR] (50) NOT NULL
	)
END