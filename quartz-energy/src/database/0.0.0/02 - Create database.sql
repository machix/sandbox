USE [master]

-- Create database
IF NOT EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'QuartzEnergy')
BEGIN    
    CREATE DATABASE [QuartzEnergy]
    COLLATE SQL_Latin1_General_CP1_CI_AS;      
END
GO

-- Create login
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'QuartzEnergy')
BEGIN
	CREATE LOGIN [QuartzEnergy] 
		WITH PASSWORD=N'DbPassword!234', 
		DEFAULT_DATABASE=[QuartzEnergy], 
		DEFAULT_LANGUAGE=[us_english], 
		CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF
END 
GO

USE [QuartzEnergy]
GO

-- Create user
IF NOT EXISTS 
    (SELECT [name]
     FROM [sys].[database_principals]
     WHERE [name] = 'QuartzEnergy')
BEGIN
	CREATE USER [QuartzEnergy] FOR LOGIN [QuartzEnergy] WITH DEFAULT_SCHEMA=[dbo]
	
	EXEC sp_addrolemember N'db_owner', N'QuartzEnergy'
END
GO
