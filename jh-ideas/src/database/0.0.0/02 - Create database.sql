USE [master]

-- Create database
IF NOT EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'Ideas')
BEGIN    
    CREATE DATABASE [Ideas]
    COLLATE SQL_Latin1_General_CP1_CI_AS;      
END
GO

-- Create login
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'Ideas')
BEGIN
	CREATE LOGIN [Ideas] 
		WITH PASSWORD=N'DbPassword!234', 
		DEFAULT_DATABASE=[Ideas], 
		DEFAULT_LANGUAGE=[us_english], 
		CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF
END 
GO

USE [Ideas]
GO

-- Create user
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[database_principals]
     WHERE [name] = 'Ideas')
BEGIN
	CREATE USER [Ideas] FOR LOGIN [Ideas] WITH DEFAULT_SCHEMA=[dbo]
	
	EXEC sp_addrolemember N'db_owner', N'Ideas'
END
GO
