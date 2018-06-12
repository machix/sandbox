USE [TimeTracker]
GO

IF NOT EXISTS (SELECT * FROM [TimeReportings])
BEGIN 
	SET IDENTITY_INSERT [TimeReportings] ON
	
	INSERT INTO [TimeReportings] ([Id], [Name]) VALUES 
		(1, N'Regular'),
		(2, N'Paid Time Off'),
		(3, N'Holiday'),
		(4, N'Jury duty'),
		(5, N'Bereavement'),
		(6, N'Extended sick leave @ 100%'),
		(7, N'LWOP'),
		(8, N'Military Leave'),
		(9, N'Military Training'),
		(10, N'Office Closing'),
		(11, N'PTO Relocation Co Sponsor'),
		(12, N'STD @ 66.67%'),
		(13, N'Tribe Resv Memo Only'),
		(14, N'Workers'' Compensation');	
		
	SET IDENTITY_INSERT [TimeReportings] OFF
END

IF NOT EXISTS (SELECT * FROM [Afes])
BEGIN 
	SET IDENTITY_INSERT [Afes] ON
	
	INSERT INTO [Afes] ([Id], [Name]) VALUES 
		(1, N'AFE00120'),
		(2, N'AFE00121'),
		(3, N'AFE00122'),
		(4, N'AFE00123'),
		(5, N'AFE00124'),
		(6, N'AFE00125'),
		(7, N'AFE00126'),
		(8, N'CC0001230'),
		(9, N'CC0001231'),
		(10, N'CC0001232'),
		(11, N'CC0001233'),
		(12, N'CC0001234'),
		(13, N'CC0001235'),
		(14, N'CC0001236');	
		
	SET IDENTITY_INSERT [Afes] OFF
END

DECLARE @today DATETIME
SET @today = DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0)

TRUNCATE TABLE [Projects];

SET IDENTITY_INSERT [Projects] ON

INSERT INTO [Projects] ([Id], [Date], [Comments], [TimeReportingId], [AfeId]) VALUES 	
	(1, @today, N'Lorem Ipsum is simply dummy text of the printing and typesetting industry.', 1, 1),
	(2, @today, N'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.', 2, 2),
	(3, @today, N'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', 3, 3),
	(4, @today, N'It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 4, 4),
	(5, @today, N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.', 5, 5);
 
 SET IDENTITY_INSERT [Projects] OFF