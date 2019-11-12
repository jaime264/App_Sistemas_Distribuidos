USE [Hotel]
GO

INSERT INTO [dbo].[Hotel]
           ([Name]
           ,[phone]
           ,[QuantityRoom]
           ,[Direction])
     VALUES
           ('Hotel Casino',
           2873569,
           25,
           'Arequipa 125')
GO

INSERT INTO [dbo].[Hotel]
           ([Name]
           ,[phone]
           ,[QuantityRoom]
           ,[Direction])
     VALUES
           ('Hotel Lima',
           2873569,
           25,
           'Lima 125')
GO


USE [Hotel]
GO

INSERT INTO [dbo].[Room]
           ([TypeRoom]
           ,[NumberRoom]
           ,[Price])
     VALUES
           ('Quen', 
           15,
           255.50)
GO

INSERT INTO [dbo].[Room]
           ([TypeRoom]
           ,[NumberRoom]
           ,[Price])
     VALUES
           ('Solo', 
           1,
           150.99)
GO

INSERT INTO [dbo].[Room]
           ([TypeRoom]
           ,[NumberRoom]
           ,[Price])
     VALUES
           ('pareja', 
           10,
           200.99)
GO

INSERT INTO [dbo].[Room]
           ([TypeRoom]
           ,[NumberRoom]
           ,[Price])
     VALUES
           ('Matrimonial', 
           14,
           350.99)
GO


