USE [SheepControl]
GO

INSERT INTO [dbo].[Actions]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
           ('Create'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Actions]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('Read'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Actions]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('Update'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Actions]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('Delete'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

 