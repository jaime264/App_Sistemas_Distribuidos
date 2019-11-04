use Hotel

CREATE TABLE Customer  
   (CustomerId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(25) NOT NULL,  
    SurName varchar (25) NOT NULL,  
    DocumentType varchar (25) NOT NULL,
	DocumentNumber varchar (25) NOT NULL)
GO 