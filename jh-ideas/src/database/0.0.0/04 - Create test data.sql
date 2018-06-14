USE [Ideas]
GO

IF NOT EXISTS (SELECT * FROM [Users])
BEGIN 
	SET IDENTITY_INSERT [Users] ON
	
	INSERT INTO [Users] ([Id], [FirstName], [LastName], [Phone], [Email], [JobTitle], [Location]) VALUES 
		(1, N'Faustina', N'Ojeda', N'+1(704)352-9938', N'onestab@aol.com', N'Logistician', N'Riverside, California'),
		(2, N'Lenna', N'Odem', N'+1(816)395-2683', N'grdschl@mac.com', N'Mechanical Engineer', N'Chandler, Arizona'),
		(3, N'Clare', N'Caton', N'+1(556)762-1197', N'dbanarse@mac.com', N'Veterinarian', N'Memphis, Tennessee'),
		(4, N'Emilio', N'Napolitano', N'+1(347)863-4679', N'citadel@yahoo.com', N'Automotive mechanic', N'Oklahoma City, Oklahoma'),
		(5, N'Ellyn', N'Crayton', N'+1(260)470-2278', N'fudrucker@yahoo.com', N'High School Teacher', N'Jacksonville, Florida'),
		(6, N'Jess', N'Fegan', N'+1(607)521-3920', N'leviathan@sbcglobal.net', N'Janitor', N'Anaheim California'),
		(7, N'Reanna', N'Speller', N'+1(552)816-8974', N'syncnine@gmail.com', N'Hairdresser', N'San Diego, California'),
		(8, N'Ladawn', N'Clendening', N'+1(574)588-0325', N'sriha@live.com', N'Maintenance & Repair Worker', N'Glendale, Arizona'),
		(9, N'Rea', N'Summa', N'+1(989)434-6264', N'smallpaul@sbcglobal.net', N'Teacher Assistant', N'Aurora, Colorado'),
		(10, N'Porsha', N'Emily', N'+1(260)501-1255', N'jnolan@aol.com', N'HR Specialist', N'Nashville-Davidson, Tennessee'),
		(11, N'Alessandra', N'Hilliker', N'+1(851)129-3241', N'nasor@att.net', N'Medical Secretary', N'North Hempstead, New York'),
		(12, N'Myron', N'Haggins', N'+1(282)973-4862', N'thaljef@verizon.net', N'Cost Estimator', N'Miami, Florida'),
		(13, N'Quinn', N'Searle', N'+1(928)613-8198', N'rgarton@outlook.com', N'Cashier', N'Akron, Ohio'),
		(14, N'Chester', N'Buckman', N'+1(743)856-6989', N'jimmichie@aol.com', N'Lawyer', N'Phoenix, Arizona'),
		(15, N'Gilbert', N'Lisenby', N'+1(697)709-4532', N'fatelk@mac.com', N'School Counselor', N'Las Vegas, Nevada');
		
	SET IDENTITY_INSERT [Users] OFF
END

IF NOT EXISTS (SELECT * FROM [Areas])
BEGIN 
	SET IDENTITY_INSERT [Areas] ON
	
	INSERT INTO [Areas] ([Id], [Name]) VALUES 
		(1, N'Customer Experience'),
		(2, N'Employee Experience'),
		(3, N'Human Resources'),
		(4, N'Operations'),
		(5, N'Wealth Management'),
		(6, N'Insurance'),
		(7, N'Product Development'),
		(8, N'Legal/Compliance'),
		(9, N'Finance/Accounting'),
		(10, N'Marketing'),
		(11, N'Information Technology'),
		(12, N'Risk Management'),
		(13, N'Brand Management');
				
	SET IDENTITY_INSERT [Areas] OFF
END

IF NOT EXISTS (SELECT * FROM [Statuses])
BEGIN 
	SET IDENTITY_INSERT [Statuses] ON
	
	INSERT INTO [Statuses] ([Id], [Name]) VALUES 
		(1, N'Open'),
		(2, N'In Review'),
		(3, N'Approved'),
		(4, N'In Development'),
		(5, N'Complete'),
		(6, N'Archived')
						
	SET IDENTITY_INSERT [Statuses] OFF
END

IF NOT EXISTS (SELECT * FROM [Ideas])
BEGIN 
	SET IDENTITY_INSERT [Ideas] ON
	
	INSERT INTO [Ideas] ([Id], [Name], [StatusId], [Description], [ProblemToSolve]) VALUES 
		(1, N'Sed ut perspiciatis unde omnis', 1, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(2, N'Nemo enim ipsam voluptatem quia voluptas', 2, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(3, N'Neque porro quisquam est', 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(4, N'Sed ut perspiciatis unde omnis', 4, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(5, N'Nemo enim ipsam voluptatem quia voluptas', 5, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(6, N'Neque porro quisquam est', 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(7, N'Sed ut perspiciatis unde omnis', 1, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(8, N'Nemo enim ipsam voluptatem quia voluptas', 2, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(9, N'Neque porro quisquam est', 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(10, N'Sed ut perspiciatis unde omnis', 4, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(11, N'Nemo enim ipsam voluptatem quia voluptas', 5, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(12, N'Neque porro quisquam est', 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(13, N'Sed ut perspiciatis unde omnis', 1, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(14, N'Nemo enim ipsam voluptatem quia voluptas', 2, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(15, N'Neque porro quisquam est', 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(16, N'Sed ut perspiciatis unde omnis', 4, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(17, N'Nemo enim ipsam voluptatem quia voluptas', 5, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(18, N'Neque porro quisquam est', 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(19, N'Sed ut perspiciatis unde omnis', 1, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(20, N'Nemo enim ipsam voluptatem quia voluptas', 2, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(21, N'Neque porro quisquam est', 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(22, N'Sed ut perspiciatis unde omnis', 4, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(23, N'Nemo enim ipsam voluptatem quia voluptas', 5, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(24, N'Neque porro quisquam est', 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(25, N'Sed ut perspiciatis unde omnis', 1, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(26, N'Nemo enim ipsam voluptatem quia voluptas', 2, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(27, N'Neque porro quisquam est', 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(28, N'Sed ut perspiciatis unde omnis', 4, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(29, N'Nemo enim ipsam voluptatem quia voluptas', 5, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(30, N'Neque porro quisquam est', 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.');
						
	SET IDENTITY_INSERT [Ideas] OFF
END

IF NOT EXISTS (SELECT * FROM [IdeasSubmitters])
BEGIN 
	INSERT INTO [IdeasSubmitters] ([IdeaId], [UserId]) VALUES 
		(1, 1),
		(2, 2),
		(3, 3),
		(4, 4),
		(5, 5),
		(6, 6),
		(7, 7),
		(8, 8),
		(9, 9),
		(10, 10),
		(11, 11),
		(12, 12),
		(13, 13),
		(14, 14),
		(15, 15),
		(16, 1),
		(17, 2),
		(18, 3),
		(19, 4),
		(20, 5),
		(21, 6),
		(22, 7),
		(23, 8),
		(24, 9),
		(25, 10),
		(26, 11),
		(27, 12),
		(28, 13),
		(29, 14),
		(30, 15),
		(1, 2),
		(1, 3),
		(2, 1),
		(2, 3),
		(3, 1),
		(3, 2),
		(4, 1),
		(4, 2),
		(5, 2),
		(5, 3);
END

IF NOT EXISTS (SELECT * FROM [IdeasOwners])
BEGIN 
	INSERT INTO [IdeasOwners] ([IdeaId], [UserId]) VALUES 
		(1, 1),
		(2, 2),
		(3, 3),
		(4, 4),
		(5, 5),
		(6, 6),
		(7, 7),
		(8, 8),
		(9, 9),
		(10, 10),
		(11, 11),
		(12, 12),
		(13, 13),
		(14, 14),
		(15, 15),
		(16, 1),
		(17, 2),
		(18, 3),
		(19, 4),
		(20, 5),
		(21, 6),
		(22, 7),
		(23, 8),
		(24, 9),
		(25, 10),
		(26, 11),
		(27, 12),
		(28, 13),
		(29, 14),
		(30, 15),
		(3, 1),
		(3, 2),
		(3, 4),
		(4, 1),
		(4, 2),
		(4, 3),
		(5, 1),
		(5, 2),
		(6, 3),
		(6, 1);
END

IF NOT EXISTS (SELECT * FROM [IdeasAreas])
BEGIN 
	INSERT INTO [IdeasAreas] ([IdeaId], [AreaId]) VALUES 
		(1, 1),
		(2, 2),
		(3, 3),
		(4, 4),
		(5, 5),
		(6, 6),
		(7, 7),
		(8, 8),
		(9, 9),
		(10, 10),
		(11, 11),
		(12, 12),
		(13, 13),
		(14, 1),
		(15, 2),
		(16, 3),
		(17, 4),
		(18, 5),
		(19, 6),
		(20, 7),
		(21, 8),
		(22, 9),
		(23, 10),
		(24, 11),
		(25, 12),
		(26, 13),
		(27, 1),
		(28, 2),
		(29, 3),
		(30, 4),
		(1, 5),
		(1, 6),
		(2, 7),
		(2, 8),
		(3, 9),
		(3, 10),
		(4, 11),
		(4, 12),
		(5, 13),
		(5, 1);
END

IF NOT EXISTS (SELECT * FROM [IdeaLikes])
BEGIN 
	INSERT INTO [IdeaLikes] ([IdeaId], [UserId]) VALUES 
		(1, 1),
		(2, 2),
		(3, 3),
		(4, 4),
		(5, 5),
		(6, 6),
		(7, 7),
		(8, 8),
		(9, 9),
		(10, 10),
		(11, 11),
		(12, 12),
		(13, 13),
		(14, 14),
		(15, 15),
		(16, 1),
		(17, 2),
		(18, 3),
		(19, 4),
		(20, 5),
		(21, 6),
		(22, 7),
		(23, 8),
		(24, 9),
		(25, 10),
		(26, 11),
		(27, 12),
		(28, 13),
		(29, 14),
		(30, 15),
		(1, 2),
		(2, 3),
		(3, 4),
		(4, 1),
		(5, 2),
		(6, 3),
		(7, 4),
		(8, 5),
		(9, 6),
		(10, 7);						
END

IF NOT EXISTS (SELECT * FROM [Comments])
BEGIN 
	SET IDENTITY_INSERT [Comments] ON
	
	INSERT INTO [Comments] ([Id], [IdeaId], [UserId], [RepliedToId], [Text]) VALUES 
		(1, 1, 1, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(2, 2, 2, 1, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(3, 3, 3, 2, N'Neque porro quisquam est.'),
		(4, 4, 4, 3, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(5, 5, 5, 4, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(6, 6, 6, 5, N'Neque porro quisquam est.'),
		(7, 7, 7, 6, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(8, 8, 8, 7, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(9, 9, 9, 8, N'Neque porro quisquam est.'),
		(10, 10, 10, 9, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(11, 11, 11, 10, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(12, 12, 12, 11, N'Neque porro quisquam est.'),
		(13, 13, 13, 12, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(14, 14, 14, 13, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(15, 15, 15, 14, N'Neque porro quisquam est.'),
		(16, 16, 1, 15, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(17, 17, 2, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(18, 18, 3, NULL, N'Neque porro quisquam est.'),
		(19, 19, 4, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(20, 20, 5, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(21, 21, 6, NULL, N'Neque porro quisquam est.'),
		(22, 22, 7, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(23, 23, 8, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(24, 24, 9, NULL, N'Neque porro quisquam est.'),
		(25, 25, 10, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(26, 26, 11, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(27, 27, 12, NULL, N'Neque porro quisquam est.'),
		(28, 28, 13, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(29, 29, 14, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(30, 30, 15, NULL, N'Neque porro quisquam est.'),
		(31, 1, 1, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(32, 2, 2, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(33, 3, 3, NULL, N'Neque porro quisquam est.'),
		(34, 4, 4, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(35, 5, 5, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(36, 6, 6, NULL, N'Neque porro quisquam est.'),
		(37, 7, 7, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.'),
		(38, 8, 8, NULL, N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.'),
		(39, 9, 9, NULL, N'Neque porro quisquam est.'),
		(40, 10, 10, NULL, N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.');
				
	SET IDENTITY_INSERT [Comments] OFF
END

IF NOT EXISTS (SELECT * FROM [CommentLikes])
BEGIN 
	INSERT INTO [CommentLikes] ([CommentId], [UserId]) VALUES 
		(1, 1),
		(1, 2),
		(1, 3),
		(1, 4),
		(1, 5),		
		(2, 2),
		(3, 3),
		(4, 4),
		(5, 5),
		(6, 6),
		(7, 7),
		(8, 8),
		(9, 9),
		(10, 10),
		(11, 11),
		(12, 12),
		(13, 13),
		(14, 14),
		(15, 15),
		(16, 1),
		(17, 2),
		(18, 3),
		(19, 4),
		(20, 5),
		(21, 6),
		(22, 7),
		(23, 8),
		(24, 9),
		(25, 10),
		(26, 11),
		(27, 12),
		(28, 13),
		(29, 14),
		(30, 15),
		(31, 2),
		(32, 3),
		(33, 4),
		(34, 1),
		(35, 2),
		(36, 3),
		(37, 4),
		(38, 5),
		(39, 6),
		(40, 7);						
END

IF NOT EXISTS (SELECT * FROM [Notifications])
BEGIN 
	SET IDENTITY_INSERT [Notifications] ON
	
	INSERT INTO [Notifications] ([Id], [UserId], [IdeaId], [LikedById], [CommentedById], [StatusToId]) VALUES 
		(1, 1, 1, 2, NULL, NULL),
		(2, 1, 2, NULL, 3, NULL),
		(3, 1, 3, NULL, NULL, 3);
		
	SET IDENTITY_INSERT [Notifications] OFF
END

