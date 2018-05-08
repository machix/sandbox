USE [QuartzEnergy]
GO

IF NOT EXISTS (SELECT * FROM [Regions])
BEGIN 
	SET IDENTITY_INSERT [Regions] ON
	
	INSERT INTO [Regions] ([Id], [Name]) VALUES 
		(1, N'Region 01'),
		(2, N'Region 02'),
		(3, N'Region 03'),
		(4, N'Region 04'),
		(5, N'Region 05'),
		(6, N'Region 06'),
		(7, N'Region 07'),
		(8, N'Region 08'),
		(9, N'Region 09'),
		(10, N'Region 10');
	
	SET IDENTITY_INSERT [Regions] OFF
END

IF NOT EXISTS (SELECT * FROM [States])
BEGIN 
	SET IDENTITY_INSERT [States] ON
	
	INSERT INTO [States] ([Id], [Code], [Name]) VALUES 
		(1, 'AL', 'Alabama'),
		(2, 'AK', 'Alaska'),
		(3, 'AZ', 'Arizona'),
		(4, 'AR', 'Arkansas'),
		(5, 'CA', 'California'),
		(6, 'CO', 'Colorado'),
		(7, 'CT', 'Connecticut'),
		(8, 'DE', 'Delaware'),
		(9, 'DC', 'District of Columbia'),
		(10, 'FL', 'Florida'),
		(11, 'GA', 'Georgia'),
		(12, 'HI', 'Hawaii'),
		(13, 'ID', 'Idaho'),
		(14, 'IL', 'Illinois'),
		(15, 'IN', 'Indiana'),
		(16, 'IA', 'Iowa'),
		(17, 'KS', 'Kansas'),
		(18, 'KY', 'Kentucky'),
		(19, 'LA', 'Louisiana'),
		(20, 'ME', 'Maine'),
		(21, 'MD', 'Maryland'),
		(22, 'MA', 'Massachusetts'),
		(23, 'MI', 'Michigan'),
		(24, 'MN', 'Minnesota'),
		(25, 'MS', 'Mississippi'),
		(26, 'MO', 'Missouri'),
		(27, 'MT', 'Montana'),
		(28, 'NE', 'Nebraska'),
		(29, 'NV', 'Nevada'),
		(30, 'NH', 'New Hampshire'),
		(31, 'NJ', 'New Jersey'),
		(32, 'NM', 'New Mexico'),
		(33, 'NY', 'New York'),
		(34, 'NC', 'North Carolina'),
		(35, 'ND', 'North Dakota'),
		(36, 'OH', 'Ohio'),
		(37, 'OK', 'Oklahoma'),
		(38, 'OR', 'Oregon'),
		(39, 'PA', 'Pennsylvania'),
		(40, 'PR', 'Puerto Rico'),
		(41, 'RI', 'Rhode Island'),
		(42, 'SC', 'South Carolina'),
		(43, 'SD', 'South Dakota'),
		(44, 'TN', 'Tennessee'),
		(45, 'TX', 'Texas'),
		(46, 'UT', 'Utah'),
		(47, 'VT', 'Vermont'),
		(48, 'VA', 'Virginia'),
		(49, 'WA', 'Washington'),
		(50, 'WV', 'West Virginia'),
		(51, 'WI', 'Wisconsin'),
		(52, 'WY', 'Wyoming');
	
	SET IDENTITY_INSERT [States] OFF
END

IF NOT EXISTS (SELECT * FROM [Companies])
BEGIN 
	SET IDENTITY_INSERT [Companies] ON
	INSERT INTO [Companies] ([Id], [Name]) VALUES 
		(1, N'Company 01'),
		(2, N'Company 02'),
		(3, N'Company 03'),
		(4, N'Company 04'),
		(5, N'Company 05'),
		(6, N'Company 06'),
		(7, N'Company 07'),
		(8, N'Company 08'),
		(9, N'Company 09'),
		(10, N'Company 10');
	
	SET IDENTITY_INSERT [Companies] OFF
END

IF NOT EXISTS (SELECT * FROM [Contacts])
BEGIN 
	SET IDENTITY_INSERT [Contacts] ON
	
	INSERT INTO [Contacts] ([Id], [CompanyId], [ContactOrder], [FullName], [Email], [Phone], [City], [StateId]) VALUES
		(1, 1, 1, N'William Shelton', N'pemungkah@live.com', N'(398) 427-3788', N'Lexington-Fayette', 1),	 
		(2, 1, 2, N'Elle Stein', N'hermes@gmail.com', N'(299) 879-0547', N'Cincinnati', 3),	 
		(3, 1, 3, N'Cohen Gaines', N'weazelman@aol.com', N'(826) 955-1895', N'Baltimore', 5),	 
		(4, 1, 4, N'Rhys Hayden', N'dogdude@comcast.net', N'(533) 162-1659', N'Portland', 7),	 
		(5, 2, 1, N'Lilliana Salinas', N'crobles@att.net', N'(406) 305-5571', N'Austin', 9),	 
		(6, 2, 2, N'Jaeden Malone', N'kohlis@sbcglobal.net', N'(740) 218-5375', N'Chesapeake', 11),	 
		(7, 3, 1, N'Tiana Parks', N'smallpaul@icloud.com', N'(571) 230-7060', N'San Bernardino', 13),	 
		(8, 3, 2, N'Byron Acosta', N'amimojo@yahoo.ca', N'(450) 495-7814', N'Greensboro', 15),	 
		(9, 4, 1, N'Raymond Farmer', N'yruan@live.com', N'(875) 991-9982', N'Birmingham', 17),	 
		(10, 4, 2, N'Karma Rich', N'kmiller@sbcglobal.net', N'(804) 268-0327', N'Jersey City', 19),	 
		(11, 5, 1, N'Layla Ward', N'kimvette@aol.com', N'(171) 440-5205', N'Minneapolis', 21),	 
		(12, 5, 2, N'Brett Newman', N'redingtn@icloud.com', N'(861) 817-5532', N'Columbus', 23),	 
		(13, 6, 1, N'Jordyn Hill', N'tjensen@yahoo.com', N'(696) 699-4813', N'Charlotte', 25),	 
		(14, 6, 2, N'Henry Hammond', N'qrczak@att.net', N'(544) 724-1377', N'Lubbock', 27),	 
		(15, 7, 1, N'Marquis Hunter', N'szymansk@verizon.net', N'(956) 336-6680', N'Indianapolis', 29),	 
		(16, 7, 2, N'Valeria Moss', N'irving@msn.com', N'(856) 165-8531', N'Baton Rouge', 31),	 
		(17, 8, 1, N'Khloe Briggs', N'mrsam@msn.com', N'(997) 585-4492', N'Omaha', 33),	 
		(18, 8, 2, N'Moses Frank', N'mwilson@yahoo.com', N'(366) 572-8697', N'Huntington', 35),	 
		(19, 9, 1, N'David Mathews', N'jaffe@gmail.com', N'(555) 673-5999', N'Durham', 37),	 
		(20, 9, 2, N'Cristopher Duran', N'rmcfarla@me.com', N'(109) 907-0378', N'St. Louis', 39),			 
		(21, 10, 1, N'Ashly Ferrell', N'wonderkid@comcast.net', N'(476) 243-0742', N'Bakersfield', 41),	 
		(22, 10, 2, N'Sarai Dickson', N'preneel@yahoo.ca', N'(112) 973-4262', N'Dallas', 43);
		
	
	SET IDENTITY_INSERT [Contacts] OFF
END

IF NOT EXISTS (SELECT * FROM [Wells])
BEGIN 
	SET IDENTITY_INSERT [Wells] ON
	
	INSERT INTO [Wells] ([Id], [Name], [SurfaceLat], [SurfaceLong], [BottomholeLat], [BottomholeLong],
		[Tvd], [Api], [RegionId]) VALUES 
		(1, N'TREES STATE 17-18-4303H', 41.56402937, -105.05748478, 41.56402937, -105.05748478, N'TVD Info', N'4238936516', 1),
		(2, N'TREES STATE 17-18-4304H', 35.5435724, -110.33272276, 35.5435724, -110.33272276, N'TVD Info', N'4238936516', 2),
		(3, N'TREES STATE 17-18-4305H', 32.76600756, -107.10165357, 32.76600756, -107.10165357	, N'TVD Info', N'4238936516', 3),
		(4, N'TREES STATE 17-18-4306H', 36.83901027, -107.88041209, 36.83901027, -107.88041209, N'TVD Info', N'4238936516', 4),
		(5, N'TREES STATE 17-18-4307H', 36.51250794, -109.8958933, 36.51250794, -109.8958933, N'TVD Info', N'4238936516', 5),
		(6, N'GRANADA 11 14H', 43.60310452, -96.59594224, 43.60310452, -96.59594224, N'TVD Info', N'4238936516', 6),
		(7, N'GRANADA 11 15H', 43.32119781, -106.8168817, 43.32119781, -106.8168817, N'TVD Info', N'4238936516', 7),
		(8, N'GRANADA 11 16H', 38.75683424, -99.72944464, 38.75683424, -99.72944464, N'TVD Info', N'4238936516', 8),
		(9, N'GRANADA 11 17H', 37.8066505, -106.89861935, 37.8066505, -106.89861935, N'TVD Info', N'4238936516', 9),
		(10, N'GRANADA 11 18H', 43.97765504, -114.85554211, 43.97765504, -114.85554211, N'TVD Info', N'4238936516', 10),
		(11, N'L BLACK 87-88 4N 14H', 39.38820928, -109.33214865, 39.38820928, -109.33214865, N'TVD Info', N'4238936516', 1),
		(12, N'L BLACK 87-88 4N 15H', 41.39732208, -109.55155919, 41.39732208, -109.55155919, N'TVD Info', N'4238936516', 2),
		(13, N'L BLACK 87-88 4N 16H', 37.31519378, -111.04279712, 37.31519378, -111.04279712, N'TVD Info', N'4238936516', 3),
		(14, N'L BLACK 87-88 4N 17H', 41.40462672, -111.43100715, 41.40462672, -111.43100715, N'TVD Info', N'4238936516', 4),
		(15, N'L BLACK 87-88 4N 18H', 33.18303211, -105.2248509, 33.18303211, -105.2248509, N'TVD Info', N'4238936516', 5),
		(16, N'MCCULLOUGH 35-38-2S STATE 14H', 39.87005841, -94.39802146, 39.87005841, -94.39802146, N'TVD Info', N'4238936516', 6),
		(17, N'MCCULLOUGH 35-38-2S STATE 15H', 36.21260406, -112.47552142, 36.21260406, -112.47552142, N'TVD Info', N'4238936516', 7),
		(18, N'MCCULLOUGH 35-38-2S STATE 16H', 34.84584896, -107.92218998, 34.84584896, -107.92218998, N'TVD Info', N'4238936516', 8),
		(19, N'MCCULLOUGH 35-38-2S STATE 17H', 44.14369407, -109.58741202, 44.14369407, -109.58741202, N'TVD Info', N'4238936516', 9),
		(20, N'MCCULLOUGH 35-38-2S STATE 18H', 39.32086217, -102.52450878, 39.32086217, -102.52450878, N'TVD Info', N'4238936516', 10),
		(21, N'J.W. MCCULLOUGH A UNIT 12H', 41.15922666, -112.21685614, 41.15922666, -112.21685614, N'TVD Info', N'4238936516', 1),
		(22, N'J.W. MCCULLOUGH A UNIT 13H', 31.30206989, -105.181412, 31.30206989, -105.181412, N'TVD Info', N'4238936516', 2),
		(23, N'J.W. MCCULLOUGH A UNIT 14H', 34.01525763, -103.03194326, 34.01525763, -103.03194326, N'TVD Info', N'4238936516', 3),
		(24, N'J.W. MCCULLOUGH A UNIT 15H', 36.22305837, -105.88914453, 36.22305837, -105.88914453, N'TVD Info', N'4238936516', 4),
		(25, N'J.W. MCCULLOUGH A UNIT 16H', 45.77058457, -102.42205807, 45.77058457, -102.42205807, N'TVD Info', N'4238936516', 5),
		(26, N'YOW STATE 38 11H', 42.03888664, -116.22177458, 42.03888664, -116.22177458, N'TVD Info', N'4238936516', 6),
		(27, N'YOW STATE 38 12H', 36.33014932, -102.11989929, 36.33014932, -102.11989929, N'TVD Info', N'4238936516', 7),
		(28, N'YOW STATE 38 13H', 35.5277271, -98.96260317, 35.5277271, -98.96260317, N'TVD Info', N'4238936516', 8),
		(29, N'YOW STATE 38 14H', 46.97108909, -106.3309483, 46.97108909, -106.3309483, N'TVD Info', N'4238936516', 9),
		(30, N'YOW STATE 38 15H', 36.53895031, -108.19656628, 36.53895031, -108.19656628, N'TVD Info', N'4238936516', 10),
		(31, N'LYDA 33-40-2S STATE 12H', 35.70963177, -112.97787781, 35.70963177, -112.97787781, N'TVD Info', N'4238936516', 1),
		(32, N'LYDA 33-40-2S STATE 13H', 43.02950972, -108.81432698, 43.02950972, -108.81432698, N'TVD Info', N'4238936516', 2),
		(33, N'LYDA 33-40-2S STATE 14H', 36.24075294, -115.47623846, 36.24075294, -115.47623846, N'TVD Info', N'4238936516', 3),
		(34, N'LYDA 33-40-2S STATE 15H', 39.96414724, -105.36001301, 39.96414724, -105.36001301, N'TVD Info', N'4238936516', 4),
		(35, N'LYDA 33-40-2S STATE 16H', 33.51660986, -106.79111672, 33.51660986, -106.79111672, N'TVD Info', N'4238936516', 5);
	
	SET IDENTITY_INSERT [Wells] OFF
END

IF NOT EXISTS (SELECT * FROM [Schedules])
BEGIN 
	SET IDENTITY_INSERT [Schedules] ON
	
	INSERT INTO [Schedules] ([Id], [WellId], [CompanyId], [FracStartDate], [FracEndDate]) VALUES 
		(1, 1, 1, N'2018-05-15', N'2018-05-20'),
		(2, 2, 2, N'2018-05-15', N'2018-05-21'),
		(3, 3, 3, N'2018-05-15', N'2018-05-22'),
		(4, 4, 4, N'2018-05-15', N'2018-05-23'),
		(5, 5, 5, N'2018-05-15', N'2018-05-24'),
		(6, 6, 6, N'2018-05-15', N'2018-05-25'),
		(7, 7, 7, N'2018-05-15', N'2018-05-26'),
		(8, 8, 8, N'2018-05-15', N'2018-05-27'),
		(9, 9, 9, N'2018-05-15', N'2018-05-28'),
		(10, 10, 10, N'2018-05-15', N'2018-05-29'),
		(11, 11, 1, N'2018-05-20', N'2018-06-21'),
		(12, 12, 2, N'2018-05-20', N'2018-06-22'),
		(13, 13, 3, N'2018-05-20', N'2018-06-23'),
		(14, 14, 4, N'2018-05-20', N'2018-06-24'),
		(15, 15, 5, N'2018-05-20', N'2018-06-25'),
		(16, 16, 6, N'2018-05-20', N'2018-06-26'),
		(17, 17, 7, N'2018-05-20', N'2018-06-27'),
		(18, 18, 8, N'2018-05-20', N'2018-06-28'),
		(19, 19, 9, N'2018-05-20', N'2018-06-29'),
		(20, 20, 10, N'2018-05-20', N'2018-06-30'),
		(21, 21, 1, N'2018-06-11', N'2018-07-01'),
		(22, 22, 2, N'2018-06-11', N'2018-07-02'),
		(23, 23, 3, N'2018-06-11', N'2018-07-03'),
		(24, 24, 4, N'2018-06-11', N'2018-07-04'),
		(25, 25, 5, N'2018-06-11', N'2018-07-05'),
		(26, 26, 6, N'2018-06-11', N'2018-07-06'),
		(27, 27, 7, N'2018-06-11', N'2018-07-07'),
		(28, 28, 8, N'2018-06-11', N'2018-07-08'),
		(29, 29, 9, N'2018-06-11', N'2018-07-09'),
		(30, 30, 10, N'2018-06-11', N'2018-07-10'),
		(31, 31, 1, N'2018-06-12', N'2018-08-11'),
		(32, 32, 2, N'2018-06-12', N'2018-08-12'),
		(33, 33, 3, N'2018-06-12', N'2018-08-13'),
		(34, 34, 4, N'2018-06-12', N'2018-08-14'),
		(35, 35, 5, N'2018-06-12', N'2018-08-15'),
		(36, 1, 6, N'2018-06-12', N'2018-08-16'),
		(37, 2, 7, N'2018-06-12', N'2018-08-17'),
		(38, 3, 8, N'2018-06-12', N'2018-08-18'),
		(39, 4, 9, N'2018-06-12', N'2018-08-19'),		
		(40, 5, 10, N'2018-06-12', N'2018-08-20');		
	
	SET IDENTITY_INSERT [Schedules] OFF
END


SELECT
	w.[Name] AS 'Well Name',
	c.[Name] AS 'Operator',
	CONVERT(NVARCHAR, s.[FracStartDate], 103) AS 'Frac Start',
	CONVERT(NVARCHAR, s.[FracEndDate], 103) AS 'Frac End',
	w.[Api] AS 'API',
	CONVERT (VARCHAR(50), w.[SurfaceLat], 128) + ', ' + CONVERT (VARCHAR(50), w.[SurfaceLong], 128) AS 'Surface Lat, Long',
	CONVERT (VARCHAR(50), w.[BottomholeLat], 128) + ', ' + CONVERT (VARCHAR(50), w.[BottomholeLong], 128) AS 'Bottomhole Lat, Long',
	w.[Tvd] AS 'TVD'
fROM [Schedules] s
INNER JOIN [Wells] w ON s.[WellId] = w.[Id]
INNER JOIN [Companies] c ON s.[CompanyId] = c.[Id]	
 