USE [SheepControl]
GO
DECLARE @controllerId INT;
DECLARE @actionId INT;

DECLARE @contador1 INT = 1, @numFilas1 INT;

SELECT @numFilas1 = COUNT(*) FROM Controllers;

WHILE @contador1 <= @numFilas1
BEGIN
    SELECT @controllerId = Id FROM Controllers WHERE id = @contador1;

	DECLARE @contador2 INT = 1, @numFilas2 INT;
	SELECT @numFilas2 = COUNT(*) FROM Actions;

	WHILE @contador2 <= @numFilas2
	BEGIN
		SELECT @actionId = Id FROM Actions WHERE id = @contador2;

		INSERT INTO [dbo].[Permissions]
           ([Description]
           ,[Clave]
           ,[ControllerId]
           ,[ActionId]
           ,[CreationDate]
           ,[ModificationDate]
           ,[Active])
     VALUES
           (''
           ,''
           ,@controllerId
           ,@actionId
           ,CONVERT(date,'01-01-00')
           ,CONVERT(date,'01-01-00')
           ,1)

		PRINT concat('controller ',convert(int,@controllerId), ' action ',convert(int,@actionId) );

    SET @contador2 = @contador2 + 1;
END;

    SET @contador1 = @contador1 + 1;
END;



