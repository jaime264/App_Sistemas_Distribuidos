use Hotel

CREATE TABLE Customer  
   (id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(25) NOT NULL,  
    SurName varchar (25) NOT NULL,  
    DocumentType varchar (25) NOT NULL,
	DocumentNumber varchar (25) NOT NULL,
	Phone varchar(25) NOT NULL)
GO 

CREATE TABLE Reservation  
   (id int IDENTITY(1,1) PRIMARY KEY,
    AdmissionDate varchar(25) NOT NULL,  
    DepartureDate varchar (25) NOT NULL,  
    CustomerId int NOT NULL,
	FOREIGN KEY (CustomerId) REFERENCES Customer(id))
GO 

CREATE TABLE Hotel  
   (id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(25) NOT NULL,
	phone varchar(25) NOT NULL, 
    Direction varchar (25) NOT NULL)
GO 

CREATE TABLE Room  
   (id int IDENTITY(1,1) PRIMARY KEY,
    TypeRoom varchar(25) NOT NULL,  
    NumberRoom varchar (25) NOT NULL,  
	price varchar(25) NOT NULL,
    HotelId int NOT NULL,
	FOREIGN KEY (HotelId) REFERENCES Hotel(id))
GO 