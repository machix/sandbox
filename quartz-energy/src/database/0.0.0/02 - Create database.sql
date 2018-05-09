USE [master]

-- Create database
IF NOT EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'FracSchedule')
BEGIN    
    CREATE DATABASE [FracSchedule]
    COLLATE SQL_Latin1_General_CP1_CI_AS;      
END
GO

-- Create login
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'FracSchedule')
BEGIN
	CREATE LOGIN [FracSchedule] 
		WITH PASSWORD=N'DbPassword!234', 
		DEFAULT_DATABASE=[FracSchedule], 
		DEFAULT_LANGUAGE=[us_english], 
		CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF
END 
GO

USE [FracSchedule]
GO

-- Create user
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[database_principals]
     WHERE [name] = 'FracSchedule')
BEGIN
	CREATE USER [FracSchedule] FOR LOGIN [FracSchedule] WITH DEFAULT_SCHEMA=[dbo]
	
	EXEC sp_addrolemember N'db_owner', N'FracSchedule'
END
GO
