USE [SheepControl]
GO

INSERT INTO [dbo].[Roles]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
           ('SuperAdmin'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Roles]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('Admin'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Roles]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('User'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

INSERT INTO [dbo].[Roles]
           ([Name]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
		   ('Invited'
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

 