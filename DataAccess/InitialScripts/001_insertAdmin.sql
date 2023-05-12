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
           ('sa'
           ,'sa'
           ,'9919596720'
           ,'sa@gmail.com'
           ,'sa'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1
           ,CONVERT(date,'01-01-00'))
GO


