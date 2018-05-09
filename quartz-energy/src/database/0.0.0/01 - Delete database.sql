USE [master]

-- Delete database
IF EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'FracSchedule')
BEGIN    
	ALTER DATABASE [FracSchedule] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [FracSchedule];    
END
GO

-- Delete login
IF EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'FracSchedule')
BEGIN
	DROP LOGIN [FracSchedule]
END 
GO