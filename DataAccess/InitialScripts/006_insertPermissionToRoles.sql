
/*for super admin*/
USE [SheepControl]
GO
DECLARE @permissionId INT;
DECLARE @RoleId INT;
DECLARE @contador1 INT = 1, @numFilas1 INT;

SELECT @numFilas1 = COUNT(*) FROM dbo.Permissions;

SELECT @RoleId =  Id FROM Roles WHERE Name = 'SuperAdmin'

WHILE @contador1 <= @numFilas1
BEGIN
    SELECT @permissionId = Id FROM dbo.Permissions WHERE id = @contador1;
	
		INSERT INTO [dbo].[PermissionsRoles]
           (PermissionId
		   ,RoleId
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
           (@permissionId
		   ,@RoleId
           
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

		PRINT concat('permission ',convert(int,@permissionId),' role ',convert(int,@roleId));

    SET @contador1 = @contador1 + 1;
END;

 