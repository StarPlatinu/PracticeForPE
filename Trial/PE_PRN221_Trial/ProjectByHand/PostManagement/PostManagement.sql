USE [master]
GO
Create  database PostManagement
go
Use PostManagement
go


create table AppUsers (
	UserID INT primary key not null,
	Fullname VARCHAR(50),
	Address VARCHAR(50),
	Email VARCHAR(50),
	Password VARCHAR(50)
);

insert into AppUsers (UserID, Fullname, Address, Email, Password) values (1, 'Trula Wardlow', 'Suite 16', 'twardlow0@ucoz.ru', 'Cz818rVw');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (2, 'Candida Limpkin', 'Apt 242', 'climpkin1@cloudflare.com', 'VauBqnsgg');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (3, 'Justis Durbann', '5th Floor', 'jdurbann2@deliciousdays.com', 'iL7Zp05');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (4, 'Dayle Illidge', 'Suite 70', 'dillidge3@usatoday.com', 'i7Dua90P3');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (5, 'Had Robotham', 'Suite 36', 'hrobotham4@go.com', '0SjOKW');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (6, 'Godiva Matysiak', 'PO Box 83648', 'gmatysiak5@biblegateway.com', 'KqAK92');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (7, 'Heddie Dashkov', 'Apt 1450', 'hdashkov6@de.vu', 'wrHP0ucc6u');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (8, 'Bat Antoney', '18th Floor', 'bantoney7@istockphoto.com', 'f64ELJ');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (9, 'Jaynell Adamiec', '13th Floor', 'jadamiec8@vimeo.com', 'DSUkSyjBh9');
insert into AppUsers (UserID, Fullname, Address, Email, Password) values (10, 'Fay Yerlett', 'PO Box 91115', 'fyerlett9@edublogs.org', 'dJLfmmxy');

create table PostCategories (
	CategoryID INT primary key not null,
	CategoryName VARCHAR(50),
	Description VARCHAR(50)
);
insert into PostCategories (CategoryID, CategoryName, Description) values (1, 'Prodder', 'Oelui');
insert into PostCategories (CategoryID, CategoryName, Description) values (2, 'Tres-Zap', 'Cigedang');
insert into PostCategories (CategoryID, CategoryName, Description) values (3, 'Regrant', 'Mölndal');
insert into PostCategories (CategoryID, CategoryName, Description) values (4, 'Pannier', 'Svislach');
insert into PostCategories (CategoryID, CategoryName, Description) values (5, 'Cookley', 'Lijia');
insert into PostCategories (CategoryID, CategoryName, Description) values (6, 'Bitwolf', 'Saint-Denis');
insert into PostCategories (CategoryID, CategoryName, Description) values (7, 'Alphazap', 'Ban Haet');
insert into PostCategories (CategoryID, CategoryName, Description) values (8, 'Biodex', 'Grazhdanka');
insert into PostCategories (CategoryID, CategoryName, Description) values (9, 'Duobam', 'Tambong');
insert into PostCategories (CategoryID, CategoryName, Description) values (10, 'Bytecard', 'Moulins');


create table Posts (
	PostID INT primary key not null,
	AuthorID INT foreign key references AppUsers(UserID),
	CreatedDate DATE,
	UpdatedDate DATE,
	Title VARCHAR(50),
	Content VARCHAR(50),
	PublishedStatus VARCHAR(50),
	CategoryID INT foreign key references PostCategories(CategoryID)
);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (1, 1, '6/3/2022', '8/24/2022', 'Blind Dating', 'Glass & Glazing', 'Mitsubishi', 8);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (2, 2, '4/26/2022', '4/19/2022', 'The Ghost Story of Oiwa''s Spirit', 'Structural and Misc Steel (Fabrication)', 'Mercedes-Benz', 2);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (3, 2, '12/21/2022', '5/17/2022', 'Day After Trinity, The', 'Masonry', 'BMW', 10);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (4, 9, '4/7/2022', '8/23/2022', 'Donos de Portugal', 'Prefabricated Aluminum Metal Canopies', 'Honda', 6);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (5, 1, '6/2/2022', '1/27/2023', 'The 11 Commandments', 'Exterior Signage', 'Chevrolet', 3);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (6, 9, '3/2/2023', '11/10/2022', 'Still Walking (Aruitemo aruitemo)', 'Structural and Misc Steel (Fabrication)', 'GMC', 8);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (7, 6, '2/8/2023', '2/5/2023', 'Stonehenge Apocalypse', 'Drywall & Acoustical (MOB)', 'Chrysler', 3);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (8, 7, '3/22/2022', '5/8/2022', 'My Last Five Girlfriends', 'Structural & Misc Steel Erection', 'Nissan', 3);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (9, 6, '3/26/2022', '11/27/2022', 'Dante''s Inferno: An Animated Epic', 'Sitework & Site Utilities', 'Kia', 2);
insert into Posts (PostID, AuthorID, CreatedDate, UpdatedDate, Title, Content, PublishedStatus, CategoryID) values (10, 8, '3/1/2023', '11/16/2022', 'Immensee', 'Overhead Doors', 'Buick', 4);