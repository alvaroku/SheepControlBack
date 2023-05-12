USE [SheepControl]
GO
DECLARE @roleId INT;
DECLARE @userId INT;

SELECT @userId = Id FROM Users WHERE Name = 'sa'
SELECT @roleId = Id FROM Roles WHERE Name = 'SuperAdmin'


INSERT INTO [dbo].[RolesUsers]
           ([RoleId]
		   ,[UserId]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
           (@roleId,
		   @userId
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)
 