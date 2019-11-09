--Delete the TestData database if it exists.  
IF EXISTS(SELECT * from sys.databases WHERE name='Hotel')  
BEGIN  
    DROP DATABASE Hotel;  
END 

--Create a new database called TestData.  
CREATE DATABASE Hotel;  
--Press the F5 key to execute the code and create the database.

USE Hotel
GO  