USE [master]

-- Delete database
IF EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'QuartzEnergy')
BEGIN    
	ALTER DATABASE [QuartzEnergy] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [QuartzEnergy];    
END
GO

-- Delete login
IF EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'QuartzEnergy')
BEGIN
	DROP LOGIN [QuartzEnergy]
END 
GO