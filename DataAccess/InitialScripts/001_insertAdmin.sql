USE [SheepControl]
GO

INSERT INTO [dbo].[Users]
           ([Name]
           ,[LastName]
           ,[PhoneNumber]
           ,[Email]
           ,[Password]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active]
           ,[BirthDate])
     VALUES
           ('admin'
           ,'admin'
           ,'9919596720'
           ,'admin@gmail.com'
           ,'admin'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1
           ,CONVERT(date,'01-01-00'))
GO


