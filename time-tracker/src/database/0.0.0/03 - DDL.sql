USE [TimeTracker]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Time reportings
IF OBJECT_ID (N'TimeReportings', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[TimeReportings](
		[Id] INT IDENTITY(1,1) NOT NULL,	
		[Name] NVARCHAR(50) NOT NULL
CONSTRAINT [PK_TimeReportings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	
END
GO

-- AFEs
IF OBJECT_ID (N'Afes', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[Afes](
		[Id] INT IDENTITY(1,1) NOT NULL,	
		[Name] NVARCHAR(20) NOT NULL
CONSTRAINT [PK_Afes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	
END
GO

-- Projects
IF OBJECT_ID (N'Projects', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[Projects](
		[Id] INT IDENTITY(1,1) NOT NULL,	
		[Date] DATETIME NOT NULL,
		[Comments] NVARCHAR(MAX) NULL,
		[TimeReportingId] INT NOT NULL,
		[AfeId] INT NOT NULL,
		[LogTime] DATETIME NULL,
		[IsManualEntry] BIT NOT NULL,
		[ManualEntryStart] DATETIME NULL,
		[ManualEntryEnd] DATETIME NULL,
CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	

ALTER TABLE [dbo].[Projects] WITH CHECK ADD CONSTRAINT [FK_Projects_TimeReportings_TimeReportingId] FOREIGN KEY([TimeReportingId])
REFERENCES [dbo].[TimeReportings] ([Id])

ALTER TABLE [dbo].[Projects] WITH CHECK ADD CONSTRAINT [FK_Projects_Afes_AfeId] FOREIGN KEY([AfeId])
REFERENCES [dbo].[Afes] ([Id])

	-- Default value for Date column
	ALTER TABLE [dbo].[Projects]
		ADD CONSTRAINT DF_Projects_Date
		DEFAULT GETDATE() FOR [Date] 


	-- Default value for IsManualEntry column
	ALTER TABLE [dbo].[Projects]
		ADD CONSTRAINT DF_Projects_IsManualEntry
		DEFAULT 0 FOR [IsManualEntry] 

END
GO

-- Users
IF OBJECT_ID (N'Users', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[Users](
		[Id] INT IDENTITY(1,1) NOT NULL,	
		[Name] NVARCHAR(50) NOT NULL,
		[Email] NVARCHAR(256) NOT NULL,
		[Password] NVARCHAR(MAX) NOT NULL,
		[LastLoginDate] DATETIME NULL
CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	

END
GO

-- User Photos
IF OBJECT_ID (N'UserPhotos', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[UserPhotos](
		[Id] INT NOT NULL,	
		[FileName] NVARCHAR(255) NOT NULL,
		[MimeType] NVARCHAR(20) NOT NULL,
		[UserId] INT NOT NULL,
CONSTRAINT [PK_UserPhotos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	

ALTER TABLE [dbo].[UserPhotos] WITH CHECK ADD CONSTRAINT [FK_UuserPhotos_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])

END
GO

-- User settings
IF OBJECT_ID (N'UserSettings', N'U') IS NULL 
BEGIN
	CREATE TABLE [dbo].[UserSettings](
		[Id] INT IDENTITY(1,1) NOT NULL,			
		[UserId] INT NOT NULL,
		[CostCenterId] NVARCHAR(20) NULL,
		[DateFormat] NVARCHAR(20) NOT NULL,
		[Is12HourFormat] BIT NOT NULL,
		[MaximumWorkingHours] TINYINT NULL,
		[LoggingReminder] BIT NOT NULL,
		[MaxWorkingTimeReminder] BIT NOT NULL,
		[IdleReminder] BIT NOT NULL,
		[IdleTime] SMALLINT NULL,
		[ReminderTime] SMALLINT NULL,
		[MonReminder] BIT NOT NULL,
		[TuesReminder] BIT NOT NULL,
		[WedReminder] BIT NOT NULL,
		[ThursReminder] BIT NOT NULL,
		[FriReminder] BIT NOT NULL,
		[SatReminder] BIT NOT NULL,
		[SunReminder] BIT NOT NULL,		
		[EmailTimeEntryUpdates] BIT NOT NULL,		
		[EmailWeeklyReports] BIT NOT NULL		
CONSTRAINT [PK_UserSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)	

ALTER TABLE [dbo].[UserSettings] WITH CHECK ADD CONSTRAINT [FK_UserSettings_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])

	-- Default value for DateFormat column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_DateFormat
		DEFAULT N'dd/mm/yyyy' FOR [DateFormat] 

	-- Default value for Is24HourFormat column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_Is12HourFormat
		DEFAULT 1 FOR [Is12HourFormat] 

	-- Default value for LoggingReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_LoggingReminder
		DEFAULT 1 FOR [LoggingReminder] 

	-- Default value for MaxWorkingTimeReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_MaxWorkingTimeReminder
		DEFAULT 1 FOR [MaxWorkingTimeReminder] 

	-- Default value for IdleReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_IdleReminder
		DEFAULT 1 FOR [IdleReminder] 

	-- Default value for MonReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_MonReminder
		DEFAULT 0 FOR [MonReminder] 

	-- Default value for TuesReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_TuesReminder
		DEFAULT 0 FOR [TuesReminder] 

	-- Default value for WedReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_WedReminder
		DEFAULT 0 FOR [WedReminder] 

	-- Default value for ThursReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_ThursReminder
		DEFAULT 0 FOR [ThursReminder] 

	-- Default value for FriReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_FriReminder
		DEFAULT 0 FOR [FriReminder] 

	-- Default value for SatReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_SatReminder
		DEFAULT 0 FOR [SatReminder] 

	-- Default value for SunReminder column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_SunReminder
		DEFAULT 1 FOR [SunReminder] 
		
	-- Default value for EmailTimeEntryUpdates column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_EmailTimeEntryUpdates
		DEFAULT 1 FOR [EmailTimeEntryUpdates] 
		
	-- Default value for EmailWeeklyReports column
	ALTER TABLE [dbo].[UserSettings]
		ADD CONSTRAINT DF_UserSettings_EmailWeeklyReports
		DEFAULT 1 FOR [EmailWeeklyReports] 
		
END
GO
