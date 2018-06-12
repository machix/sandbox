USE [master]

-- Create database
IF NOT EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'TimeTracker')
BEGIN    
    CREATE DATABASE [TimeTracker]
    COLLATE SQL_Latin1_General_CP1_CI_AS;      
END
GO

-- Create login
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'TimeTracker')
BEGIN
	CREATE LOGIN [TimeTracker] 
		WITH PASSWORD=N'DbPassword!234', 
		DEFAULT_DATABASE=[TimeTracker], 
		DEFAULT_LANGUAGE=[us_english], 
		CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF
END 
GO

USE [TimeTracker]
GO

-- Create user
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[database_principals]
     WHERE [name] = 'TimeTracker')
BEGIN
	CREATE USER [TimeTracker] FOR LOGIN [TimeTracker] WITH DEFAULT_SCHEMA=[dbo]
	
	EXEC sp_addrolemember N'db_owner', N'TimeTracker'
END
GO
