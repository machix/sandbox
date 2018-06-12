
INSERT OR REPLACE INTO [TimeReportings] ([Id], [Name]) VALUES 
	(1, 'Regular'),
	(2, 'Paid Time Off'),
	(3, 'Holiday'),
	(4, 'Jury duty'),
	(5, 'Bereavement'),
	(6, 'Extended sick leave @ 100%'),
	(7, 'LWOP'),
	(8, 'Military Leave'),
	(9, 'Military Training'),
	(10, 'Office Closing'),
	(11, 'PTO Relocation Co Sponsor'),
	(12, 'STD @ 66.67%'),
	(13, 'Tribe Resv Memo Only'),
	(14, 'Workers'' Compensation');	

INSERT OR REPLACE INTO [Afes] ([Id], [Name]) VALUES 
	(1, 'AFE00120'),
	(2, 'AFE00121'),
	(3, 'AFE00122'),
	(4, 'AFE00123'),
	(5, 'AFE00124'),
	(6, 'AFE00125'),
	(7, 'AFE00126'),
	(8, 'CC0001230'),
	(9, 'CC0001231'),
	(10, 'CC0001232'),
	(11, 'CC0001233'),
	(12, 'CC0001234'),
	(13, 'CC0001235'),
	(14, 'CC0001236');	
	
INSERT OR REPLACE INTO [Projects] ([Id], [Date], [Comments], [TimeReportingId], [AfeId]) VALUES 	
	(1, CURRENT_DATE, 'Lorem Ipsum is simply dummy text of the printing and typesetting industry.', 1, 1),
	(2, CURRENT_DATE, 'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.', 2, 2),
	(3, CURRENT_DATE, 'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', 3, 3),
	(4, CURRENT_DATE, 'It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 4, 4),
	(5, CURRENT_DATE, 'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.', 5, 5);
