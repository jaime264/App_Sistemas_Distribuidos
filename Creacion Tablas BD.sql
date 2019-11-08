use Hotel

CREATE TABLE Customer  
   (id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(25) NOT NULL,  
    SurName varchar(25) NOT NULL,  
    DocumentType varchar(25) NOT NULL,
	DocumentNumber int NOT NULL,
	Phone int NOT NULL)
GO 

CREATE TABLE Reservation  
   (id int IDENTITY(1,1) PRIMARY KEY,
    AdmissionDate date NOT NULL,  
    DepartureDate date,  
    CustomerId int NOT NULL,
	RoomId int NOT NULL,
	HotelId int NOT NULL,
	FOREIGN KEY (CustomerId) REFERENCES Customer(id),
	FOREIGN KEY (RoomId) REFERENCES Room(id),
	FOREIGN KEY (HotelId) REFERENCES Hotel(id))
GO 

CREATE TABLE Hotel  
   (id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(25) NOT NULL,
	phone int NOT NULL, 
	QuantityRoom int NOT NULL,
    Direction varchar (25) NOT NULL)
GO 

CREATE TABLE Room  
   (id int IDENTITY(1,1) PRIMARY KEY,
    TypeRoom varchar(25) NOT NULL,  
    NumberRoom varchar (10) NOT NULL,  
	Price float NOT NULL)
GO 