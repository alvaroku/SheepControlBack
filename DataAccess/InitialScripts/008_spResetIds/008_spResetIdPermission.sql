CREATE PROCEDURE ResetIdPermission
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Permissions;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (Permissions, RESEED, @lastInsertedID);
END