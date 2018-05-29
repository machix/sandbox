USE [master]

-- Delete database
IF EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'TimeTracker')
BEGIN    
	ALTER DATABASE [TimeTracker] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [TimeTracker];    
END
GO

-- Delete login
IF EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'TimeTracker')
BEGIN
	DROP LOGIN [TimeTracker]
END 
GO