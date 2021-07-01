INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5e5dfd67-c552-4742-9e17-99cae3adbc19', N'admin', N'admin', N'c54824f7-2bb7-43d7-8466-75fb2172ebaa')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0202a791-724b-4273-988d-6cc4d6727887', N'power@gmail.com', N'POWER@GMAIL.COM', N'power@gmail.com', N'POWER@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGudXrDbnO8lR10E8EbRbygU2qUY0zsupJ3vdrDThflyPaG0v17/3qh24iCQMyYjZA==', N'T7OD5WEVCBUJPNIGZCZBXGIIURE2VCEX', N'deaf881e-7733-4619-89fc-d3dc9b12e623', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a559220b-9022-4528-8b23-d4f9396d8d2e', N'john@gmail.com', N'JOHN@GMAIL.COM', N'john@gmail.com', N'JOHN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEJXM1RLZB8lq9cJTXRJ64bZXelgJgqowlbH6RB2YPek/XB+TofWXt3fgr/2mnH0Eg==', N'GKY4SO54FG67V5QNZXPX7R6R5PUWC6T4', N'4da92046-a7bf-4be1-80dc-ccde5da5114a', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0202a791-724b-4273-988d-6cc4d6727887', N'5e5dfd67-c552-4742-9e17-99cae3adbc19')
GO
SET IDENTITY_INSERT [dbo].[Destinations] ON 
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (1, N'Auckland', N'From world-class food and wine to beautiful beaches and islands, designer shopping to outdoor adventures, you''ll find the best of both worlds right here.', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (2, N'Wellington', N'Take a ride on iconic cable car or browse the stores on eclectic Cuba Street. There''s so much to do in Wellington.', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (3, N'Christchurch', N'The vistas and beautiful countryside that surround the metropolis greet you as soon as you arrive. There is more to Christchurch and the Cantebury region than the stunning scenery though. ', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (4, N'Queenstown', N'We have one of the most picturesque areas in the world, and it''s not hard to see why Queenstown is so breathtaking.', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (5, N'Wanaka', N'An idyllic Summer and Winter holiday destination, Wanaka offers a vast range of outdoor activities and luxury accommodation options.', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (6, N'Fiji', N'Fiji presents the tropical island destination that dreams are made of: warm, balmy days and nights, crystal clear water, beautiful corals and perfect sandy beaches fringed by coconut palms.', N'New Zealand', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (7, N'Sydney', N'Sydney, spectacularly draped around its glorious harbour and beaches, has visual wow factor like few other cities. Scratch the surface and it only gets better.', N'Australia', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (8, N'Melbourne', N'There’s a flavour to tempt every taste bud; Melbourne has more restaurants and cafes per capita than any other city, with an assortment of cuisines and no end of stylish bars. ', N'Australia', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (9, N'Tropical North Queensland', N'In this stunning part of the world, white sand beaches welcome warm, clear waters to its idyllic shores in the midst of myriad tropical islands. There''s no place quite like it.', N'Australia', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (10, N'Brisbane', N'With its idyllic coastal proximity, pleasant sub-tropical climate, and sophisticated urban flair, Brisbane is a city always on the move – and it only seems to get better (and better) every year.', N'Australia', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (11, N'London', N'London has historically been at the epicentre of English life. Today, London is one of the most diverse, exciting and creative cities in the world.', N'Europe', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (12, N'Paris', N'Paris is where the modern and wonderfully old-fashioned meet, in the midst of beautiful boulevards, leafy parks and romantic architecture.', N'Europe', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (13, N'Rome', N'A heady mix of haunting ruins, awe-inspiring art and vibrant street life, history, famous art and culture combine to make Rome one of the world’s most fascinating cities. ', N'Europe', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (14, N'Amsterdam', N'The Netherlands’ capital boasts medieval history in spades, with a healthy lashing of modern-day breweries, bars and al fresco restaurants fringing ancient squares.', N'Europe', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (15, N'Athens', N'The cultural and social life of Athens plays out amid, around and in landmarks that are centuries old, if not millennia. Not to mention, the mythology, drama and philosophy. ', N'Europe', N'.jpg')
GO
INSERT [dbo].[Destinations] ([DestinationID], [DestinationName], [About], [Country], [Extension]) VALUES (16, N'Barcelona', N'Barcelona is an enchanting seaside city with boundless culture, fabled architecture and a world-class drinking and dining scene.', N'Europe', N'.jpg')
GO
SET IDENTITY_INSERT [dbo].[Destinations] OFF
GO
SET IDENTITY_INSERT [dbo].[Flights] ON 
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (1, N'Air New Zealand', N'Economy', 179, 1, 2)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (2, N'Air New Zealand', N'Economy', 195, 1, 3)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (3, N'Air New Zealand', N'Economy', 179, 1, 5)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (4, N'Air New Zealand', N'Economy', 189, 1, 6)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (5, N'Air New Zealand', N'Economy', 229, 3, 2)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (6, N'Air New Zealand', N'Economy', 645, 1, 8)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (7, N'Air New Zealand', N'Business Class', 1125, 1, 8)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (8, N'Air New Zealand', N'Economy', 655, 1, 10)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (9, N'Air New Zealand', N'Premium Economy', 839, 1, 7)
GO
INSERT [dbo].[Flights] ([FlightID], [Airline], [Type], [Price], [SourceID], [DestinationID]) VALUES (10, N'Air New Zealand', N'Economy', 669, 1, 7)
GO
SET IDENTITY_INSERT [dbo].[Flights] OFF
GO
SET IDENTITY_INSERT [dbo].[Cruises] ON 
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (1, N'Princess Cruises', N'New Zealand - Auckland to Sydney', N'8 night cruise from', 2365)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (2, N'Princess Cruises', N'New Zealand - Auckland Return', N'14 night cruise from', 4409)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (3, N'Azamara', N'Australia Intensive - Sydney to Perth', N'13 night cruise from', 8255)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (4, N'Princess Cruises', N'Queensland', N'7 night cruise from', 1899)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (5, N'Holland America Line', N'Northern Australia - Sydney to Perth', N'21 night cruise from', 9529)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (6, N'Holland America Line', N'Southern Australia - Perth to Sydney', N'14 night cruise from', 6315)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (7, N'Holland America Line', N'New Zealand - Sydney to Auckland', N'13 night cruise from', 5089)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (8, N'MSC Cruises', N'Mediterranean from Marseille', N'1 night cruise from', 109)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (9, N'MSC Cruises', N'Mediterranean from Genoa', N'1 night cruise from', 109)
GO
INSERT [dbo].[Cruises] ([CruiseID], [CruiseLine], [DestinationName], [Description], [Price]) VALUES (10, N'Holland America Line', N'Pacific Coastal', N'1 night cruise from', 234)
GO
SET IDENTITY_INSERT [dbo].[Cruises] OFF
GO
SET IDENTITY_INSERT [dbo].[Enquiries] ON 
GO
INSERT [dbo].[Enquiries] ([EnquiryID], [UserID], [EnquiryDate], [About], [Phone], [Name]) VALUES (1, N'john@gmail.com', CAST(N'2021-06-30T22:59:45.0267574' AS DateTime2), N'New Zealand - Auckland to Sydney in Princess Cruises', N'085486963', N'Jacobson')
GO
INSERT [dbo].[Enquiries] ([EnquiryID], [UserID], [EnquiryDate], [About], [Phone], [Name]) VALUES (2, N'john@gmail.com', CAST(N'2021-06-30T23:00:01.0338422' AS DateTime2), N'Auckland to Wellington in Economy', N'085296396', N'Sophie Hunt')
GO
SET IDENTITY_INSERT [dbo].[Enquiries] OFF
GO
