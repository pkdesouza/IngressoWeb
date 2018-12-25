PRINT('CREATE Movie')
CREATE TABLE Movie(
	id INT IDENTITY(1,1),
	name VARCHAR(255) NOT NULL,
	synopsis VARCHAR(1000) NOT NULL,
	ageRating INT NOT NULL,
	trailer VARCHAR(1000), 
	image VARCHAR(1000), 
	price MONEY NOT NULL,
	releaseYear INT NOT NULL ,
	registrationDate  DATETIME DEFAULT GETDATE(),
	lastModificationDate DATETIME,
	active BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY(id)
)
GO
PRINT('CREATE City')
CREATE TABLE City(
	id INT IDENTITY(1,1),
	name VARCHAR(50) NOT NULL,
	state CHAR(2) NOT NULL CHECK(len(state)=2),
	PRIMARY KEY(id)
)
GO
PRINT('CREATE MovieTheater')
CREATE TABLE MovieTheater(
	id INT IDENTITY(1,1),
	name VARCHAR(100) NOT NULL,
	streetName VARCHAR(100) NOT NULL,
	numberAddress INT NOT NULL,
	zipCode INT NOT NULL CHECK(len(zipCode)=8) ,
	city INT NOT NULL,
	active BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (city) REFERENCES city(id)
)
GO
PRINT('CREATE Room')
CREATE TABLE Room(
	id INT IDENTITY(1,1),
	roomNumber INT NOT NULL,
	capacity INT NOT NULL CHECK(capacity > 0),
	movieTheater INT NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (movieTheater) REFERENCES movieTheater(id),
	CONSTRAINT roomPK UNIQUE (roomNumber,movieTheater)
)
GO
PRINT('CREATE Session')
CREATE TABLE Session(
	id INT IDENTITY(1,1),
	movie INT NOT NULL,
	room INT NOT NULL,
	startDate DATETIME NOT NULL,
	endDate DATETIME NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (room) REFERENCES Room(id),
	FOREIGN KEY (movie) REFERENCES Movie(id),
	CONSTRAINT sessionPK UNIQUE (movie,room,startDate)
)






