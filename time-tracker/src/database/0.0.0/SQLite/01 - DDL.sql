
PRAGMA foreign_keys = ON;

-- Time reportings
CREATE TABLE IF NOT EXISTS [TimeReportings](
	[Id] INT PRIMARY KEY,	
	[Name] NVARCHAR(50) NOT NULL UNIQUE
) WITHOUT ROWID;

-- AFEs
CREATE TABLE IF NOT EXISTS [Afes](
	[Id] INT PRIMARY KEY,	
	[Name] NVARCHAR(20) NOT NULL UNIQUE
) WITHOUT ROWID;

-- Projects
CREATE TABLE IF NOT EXISTS [Projects](
	[Id] INT PRIMARY KEY,	
	[Date] DATETIME NOT NULL DEFAULT(DATETIME('now')),
	[Comments] TEXT NULL,
	[TimeReportingId] INT NOT NULL,
	[AfeId] INT NOT NULL,
	[LogTime] DATETIME NULL,
	[IsManualEntry] BIT NOT NULL DEFAULT(0),
	[ManualEntryStart] DATETIME NULL,
	[ManualEntryEnd] DATETIME NULL,
	[IsArchived] BIT NOT NULL DEFAULT(0),
	
	FOREIGN KEY ([TimeReportingId]) REFERENCES [TimeReportings] ([Id]),
	FOREIGN KEY ([AfeId]) REFERENCES [Afes] ([Id])		
) WITHOUT ROWID;

-- Users
CREATE TABLE IF NOT EXISTS [Users](
	[Id] INT PRIMARY KEY,	
	[Name] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(256) NOT NULL,
	[Password] TEXT NOT NULL,
	[LastLoginDate] DATETIME NULL
) WITHOUT ROWID;

-- User Photos
CREATE TABLE IF NOT EXISTS [UserPhotos](
		[Id] INT PRIMARY KEY,	
		[FileName] NVARCHAR(255) NOT NULL,
		[MimeType] NVARCHAR(20) NOT NULL,
		[UserId] INT NOT NULL,
		
		FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
) WITHOUT ROWID;

-- User settings
CREATE TABLE IF NOT EXISTS [UserSettings](
		[Id] INT PRIMARY KEY,
		[UserId] INT NOT NULL,
		[CostCenterId] NVARCHAR(20) NULL,
		[DateFormat] NVARCHAR(20) NOT NULL DEFAULT('dd/mm/yyyy'),
		[Is12HourFormat] BIT NOT NULL DEFAULT(1),
		[MaximumWorkingHours] TINYINT NULL,
		[LoggingReminder] BIT NOT NULL DEFAULT(1),
		[MaxWorkingTimeReminder] BIT NOT NULL DEFAULT(1),
		[IdleReminder] BIT NOT NULL DEFAULT(1),
		[IdleTime] SMALLINT NULL,
		[ReminderTime] SMALLINT NULL,
		[MonReminder] BIT NOT NULL DEFAULT(0),
		[TuesReminder] BIT NOT NULL DEFAULT(0),
		[WedReminder] BIT NOT NULL DEFAULT(0),
		[ThursReminder] BIT NOT NULL DEFAULT(0),
		[FriReminder] BIT NOT NULL DEFAULT(0),
		[SatReminder] BIT NOT NULL DEFAULT(0),
		[SunReminder] BIT NOT NULL DEFAULT(1),		
		[EmailTimeEntryUpdates] BIT NOT NULL DEFAULT(1),		
		[EmailWeeklyReports] BIT NOT NULL DEFAULT(1),
		
		FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
) WITHOUT ROWID;