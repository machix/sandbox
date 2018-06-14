USE [master]

-- Delete database
IF EXISTS (SELECT * FROM [master].[dbo].[sysdatabases] WHERE name = 'Ideas')
BEGIN    
	ALTER DATABASE [Ideas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [Ideas];    
END
GO

-- Delete login
IF EXISTS 
    (SELECT [name]
     FROM [sys].[server_principals]
     WHERE [name] = 'Ideas')
BEGIN
	DROP LOGIN [Ideas]
END 
GO